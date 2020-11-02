using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ThunderRaeder.API.Commands.Create;
using ThunderRaeder.API.Dtos;
using ThunderRaeder.API.Infrastructure.Modifiers;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Handlers.CommandHandlers
{
    //public class AddUserBooksHandler : CommandHandlerBase, IRequestHandler<AddUserBooksCommand, Response<UserResponse>>
    //{
    //    private readonly IRepositoryWrapper _repositoryWrapper;
    //    private readonly IMapper _mapper;
    //    private readonly IModifier<AppUserBook, AddUserBooksCommand> _modifier;

    //    public AddUserBooksHandler(IRepositoryWrapper repositoryWrapper, IMapper mapper, IModifier<AppUserBook, AddUserBooksCommand> modifier)
    //    {
    //        _repositoryWrapper = repositoryWrapper;
    //        _mapper = mapper;
    //        _modifier = modifier;
    //    }
    //    public async Task<Response<UserResponse>> Handle(AddUserBooksCommand request, CancellationToken cancellationToken)
    //    {
    //        var books = await _repositoryWrapper.General.GetManyAsync<Book>(request.BookIds);
    //        var user = await _repositoryWrapper.General.GetSingleAsync<AppUser>(request.Id);
    //        _modifier.Append((nameof(AppUserBook.Book), books[0]),
    //                         (nameof(AppUserBook.AppUser), user));
    //        //    await _repositoryWrapper.General.CreateManyAsync(_modifier.BulkCreator(request));
    //        await _repositoryWrapper.General.CreateAsync(_modifier.Creator(request));
    //        return await SaveAndReturnAsync<AppUser, UserDto, UserResponse>(
    //           _repositoryWrapper, _mapper, request.Id);
    //    }
    //}
}
