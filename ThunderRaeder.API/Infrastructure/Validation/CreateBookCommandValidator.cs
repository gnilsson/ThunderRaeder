using FluentValidation;
using ThunderRaeder.API.Commands.Create;

namespace ThunderRaeder.API.Infrastructure.Validation
{
    public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(x => x.ValidationModel.AuthorId).NotEmpty();
            RuleFor(x => x.ValidationModel.Genre).IsInEnum();
        }
    }
}
