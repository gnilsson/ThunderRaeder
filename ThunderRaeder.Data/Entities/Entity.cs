using System;

namespace ThunderRaeder.Data.Entities
{
    public abstract class Entity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}