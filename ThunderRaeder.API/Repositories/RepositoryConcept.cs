using ThunderRaeder.Data.Contexts;

namespace ThunderRaeder.API.Repositories
{
    public abstract class RepositoryConcept
    {
        protected ThunderRaederDbContext DatabaseContext { get; }

        public RepositoryConcept(ThunderRaederDbContext dbContext)
        {
            DatabaseContext = dbContext;
        }
    }
}
