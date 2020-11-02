using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThunderRaeder.Data.Migrations
{
    public partial class AddPopularityScore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PopularityScore",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "Firstname", "Gender", "Lastname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("b45469c1-63aa-4911-ada6-8d787805359d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sonja", 1, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("43e17ca6-024d-4e32-90a3-a10f3821ae78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guadalupe", 0, "Andersson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0757143-62fb-414b-8148-7c7032e15c4d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mike", 0, "Eriksson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b08c0a0-5b23-4287-a927-abee1d987e9b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yvette", 1, "Karlsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb630132-d895-494c-8b78-3015a4e579db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramona", 1, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("647080cd-b433-4d8f-a38b-7a77ce6d45f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosemarie", 1, "Persson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f15b42e7-f8e5-4e58-be80-17738ec6d2fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terri", 1, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6cf15954-9bae-4d05-a82b-4871a98759ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frederick", 0, "Nilsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68002941-242f-4d32-9d87-485204f052c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robin", 0, "Karlsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e781960-c945-4b32-b634-15179755c9cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasha", 1, "Karlsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb88122d-0d36-4282-be8b-49b7c29b5b5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro", 0, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79466dbc-1d2d-4f2e-8855-5bd606835f02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yolanda", 1, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("466fd272-5d63-4e52-ab43-3b9204c0289f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noel", 0, "Svensson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6bdd51b2-5dd9-4ca8-8f56-37c777e6e5f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kerry", 0, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7aae0002-6e40-4650-a430-fa750799cbe7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexis", 1, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e92ec76a-9faa-4319-b4de-13eab8bc5f40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eva", 1, "Andersson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e0b7a21-6050-4d3e-83dd-2d545391c132"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randy", 0, "Nilsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("82b083b8-b517-4fe6-acee-9b71cae2fa8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bernice", 1, "Svensson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("26cdbfc6-4812-4122-a724-362ee496f225"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adrienne", 1, "Svensson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c52f8f1-4fe2-40e9-98f8-f2ecedea2d4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domingo", 0, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("30865b1b-2ee4-4629-bd7e-9d105a62197c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cathy", 1, "Karlsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ab0bd1dd-3498-4a9c-95a7-c66d1d575046"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roderick", 0, "Nilsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b67869dc-160c-427b-af7a-f15a4d117730"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel", 0, "Svensson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa4d5636-d22f-4c27-8bc3-b304fdd93b30"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Travis", 0, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fcccfb0b-1b9e-419c-b873-282de4d3ddaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peggy", 1, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4c265f1-9530-4e19-bacf-0c94f0144cbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnnie", 1, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9cc559db-b14b-4698-897c-0a9cddc99cce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penny", 1, "Gustafsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d93bde1-31dc-414c-bd16-0306906fb12b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenny", 0, "Eriksson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96a9c762-83da-488c-819c-c7bbdd21cda0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nichole", 1, "Gustafsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7981f342-e175-49ca-8a53-d92ff6b6a87c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachary", 0, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("356157a3-6a6c-486a-ab0d-cf59e9254694"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hazel", 1, "Persson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99431c48-1587-41e3-a503-db541da6365b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda", 1, "Olsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5985f988-91bc-49a7-8d42-5bdd495dce5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joann", 1, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da15ea4d-e804-472f-b131-cc04d08f764e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karl", 0, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75bc7fbf-c02a-4efb-ba23-7a4765fed8be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eugene", 0, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("28a844f7-ed27-45ad-b2b2-34f9672fcb43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jody", 0, "Nilsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0b8ae3cf-9270-4ed8-ad94-cd441c683420"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emmett", 0, "Karlsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b30e434-3b54-49f1-9134-285a8cde2591"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everett", 0, "Andersson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("658328e0-fc7a-4205-a129-0cf9b11bc505"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dora", 1, "Nilsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f0792a6-300a-420b-980e-42938c4c8a6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscar", 0, "Nilsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("54972f14-23d6-4611-b245-c70cf2e10e77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margarita", 1, "Gustafsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff97f372-27e7-4077-93d6-83fd53c4a80b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ollie", 1, "Nilsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0a45cfe-41c2-417f-bc11-7fed60f27b16"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joy", 1, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c6cc988e-d5e9-4518-80b7-d9d07c75fb99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leslie", 1, "Olsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13cbdb09-b659-498d-aacc-b5a095b129b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kristi", 1, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62e645e9-2e79-4304-9ad8-145e31e1aafc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shelley", 1, "Eriksson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc9ea431-5cdd-4cee-9083-f18fd8eaa803"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roxanne", 1, "Gustafsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15148de0-5c96-4e1d-9d9d-aeb172d25aa8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Florence", 1, "Svensson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ec3a621-939f-4fcf-9c6c-2d5c94a3e67d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marco", 0, "Svensson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("750437fa-5176-443d-9d2c-bf3e216910a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattie", 1, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AnnouncementId", "AuthorId", "CreatedDate", "Description", "DriveId", "Genre", "PopularityScore", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("fbeb3f10-c15b-423c-a254-d37c33e26601"), null, new Guid("b45469c1-63aa-4911-ada6-8d787805359d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nisi possimus dolor facere qui nemo reiciendis alias aut iusto. Cupiditate harum sint consequatur eos non occaecati delectus. Eaque voluptates et minima incidunt iure. Deleniti numquam perferendis est eligendi omnis ea minus fugit. Et non magnam. Asperiores ipsam assumenda doloremque dolorum blanditiis qui ut et.", null, 2, 0, "Drink Cent Pizzas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0e15b3e8-6909-456b-8ec8-eb94e276667b"), null, new Guid("466fd272-5d63-4e52-ab43-3b9204c0289f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas autem aut. Vel quia possimus aspernatur. Tempore fugit exercitationem molestias reprehenderit corrupti eaque tempore.", null, 5, 0, "Bolt Enjoy Passenger", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3ed38538-6fdf-4bf0-8a02-84a4db7d18c6"), null, new Guid("466fd272-5d63-4e52-ab43-3b9204c0289f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed repudiandae maxime sit blanditiis voluptatem ducimus officiis. Dolorem reiciendis aut assumenda mollitia culpa voluptates cupiditate ut. Fuga voluptatem odit mollitia libero nemo. Debitis sapiente qui quisquam cupiditate temporibus laborum sit beatae.", null, 4, 0, "Way Jazzy Sore", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c6fff9b-a0bf-472a-bffc-c7b6a50be7a2"), null, new Guid("466fd272-5d63-4e52-ab43-3b9204c0289f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tenetur aperiam molestiae suscipit voluptatem corrupti odit similique dolorem. Itaque recusandae aliquam voluptatem nihil officiis hic ex beatae. Esse suscipit temporibus maiores qui omnis fugiat.", null, 0, 0, "Scarecrow Pizzas Way Elderly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1742379d-0c40-46fc-88e2-8104e9d16460"), null, new Guid("79466dbc-1d2d-4f2e-8855-5bd606835f02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accusamus cumque sit voluptatem necessitatibus nostrum beatae. Libero numquam sapiente. Ut dolorem nulla fugit vel.", null, 3, 0, "Helpful Evanescent Wrist Huge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("31f573d4-0078-42e1-8761-3b548254dd83"), null, new Guid("79466dbc-1d2d-4f2e-8855-5bd606835f02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est qui debitis corporis quia rerum totam est perferendis voluptates. Sint sit omnis neque excepturi voluptatem odio nihil. Tempora minus minima. Optio repellat vero non voluptas non rem perferendis quo. Et in quasi atque odit fuga optio sed.", null, 1, 0, "Of Miss Drink", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77299a33-bd2d-490e-91ad-2e1234dbdbb4"), null, new Guid("6e781960-c945-4b32-b634-15179755c9cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delectus asperiores similique. Eligendi amet vel optio debitis. Enim architecto et omnis accusantium esse consectetur et consequatur dolores. Itaque exercitationem dolorum quam laborum sunt tempore eveniet. Vel ullam dolorum quaerat nulla et molestiae illo pariatur.", null, 1, 0, "Helpful of", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d0398769-1c0e-4aec-803c-0c925d3dc7a0"), null, new Guid("68002941-242f-4d32-9d87-485204f052c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dignissimos quo sint maxime illo architecto nesciunt asperiores voluptatem. Vitae mollitia provident et ipsam debitis alias necessitatibus qui. In sapiente aliquam.", null, 5, 0, "Damp Strange Swanky", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96f7cfa8-220a-469b-bad4-690b7c0eea3b"), null, new Guid("6cf15954-9bae-4d05-a82b-4871a98759ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delectus libero accusamus soluta placeat ut quia velit. Natus fugiat voluptatem. Minus eveniet voluptatem delectus fugiat dicta a illo nihil voluptas. Possimus voluptatum saepe blanditiis ut. Consequuntur provident quas similique aut ut aut voluptatem error minus.", null, 0, 0, "Position Thought Bleach", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("05d2d1de-d72b-44c7-9c8d-b89222a88a5c"), null, new Guid("f15b42e7-f8e5-4e58-be80-17738ec6d2fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ab similique ut at dolorem cupiditate culpa officia assumenda. Velit quo alias aspernatur error. Ducimus beatae aut tempora eaque eum maiores maxime ipsa. Qui id porro est quae rerum quo et. Rerum placeat eius quod.", null, 4, 0, "Way Bolt Ancient Jazzy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4f009d9-2065-427a-8646-c77e8d4ff5ce"), null, new Guid("f15b42e7-f8e5-4e58-be80-17738ec6d2fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatibus hic reiciendis assumenda officia. Et corrupti eum vero laboriosam voluptate necessitatibus laudantium nihil. Pariatur aut at iure delectus omnis laudantium. Consequatur facere itaque earum exercitationem quaerat eos nam consequatur nobis.", null, 3, 0, "Sore Quizzical Drink of", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("67ecb354-7cef-4113-82e6-78e0503b6823"), null, new Guid("eb630132-d895-494c-8b78-3015a4e579db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cupiditate ut illo a est non culpa id. Quia omnis officia ad quibusdam consectetur eius. Totam enim saepe sapiente consectetur et.", null, 5, 0, "Passenger Explode Wrap for", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("651143ff-42af-4def-9372-a40367b686ec"), null, new Guid("eb630132-d895-494c-8b78-3015a4e579db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis tempora ut. Autem molestias sapiente et sunt autem. Nihil occaecati facere in libero. Dolore ipsam neque fugiat vitae esse. Sint hic delectus similique quo dolorem. Adipisci aut commodi sunt officia.", null, 5, 0, "Way Enjoy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8f6cf604-d4f8-46f8-9956-fa2c572b8cb2"), null, new Guid("eb630132-d895-494c-8b78-3015a4e579db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Totam aspernatur nihil quibusdam dolorem hic aut. Cumque enim nihil dolores dolorem omnis odit reprehenderit. Ab inventore voluptas voluptate similique et deleniti voluptas. Odio sint nemo ut quia voluptas dolor laborum provident. Consequatur aut aliquam et facilis quibusdam minima aut dolores modi.", null, 5, 0, "Vivacious Thought Pizzas Time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("215bc8bd-c1b3-4615-b19d-e20cb5d0a761"), null, new Guid("9b08c0a0-5b23-4287-a927-abee1d987e9b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et atque dignissimos quaerat molestias deleniti error in quia. Nostrum repudiandae rerum doloremque. Et est fugit maxime cumque ducimus. Sint delectus nobis possimus voluptatem at dolores. Fuga quam culpa. Ut cumque officiis.", null, 3, 0, "And Chess", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("017f1009-a29e-45e8-be33-19fbd4498d1e"), null, new Guid("9b08c0a0-5b23-4287-a927-abee1d987e9b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas dignissimos quia dolores eveniet incidunt tempora rem ut. Consectetur autem quibusdam voluptatem earum quo omnis. Quia culpa non autem. Soluta est nostrum maiores. Aut molestiae sed nemo omnis sed ea voluptatem praesentium voluptatum.", null, 3, 0, "Miss of", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5383ea0b-5497-4b62-8a4f-bc8e90ab0797"), null, new Guid("a0757143-62fb-414b-8148-7c7032e15c4d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur dolor aut alias consequatur tempore necessitatibus distinctio in culpa. Voluptatem ea eum minus quae sint mollitia nostrum omnis. Ad occaecati ipsum suscipit ullam accusamus aperiam perferendis soluta voluptas. Aperiam eligendi dolor eum non reiciendis enim. Consequatur assumenda similique accusamus doloremque totam tempora iure libero.", null, 3, 0, "For Sneeze", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99c274a8-d29d-47f1-921b-5d3f1e3ed430"), null, new Guid("a0757143-62fb-414b-8148-7c7032e15c4d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modi placeat placeat quis ut voluptatem. Amet in ea quo praesentium error. Eius amet aut explicabo voluptatibus. Quas cumque ea nihil aut sit rerum repellat.", null, 5, 0, "Ludicrous with Knee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40ea1e56-20b3-401d-b91e-aecfe8422b89"), null, new Guid("43e17ca6-024d-4e32-90a3-a10f3821ae78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis est dolores beatae ratione. Deleniti est ut. Nemo qui temporibus labore illo.", null, 2, 0, "Sneeze to Scary", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e55df9c-f8c7-4279-b28d-b3493a756983"), null, new Guid("43e17ca6-024d-4e32-90a3-a10f3821ae78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accusantium facere voluptates est velit. Accusamus aliquid id officiis nobis in dignissimos consequatur magnam facere. Ut et quidem. Porro dolorem sed. Ratione odio aspernatur quibusdam quae modi. Animi aut consequatur esse inventore quisquam beatae repellat.", null, 0, 0, "Position and Elderly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ae6a9da-f578-4255-a899-6b531fea34a8"), null, new Guid("43e17ca6-024d-4e32-90a3-a10f3821ae78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas nesciunt quidem praesentium non saepe nobis dolor. Quod consequatur assumenda. Alias mollitia qui. Officiis vel tenetur iste deleniti deserunt. Maxime accusantium voluptatibus rerum repellat et blanditiis blanditiis id nam. Ipsa et labore dolor dolorem.", null, 1, 0, "Position Look", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6605249c-e589-429d-be50-d429d294bdf7"), null, new Guid("43e17ca6-024d-4e32-90a3-a10f3821ae78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explicabo non enim quod porro. In quis perferendis. Nesciunt ut quia nihil impedit et in praesentium. Voluptate quia velit nostrum dolore culpa tempore voluptatum veritatis. Quia consequatur nemo delectus et neque enim officiis. Molestiae minus repudiandae aut dicta molestiae corrupti eligendi voluptatem.", null, 0, 0, "Bleach Truck Scarecrow Huge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f20b7462-59df-4e4d-9b90-9b788bb6de64"), null, new Guid("466fd272-5d63-4e52-ab43-3b9204c0289f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doloribus vero aut. Omnis nihil cupiditate. Ad repellat occaecati dolores aut voluptatem ducimus. Magni laudantium laborum ea repudiandae ullam aut odio quo ea.", null, 5, 0, "Damp Ludicrous Look Effect", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("518c96ae-6959-463a-9e43-e920b52747b5"), null, new Guid("43e17ca6-024d-4e32-90a3-a10f3821ae78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aliquam quisquam et deleniti enim reprehenderit et. Qui labore consectetur sunt. Rerum eum in eum repudiandae. Aliquid delectus voluptatibus. Officiis quaerat illum et corporis ullam eos ab iure quia. Eaque odit minima voluptatem.", null, 3, 0, "Position the Dry", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3e2ef45f-ec34-4a7c-b89f-6d86dd32cfc3"), null, new Guid("6bdd51b2-5dd9-4ca8-8f56-37c777e6e5f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eveniet sed ut. Tempore et quia eligendi non minus est delectus. Temporibus dignissimos error dicta et odio. Possimus doloremque quae quam quas. Voluptatum corporis ea voluptas sit assumenda. Rerum aut occaecati quaerat suscipit recusandae est eum eum dolor.", null, 4, 0, "Position the Dry", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d47ea8e2-f3d5-4a38-84ff-669af781b538"), null, new Guid("7aae0002-6e40-4650-a430-fa750799cbe7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maxime magnam ut dolore aut asperiores tenetur rerum. Iusto natus ut corrupti commodi ut laborum amet. Enim reiciendis sed blanditiis optio molestiae ut. Qui et officia assumenda in unde.", null, 1, 0, "Wrist Quizzical", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c925f044-f4e3-4b53-8e27-9861d74fcb67"), null, new Guid("750437fa-5176-443d-9d2c-bf3e216910a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harum omnis aut dolores in non laboriosam soluta distinctio. Debitis ipsum sint voluptas ducimus cumque nostrum non. Porro iure eos nulla rerum ut.", null, 0, 0, "Scary Scarecrow Sneeze", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f9003b4-f271-4d59-bce0-f3b353b2dfca"), null, new Guid("0b8ae3cf-9270-4ed8-ad94-cd441c683420"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem deleniti blanditiis. Consequatur consequatur consequatur. Minus labore beatae officiis aut ea distinctio iste. Asperiores quam quia minus ratione sunt distinctio animi autem.", null, 2, 0, "Position and Elderly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5993b63f-9cb2-4538-a4f0-ae003f411493"), null, new Guid("0b8ae3cf-9270-4ed8-ad94-cd441c683420"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex dignissimos quod cupiditate. Molestiae a asperiores et animi minus dolor voluptatem ut eum. Necessitatibus molestiae doloremque voluptate est iusto et quaerat dolorem. Odit quia eos illo adipisci molestiae. Consequatur ea optio vel quaerat libero inventore necessitatibus. Earum inventore culpa omnis nulla et architecto.", null, 1, 0, "Evanescent Wrist Cent", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0bc37584-8d3e-460a-9eab-52036b6d331f"), null, new Guid("0b8ae3cf-9270-4ed8-ad94-cd441c683420"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excepturi incidunt voluptas doloremque corporis deleniti fugiat animi aut. Et voluptas ut veritatis maxime doloremque. Corrupti sed velit ut praesentium quis unde officia et. Omnis iusto consequatur et. Beatae iure optio quia ullam quo illo ea.", null, 1, 0, "Passenger Explode Wrap for", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cecd7822-23b4-4be5-b618-7854ef8ba0aa"), null, new Guid("ab0bd1dd-3498-4a9c-95a7-c66d1d575046"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur reprehenderit aut voluptatem beatae. Qui ratione sed. Dignissimos vel suscipit voluptatem consequatur reiciendis repellat dolorum vitae unde.", null, 5, 0, "Drink Ludicrous", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1dd9f85c-3924-4f6e-860f-32299676d528"), null, new Guid("ab0bd1dd-3498-4a9c-95a7-c66d1d575046"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem numquam quis. Fugiat impedit molestias. Voluptas neque ab consequuntur id sequi quo voluptatem nostrum. Qui odit accusamus. Dolor sunt architecto sapiente est.", null, 4, 0, "Damp Trains", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d356e5a-4746-4589-a034-cf2ec278b21e"), null, new Guid("2c52f8f1-4fe2-40e9-98f8-f2ecedea2d4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut sit ratione numquam ea rem qui tenetur inventore. Suscipit consectetur hic ab ullam quam. Optio nam dolores qui veritatis. Ut est facilis. Numquam qui nostrum.", null, 2, 0, "Of Position Church Explode", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd723dcf-d4d0-4820-8974-c071233df1d2"), null, new Guid("2c52f8f1-4fe2-40e9-98f8-f2ecedea2d4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tempora ipsam libero repellendus sunt sint voluptas iusto omnis. Voluptatem et quas et enim autem facere pariatur. Et corporis facilis laboriosam.", null, 5, 0, "Whisper Ludicrous", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1051833-2e4b-481f-8ea0-1ec86fa8fe4f"), null, new Guid("2c52f8f1-4fe2-40e9-98f8-f2ecedea2d4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deserunt voluptate quia deserunt eligendi et. Porro repudiandae sit tenetur labore sed dolorum. Quasi qui pariatur. Officia rerum soluta voluptatem ipsam blanditiis. Vero itaque esse nihil quia incidunt. Vel voluptatem voluptatem atque autem sequi repudiandae illum sint sit.", null, 4, 0, "Pizzas Look Helpful Scary", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f0891b9-0607-4063-9ab0-f7197ee07136"), null, new Guid("2c52f8f1-4fe2-40e9-98f8-f2ecedea2d4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Totam autem quae officiis laudantium est voluptatem ut. Veniam sed voluptatem inventore et architecto maiores earum. Vitae illum aut. Velit aut et minima doloremque officiis recusandae. Et autem est commodi expedita tempora aut sapiente quibusdam.", null, 3, 0, "Wrap Scarecrow Damp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("18b2070d-c393-43c7-9262-1c5d1501cae6"), null, new Guid("2c52f8f1-4fe2-40e9-98f8-f2ecedea2d4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quos iusto sint temporibus. Facere velit est et est maiores id nesciunt minima. Enim sit molestiae earum saepe aut saepe. Est voluptatum reiciendis facere cupiditate quia occaecati dolore accusantium ut. Ut et quae quo dolorem.", null, 0, 0, "For Jazzy Chess", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f8d75c5-c410-4089-94f7-05dc40c798f1"), null, new Guid("2c52f8f1-4fe2-40e9-98f8-f2ecedea2d4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ducimus sint aut atque ea excepturi voluptatem. Vero ducimus voluptate consequatur sint qui sit magni ipsa. Omnis aut occaecati magni dolores autem soluta laborum. Deleniti aspernatur illum tenetur tempora eaque sunt commodi. Est voluptas ut nesciunt id aut. Quos est assumenda eaque qui dignissimos earum veniam.", null, 2, 0, "Optimal the Huge Huge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189fc66-1ff6-4609-bbe0-188d6360de7c"), null, new Guid("2c52f8f1-4fe2-40e9-98f8-f2ecedea2d4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptate cum dicta sint aliquam enim debitis explicabo sunt eveniet. Ad beatae ipsam ipsa qui voluptas facilis. Quo eos omnis repellendus expedita atque pariatur officia odio distinctio. Minus odit dolorem ut quia.", null, 5, 0, "Too Drink Cent", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0094795d-c48c-4292-8fbd-821d1db38db9"), null, new Guid("26cdbfc6-4812-4122-a724-362ee496f225"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atque voluptatem quia eaque quae voluptatem illo. Sequi minima eveniet quam eligendi alias totam. Laborum nemo nihil et sunt quod id cum rerum sint.", null, 2, 0, "Way Enjoy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("67ac769c-5f7f-4a3b-bccc-4bd8f3f02115"), null, new Guid("26cdbfc6-4812-4122-a724-362ee496f225"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quisquam mollitia officiis eos debitis dolorum quia accusamus quasi deleniti. Ad iure qui quis. Quo alias aut deserunt. Molestiae corporis placeat ut fugiat eveniet molestiae pariatur. Nemo quisquam vero atque culpa.", null, 4, 0, "Wrist Ludicrous", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b33b77a-5060-45a8-8b69-ee4e273f8bbe"), null, new Guid("26cdbfc6-4812-4122-a724-362ee496f225"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cum facilis omnis et ut. Aut quidem eum enim labore ut asperiores inventore. Ut minima aut ut deserunt tempora in. Maiores quidem quo.", null, 1, 0, "Helpful Evanescent Wrist Huge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d3cf947c-3a43-4b67-9453-01fad511f489"), null, new Guid("82b083b8-b517-4fe6-acee-9b71cae2fa8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnam pariatur cumque nihil velit. Enim aut voluptatem nihil qui non vero earum. Ducimus itaque cumque hic eveniet impedit.", null, 0, 0, "Sneeze Enjoy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7287bd9d-5680-468e-81b7-77f5017c0d99"), null, new Guid("8e0b7a21-6050-4d3e-83dd-2d545391c132"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alias minus expedita non nam molestias aut at facilis quisquam. Incidunt fugit libero sed aliquid. Ut veniam molestias maxime ratione nihil et qui accusamus. Atque consequatur sint. Voluptas ab beatae eligendi ducimus est minima enim et reiciendis.", null, 5, 0, "Damp Trains", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("903da0c4-7fa9-4791-9886-38d447d92dd1"), null, new Guid("e92ec76a-9faa-4319-b4de-13eab8bc5f40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aliquid natus sit voluptatem nam neque minima alias non. Accusantium alias temporibus quibusdam odio voluptatem corrupti magni maxime. Dolor aperiam reiciendis facere fuga iste. Atque non temporibus voluptatem. Aperiam nisi sint excepturi ullam quae pariatur consequatur atque.", null, 0, 0, "Strange Vivacious", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6043b602-75fb-4f8a-8764-eb0aa8bbd6ac"), null, new Guid("e92ec76a-9faa-4319-b4de-13eab8bc5f40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magni deserunt quod nisi quia tempora inventore. Vero sit commodi. Ut ratione aut quis eos et voluptas eaque quaerat repudiandae. Vero dolore modi dolores omnis quia. Omnis atque est mollitia ratione repellat.", null, 5, 0, "Jazzy Sore Position", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17b91ab7-4190-49b8-8783-e593d6985991"), null, new Guid("e92ec76a-9faa-4319-b4de-13eab8bc5f40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ea nam dolorem voluptas vel doloribus quo omnis. Voluptatem perspiciatis sit quod mollitia maiores reprehenderit modi atque consequatur. Quo illum molestiae adipisci consequuntur repellat cum mollitia sed a. Sapiente fugit laudantium dolores quisquam. Asperiores vitae voluptatibus aut sed voluptatibus dolorum placeat et.", null, 0, 0, "Swanky the", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b9029b36-a0ef-42cb-af5a-38747fe3a11d"), null, new Guid("7aae0002-6e40-4650-a430-fa750799cbe7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut magnam est maiores voluptatem hic provident molestias officiis. Eligendi quae hic cupiditate laborum doloremque est id molestiae. Aliquam dicta suscipit nihil aperiam voluptates fugiat repudiandae et aut. Nulla similique ea quidem recusandae consequatur. Voluptatem aut aspernatur voluptatem libero.", null, 5, 0, "Strange Miss Swanky", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e77a1804-1fea-4d31-812b-c8c969bfa7ef"), null, new Guid("43e17ca6-024d-4e32-90a3-a10f3821ae78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eveniet eum facere et beatae aut veniam vel. Quas ipsam laudantium est id perferendis. Alias non numquam temporibus quibusdam et quis. Dolores impedit expedita quae ut quae asperiores aliquid sapiente fugit. Minus voluptas atque praesentium vel quia voluptatem asperiores aut est. Fuga et nam illo explicabo accusantium repellendus consequuntur.", null, 5, 0, "Thought Bleach", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f50027a8-6a87-401f-a7e2-bd483013a12c"), null, new Guid("b67869dc-160c-427b-af7a-f15a4d117730"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis quia natus porro sit necessitatibus. Ipsam architecto deserunt hic dolor. Numquam maiores nam ut.", null, 2, 0, "Miss of", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("700accca-019d-49bb-a441-f46bf5998a9e"), null, new Guid("b67869dc-160c-427b-af7a-f15a4d117730"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex voluptates qui doloremque est. Provident nesciunt modi tempore omnis consequatur. Aspernatur quod saepe perspiciatis sit. Laboriosam nostrum ea nostrum inventore atque nobis. Culpa reiciendis maxime quia et consequatur similique.", null, 0, 0, "Legal Trains", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71bafa10-c321-450f-ac73-85468bb8ce2c"), null, new Guid("9b30e434-3b54-49f1-9134-285a8cde2591"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolor repellendus occaecati voluptas porro nulla facilis dolorem numquam cum. Et dolore ipsam quia et quod non. Quia sint vero. Assumenda molestias vero et reprehenderit. Sit occaecati ut. Quas est qui a molestias aut voluptatem.", null, 5, 0, "Strange Vivacious", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee32b653-4fa8-4788-99b8-b1a06f6aab27"), null, new Guid("9b30e434-3b54-49f1-9134-285a8cde2591"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed voluptatem sit omnis aspernatur. Eum voluptatem possimus officia quam debitis fugit. A delectus repellendus quibusdam provident aliquam tempora commodi qui laboriosam. Rerum itaque nostrum qui autem omnis quod praesentium ex. Vero hic ipsa sunt autem.", null, 0, 0, "Drink Jazzy Sore", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3bf7e068-2a81-4878-929b-6e3bb26b9e16"), null, new Guid("9b30e434-3b54-49f1-9134-285a8cde2591"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur nisi sit id. Ut sequi praesentium quia cumque consequuntur ut. Qui eveniet aut magni qui consectetur et aut eos voluptatibus. In est impedit eius dolorem voluptatum.", null, 1, 0, "Of Miss Drink", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1851f54b-f52f-4ce8-a523-744e05885575"), null, new Guid("28a844f7-ed27-45ad-b2b2-34f9672fcb43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed consequuntur recusandae expedita et harum dolor sint excepturi. Sed nobis aperiam ea. Quia distinctio blanditiis. Non animi accusantium temporibus nostrum. Nisi et accusamus molestias nesciunt veniam omnis omnis nesciunt. Ullam magnam ea nesciunt.", null, 2, 0, "Bleach Miss Huge Wrap", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("770f1ddd-3bf1-4341-a5d5-8a727bcd4a74"), null, new Guid("28a844f7-ed27-45ad-b2b2-34f9672fcb43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expedita voluptatem sit consectetur perferendis repudiandae possimus. Error animi dolore amet aperiam officia placeat quam voluptates. Qui qui illum id non necessitatibus. Aut earum vel ducimus error ut. Odio ea rerum quis. Molestias et asperiores voluptates.", null, 0, 0, "Position and Elderly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd32a2af-214f-40ba-b4a6-f7078914618d"), null, new Guid("28a844f7-ed27-45ad-b2b2-34f9672fcb43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magni est ratione harum reiciendis quidem. Necessitatibus sit asperiores. Ut modi voluptatem doloribus odit. Neque minima laboriosam facilis numquam velit.", null, 3, 0, "Evanescent Effect Hate Way", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("373faa68-be0f-4295-9aa6-f549d4834bb7"), null, new Guid("28a844f7-ed27-45ad-b2b2-34f9672fcb43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hic nemo quo praesentium esse quia odio assumenda fugiat quis. Dolores numquam quas. Et ut consequatur quae accusamus officiis eum porro qui consequatur. Ipsam culpa voluptas ipsa quis commodi consequatur. Deserunt explicabo dolor omnis ad quod laborum blanditiis. Magnam rerum dicta natus tempora nobis commodi.", null, 0, 0, "Knee Jazzy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7b0fc97-0d01-46b6-8df1-becc2912174f"), null, new Guid("75bc7fbf-c02a-4efb-ba23-7a4765fed8be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natus ut ducimus dolor dolores. Eius natus perspiciatis perferendis ipsa aut consequatur hic. Autem nostrum consequuntur dolorem quae. Qui sit est ipsum deleniti esse ut labore. Ad eum aut id doloremque qui. Cupiditate et nemo laborum suscipit eum.", null, 5, 0, "Too Swanky", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76cf41f6-0f4f-448c-97d2-0dbe3812fd30"), null, new Guid("da15ea4d-e804-472f-b131-cc04d08f764e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesentium beatae eos. Possimus sequi dignissimos. Aperiam ipsum iure doloremque optio hic tenetur vitae laborum nihil. Odit qui aut blanditiis perspiciatis non neque corrupti dolores. Nesciunt non recusandae.", null, 1, 0, "Swanky Dry Jazzy Ancient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("083c789f-c39d-43a2-a124-7306d6583e4f"), null, new Guid("5985f988-91bc-49a7-8d42-5bdd495dce5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et unde voluptatem quod sed asperiores. Aut et omnis mollitia nobis et aut sint aut hic. Id libero nisi omnis sunt culpa eos. Facere repudiandae adipisci. Expedita voluptas non fuga accusantium quidem.", null, 4, 0, "Drink Cent Pizzas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d18cf1d8-3efc-40e6-be0a-bb42e0b5a66d"), null, new Guid("99431c48-1587-41e3-a503-db541da6365b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quos sint ea expedita totam repellat aut consequuntur. Ipsam culpa molestiae optio aut itaque quibusdam. Nihil fugiat ipsum ut dignissimos minima. Voluptatem odio minima recusandae consequatur magni dolorem eos sit ut.", null, 0, 0, "Evanescent Bleach", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63704e36-6266-4436-b687-4fc56724281c"), null, new Guid("99431c48-1587-41e3-a503-db541da6365b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explicabo omnis aut. Minima vel nam sit quae quia alias tempora. Ut error deleniti sunt facere. Impedit dignissimos accusantium natus accusamus.", null, 2, 0, "Drink Jazzy Sore", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4fe2773-0182-4e7a-b952-d8de441dcf0d"), null, new Guid("99431c48-1587-41e3-a503-db541da6365b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut sit in aliquam velit autem rerum sed. Cupiditate adipisci aut fugit vero. Ut cum commodi. Corporis ad qui. Ut commodi ducimus sit. Consequatur qui et vitae itaque ut et non.", null, 5, 0, "Cloistered Way Church too", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bfc12a57-2506-446e-ad3f-0db3ace69ca0"), null, new Guid("356157a3-6a6c-486a-ab0d-cf59e9254694"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut praesentium aut. Numquam quia quia reiciendis provident labore doloribus sit molestias. Voluptatem distinctio voluptatibus. Voluptatem id laboriosam. Hic temporibus et molestias neque saepe dolore aliquam. Nostrum sit est quos nihil.", null, 0, 0, "Scarecrow and Whisper Elderly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f196c1f-0086-4e66-8228-95ff997f4c19"), null, new Guid("356157a3-6a6c-486a-ab0d-cf59e9254694"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit dignissimos officia vitae ut dignissimos nobis nostrum architecto. Non tempore non hic quaerat molestiae. Perferendis beatae et quaerat. Esse et temporibus ea aspernatur aut nihil similique.", null, 1, 0, "Knee Jazzy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd949416-4018-4a8d-81fe-c29784818368"), null, new Guid("356157a3-6a6c-486a-ab0d-cf59e9254694"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitae et doloremque quam rerum repellendus consequatur. Accusamus id qui. Dolor neque odio sit et minima ullam a harum dolorem. Eligendi repellat pariatur officiis reiciendis quia iusto.", null, 5, 0, "Way Bolt Ancient Jazzy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ed60ee7-94ca-48a1-bbe2-850d9f6200cf"), null, new Guid("7981f342-e175-49ca-8a53-d92ff6b6a87c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut libero sed asperiores molestias doloremque corporis error. Voluptatem dolor harum cum porro molestiae et ipsam. Voluptatem id iure.", null, 2, 0, "Trains Damp Wrap Quizzical", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("285a5084-2ec0-4948-927f-a6ca63c67778"), null, new Guid("96a9c762-83da-488c-819c-c7bbdd21cda0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culpa adipisci sunt numquam possimus a et. Maxime voluptas sequi pariatur similique tempore non. Commodi quo deleniti et voluptatum provident cupiditate. Magnam blanditiis quam possimus minus harum hic et voluptate qui. Sed dolor aut ut modi molestiae asperiores delectus.", null, 5, 0, "Bolt Enjoy Passenger", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a56b5b9d-6c6c-4c8b-8e56-15d6ffd85381"), null, new Guid("8d93bde1-31dc-414c-bd16-0306906fb12b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saepe deserunt tempora non excepturi ut omnis optio ut voluptatem. Similique nulla repellat praesentium. Ut officia eum vel cum esse omnis. Aspernatur perferendis quod impedit sequi quia ea qui. Ea aut quae impedit vitae eius fugiat modi. Adipisci quia consectetur.", null, 1, 0, "Passenger Explode Wrap for", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1f9370e-c5af-43af-8637-4223006b1673"), null, new Guid("9cc559db-b14b-4698-897c-0a9cddc99cce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quam harum et placeat debitis. Nobis ipsa quos sit est nihil sunt quod dignissimos. Qui animi ut esse qui alias est voluptates.", null, 3, 0, "Bleach Sneeze Ancient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff3e0c92-cb65-4ea2-b602-e6373e588a23"), null, new Guid("b45469c1-63aa-4911-ada6-8d787805359d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excepturi ex saepe consequatur officiis. In et quia vero. Est porro aliquam atque sit. Facilis omnis enim sunt aspernatur veritatis facilis. Velit est suscipit dolorem.", null, 0, 0, "Legal Trains", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("08d174bd-ff66-46d0-a7cc-7693cd8120db"), null, new Guid("4ec3a621-939f-4fcf-9c6c-2d5c94a3e67d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia quia sunt sunt enim ut quis. Eos occaecati rerum ipsam consequatur enim vel ratione recusandae. Nam consequuntur recusandae et ex assumenda saepe iusto ut consectetur. Sit architecto error quia. Ut omnis neque amet eveniet a nemo voluptas ut.", null, 3, 0, "Bleach Truck Evanescent Look", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8a5fae9-a726-4dfd-88c1-3025fe8e468a"), null, new Guid("4ec3a621-939f-4fcf-9c6c-2d5c94a3e67d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doloribus veritatis a quia omnis inventore sit facilis qui. Consequatur modi qui cupiditate vel sed. Reiciendis officiis quae minima natus quia et a. Aspernatur incidunt laboriosam et doloremque reprehenderit ab qui possimus voluptatibus. Laborum voluptas distinctio ut in dolores modi eligendi. Illo modi ea dolorum reiciendis modi est minus error molestiae.", null, 5, 0, "Whisper Helpful", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d05fd234-b8b2-49da-9b5a-1005ac021111"), null, new Guid("4ec3a621-939f-4fcf-9c6c-2d5c94a3e67d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cum et quia incidunt amet rerum eveniet voluptatibus pariatur necessitatibus. Aliquid nihil officiis culpa nam deleniti et. Atque incidunt sed ipsam. In nihil eaque enim perspiciatis amet.", null, 3, 0, "Drink Jazzy Sore", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("953db6a6-d303-4b0e-98cb-3d9c3d17e914"), null, new Guid("4ec3a621-939f-4fcf-9c6c-2d5c94a3e67d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorum aperiam neque expedita similique voluptatibus. Ab commodi molestiae explicabo. Accusantium dicta suscipit. Vel explicabo velit vero rerum repudiandae cupiditate iure voluptas voluptate. Beatae ducimus non sunt fugiat facere maiores earum tempora inventore. Enim aut dolor cum qui omnis ut.", null, 2, 0, "Legal Trains", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5af41cdd-923b-4efe-9ac1-d67188991775"), null, new Guid("b67869dc-160c-427b-af7a-f15a4d117730"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odio quasi dolores optio ullam eos. Consequatur et illo modi nostrum est et aut earum enim. Aliquam aut maxime cum nihil autem modi ea soluta deserunt.", null, 2, 0, "Miss of", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5cdf565f-2a0d-4867-be51-cb612f7c7c1c"), null, new Guid("b67869dc-160c-427b-af7a-f15a4d117730"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et animi sint qui quia suscipit. Voluptates iure aut dolores ad quibusdam est. Quos veritatis quisquam aliquam quod. Illo qui animi optio error. Delectus nam velit aut perspiciatis cupiditate vel optio illum. Libero et est consequatur velit quidem voluptatum distinctio aut sed.", null, 1, 0, "Bleach Truck Scarecrow Huge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d11e4742-7152-4c4c-a8bb-3340bc302260"), null, new Guid("b67869dc-160c-427b-af7a-f15a4d117730"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pariatur quod ad perspiciatis ipsa facilis numquam numquam dolorum. Eligendi unde et dolore ut. Id velit delectus ut nihil. Sunt eveniet omnis modi vel enim recusandae consectetur.", null, 3, 0, "Vivacious Church", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a63826b-1eab-4814-b3a1-7c2ca4e299ff"), null, new Guid("fa4d5636-d22f-4c27-8bc3-b304fdd93b30"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est iusto quia iste odit nam. Ea et distinctio consequatur perferendis voluptatem corrupti laboriosam. Voluptas accusantium aut quas enim. Ea et et dignissimos excepturi corrupti. Doloribus qui inventore voluptatibus provident voluptas illum qui. Assumenda quis quisquam cum delectus possimus ut est nam.", null, 1, 0, "Wheel Knee and Ludicrous", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad299551-036f-4bbc-b652-d1a06b548970"), null, new Guid("fa4d5636-d22f-4c27-8bc3-b304fdd93b30"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut quia aut non voluptatem omnis odit voluptates non rem. Vitae aut unde voluptatem soluta quae debitis dignissimos quidem tempora. Recusandae ut et sequi alias. Sint eveniet quam accusamus facere voluptatum reiciendis sequi sed quisquam. Alias porro et.", null, 2, 0, "Damp Ludicrous Look Effect", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd4311c2-04a5-4b51-badf-d7a0609f2164"), null, new Guid("fcccfb0b-1b9e-419c-b873-282de4d3ddaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum quas dolores. Neque laudantium dolorum molestiae eius et. Vero nostrum odio. Aliquam minima dolorem corporis deserunt aut voluptas voluptatem. Similique qui sed et porro.", null, 1, 0, "Helpful Juice Legal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b98056f1-7aab-4229-a546-b2a5225656af"), null, new Guid("d4c265f1-9530-4e19-bacf-0c94f0144cbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Officiis voluptas voluptates vel quasi voluptate molestias placeat tenetur. Perferendis id voluptas accusantium itaque recusandae atque iusto laborum. Nihil consequuntur qui odio fugiat suscipit beatae ut aut. Recusandae sed et ratione maiores velit. Porro in est sed aut optio quo inventore aut omnis. Possimus sit placeat voluptates dolores aut ratione.", null, 4, 0, "Elderly too", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("46bc4b93-edf0-4ee3-963d-d5d5d8c7d389"), null, new Guid("15148de0-5c96-4e1d-9d9d-aeb172d25aa8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rerum enim explicabo dolor aperiam molestias enim nam voluptatem ratione. Et architecto nemo aperiam repellendus neque occaecati sit. Quaerat mollitia repellendus harum laudantium est facilis totam omnis dolor. Ratione rerum fuga.", null, 1, 0, "Whisper Ludicrous", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4ffebb2-aa55-4a80-a30c-643bdd771cd9"), null, new Guid("15148de0-5c96-4e1d-9d9d-aeb172d25aa8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repudiandae dolorum voluptates nihil ullam inventore consectetur ex soluta qui. Nihil fugit sit ipsa. Aut et molestias incidunt fugit non. Voluptatem labore voluptas dolore odio esse quod sequi.", null, 5, 0, "Cloistered Vivacious", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9478d243-be16-4edc-a51f-4226c9a70a72"), null, new Guid("62e645e9-2e79-4304-9ad8-145e31e1aafc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neque illo ducimus eum ut in ad eum blanditiis. Voluptate tempora cumque quis quis vel. Quos molestiae perspiciatis qui nam voluptate molestias sunt qui. Nam vel repellendus sunt.", null, 3, 0, "Cloistered Vivacious", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8252941-494a-40d6-91f2-e608ad9da20e"), null, new Guid("750437fa-5176-443d-9d2c-bf3e216910a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sapiente veritatis exercitationem aut voluptatem explicabo ipsa velit cumque asperiores. Totam facere aliquam eos velit. Sequi aperiam sequi rerum beatae. Deserunt accusamus odit ut aut id magnam illo. Occaecati at unde quibusdam eos vel eligendi. Deleniti est officiis.", null, 3, 0, "Trains Cloistered", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b27f5f76-8bfe-406c-acf5-cfda8927c71f"), null, new Guid("62e645e9-2e79-4304-9ad8-145e31e1aafc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et non molestias aut nesciunt est iure ipsa. Reprehenderit amet in quia suscipit asperiores cumque alias. Repudiandae sapiente recusandae sit distinctio.", null, 5, 0, "Elderly too", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e96ff653-c2a6-440b-bc57-c73924f703ba"), null, new Guid("13cbdb09-b659-498d-aacc-b5a095b129b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Optio aliquam non blanditiis inventore aliquam numquam optio neque. Perferendis sed et maxime laudantium voluptatem dolores. Doloribus ea dolor est vel voluptas. Eum earum veniam et qui nihil perferendis sed iure.", null, 5, 0, "For Legal Whisper", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8bf6cd4d-e8a5-4b9e-9519-44c55528755f"), null, new Guid("c6cc988e-d5e9-4518-80b7-d9d07c75fb99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatibus officiis magni autem. Enim officiis explicabo accusantium sit. Similique quo quo et repudiandae id dolor et veniam.", null, 3, 0, "Quizzical Pizzas Swanky Wheel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1e716ee-5edc-42c8-b499-4884b91c850f"), null, new Guid("f0a45cfe-41c2-417f-bc11-7fed60f27b16"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ad occaecati voluptatibus nemo error laboriosam eligendi ut. Officiis unde possimus ut aliquam voluptatem explicabo tenetur. Enim quia eius corporis quasi nesciunt eligendi aut.", null, 3, 0, "Jazzy Sore Position", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb86e85b-cc21-4a16-af25-10ebada527ac"), null, new Guid("f0a45cfe-41c2-417f-bc11-7fed60f27b16"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neque in beatae nobis et veritatis. Quae omnis suscipit unde. Harum pariatur sunt maxime perspiciatis iusto maxime similique provident aut. Ea quia eos omnis rerum et. Iusto amet odio laborum ratione similique.", null, 2, 0, "Bleach Miss Huge Wrap", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc6e221c-d298-4a6c-bbf3-33ad2086a875"), null, new Guid("f0a45cfe-41c2-417f-bc11-7fed60f27b16"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est repudiandae cum qui ipsam laboriosam nam. Reiciendis eum ea cumque libero minus at maiores error dolorem. Quo delectus natus optio inventore. Dolorum temporibus neque nihil iusto. Facere et nihil totam et ipsam rem. Error et voluptatem quis voluptas.", null, 5, 0, "Huge Passenger Sneeze Effect", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2027e488-cf2c-4b8f-b079-4403cb47555c"), null, new Guid("f0a45cfe-41c2-417f-bc11-7fed60f27b16"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quisquam a pariatur ut aut provident rem. Autem omnis et. Aut eius architecto deserunt distinctio. Dolor quo quis consequatur ad qui modi quia esse. Reiciendis necessitatibus et ad dolorem. Odit unde itaque excepturi error qui deserunt non hic.", null, 3, 0, "Vivacious Thought Pizzas Time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("361ba436-a63e-4eb7-98c9-49d6a1356a7a"), null, new Guid("ff97f372-27e7-4077-93d6-83fd53c4a80b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem voluptates tempore quia temporibus consequuntur. Omnis inventore consequatur rem. Commodi aliquam officiis mollitia. Rerum sit dolor occaecati.", null, 1, 0, "Ancient Juice", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffd476e9-ec76-443f-a716-7e3973ed2fc4"), null, new Guid("54972f14-23d6-4611-b245-c70cf2e10e77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut reiciendis nisi adipisci quo optio voluptas sequi. Atque itaque quia aut quibusdam recusandae. Corporis sit est accusantium maxime maiores. Consequatur et eum ut atque. Molestias vel provident.", null, 5, 0, "Trains Cloistered", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49d0a6a3-50a8-4d33-86aa-eedcc77b9c55"), null, new Guid("54972f14-23d6-4611-b245-c70cf2e10e77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia officia quaerat. Autem vero eos odio autem vitae est consequuntur. Voluptates repellendus veniam eos provident corporis quaerat. Aliquam totam similique est veritatis dicta. Delectus alias quidem nesciunt ipsa est rem quas cupiditate aut. Aut facere perferendis dolor dolorem neque.", null, 5, 0, "For Legal Whisper", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1df63d3c-2268-43c4-a097-54cd7774d214"), null, new Guid("3f0792a6-300a-420b-980e-42938c4c8a6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iusto excepturi quas occaecati laboriosam molestias dolores repellendus sunt. Aut omnis ad dolor magnam fugit minima officia. Quidem quae mollitia voluptatum dolore est recusandae et. Natus deserunt neque nobis.", null, 1, 0, "Scarecrow and Whisper Elderly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3bb3e0bb-19ab-4eea-bba2-d49b3622c5ce"), null, new Guid("13cbdb09-b659-498d-aacc-b5a095b129b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Velit blanditiis quam deleniti qui iste molestias laboriosam perferendis voluptate. Aliquam ut nemo rerum cupiditate id et dolore consequatur quam. Rerum mollitia soluta autem dolorum. Architecto deserunt provident repellat eveniet. Est tempora consectetur vel quaerat nihil deserunt officia amet eveniet.", null, 4, 0, "Strange Vivacious", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ccfe0e6a-2ca4-4b28-9d81-b46efa732758"), null, new Guid("750437fa-5176-443d-9d2c-bf3e216910a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debitis eos quo error mollitia. Ut optio ea. Esse voluptatum ipsa consequuntur ipsam reiciendis soluta animi.", null, 0, 0, "Bleach Sneeze Ancient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("30865b1b-2ee4-4629-bd7e-9d105a62197c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("647080cd-b433-4d8f-a38b-7a77ce6d45f8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("658328e0-fc7a-4205-a129-0cf9b11bc505"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dc9ea431-5cdd-4cee-9083-f18fd8eaa803"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fb88122d-0d36-4282-be8b-49b7c29b5b5c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0094795d-c48c-4292-8fbd-821d1db38db9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("017f1009-a29e-45e8-be33-19fbd4498d1e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("05d2d1de-d72b-44c7-9c8d-b89222a88a5c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("083c789f-c39d-43a2-a124-7306d6583e4f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("08d174bd-ff66-46d0-a7cc-7693cd8120db"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0bc37584-8d3e-460a-9eab-52036b6d331f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e15b3e8-6909-456b-8ec8-eb94e276667b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1742379d-0c40-46fc-88e2-8104e9d16460"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("17b91ab7-4190-49b8-8783-e593d6985991"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1851f54b-f52f-4ce8-a523-744e05885575"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("18b2070d-c393-43c7-9262-1c5d1501cae6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d356e5a-4746-4589-a034-cf2ec278b21e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1dd9f85c-3924-4f6e-860f-32299676d528"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1df63d3c-2268-43c4-a097-54cd7774d214"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2027e488-cf2c-4b8f-b079-4403cb47555c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("215bc8bd-c1b3-4615-b19d-e20cb5d0a761"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("285a5084-2ec0-4948-927f-a6ca63c67778"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("31f573d4-0078-42e1-8761-3b548254dd83"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("361ba436-a63e-4eb7-98c9-49d6a1356a7a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("373faa68-be0f-4295-9aa6-f549d4834bb7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3bb3e0bb-19ab-4eea-bba2-d49b3622c5ce"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3bf7e068-2a81-4878-929b-6e3bb26b9e16"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3e2ef45f-ec34-4a7c-b89f-6d86dd32cfc3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3ed38538-6fdf-4bf0-8a02-84a4db7d18c6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("40ea1e56-20b3-401d-b91e-aecfe8422b89"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4189fc66-1ff6-4609-bbe0-188d6360de7c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("46bc4b93-edf0-4ee3-963d-d5d5d8c7d389"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("49d0a6a3-50a8-4d33-86aa-eedcc77b9c55"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4ae6a9da-f578-4255-a899-6b531fea34a8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4b33b77a-5060-45a8-8b69-ee4e273f8bbe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4e55df9c-f8c7-4279-b28d-b3493a756983"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("518c96ae-6959-463a-9e43-e920b52747b5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5383ea0b-5497-4b62-8a4f-bc8e90ab0797"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5993b63f-9cb2-4538-a4f0-ae003f411493"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5af41cdd-923b-4efe-9ac1-d67188991775"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5cdf565f-2a0d-4867-be51-cb612f7c7c1c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5f0891b9-0607-4063-9ab0-f7197ee07136"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6043b602-75fb-4f8a-8764-eb0aa8bbd6ac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("63704e36-6266-4436-b687-4fc56724281c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("651143ff-42af-4def-9372-a40367b686ec"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6605249c-e589-429d-be50-d429d294bdf7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("67ac769c-5f7f-4a3b-bccc-4bd8f3f02115"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("67ecb354-7cef-4113-82e6-78e0503b6823"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6f8d75c5-c410-4089-94f7-05dc40c798f1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("700accca-019d-49bb-a441-f46bf5998a9e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("71bafa10-c321-450f-ac73-85468bb8ce2c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7287bd9d-5680-468e-81b7-77f5017c0d99"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("76cf41f6-0f4f-448c-97d2-0dbe3812fd30"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("770f1ddd-3bf1-4341-a5d5-8a727bcd4a74"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77299a33-bd2d-490e-91ad-2e1234dbdbb4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7c6fff9b-a0bf-472a-bffc-c7b6a50be7a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7ed60ee7-94ca-48a1-bbe2-850d9f6200cf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7f196c1f-0086-4e66-8228-95ff997f4c19"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8a63826b-1eab-4814-b3a1-7c2ca4e299ff"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8bf6cd4d-e8a5-4b9e-9519-44c55528755f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8f6cf604-d4f8-46f8-9956-fa2c572b8cb2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("903da0c4-7fa9-4791-9886-38d447d92dd1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9478d243-be16-4edc-a51f-4226c9a70a72"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("953db6a6-d303-4b0e-98cb-3d9c3d17e914"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("96f7cfa8-220a-469b-bad4-690b7c0eea3b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("99c274a8-d29d-47f1-921b-5d3f1e3ed430"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9f9003b4-f271-4d59-bce0-f3b353b2dfca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a4ffebb2-aa55-4a80-a30c-643bdd771cd9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a56b5b9d-6c6c-4c8b-8e56-15d6ffd85381"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a8a5fae9-a726-4dfd-88c1-3025fe8e468a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ad299551-036f-4bbc-b652-d1a06b548970"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b1e716ee-5edc-42c8-b499-4884b91c850f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b27f5f76-8bfe-406c-acf5-cfda8927c71f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4f009d9-2065-427a-8646-c77e8d4ff5ce"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b7b0fc97-0d01-46b6-8df1-becc2912174f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b8252941-494a-40d6-91f2-e608ad9da20e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b9029b36-a0ef-42cb-af5a-38747fe3a11d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b98056f1-7aab-4229-a546-b2a5225656af"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bd4311c2-04a5-4b51-badf-d7a0609f2164"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bfc12a57-2506-446e-ad3f-0db3ace69ca0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c1051833-2e4b-481f-8ea0-1ec86fa8fe4f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c4fe2773-0182-4e7a-b952-d8de441dcf0d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c925f044-f4e3-4b53-8e27-9861d74fcb67"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ccfe0e6a-2ca4-4b28-9d81-b46efa732758"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cd32a2af-214f-40ba-b4a6-f7078914618d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cd949416-4018-4a8d-81fe-c29784818368"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cecd7822-23b4-4be5-b618-7854ef8ba0aa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d0398769-1c0e-4aec-803c-0c925d3dc7a0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d05fd234-b8b2-49da-9b5a-1005ac021111"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d11e4742-7152-4c4c-a8bb-3340bc302260"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d18cf1d8-3efc-40e6-be0a-bb42e0b5a66d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d3cf947c-3a43-4b67-9453-01fad511f489"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d47ea8e2-f3d5-4a38-84ff-669af781b538"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc6e221c-d298-4a6c-bbf3-33ad2086a875"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dd723dcf-d4d0-4820-8974-c071233df1d2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e1f9370e-c5af-43af-8637-4223006b1673"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e77a1804-1fea-4d31-812b-c8c969bfa7ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e96ff653-c2a6-440b-bc57-c73924f703ba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("eb86e85b-cc21-4a16-af25-10ebada527ac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ee32b653-4fa8-4788-99b8-b1a06f6aab27"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f20b7462-59df-4e4d-9b90-9b788bb6de64"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f50027a8-6a87-401f-a7e2-bd483013a12c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fbeb3f10-c15b-423c-a254-d37c33e26601"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ff3e0c92-cb65-4ea2-b602-e6373e588a23"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ffd476e9-ec76-443f-a716-7e3973ed2fc4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0b8ae3cf-9270-4ed8-ad94-cd441c683420"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("13cbdb09-b659-498d-aacc-b5a095b129b5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("15148de0-5c96-4e1d-9d9d-aeb172d25aa8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("26cdbfc6-4812-4122-a724-362ee496f225"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("28a844f7-ed27-45ad-b2b2-34f9672fcb43"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2c52f8f1-4fe2-40e9-98f8-f2ecedea2d4b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("356157a3-6a6c-486a-ab0d-cf59e9254694"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3f0792a6-300a-420b-980e-42938c4c8a6e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("43e17ca6-024d-4e32-90a3-a10f3821ae78"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("466fd272-5d63-4e52-ab43-3b9204c0289f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4ec3a621-939f-4fcf-9c6c-2d5c94a3e67d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("54972f14-23d6-4611-b245-c70cf2e10e77"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5985f988-91bc-49a7-8d42-5bdd495dce5e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("62e645e9-2e79-4304-9ad8-145e31e1aafc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("68002941-242f-4d32-9d87-485204f052c0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6bdd51b2-5dd9-4ca8-8f56-37c777e6e5f6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6cf15954-9bae-4d05-a82b-4871a98759ee"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6e781960-c945-4b32-b634-15179755c9cb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("750437fa-5176-443d-9d2c-bf3e216910a5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("75bc7fbf-c02a-4efb-ba23-7a4765fed8be"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("79466dbc-1d2d-4f2e-8855-5bd606835f02"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7981f342-e175-49ca-8a53-d92ff6b6a87c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7aae0002-6e40-4650-a430-fa750799cbe7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("82b083b8-b517-4fe6-acee-9b71cae2fa8a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8d93bde1-31dc-414c-bd16-0306906fb12b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8e0b7a21-6050-4d3e-83dd-2d545391c132"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("96a9c762-83da-488c-819c-c7bbdd21cda0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("99431c48-1587-41e3-a503-db541da6365b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9b08c0a0-5b23-4287-a927-abee1d987e9b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9b30e434-3b54-49f1-9134-285a8cde2591"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9cc559db-b14b-4698-897c-0a9cddc99cce"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a0757143-62fb-414b-8148-7c7032e15c4d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ab0bd1dd-3498-4a9c-95a7-c66d1d575046"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b45469c1-63aa-4911-ada6-8d787805359d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b67869dc-160c-427b-af7a-f15a4d117730"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c6cc988e-d5e9-4518-80b7-d9d07c75fb99"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d4c265f1-9530-4e19-bacf-0c94f0144cbf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("da15ea4d-e804-472f-b131-cc04d08f764e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e92ec76a-9faa-4319-b4de-13eab8bc5f40"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("eb630132-d895-494c-8b78-3015a4e579db"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f0a45cfe-41c2-417f-bc11-7fed60f27b16"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f15b42e7-f8e5-4e58-be80-17738ec6d2fa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fa4d5636-d22f-4c27-8bc3-b304fdd93b30"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fcccfb0b-1b9e-419c-b873-282de4d3ddaa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ff97f372-27e7-4077-93d6-83fd53c4a80b"));

            migrationBuilder.DropColumn(
                name: "PopularityScore",
                table: "Books");
        }
    }
}
