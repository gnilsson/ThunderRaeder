using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThunderRaeder.API.QueryDefinitions.Parameters
{
    public interface IParameter
    {
        public string[] TableReferenceParents { get; }
        public string[] TableReferenceChildren { get; }
        public object Value { get; }
        public string Method { get; }
        public void Set(string value);
    }
}
