using FluentValidation;
using ThunderRaeder.API.Commands;
using ThunderRaeder.API.Commands.Create;

namespace ThunderRaeder.API.Infrastructure.Validation
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        //public CreateUserCommandValidator()
        //{
        //    RuleFor(x => x.IdentityId)
        //        .NotEmpty();
        //    RuleFor(x => x.Alias)
        //        .NotEqual("string");
        //}
    }
}
