using System;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.Infrastructure.Modifiers
{
    public interface IModifier<TEntity, TCommand>
        where TEntity : Entity
        where TCommand : ICommand
    {
        public UpdateDelegate Updater { get; }
        public CreateDelegate Creator { get; }

        public delegate void UpdateDelegate(TEntity entity, TCommand command);
        public delegate TEntity CreateDelegate(TCommand command);
        public void DetailedAppend(params (string, (object, Type))[] properties);
        public void Append(params (string, object)[] properties);
    }
}
