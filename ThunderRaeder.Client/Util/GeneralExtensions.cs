using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThunderRaeder.Client.Util
{
    public static class GeneralExtensions
    {
        public static void AddOrUpdate(this Dictionary<string, string> dict, string key, string value)
        {
            if (dict.ContainsKey(key))
                dict.Remove(key);
            dict.Add(key, value);
        }
    }
}
