namespace ThunderRaeder.API.General.ActionRoutes
{

    public class GetAnnouncementRoute : IRoute
    {
        public string Action => "GetAnnouncement";
        public string Controller => "Announcements";

        public object GetParameter(string id)
            => new { announcementId = id };

    }
}
