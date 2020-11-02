namespace ThunderRaeder.Shared.ServerApiContracts
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Books
        {
            private const string Route = "/books";
            private const string Id = "/{bookId}";

            // GET :
            public const string Get = Base + Route;

            public const string GetById = Base + Route + Id;

            // POST :
            public const string Create = Base + Route;

            // PUT :
            public const string Update = Base + Route + Id;

            // DELETE :
            public const string Delete = Base + Route + Id;
        }

        public static class Authors
        {
            private const string Route = "/authors";
            private const string Id = "/{authorId}";

            // GET :
            public const string Get = Base + Route;

            public const string GetById = Base + Route + Id;

            // POST :
            public const string Create = Base + Route;

            // PUT :
            public const string Update = Base + Route + Id;

            // DELETE :
            public const string Delete = Base + Route + Id;
        }

        public static class Users
        {
            private const string Route = "/users";
            private const string Id = "/{userId}";

            // GET :
            public const string Get = Base + Route;

            public const string GetById = Base + Route + Id;

            // POST :
            public const string Create = Base + Route;

            public const string AddBooks = Base + Route + "/books";

            public const string Invite = Base + Route + "/invite";

            // PUT :
            public const string Update = Base + Route + Id;

            // DELETE :
            public const string Delete = Base + Route + Id;
        }

        public static class Me
        {
            private const string Route = "/me";

            // GET :
            public const string Get = Base + Route;

            public const string Books = Base + Route + "/books";

            public const string Verify = Base + Route + "/verify";

            // POST :
            public const string AddBook = Base + Route + "/books";
        }

        public static class Announcements
        {
            private const string Route = "/announcements";
            private const string Id = "/{announcementId}";

            // GET :
            public const string Get = Base + Route;

            public const string GetById = Base + Route + Id;

            // POST :
            public const string Create = Base + Route;

            // PUT :
            public const string Update = Base + Route + Id;

            // DELETE :
            public const string Delete = Base + Route + Id;
        }

        public static class Comments
        {
            private const string Route = "/comments";
            private const string Id = "/{commentId}";

            // GET :
            public const string Get = Base + Route;

            public const string GetById = Base + Route + Id;

            // POST :
            public const string Create = Base + Route;

            // PUT :
            public const string Update = Base + Route + Id;

            // DELETE :
            public const string Delete = Base + Route + Id;
        }

        public static class Media
        {
            // GET : 
            public const string Get = Base + "/media/{driveId}";

            // POST : 
            public const string Add = Base + "/media";
        }
    }
}
