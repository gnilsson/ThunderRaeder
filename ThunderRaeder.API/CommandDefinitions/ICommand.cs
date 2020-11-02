using System;
using System.Collections.Generic;

namespace ThunderRaeder.API.CommandDefinitions
{
    public interface ICommand : IIdentifiableCommand
    {
        public Dictionary<string, (object, Type)> RequestPropertyValues { get; }
    }
}
