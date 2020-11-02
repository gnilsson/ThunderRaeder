using System.Collections.Generic;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.QueryDefinitions.QueryDetailsConfigurations
{
    public abstract class QueryConfigurationBase<TEntity> where TEntity : Entity
    {
        public List<string[]> IncluderDetails { get; protected set; }
        
    }
}
