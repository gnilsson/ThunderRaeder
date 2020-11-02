namespace ThunderRaeder.API.General.ActionRoutes
{
    public class GetBookRoute : IRoute
    {
        public string Action => "GetBook";
        public string Controller => "Books";

        public object GetParameter(string id)
            => new { bookId = id };
    }
}
