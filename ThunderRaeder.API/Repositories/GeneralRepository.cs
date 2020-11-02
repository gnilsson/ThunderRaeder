using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.Data.Contexts;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.Repositories
{
    public class GeneralRepository :
                 RepositoryConcept,
                 IGeneralRepository
    {
        private readonly IMapper _mapper;
        public GeneralRepository(
            ThunderRaederDbContext dbContext,
            IMapper mapper)
            : base(dbContext)
            => (_mapper) = (mapper);

        private DbSet<TEntity> Set<TEntity>() where TEntity : class
            => DatabaseContext.Set<TEntity>();
        private IQueryable<TEntity> SetQuery<TEntity>() where TEntity : class
            => DatabaseContext.Set<TEntity>();

        public async Task<TDto> GetFirstByConditionAsync<TDto, TEntity>(
                              Expression<Func<TEntity, bool>> predicate)
                              where TEntity : class
            => await SetQuery<TEntity>()
                    .AsNoTracking()
                    .Where(predicate)
                    .ProjectTo<TDto>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync();

        public async Task<TEntity> GetFirstByConditionAsync<TEntity>(
                           Expression<Func<TEntity, bool>> predicate)
                           where TEntity : class
            => await SetQuery<TEntity>()
                    .AsNoTracking()
                    .Where(predicate)
                    .FirstOrDefaultAsync();

        public IQueryable<TEntity> FindByCondition<TEntity>(
            Expression<Func<TEntity, bool>> predicate)
            where TEntity : class
            => SetQuery<TEntity>().Where(predicate);

        public async ValueTask<TEntity> GetSingleAsync<TEntity>(
            Guid entityId)
            where TEntity : Entity, IIdentifiableEntity
          => await Set<TEntity>().FindAsync(entityId);

        public async Task<List<TEntity>> GetManyAsync<TEntity>(
            IEnumerable<Guid> entityIds)
            where TEntity : Entity, IIdentifiableEntity
             => await FindByCondition<TEntity>(e => entityIds.Contains(e.Id))
                .ToListAsync();

        public async Task CreateAsync<TEntity>(
            TEntity entity)
            where TEntity : class
           => await Set<TEntity>().AddAsync(entity);

        public async Task CreateManyAsync<TEntity>(
            IEnumerable<TEntity> entities)
            where TEntity : class
           => await Set<TEntity>().AddRangeAsync(entities);

        public void Delete<TEntity>(
            TEntity entity)
            where TEntity : class
           => Set<TEntity>().Remove(entity);


    }
}
