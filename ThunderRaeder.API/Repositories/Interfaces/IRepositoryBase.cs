using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ThunderRaeder.API.QueryDefinitions;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Requests;

namespace ThunderRaeder.API.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity, TDto> where TEntity : Entity
    {
        Task<TDto> GetFirstOrDefaultAsync(
                                Expression<Func<TEntity, bool>> predicate);
        Task<QueryResult<TDto>> GetQueriedResultAsync(
                                QueryReciever<GetRequest> queryReciever);
        Task<List<TEntity>> GetManyByConditionAsync(
                                Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetSingleByConditionAsync(
                                Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> FindByCondition(
                                Expression<Func<TEntity, bool>> predicate);
        void Delete(TEntity entity);
        Task CreateAsync(TEntity entity);
        ValueTask<TEntity> FindAsync(Guid entityId);
    }
}
