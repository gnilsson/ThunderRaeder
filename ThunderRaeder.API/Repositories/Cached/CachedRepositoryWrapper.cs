using System.Collections.Concurrent;
using System.Threading.Tasks;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.Repositories.Cached
{
    public class CachedRepositoryWrapper : IRepositoryWrapper
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly ConcurrentDictionary<string, object> _repoContainer;

        public CachedRepositoryWrapper(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _repoContainer = new ConcurrentDictionary<string, object>();
        }

        public async Task SaveAsync()
           => await _repositoryWrapper.SaveAsync();
        public IRepositoryBase<TEntity, TDto> Get<TEntity, TDto>() 
            where TEntity : Entity
            => (IRepositoryBase<TEntity, TDto>)(
            _repoContainer.ContainsKey(typeof(TEntity).Name) ?
            _repoContainer[typeof(TEntity).Name] :
                _repoContainer.GetOrAdd(
                    typeof(TEntity).Name, 
                    _repositoryWrapper.Get<TEntity, TDto>()));
        public IGeneralRepository General => _repositoryWrapper.General;
    }
}
