namespace ThunderRaeder.API.Infrastructure.Modifiers
{
    public interface IRelationalModifier<TEntity,YEntity>
    {
        public TEntity UniqueTarget { get; set; }
        public YEntity SecondUniqueTarget { get; set; }
    }
}
