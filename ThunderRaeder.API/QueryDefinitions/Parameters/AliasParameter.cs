using ThunderRaeder.API.General.Descriptive;
using ThunderRaeder.API.QueryDefinitions.Parameters.BaseParameters;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.QueryDefinitions.Parameters
{
    public class AliasParameter : StringParameter
    {
        public override void Set(string value)
        {
            base.Set(value);
            TableReferenceChildren = new[] { nameof(AppUser.Alias) };
        }
    }
}
