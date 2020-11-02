using AutoMapper.Internal;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace ThunderRaeder.API.Infrastructure.Validation
{
    public class ValidatorBase<T> : AbstractValidator<T>
    {
        public ValidatorBase()
        {
            
        }

        private Func<KeyValuePair<string, (object, Type)>, CustomContext, CancellationToken, Task> _exp = (x, y, z) =>
        {
            return null;
        };

        public void RuleForEnums<TProp>(Expression<Func<T,TProp>> expression)
        {
            
        }

        public void RuleForEnums<TProp>(Dictionary<string,(object,Type)> properties)
        {

        }

        public void RuleForAll<TProp>(Expression<Func<T, TProp>> expr, Expression<Func<T, TProp>> expr2)
        {
            var memberExpression = (MemberExpression)expr.Body;
            var property = (PropertyInfo)memberExpression.Member;

                 var method = typeof(ValidatorBase<T>).GetMethod("RuleForAlls");
                var gm = method.MakeGenericMethod(typeof(TProp));

        }

        public void RuleForAlls<TProp>(Dictionary<string, (object, Type)> properties)
        {
            var groups = properties.GroupBy(x => x.Value.Item2);
            foreach (var grouping in groups)
            {

            }
        }
    }
}
    