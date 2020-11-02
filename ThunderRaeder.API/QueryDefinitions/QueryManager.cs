using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThunderRaeder.API.QueryDefinitions.Parameters;
using ThunderRaeder.API.QueryDefinitions.QueryDetailsConfigurations;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.QueryDefinitions
{
    public class QueryManager<TEntity> where TEntity : Entity
    {
        public Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> Includer { get; private set; }

        public QueryInstructions<TEntity>.QueryDelegate Querier { get; private set; }

        public Func<IQueryable<TEntity>, OrderByParameter, IOrderedQueryable<TEntity>> Orderer { get; private set; }
        public QueryManager(
            QueryConfigurationBase<TEntity> config,
            QueryConfigurationUniversal universalConfig)
        {
            var instructions = new QueryInstructions<TEntity>(config, universalConfig);
            Querier = instructions.Querier;
            Orderer = instructions.Orderer;
            Includer = instructions.Includer();
        }
    }
}
