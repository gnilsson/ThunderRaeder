using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ThunderRaeder.API.Infrastructure.Utility
{
    public static class ExpressionUtil
    {
        public delegate object ConstructorDelegate(params object[] args);
        public static ConstructorDelegate CreateConstructor(Type type, params Type[] parameters)
        {
            var constructorInfo = type.GetConstructor(parameters);
            var paramExpr = Expression.Parameter(typeof(object[]));

            var constructorParameters = parameters.Select((paramType, index) =>
                Expression.Convert(
                    Expression.ArrayAccess(
                        paramExpr,
                        Expression.Constant(index)),
                    paramType)).ToArray();

            var body = Expression.New(constructorInfo, constructorParameters);
            var constructor = Expression.Lambda<ConstructorDelegate>(body, paramExpr);
            return constructor.Compile();
        }

        public delegate object EmptyConstructorDelegate();
        public static EmptyConstructorDelegate CreateEmptyConstructor(Type type)
        {
            return Expression.Lambda<EmptyConstructorDelegate>(
                Expression.New(
                    type.GetConstructor(
                        Type.EmptyTypes))).Compile();
        }

        public static T[] TypewisedUpdate<T, TEntity>(
            List<BinaryExpression> exprs, 
            ParameterExpression para, 
            TEntity entity)
        {
            return Expression.Lambda<Func<TEntity, T[]>>(
                Expression.NewArrayInit(typeof(T), exprs), para)
                .Compile()(entity);
        }

        public static bool TryGetProperty(
            ParameterExpression parameter, 
            string propertyName, 
            out MemberExpression property)
        {
            try
            {
                property = Expression.Property(parameter, propertyName);
                return property != null;
            }
            catch (Exception)
            {
                property = null;
                return false;
            }
        }
    }
}
