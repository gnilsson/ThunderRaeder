using System;
using ThunderRaeder.API.Commands.Create;
using ThunderRaeder.API.Infrastructure.Modifiers;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.General.Types
{
    public class UserBookTypes<TEntity> : ITypes where TEntity : Entity
    {
        public Type EntityType => typeof(TEntity);

        public Type QueryConfiguration => null;

        //public Type[] CreateModifier => new[] { typeof(IModifier<TEntity, AddUserBooksCommand>), 
        //                                        typeof(UserBookModifier<AddUserBooksCommand>) };

        public Type[] CreateModifier => null;
        public Type[] UpdateModifier => null;

        public Type[] CreateHandler => null;

        public Type[] GetHandler => null;

        public Type[] UpdateHandler => null;

    }
}
