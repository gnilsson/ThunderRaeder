using MediatR;
using ThunderRaeder.API.QueryDefinitions;
using ThunderRaeder.Shared.ServerApiContracts;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Queries
{
    public class GetUsersQuery : QueryReciever<GetRequest>, IRequest<PagedResponse<UserResponse>>
    {
        public GetUsersQuery(GetUsersRequest request) : base(request, ApiRoutes.Users.Get)
        {
            //request.Alias.BuildQuery(UserParameterType.Alias, QueryBuildModels);           
            //RequestRoute = ApiRoutes.Users.Get;
        }
    }
}
