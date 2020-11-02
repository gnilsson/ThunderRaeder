using System.Collections.Generic;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.Infrastructure.Modifiers
{
    public interface IBulkable<TEntity> where TEntity : Entity
    {
        public TEntity Target { get; set; }
        public List<TEntity> Collection { get; set; }
    }
}
