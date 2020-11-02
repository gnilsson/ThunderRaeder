using AutoMapper;
using System;
using System.Threading.Tasks;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Handlers.CommandHandlers
{
    public abstract class CommandHandlerBase
    {
        public async Task<Response<TReturn>> SaveAndReturnAsync<TEntity, TDto, TReturn>(
                                                        IRepositoryWrapper wrapper,
                                                        IMapper mapper, Guid returnId)
                                                        where TEntity : Entity, IIdentifiableEntity
        {
            await wrapper.SaveAsync();
            var userDto = await wrapper
                .Get<TEntity, TDto>()
                .GetFirstOrDefaultAsync(x => x.Id == returnId);
            return new Response<TReturn>(mapper.Map<TReturn>(userDto));
        }
        public async Task<Response<TReturn>> SaveAndReturnAsync<TEntity, TDto, TReturn>(
                                                        IRepositoryWrapper wrapper,
                                                        IRepositoryBase<TEntity, TDto> repo,
                                                        IMapper mapper, Guid returnId)
                                                        where TEntity : Entity, IIdentifiableEntity
        {
            await wrapper.SaveAsync();
            var userDto = await repo.GetFirstOrDefaultAsync(x => x.Id == returnId);
            return new Response<TReturn>(mapper.Map<TReturn>(userDto));
        }
    }
}
