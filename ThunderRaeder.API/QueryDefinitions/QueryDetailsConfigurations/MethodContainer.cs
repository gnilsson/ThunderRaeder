using System;
using System.Collections.ObjectModel;
using System.Reflection;
using ThunderRaeder.API.General.Descriptive;

namespace ThunderRaeder.API.QueryDefinitions.QueryDetailsConfigurations
{
    public class MethodContainer
    {
        public MethodInfo Contains { get; }
        public MethodInfo CompareTo { get; }
    //    public ReadOnlyDictionary<string,ReadOnlyDictionary<string,MethodInfo>> QueryMethods { get; }

        public MethodContainer()
        {
            Contains = typeof(string).GetMethod(nameof(Methods.Contains), new[] { typeof(string) });
            CompareTo = typeof(DateTime).GetMethod(Methods.CompareTo, new[] { typeof(DateTime) });
        }
    }
}
