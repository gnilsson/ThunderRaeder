using ThunderRaeder.API.Services.MicrosoftGraph;

namespace ThunderRaeder.API.Services
{
    public interface IServiceWrapper
    {
        public IMicrosoftGraphService Graph { get; }
        public IMicrosoftGraphAccountService GraphAccount { get; }
        public IMicrosoftGraphAccountService GetGraphMailService(string recipient);
    }
}
