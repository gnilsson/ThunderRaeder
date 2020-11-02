using MediatR;
using ThunderRaeder.API.QueryDefinitions;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;


namespace ThunderRaeder.API.Queries
{

    public class GetDefaultQuery<TResponse> : QueryReciever<GetRequest>, IRequest<PagedResponse<TResponse>>
    {
        public GetDefaultQuery(GetRequest request, string path) : base(request, path)
        { }
    }
}
