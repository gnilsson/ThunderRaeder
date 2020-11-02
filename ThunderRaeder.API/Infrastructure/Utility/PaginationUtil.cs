using System.Collections.Generic;
using System.Linq;
using ThunderRaeder.API.QueryDefinitions;
using ThunderRaeder.API.Services;
using ThunderRaeder.Shared.ServerApiContracts;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Infrastructure.Utility
{
    public static class PaginationUtil
    {
        public static PagedResponse<T> CreatePaginatedResponse<T>(
                      IUriService uriService, 
                      IPaginateable pagination,
                      List<T> response, string requestRoute, 
                      int? total)
        {
            var nextPage = pagination.PageNumber >= 1
                ? uriService.GetUri(requestRoute,
                 new PaginationQuery
                 {
                     PageNumber = pagination.PageNumber + 1,
                     PageSize = pagination.PageSize
                 }).ToString()
                : null;

            var previousPage = pagination.PageNumber - 1 >= 1
                ? uriService.GetUri(requestRoute,
                 new PaginationQuery
                 {
                     PageNumber = pagination.PageNumber - 1,
                     PageSize = pagination.PageSize
                 }).ToString()
                : null;

            return new PagedResponse<T>
            {
                Data = response,
                PageNumber = pagination.PageNumber >= 1 ? pagination.PageNumber
                : (int?)null,
                PageSize = pagination.PageSize > response.Count ? response.Count
                : pagination.PageSize >= 1 ? pagination.PageSize
                : (int?)null,
                NextPage = total > pagination.PageSize ? nextPage
                : null,
                PreviousPage = previousPage,
                Total = total
            };
        }

        public static IQueryable<T> ApplyPaging<T>(this IQueryable<T> efQuery, 
                                                        IPaginateable pagination)
        {
            return efQuery
                   .Skip((pagination.PageNumber - 1) * pagination.PageSize)
                   .Take(pagination.PageSize);
        }
    }
}
