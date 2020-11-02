using System;

namespace ThunderRaeder.API.CommandDefinitions
{
    public interface IIdentifiableCommand
    {
        public Guid Id { get; set; }
    }
}
