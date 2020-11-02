using System;
using ThunderRaeder.Shared.ServerApiContracts;

namespace ThunderRaeder.API.Services
{
    public interface IUriService
    {
        public Uri GetByIdUri(string requestRoute, string id);
        public Uri GetUri(string requestRoute, IPaginateable paginationData = null);
    }
}
