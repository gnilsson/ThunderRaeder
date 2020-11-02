using System.Threading.Tasks;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IGeneralRepository General { get; }
        IRepositoryBase<TEntity,TDto> Get<TEntity,TDto>() where TEntity : Entity;
        Task SaveAsync();

    }
}
