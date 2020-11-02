using FluentValidation;
using System.Linq;
using ThunderRaeder.API.Queries;

namespace ThunderRaeder.API.Infrastructure.Validation
{
    public class GetBooksQueryValidator : AbstractValidator<GetBooksQuery>
    {
        public GetBooksQueryValidator()
        {
        }
    }
}
