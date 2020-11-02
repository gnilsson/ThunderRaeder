using AutoMapper;
using ThunderRaeder.API.QueryDefinitions;
using ThunderRaeder.Data.Contexts;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.Repositories
{
    public class GenericRepository<TEntity, TDto> :
                 RepositoryBase<TEntity, TDto>
                 where TEntity : Entity
    {
        public GenericRepository(ThunderRaederDbContext dbContext, IMapper mapper,
                                 QueryManager<TEntity> queryManager)
                                : base(dbContext, mapper, queryManager)
        { }
    }
}
