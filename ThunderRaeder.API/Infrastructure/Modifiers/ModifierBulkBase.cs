using System.Collections.Generic;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Commands;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses;

namespace ThunderRaeder.API.Infrastructure.Modifiers
{
    public abstract class ModifierBulkBase<TEntity, TCommand, YEntity> 
                                                     : Modifier<TEntity, TCommand>, 
                                                       IBulkable<YEntity> // I will leave this here upon further inspection
                                                       where TEntity : Entity
                                                       where YEntity : Entity
                                                       where TCommand : ICommand

    {
        public ModifierBulkBase()
        {
            BulkCreator = BulkCreateHandler;
        }

        public BulkCreateDelegate BulkCreator { get; }
        public YEntity Target { get; set; }
        public List<YEntity> Collection { get; set; }

        public delegate IEnumerable<TEntity> BulkCreateDelegate(TCommand command, int iterator = 0);
        public virtual IEnumerable<TEntity> BulkCreateHandler(TCommand command, int iterator = 0)
        {
            var entities = new List<TEntity>();
            this.Target = this.Collection[iterator];
            var created = Creator(command);
            iterator++;
            if (this.Collection.Count > iterator)
                entities.AddRange(BulkCreator(command, iterator));
            entities.Add(created);
            return entities;
        }

        //public override void UpdateHandler(TEntity entity, TCommand command)
        //{
        //    base.Updater(entity, command);
        //}

        //public override TEntity CreateHandler(TCommand command)
        //{
        //    return base.Creator(command);
        //}
    }
}
