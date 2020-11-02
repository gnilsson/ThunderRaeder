using System.Collections.Generic;
using ThunderRaeder.API.QueryDefinitions.Parameters;
using ThunderRaeder.Shared.ServerApiContracts;

namespace ThunderRaeder.API.QueryDefinitions
{
    public abstract class QueryReciever<TRequest> 
        where TRequest : 
        IPaginateable, IOrderable, ITimeStampable
    {
        public List<IParameter> Parameters { get; }
        public PaginationQuery PaginationQuery { get; }
        public string RequestRoute { get; }
        public OrderByParameter OrderByParameter { get; }

        public QueryReciever(
            TRequest request, 
            string route)
        {
            Parameters = new List<IParameter>();
            PaginationQuery = new PaginationQuery(request);
            RequestRoute = route;

            OrderByParameter = 
                string.IsNullOrWhiteSpace(request.OrderBy) || 
                !request.OrderBy.Contains(":") ? 
                null : new OrderByParameter(request);

            Add<CreatedDateParameter>(request.CreatedDate);
            Add<UpdatedDateParameter>(request.UpdatedDate);
        }

        internal void Add<T>(
            string value) 
            where T : IParameter, new()
        {
            if (string.IsNullOrWhiteSpace(value))
                return;
            var parameter = new T();
            parameter.Set(value);
            Parameters.Add(parameter);
        }
    }
}
