using ThunderRaeder.API.Services.MicrosoftGraph;

namespace ThunderRaeder.API.Services
{
    public class ServiceWrapper : IServiceWrapper
    {
        private readonly GraphServiceClientFactory _graphServiceClientFactory;
        private IMicrosoftGraphService _graph;
        private IMicrosoftGraphAccountService _graphAccount;
        public ServiceWrapper(GraphServiceClientFactory graphServiceClientFactory)
        {
            _graphServiceClientFactory = graphServiceClientFactory;
        }

        public IMicrosoftGraphService Graph
        {
            get => _graph ??= new MicrosoftGraphService(_graphServiceClientFactory.Initialize());
        }

        public IMicrosoftGraphAccountService GraphAccount
        {
            get => _graphAccount ??= new MicrosoftGraphAccountService(_graphServiceClientFactory.InitializeAccount());
        }

        public IMicrosoftGraphAccountService GetGraphMailService(string recipient)
        {
            return new MicrosoftGraphAccountService(_graphServiceClientFactory.InitializeMail(Graph, recipient)) ?? null;
        }
    }
}
