namespace ThunderRaeder.API.General.ActionRoutes
{
    public interface IRoute
    {
        public string Action { get; }
        public string Controller { get; }
        public object GetParameter(string id);
    }
}
