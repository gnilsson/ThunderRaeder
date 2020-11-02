using FluentValidation;
using ThunderRaeder.API.Commands.Create;

namespace ThunderRaeder.API.Infrastructure.Validation
{
    public class AddUserBooksCommandValidator : AbstractValidator<AddUserBooksCommand>
    {
        public AddUserBooksCommandValidator()
        {
            RuleFor(x => x.BookIds)
                .NotEmpty();
            
        }
    }
}
