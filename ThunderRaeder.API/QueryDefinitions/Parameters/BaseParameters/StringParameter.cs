using ThunderRaeder.API.General.Descriptive;

namespace ThunderRaeder.API.QueryDefinitions.Parameters.BaseParameters
{
    public abstract class StringParameter : IParameter
    {
        public object Value { get; private set; }
        public string[] TableReferenceParents { get; internal set; }
        public string[] TableReferenceChildren { get; internal set; }
        public string Method { get; private set; }
        public virtual void Set(string value)
        {
            Value = value;
            Method = QueryMethods.StringContains;
        }
    }
}
