using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.Infrastructure.Modifiers
{
    public class UserBookModifier<TCommand> : ModifierBulkBase<AppUserBook, TCommand, Book>,
                                              IModifier<AppUserBook, TCommand>,
                                              IRelationalModifier<AppUser, Book> 
                                              where TCommand : ICommand
    {
        public AppUser UniqueTarget { get; set; }
        public Book SecondUniqueTarget { get; set; }

        //public override AppUserBook CreateHandler(TCommand command) => new AppUserBook
        //{
        //    AppUser = this.UniqueTarget,
        //    Book = this.SecondUniqueTarget ?? base.Target,
        //    PercentageRead = 0
        //};

        //public override void UpdateHandler(AppUserBook entity, TCommand command)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
