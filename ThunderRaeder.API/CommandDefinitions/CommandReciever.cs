using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using ThunderRaeder.API.Infrastructure.Extensions;
using ThunderRaeder.API.Infrastructure.Validation.Models;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.CommandDefinitions
{
    public abstract class CommandReciever<TResponse, TValid> : 
        ICommand, 
        IRequest<Response<TResponse>>
        where TValid : IValidationModel, new()
        
    {
        public string[] IgnoredProperties { get; }
        public Dictionary<string, (object, Type)> RequestPropertyValues { get; }
        public Guid Id { get; set; }
        public TValid ValidationModel { get; }
        public CommandReciever(object request, Guid id)
        {
            if (request == null)
                return;
            if(typeof(TValid) != typeof(NoValidation))
            {
                ValidationModel = new TValid();
                ValidationModel.Set(request);
            }

            Id = id;
            IgnoredProperties = new string[]
            { nameof(Entity.CreatedDate), nameof(Entity.UpdatedDate) };
            RequestPropertyValues = new Dictionary<string, (object, Type)>
            {
                { nameof(IIdentifiableEntity.Id), (id,typeof(Guid)) }
            };

            var properties = request
                .GetType()
                .GetProperties()
                .Where(x => !IgnoredProperties.Contains(x.Name));

            foreach (var prop in properties)
            {
                if (prop.TryGetPropertyValue(request, out var value))
                    RequestPropertyValues.Add(
                        value.Key, (value.Value, value.Value.GetType()));
            }
        }
    }
}
