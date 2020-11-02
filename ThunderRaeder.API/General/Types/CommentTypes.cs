using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.General.Types
{
    public class CommentTypes<TEntity, TDto, TResponse> :
                 EntityTypes<TEntity, TDto, TResponse>, ITypes
                 where TEntity : Entity, IIdentifiableEntity
    {
    }
}
