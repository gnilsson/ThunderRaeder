namespace ThunderRaeder.API.General.ActionRoutes
{
    public class GetAuthorRoute : IRoute
    {
        public string Action => "GetAuthor";

        public string Controller => "Authors";

        public object GetParameter(string id)
            => new { authorId = id };
    }
}
