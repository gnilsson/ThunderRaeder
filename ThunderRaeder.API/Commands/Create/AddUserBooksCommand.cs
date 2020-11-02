using System;
using System.Collections.Generic;
using System.Linq;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Infrastructure.Validation.Models;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Utility.DataType;

namespace ThunderRaeder.API.Commands.Create
{
    public class AddUserBooksCommand : CommandReciever<UserResponse, NoValidation>
    {
        public AddUserBooksCommand(AddUserBooksRequest request) : base(request, request.UserId.GuidTryParseExact())
        {
            BookIds = request.BookIds.Select(bId => bId.GuidTryParseExact());
        }

        public IEnumerable<Guid> BookIds { get; }
    }
}
