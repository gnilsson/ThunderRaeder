namespace ThunderRaeder.API.General.ActionRoutes
{

    public class GetCommentRoute : IRoute
    {
        public string Action => "GetComments";
        public string Controller => "Comment";

        public object GetParameter(string id)
            => new { commentId = id };

    }
}
