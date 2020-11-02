namespace ThunderRaeder.API.General.ActionRoutes
{
    public class GetUserRoute : IRoute
    {
        public string Action => "GetUser";

        public string Controller => "Users";

        public object GetParameter(string id)
            => new { userId = id };
    }
}
