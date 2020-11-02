using System;

namespace ThunderRaeder.Data.Entities
{
    public interface IIdentifiableEntity
    {
        Guid Id { get; set; }
    }
}
