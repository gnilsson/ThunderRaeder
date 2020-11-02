using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ThunderRaeder.API.General.ActionRoutes;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Extensions
{
    public static class ActionExtensions
    {
        public static async Task<IActionResult> ToOkResult<TResponse>(
                       this Task<TResponse> resultTask)
        {
            var result = await resultTask;
            return result == null ?
                (IActionResult)new NotFoundResult() :
                new OkObjectResult(result);
        }

        public static async Task<IActionResult> ToCreatedAtResult<TResponse, TData, TRoute>(
                       this Task<TResponse> resultTask)
                       where TResponse : Response<TData>
                       where TData : IIdentifiableResponse
                       where TRoute : IRoute, new()
        {
            var result = await resultTask;
            var route = new TRoute();
            return result == null ?
                (IActionResult)new NotFoundResult() :
                new CreatedAtActionResult(route.Action, route.Controller,
                                          route.GetParameter(result.Data.Id), result);
        }

        public static async Task<IActionResult> ToNoContentResult<TResponse>(
                       this Task<TResponse> resultTask)
        {
            var result = await resultTask;
            return result == null ?
                (IActionResult)new NotFoundResult() :
                new NoContentResult();
        }

        public static async Task<IActionResult> ToCreatedResult<TResponse>(
                       this Task<TResponse> resultTask, 
                       string location)
        {
            var result = await resultTask;
            return result == null ?
                (IActionResult)new NotFoundResult() :
                new CreatedResult(location, result);
        }
    }
}
