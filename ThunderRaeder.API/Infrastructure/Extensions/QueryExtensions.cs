using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using ThunderRaeder.API.General.Descriptive;
using ThunderRaeder.API.General.Exceptions;
using ThunderRaeder.API.Infrastructure.Extensions;
using ThunderRaeder.API.Infrastructure.Utility;
using ThunderRaeder.API.QueryDefinitions.Parameters;

namespace ThunderRaeder.API.Extensions
{
    public static class QueryExtensions
    {
        public static IOrderedQueryable<TEntity> OrderBy<TEntity>(
                 this IQueryable<TEntity> source,
                 OrderByParameter orderParameter)
        {
            var type = typeof(TEntity);
            var parameter = Expression.Parameter(type, "p");
            if (!ExpressionUtil.TryGetProperty(parameter, orderParameter.Node, out var property))
                throw new BadRequestException("Invalid property description");

            var propertyAccess = Expression.MakeMemberAccess(parameter, property.Member);
            var orderByExpr = Expression.Lambda(propertyAccess, parameter);
            var methodName = orderParameter.SortDirection == ListSortDirection.Ascending ?
                Methods.OrderBy :
                Methods.OrderByDescending;

            var callExpr = Expression.Call(
                typeof(Queryable), methodName,
                new Type[] { type, property.Type },
                source.Expression, Expression.Quote(orderByExpr));
            return (IOrderedQueryable<TEntity>)source.Provider.CreateQuery<TEntity>(callExpr);
        }

        public static IIncludableQueryable<TEntity, object> IncludeBy<TEntity>(
                this IQueryable<TEntity> source,
                List<string[]> details)
        {
            var type = typeof(TEntity);
            var body = source.Expression;
            foreach (var detail in details)
            {
                var parameter = Expression.Parameter(type, "p");
                var property = Expression.Property(parameter, detail[0]);
                body = CallInclude(
                    body, parameter, property, Methods.Include,
                    new Type[] { type, property.Type });

                foreach (var then in detail.Skip(1))
                {
                    var previousType = property.Type.IsEnumerableType() ?
                        property.Type.GetGenericArguments()[0] :
                        property.Type;

                    parameter = Expression.Parameter(previousType, then[0].ToString().ToLower());
                    property = Expression.Property(parameter, then);
                    body = CallInclude(
                        body, parameter, property, Methods.ThenInclude,
                        new Type[] { type, previousType, property.Type });
                }
            }
            return Expression.Lambda<Func<IQueryable<TEntity>,
                IIncludableQueryable<TEntity, object>>>(
                body, Expression.Parameter(typeof(IQueryable<TEntity>)))
                .Compile()(source);
        }

        private static Expression CallInclude(
            Expression body, ParameterExpression parameter,
            MemberExpression property, string methodName,
            Type[] types)
        {
            var lambda = Expression.Lambda(
                Expression.MakeMemberAccess(
                    parameter, property.Member), parameter);
            return Expression.Call(
                typeof(EntityFrameworkQueryableExtensions),
                methodName, types, body,
                Expression.Quote(lambda));
        }
    }
}
