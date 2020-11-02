using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.Repositories.Interfaces
{
    public interface IGeneralRepository
    {
        Task<TDto> GetFirstByConditionAsync<TDto, TEntity>(
                            Expression<Func<TEntity, bool>> predicate)
                            where TEntity : class;
        Task<TEntity> GetFirstByConditionAsync<TEntity>(
                            Expression<Func<TEntity, bool>> predicate)
                            where TEntity : class;
        IQueryable<TEntity> FindByCondition<TEntity>(
                            Expression<Func<TEntity, bool>> predicate)
                            where TEntity : class;
        ValueTask<TEntity> GetSingleAsync<TEntity>(Guid entityId)
                            where TEntity : Entity, IIdentifiableEntity;
        Task<List<TEntity>> GetManyAsync<TEntity>(IEnumerable<Guid> entityIds)
                            where TEntity : Entity, IIdentifiableEntity;
        Task CreateAsync<TEntity>(TEntity entity)
                            where TEntity : class;
        Task CreateManyAsync<TEntity>(IEnumerable<TEntity> entities)
                            where TEntity : class;
        void Delete<TEntity>(TEntity entity)
                            where TEntity : class;
    }
}
