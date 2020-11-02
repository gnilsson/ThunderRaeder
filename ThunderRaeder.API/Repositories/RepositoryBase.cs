using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ThunderRaeder.API.Infrastructure.Utility;
using ThunderRaeder.API.QueryDefinitions;
using ThunderRaeder.API.QueryDefinitions.Parameters;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.Data.Contexts;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Requests;

namespace ThunderRaeder.API.Repositories
{
    public abstract class RepositoryBase<TEntity, TDto> :
                          RepositoryConcept,
                          IRepositoryBase<TEntity, TDto>
                          where TEntity : Entity
    {
        private readonly IMapper _mapper;
        private readonly Func<IQueryable<TEntity>, OrderByParameter, IOrderedQueryable<TEntity>> _orderer;
        private readonly Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> _includer;
        private readonly QueryInstructions<TEntity>.QueryDelegate _querier;

        protected RepositoryBase(
            ThunderRaederDbContext dbContext,
            IMapper mapper,
            QueryManager<TEntity> queryManager)
            : base(dbContext)
            => (_mapper, _orderer, _includer, _querier) =
            (mapper, queryManager.Orderer, queryManager.Includer, queryManager.Querier);

        private DbSet<TEntity> Set()
            => DatabaseContext.Set<TEntity>();
        private IQueryable<TEntity> SetQuery()
            => DatabaseContext.Set<TEntity>();

        public async Task<QueryResult<TDto>> GetQueriedResultAsync(
            QueryReciever<GetRequest> queryReciever)
        {
            var query = SetQuery().AsNoTracking();
            var count = await query.CountAsync();
            var dtos = await
                _orderer(_includer(query
                    .ApplyPaging(queryReciever.PaginationQuery)
                    .Where(_querier(queryReciever.Parameters))),
                    queryReciever.OrderByParameter)
                .ProjectTo<TDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new QueryResult<TDto>(count, dtos);
        }

        public async Task<TDto> GetFirstOrDefaultAsync(
            Expression<Func<TEntity, bool>> predicate)
          => await _includer(SetQuery()
                    .AsNoTracking()
                    .Where(predicate))
                .ProjectTo<TDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();

        public async Task<TEntity> GetSingleByConditionAsync(
            Expression<Func<TEntity, bool>> predicate)
          => await FindByCondition(predicate).FirstOrDefaultAsync();

        public async Task<List<TEntity>> GetManyByConditionAsync(
            Expression<Func<TEntity, bool>> predicate)
          => await FindByCondition(predicate).ToListAsync();

        public IQueryable<TEntity> FindByCondition(
            Expression<Func<TEntity, bool>> predicate)
          => SetQuery().Where(predicate);

        public async Task CreateAsync(
            TEntity entity)
         => await Set().AddAsync(entity);

        public void Delete(
            TEntity entity)
         => Set().Remove(entity);

        public async ValueTask<TEntity> FindAsync(
            Guid entityId)
         => await Set().FindAsync(entityId);


        // -  // 
        public async Task<TDto> GetFirstOrDefaultBaseAsync(Expression<Func<TEntity, TDto>> selector,
                                                  Expression<Func<TEntity, bool>> predicate = null,
                                                  Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                                  Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
                                                  bool disableTracking = true)
        {
            var query = SetQuery();
            if (disableTracking)
            {
                query = query.AsNoTracking();
            }
            if (include != null)
            {
                query = include(query);
            }
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (orderBy != null)
            {
                return await orderBy(query).Select(selector).FirstOrDefaultAsync();
            }
            else
            {
                return await query.Select(selector).FirstOrDefaultAsync();
            }
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate,
                                          params Expression<Func<TEntity, object>>[] includes)
        {
            var efQuery = SetQuery().Where(predicate);
            return includes
                .Aggregate(efQuery, (current, includeProperty) => current
                    .Include(includeProperty));
        }

    }
}
