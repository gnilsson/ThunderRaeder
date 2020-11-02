using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ThunderRaeder.API.Infrastructure.Utility;
using ThunderRaeder.API.QueryDefinitions;
using ThunderRaeder.API.QueryDefinitions.QueryDetailsConfigurations;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.Data.Contexts;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private IGeneralRepository _general;
        private readonly ThunderRaederDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IReadOnlyDictionary<string, 
                         ExpressionUtil.EmptyConstructorDelegate> _configContainer;
        private readonly QueryConfigurationUniversal _universalConfig;

        public RepositoryWrapper(ThunderRaederDbContext dbContext, IMapper mapper,
                                 ReadOnlyDictionary<string, 
                                 ExpressionUtil.EmptyConstructorDelegate> configContainer,
                                 QueryConfigurationUniversal universalConfig)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _configContainer = configContainer;
            _universalConfig = universalConfig;
        }

        public IGeneralRepository General
            => _general ??= new GeneralRepository(_dbContext, _mapper);

        public IRepositoryBase<TEntity, TDto> Get<TEntity, TDto>() where TEntity : Entity
            => new GenericRepository<TEntity, TDto>(_dbContext, _mapper, GetQueryManager<TEntity>());

        private QueryManager<TEntity> GetQueryManager<TEntity>() where TEntity : Entity
        {
            var constructor = _configContainer
                .FirstOrDefault(x => x.Key == typeof(TEntity).Name).Value;
            return new QueryManager<TEntity>(
                constructor() as QueryConfigurationBase<TEntity>, 
                _universalConfig);
        }

        public async Task SaveAsync()
        {
            var entries = _dbContext.ChangeTracker
                .Entries()
                .Where(e => e.Entity is Entity && (
                e.State == EntityState.Added ||
                e.State == EntityState.Modified));
            foreach (var entityEntry in entries)
            {
                ((Entity)entityEntry.Entity).UpdatedDate = DateTime.Now;
                if (entityEntry.State == EntityState.Added)
                {
                    ((Entity)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}
