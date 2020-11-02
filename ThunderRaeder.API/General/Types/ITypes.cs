using System;

namespace ThunderRaeder.API.General.Types
{
    public interface ITypes
    {
        public Type EntityType => EntityType;
        public Type QueryConfiguration => QueryConfiguration;
        public Type[] CreateModifier => CreateModifier;
        public Type[] UpdateModifier => UpdateModifier;
        public Type[] CreateHandler => CreateHandler;
        public Type[] GetHandler => GetHandler;
        public Type[] UpdateHandler => UpdateHandler;
    }
}
