using MediatR;
using ThunderRaeder.API.QueryDefinitions;
using ThunderRaeder.Shared.ServerApiContracts;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Queries
{
    public class GetAuthorsQuery : QueryReciever<GetRequest>, IRequest<PagedResponse<AuthorResponse>>
    {
        public GetAuthorsQuery(GetAuthorsRequest request) : base(request, ApiRoutes.Authors.Get)
        {
            //request.Name.BuildQuery(AuthorParameterType.Name, QueryBuildModels);
            //RequestRoute = ApiRoutes.Authors.Get;
        }
    }
}
