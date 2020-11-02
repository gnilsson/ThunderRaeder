using MediatR;
using ThunderRaeder.API.QueryDefinitions;
using ThunderRaeder.API.QueryDefinitions.Parameters;
using ThunderRaeder.Shared.ServerApiContracts;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Queries
{
    public class GetBooksQuery : QueryReciever<GetRequest>, IRequest<PagedResponse<BookResponse>>
    {
        public GetBooksQuery(GetBooksRequest request) : base(request, ApiRoutes.Books.Get)
        {
            Add<BookTitleParameter>(request.Title);
            Add<BookAuthorNameParameter>(request.Author);
        }
    }
}
