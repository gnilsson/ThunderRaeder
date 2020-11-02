//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Threading.Tasks;
//using ThunderRaeder.API.CreationInstructions;
//using ThunderRaeder.API.QueryDefinitions;
//using ThunderRaeder.API.Repositories.Interfaces;
//using ThunderRaeder.Data.Entities;

//namespace ThunderRaeder.API.Repositories.Cached
//{
//    public class CachedRepositoryBase<TEntity,TDto> : IRepositoryBase<TEntity,TDto> where TEntity : Entity
//    {
//        private readonly IRepositoryBase<TEntity, TDto> _repositoryBase;
//        private readonly ConcurrentDictionary<Guid, TDto> _cache;
//        public CachedRepositoryBase(IRepositoryBase<TEntity, TDto> repositoryBase)
//        {
//            _repositoryBase = repositoryBase;
//            _cache = new ConcurrentDictionary<Guid, TDto>();
//        }

//        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> predicate)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<TDto> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<List<TEntity>> GetManyByConditionAsync(Expression<Func<TEntity, bool>> predicate)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<QueryResult<TDto>> GetQueriedResultAsync(QueryStringParameters queryParameters)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<TEntity> GetSingleByConditionAsync(Expression<Func<TEntity, bool>> predicate)
//        {
//            throw new NotImplementedException();
//        }

//        public Task UpdateAsync(ICreationInstruction<TEntity> instruction)
//        => _repositoryBase.UpdateAsync(instruction);
//        public Task CreateAsync(ICreationInstruction<TEntity> instruction)
//        => _repositoryBase.CreateAsync(instruction);

//        public Task DeleteAsync(TEntity entity)
//        => _repositoryBase.DeleteAsync(entity);
//    }
//}
//        public async Task<TDto> GetFirstByConditionAsync<UEntity>(System.Linq.Expressions.Expression<Func<UEntity, bool>> predicate) where UEntity : Entity
//                => await _getRepository.GetFirstByConditionAsync(predicate);

//        public async Task<TDto> GetFirstOrDefaultAsync(Guid entityId)
//                => _cache.ContainsKey(entityId) ? _cache[entityId] :
//                   _cache.GetOrAdd(entityId, await GetFirstOrDefaultAsync(entityId));

//        public async Task<QueryResult<TDto>> GetQueriedResultAsync<TQuery>(TQuery query) where TQuery : QueryStringParameters
//                => await _getRepository.GetQueriedResultAsync(query);