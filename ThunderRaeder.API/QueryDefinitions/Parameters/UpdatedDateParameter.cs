using ThunderRaeder.API.QueryDefinitions.Parameters.BaseParameters;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.QueryDefinitions.Parameters
{
    public class UpdatedDateParameter : DateParameter
    {
        public override void Set(string value)
        {
            base.Set(value);
            TableReferenceChildren = new[] { nameof(Entity.UpdatedDate) };
        }
    }
}
