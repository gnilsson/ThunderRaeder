using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ThunderRaeder.API.Infrastructure.Extensions
{
    public static class ReflectionExtensions
    {
        public static List<Type> GetTypesAssignableFrom<T>(this Assembly[] assemblies)
        {
            return assemblies.GetTypesAssignableFrom(typeof(T));
        }
        public static List<Type> GetTypesAssignableFrom(this Assembly[] assemblies, Type compareType)
        {
            return assemblies
               .SelectMany(s => s.GetTypes())
               .Where(p => compareType.IsAssignableFrom(p) && compareType != p)
               .ToList();
        }

        public static List<TypeInfo> GetTypesAssignableTo(this Assembly assembly, Type compareType)
        {
            var typeInfoList = assembly.DefinedTypes.Where(x => x.IsClass
                                && !x.IsAbstract
                                && x != compareType
                                && x.GetInterfaces()
                                        .Any(i => i.IsGenericType
                                                && i.GetGenericTypeDefinition() == compareType))?.ToList();

            return typeInfoList;
        }
    }
}
