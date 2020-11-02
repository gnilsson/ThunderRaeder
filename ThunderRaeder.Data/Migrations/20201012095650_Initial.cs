using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThunderRaeder.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Firstname = table.Column<string>(maxLength: 150, nullable: false),
                    Lastname = table.Column<string>(maxLength: 150, nullable: false),
                    Gender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    IdentityId = table.Column<string>(nullable: true),
                    UserType = table.Column<int>(nullable: false),
                    Alias = table.Column<string>(nullable: true),
                    UserPrincipalName = table.Column<string>(nullable: true),
                    AccountStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUsers_AspNetUsers_IdentityId",
                        column: x => x.IdentityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Token = table.Column<string>(nullable: false),
                    JwtId = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    Used = table.Column<bool>(nullable: false),
                    Invalidated = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Token);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    AppUserId = table.Column<Guid>(nullable: false),
                    Message = table.Column<string>(maxLength: 5000, nullable: false),
                    AdditionalContent = table.Column<string>(nullable: true),
                    Upvotes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 2500, nullable: false),
                    Genre = table.Column<int>(nullable: false),
                    AuthorId = table.Column<Guid>(nullable: false),
                    AnnouncementId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    AnnouncementId = table.Column<Guid>(nullable: false),
                    AppUserId = table.Column<Guid>(nullable: true),
                    Message = table.Column<string>(maxLength: 280, nullable: false),
                    AdditionalContent = table.Column<string>(nullable: true),
                    Upvotes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppUserBooks",
                columns: table => new
                {
                    AppUserId = table.Column<Guid>(nullable: false),
                    BookId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    PercentageRead = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserBooks", x => new { x.AppUserId, x.BookId });
                    table.ForeignKey(
                        name: "FK_AppUserBooks_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "Firstname", "Gender", "Lastname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("7abaa6ec-03bd-4451-ac8b-1d9870c538be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sonja", 1, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e98f737-f40d-481a-90d0-82337e5e1fdb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guadalupe", 0, "Andersson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8fe3df2-928c-4fd8-98cd-6978d75c384c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel", 0, "Svensson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17a4e652-96d7-42a5-9412-5948557b038d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Travis", 0, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed213aa8-52b4-44f4-8586-280cf833058f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peggy", 1, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f72d7f05-dd65-4d92-9fca-9b16abcd9b81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnnie", 1, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6378e9f7-0e69-4d7c-b1e2-78d4a4cea08b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Florence", 1, "Svensson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a9c7efc-842e-42b5-8747-c4623b026d6f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roxanne", 1, "Gustafsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d9b057b-7fd7-4385-a99d-e50404ac9374"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shelley", 1, "Eriksson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2cc6200-edc1-4daf-96ee-d2cb553aac1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kristi", 1, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7fa70e0e-25af-4d54-9e75-3cb27265ada3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leslie", 1, "Olsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76f9fe0b-9635-41a4-ab3b-fca395c16309"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joy", 1, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d2e7d81-c1a8-4103-a569-0f74b0796da6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ollie", 1, "Nilsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b492717d-d6a6-4033-ba18-237569056833"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margarita", 1, "Gustafsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3cca5fa3-6519-48fe-8402-1761fa5aa421"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscar", 0, "Nilsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd2f4bcb-a05f-4d44-b77f-055b1ed14e0e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dora", 1, "Nilsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d99810c-be91-4a7e-9e23-73b5450f3172"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marco", 0, "Svensson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39db8301-6476-4835-b751-311367a4400a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everett", 0, "Andersson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5108553c-8071-4a73-b06e-4697df428ee2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jody", 0, "Nilsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b78e7df4-acab-40c7-888e-3c24bfae4280"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eugene", 0, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d6a8397a-fb9a-427c-b8d2-974cc90eef41"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karl", 0, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd6145a1-f051-4069-8ba2-101c1a3280ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joann", 1, "Larsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34cb43f2-975a-413a-b7ce-af3c7bd56010"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda", 1, "Olsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8d57b4a-93c2-49b0-ad7d-205b050d0589"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hazel", 1, "Persson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f011cc3a-36ac-4934-ae63-eaf81dca40ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachary", 0, "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ccedad14-4d55-4894-ae5d-54095d0a27af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nichole", 1, "Gustafsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf88ead6-3c75-4d54-bc3e-f82fe9cad801"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenny", 0, "Eriksson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("709fa44c-e756-4d5b-935f-f329bad27f67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penny", 1, "Gustafsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c0875dd0-6857-4f9e-b38d-27bb1dc73189"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mike", 0, "Eriksson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e886fdf7-48ea-4512-87dc-1588be8e0b58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yvette", 1, "Karlsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AnnouncementId", "AuthorId", "CreatedDate", "Description", "Genre", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1f2d45bb-b04c-4c37-8ae7-44af29967580"), null, new Guid("7abaa6ec-03bd-4451-ac8b-1d9870c538be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nisi possimus dolor facere qui nemo reiciendis alias aut iusto. Cupiditate harum sint consequatur eos non occaecati delectus. Eaque voluptates et minima incidunt iure. Deleniti numquam perferendis est eligendi omnis ea minus fugit. Et non magnam. Asperiores ipsam assumenda doloremque dolorum blanditiis qui ut et.", 2, "Drink Cent Pizzas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dccae9ee-781a-4ce4-ac00-27805bcfb008"), null, new Guid("f72d7f05-dd65-4d92-9fca-9b16abcd9b81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eveniet sed ut. Tempore et quia eligendi non minus est delectus. Temporibus dignissimos error dicta et odio. Possimus doloremque quae quam quas. Voluptatum corporis ea voluptas sit assumenda. Rerum aut occaecati quaerat suscipit recusandae est eum eum dolor.", 4, "Position the Dry", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39c16d2f-6172-4f10-83ce-3b775b60e7cf"), null, new Guid("f72d7f05-dd65-4d92-9fca-9b16abcd9b81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunt placeat nulla temporibus rerum velit cupiditate. Quaerat in dolores placeat non quo. Quaerat illo aliquid quae culpa vel occaecati et voluptas eveniet. Eligendi similique ut repudiandae sint. Minima consectetur praesentium sequi ex quisquam nisi.", 4, "Swanky Church Cent", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e49c8e7-7d89-462d-a460-3f1e2b4c413c"), null, new Guid("6378e9f7-0e69-4d7c-b1e2-78d4a4cea08b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accusamus cumque sit voluptatem necessitatibus nostrum beatae. Libero numquam sapiente. Ut dolorem nulla fugit vel.", 3, "Helpful Evanescent Wrist Huge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb3ffc25-9876-41f6-910c-33d2196e5774"), null, new Guid("6378e9f7-0e69-4d7c-b1e2-78d4a4cea08b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est qui debitis corporis quia rerum totam est perferendis voluptates. Sint sit omnis neque excepturi voluptatem odio nihil. Tempora minus minima. Optio repellat vero non voluptas non rem perferendis quo. Et in quasi atque odit fuga optio sed.", 1, "Of Miss Drink", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d26854d-e406-4425-923f-9a0537fb5877"), null, new Guid("6378e9f7-0e69-4d7c-b1e2-78d4a4cea08b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cumque consequuntur ut voluptatibus. Eveniet aut magni qui consectetur et aut eos. Et in est impedit eius dolorem voluptatum voluptas aliquid tempora. Autem sed voluptatem sit omnis aspernatur unde.", 4, "Whisper Effect Chess Explode", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("603f297e-37b5-4c85-bfc2-22b78a419864"), null, new Guid("6a9c7efc-842e-42b5-8747-c4623b026d6f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delectus asperiores similique. Eligendi amet vel optio debitis. Enim architecto et omnis accusantium esse consectetur et consequatur dolores. Itaque exercitationem dolorum quam laborum sunt tempore eveniet. Vel ullam dolorum quaerat nulla et molestiae illo pariatur.", 1, "Helpful of", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ba4fd87-7737-4321-ab60-7eaef5039676"), null, new Guid("7d9b057b-7fd7-4385-a99d-e50404ac9374"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delectus libero accusamus soluta placeat ut quia velit. Natus fugiat voluptatem. Minus eveniet voluptatem delectus fugiat dicta a illo nihil voluptas. Possimus voluptatum saepe blanditiis ut. Consequuntur provident quas similique aut ut aut voluptatem error minus.", 0, "Position Thought Bleach", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66d52abd-fd72-4364-a463-c6877de20fda"), null, new Guid("7d9b057b-7fd7-4385-a99d-e50404ac9374"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dignissimos quo sint maxime illo architecto nesciunt asperiores voluptatem. Vitae mollitia provident et ipsam debitis alias necessitatibus qui. In sapiente aliquam.", 5, "Damp Strange Swanky", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f63b6356-0e4c-470b-bc0a-0bd0c5facd8d"), null, new Guid("7d9b057b-7fd7-4385-a99d-e50404ac9374"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et ipsam rem enim error et. Quis voluptas et optio. Aliquam dolor pariatur quod ad. Ipsa facilis numquam numquam dolorum nemo eligendi. Et dolore ut ullam id velit delectus.", 1, "Trains Damp Wrap Quizzical", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ccb1324-5beb-407f-87e9-5dfaf44b15d2"), null, new Guid("f2cc6200-edc1-4daf-96ee-d2cb553aac1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ab similique ut at dolorem cupiditate culpa officia assumenda. Velit quo alias aspernatur error. Ducimus beatae aut tempora eaque eum maiores maxime ipsa. Qui id porro est quae rerum quo et. Rerum placeat eius quod.", 4, "Way Bolt Ancient Jazzy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("29b0accd-5a31-49a2-a0a8-5624d6aeb054"), null, new Guid("7fa70e0e-25af-4d54-9e75-3cb27265ada3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cupiditate ut illo a est non culpa id. Quia omnis officia ad quibusdam consectetur eius. Totam enim saepe sapiente consectetur et.", 5, "Passenger Explode Wrap for", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4cd76ff-5b6b-45c2-bc95-dbce5d051a95"), null, new Guid("7fa70e0e-25af-4d54-9e75-3cb27265ada3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis tempora ut. Autem molestias sapiente et sunt autem. Nihil occaecati facere in libero. Dolore ipsam neque fugiat vitae esse. Sint hic delectus similique quo dolorem. Adipisci aut commodi sunt officia.", 5, "Way Enjoy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c3ddc86-fa81-4a50-b1a1-e7dd62ce51d5"), null, new Guid("76f9fe0b-9635-41a4-ab3b-fca395c16309"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et atque dignissimos quaerat molestias deleniti error in quia. Nostrum repudiandae rerum doloremque. Et est fugit maxime cumque ducimus. Sint delectus nobis possimus voluptatem at dolores. Fuga quam culpa. Ut cumque officiis.", 3, "And Chess", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1ebbacac-2152-4a9b-9b98-41c11366ce9e"), null, new Guid("76f9fe0b-9635-41a4-ab3b-fca395c16309"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modi placeat placeat quis ut voluptatem. Amet in ea quo praesentium error. Eius amet aut explicabo voluptatibus. Quas cumque ea nihil aut sit rerum repellat.", 5, "Ludicrous with Knee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("515ca0e1-cbf6-4aea-a249-7356e3f9419f"), null, new Guid("76f9fe0b-9635-41a4-ab3b-fca395c16309"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delectus possimus ut est nam sit iusto molestias. A rerum enim explicabo dolor. Molestias enim nam. Ratione placeat et architecto. Aperiam repellendus neque occaecati sit.", 5, "Too Swanky", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c70ca2a-d444-4172-9a0f-68ce2000ea59"), null, new Guid("76f9fe0b-9635-41a4-ab3b-fca395c16309"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non et voluptatem. Voluptas dolore odio esse. Sequi et nulla qui quis ea voluptatibus hic.", 5, "Sneeze to Scary", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f20a77b-0912-4017-bf93-a06dc8ca73a0"), null, new Guid("2d2e7d81-c1a8-4103-a569-0f74b0796da6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur dolor aut alias consequatur tempore necessitatibus distinctio in culpa. Voluptatem ea eum minus quae sint mollitia nostrum omnis. Ad occaecati ipsum suscipit ullam accusamus aperiam perferendis soluta voluptas. Aperiam eligendi dolor eum non reiciendis enim. Consequatur assumenda similique accusamus doloremque totam tempora iure libero.", 3, "For Sneeze", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a7c6bccd-4f90-4d40-99bf-cd565a0a0bf5"), null, new Guid("2d2e7d81-c1a8-4103-a569-0f74b0796da6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas nesciunt quidem praesentium non saepe nobis dolor. Quod consequatur assumenda. Alias mollitia qui. Officiis vel tenetur iste deleniti deserunt. Maxime accusantium voluptatibus rerum repellat et blanditiis blanditiis id nam. Ipsa et labore dolor dolorem.", 1, "Position Look", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("003dd489-d10e-4d1d-a856-258b22fc429e"), null, new Guid("2d2e7d81-c1a8-4103-a569-0f74b0796da6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explicabo non enim quod porro. In quis perferendis. Nesciunt ut quia nihil impedit et in praesentium. Voluptate quia velit nostrum dolore culpa tempore voluptatum veritatis. Quia consequatur nemo delectus et neque enim officiis. Molestiae minus repudiandae aut dicta molestiae corrupti eligendi voluptatem.", 0, "Bleach Truck Scarecrow Huge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a83264ac-602b-419b-8071-012c90b62b60"), null, new Guid("2d2e7d81-c1a8-4103-a569-0f74b0796da6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aliquam quisquam et deleniti enim reprehenderit et. Qui labore consectetur sunt. Rerum eum in eum repudiandae. Aliquid delectus voluptatibus. Officiis quaerat illum et corporis ullam eos ab iure quia. Eaque odit minima voluptatem.", 3, "Position the Dry", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e93a1fd6-122c-4c36-bdc9-f6c6ee483653"), null, new Guid("2d2e7d81-c1a8-4103-a569-0f74b0796da6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis quia natus porro sit necessitatibus. Ipsam architecto deserunt hic dolor. Numquam maiores nam ut.", 2, "Miss of", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("01017dff-4c2b-45f4-a869-8c7d767ba1a3"), null, new Guid("f72d7f05-dd65-4d92-9fca-9b16abcd9b81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed repudiandae maxime sit blanditiis voluptatem ducimus officiis. Dolorem reiciendis aut assumenda mollitia culpa voluptates cupiditate ut. Fuga voluptatem odit mollitia libero nemo. Debitis sapiente qui quisquam cupiditate temporibus laborum sit beatae.", 4, "Way Jazzy Sore", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c1f1b8b-23ba-4278-8864-47c08cfd6aab"), null, new Guid("2d2e7d81-c1a8-4103-a569-0f74b0796da6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eveniet eum facere et beatae aut veniam vel. Quas ipsam laudantium est id perferendis. Alias non numquam temporibus quibusdam et quis. Dolores impedit expedita quae ut quae asperiores aliquid sapiente fugit. Minus voluptas atque praesentium vel quia voluptatem asperiores aut est. Fuga et nam illo explicabo accusantium repellendus consequuntur.", 5, "Thought Bleach", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("07a10dbe-20ab-4b96-8b52-362563838c09"), null, new Guid("f72d7f05-dd65-4d92-9fca-9b16abcd9b81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas autem aut. Vel quia possimus aspernatur. Tempore fugit exercitationem molestias reprehenderit corrupti eaque tempore.", 5, "Bolt Enjoy Passenger", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71ddb4fc-4ef9-484d-9291-6dcd6a06d7f1"), null, new Guid("ed213aa8-52b4-44f4-8586-280cf833058f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut magnam est maiores voluptatem hic provident molestias officiis. Eligendi quae hic cupiditate laborum doloremque est id molestiae. Aliquam dicta suscipit nihil aperiam voluptates fugiat repudiandae et aut. Nulla similique ea quidem recusandae consequatur. Voluptatem aut aspernatur voluptatem libero.", 5, "Strange Miss Swanky", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e1ba6c3-cb32-486f-971f-997331b7eaeb"), null, new Guid("e886fdf7-48ea-4512-87dc-1588be8e0b58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sapiente veritatis exercitationem aut voluptatem explicabo ipsa velit cumque asperiores. Totam facere aliquam eos velit. Sequi aperiam sequi rerum beatae. Deserunt accusamus odit ut aut id magnam illo. Occaecati at unde quibusdam eos vel eligendi. Deleniti est officiis.", 3, "Trains Cloistered", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3462e359-934a-4e54-823d-3838d88e3351"), null, new Guid("e886fdf7-48ea-4512-87dc-1588be8e0b58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut praesentium quis unde officia et. Omnis iusto consequatur et. Beatae iure optio quia ullam quo illo ea.", 1, "Passenger Explode Wrap for", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0cfd0ea1-aec7-4528-b32f-f13041f6ff09"), null, new Guid("e886fdf7-48ea-4512-87dc-1588be8e0b58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mollitia sed a voluptatem sapiente fugit laudantium dolores. Et asperiores vitae voluptatibus aut sed voluptatibus dolorum. Et sed et dolorem nostrum veniam cum facilis omnis. Ut quod aut quidem eum enim labore ut asperiores. Qui ut minima. Ut deserunt tempora.", 2, "Ancient Juice", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f69ba86-2dd5-4f66-ad31-11dc2beef16e"), null, new Guid("c0875dd0-6857-4f9e-b38d-27bb1dc73189"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur reprehenderit aut voluptatem beatae. Qui ratione sed. Dignissimos vel suscipit voluptatem consequatur reiciendis repellat dolorum vitae unde.", 5, "Drink Ludicrous", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8478f385-a54b-4ff0-ad0f-6e76ff62facb"), null, new Guid("c0875dd0-6857-4f9e-b38d-27bb1dc73189"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem numquam quis. Fugiat impedit molestias. Voluptas neque ab consequuntur id sequi quo voluptatem nostrum. Qui odit accusamus. Dolor sunt architecto sapiente est.", 4, "Damp Trains", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1c678dfc-e565-432e-a716-343cb7827016"), null, new Guid("c0875dd0-6857-4f9e-b38d-27bb1dc73189"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex dignissimos quod cupiditate. Molestiae a asperiores et animi minus dolor voluptatem ut eum. Necessitatibus molestiae doloremque voluptate est iusto et quaerat dolorem. Odit quia eos illo adipisci molestiae. Consequatur ea optio vel quaerat libero inventore necessitatibus. Earum inventore culpa omnis nulla et architecto.", 1, "Evanescent Wrist Cent", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73b0bb9d-3848-4806-9213-2dc3beb51ebc"), null, new Guid("4e98f737-f40d-481a-90d0-82337e5e1fdb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut sit ratione numquam ea rem qui tenetur inventore. Suscipit consectetur hic ab ullam quam. Optio nam dolores qui veritatis. Ut est facilis. Numquam qui nostrum.", 2, "Of Position Church Explode", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d695a428-dc26-489a-9954-e9c67c8a7733"), null, new Guid("4e98f737-f40d-481a-90d0-82337e5e1fdb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tempora ipsam libero repellendus sunt sint voluptas iusto omnis. Voluptatem et quas et enim autem facere pariatur. Et corporis facilis laboriosam.", 5, "Whisper Ludicrous", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf7b5b96-17b0-4c8b-a491-59189b067d0e"), null, new Guid("4e98f737-f40d-481a-90d0-82337e5e1fdb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deserunt voluptate quia deserunt eligendi et. Porro repudiandae sit tenetur labore sed dolorum. Quasi qui pariatur. Officia rerum soluta voluptatem ipsam blanditiis. Vero itaque esse nihil quia incidunt. Vel voluptatem voluptatem atque autem sequi repudiandae illum sint sit.", 4, "Pizzas Look Helpful Scary", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e742da9-e2f1-4515-aba5-92546898b2fc"), null, new Guid("4e98f737-f40d-481a-90d0-82337e5e1fdb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Totam autem quae officiis laudantium est voluptatem ut. Veniam sed voluptatem inventore et architecto maiores earum. Vitae illum aut. Velit aut et minima doloremque officiis recusandae. Et autem est commodi expedita tempora aut sapiente quibusdam.", 3, "Wrap Scarecrow Damp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9aa32af6-dadc-4f0e-814a-ae414016f696"), null, new Guid("4e98f737-f40d-481a-90d0-82337e5e1fdb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quos iusto sint temporibus. Facere velit est et est maiores id nesciunt minima. Enim sit molestiae earum saepe aut saepe. Est voluptatum reiciendis facere cupiditate quia occaecati dolore accusantium ut. Ut et quae quo dolorem.", 0, "For Jazzy Chess", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("551fa83c-0c12-4693-b467-1292e4214491"), null, new Guid("4e98f737-f40d-481a-90d0-82337e5e1fdb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ducimus sint aut atque ea excepturi voluptatem. Vero ducimus voluptate consequatur sint qui sit magni ipsa. Omnis aut occaecati magni dolores autem soluta laborum. Deleniti aspernatur illum tenetur tempora eaque sunt commodi. Est voluptas ut nesciunt id aut. Quos est assumenda eaque qui dignissimos earum veniam.", 2, "Optimal the Huge Huge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8444f0a7-0eb1-4ca8-9c4d-0cfc6d43d9bc"), null, new Guid("4e98f737-f40d-481a-90d0-82337e5e1fdb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptate cum dicta sint aliquam enim debitis explicabo sunt eveniet. Ad beatae ipsam ipsa qui voluptas facilis. Quo eos omnis repellendus expedita atque pariatur officia odio distinctio. Minus odit dolorem ut quia.", 5, "Too Drink Cent", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b92c7e6d-d3df-439f-93d1-bc0a6cf363e2"), null, new Guid("f8fe3df2-928c-4fd8-98cd-6978d75c384c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atque voluptatem quia eaque quae voluptatem illo. Sequi minima eveniet quam eligendi alias totam. Laborum nemo nihil et sunt quod id cum rerum sint.", 2, "Way Enjoy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85615902-9ff9-493c-9dde-7aeb8cfd950b"), null, new Guid("f8fe3df2-928c-4fd8-98cd-6978d75c384c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnam pariatur cumque nihil velit. Enim aut voluptatem nihil qui non vero earum. Ducimus itaque cumque hic eveniet impedit.", 0, "Sneeze Enjoy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("29157546-94dd-4b2f-a2f3-97958dd1cc4d"), null, new Guid("f8fe3df2-928c-4fd8-98cd-6978d75c384c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quisquam mollitia officiis eos debitis dolorum quia accusamus quasi deleniti. Ad iure qui quis. Quo alias aut deserunt. Molestiae corporis placeat ut fugiat eveniet molestiae pariatur. Nemo quisquam vero atque culpa.", 4, "Wrist Ludicrous", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bcdbdb9a-c316-4afe-b223-3fa1714b67f1"), null, new Guid("f8fe3df2-928c-4fd8-98cd-6978d75c384c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maiores veritatis tenetur quia nostrum ratione. Nisi amet doloribus non similique quas beatae saepe. Quisquam a pariatur ut aut provident rem. Autem omnis et. Aut eius architecto deserunt distinctio. Dolor quo quis consequatur ad qui modi quia esse.", 1, "Evanescent Effect Hate Way", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e816ccc1-9be7-4a1b-bb9c-e509f32fb693"), null, new Guid("17a4e652-96d7-42a5-9412-5948557b038d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aliquid natus sit voluptatem nam neque minima alias non. Accusantium alias temporibus quibusdam odio voluptatem corrupti magni maxime. Dolor aperiam reiciendis facere fuga iste. Atque non temporibus voluptatem. Aperiam nisi sint excepturi ullam quae pariatur consequatur atque.", 0, "Strange Vivacious", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9dae164b-8c87-4514-882f-f95b1e8f4e7d"), null, new Guid("17a4e652-96d7-42a5-9412-5948557b038d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alias minus expedita non nam molestias aut at facilis quisquam. Incidunt fugit libero sed aliquid. Ut veniam molestias maxime ratione nihil et qui accusamus. Atque consequatur sint. Voluptas ab beatae eligendi ducimus est minima enim et reiciendis.", 5, "Damp Trains", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c20ed254-e969-40b9-b01e-1859da9e2f8b"), null, new Guid("17a4e652-96d7-42a5-9412-5948557b038d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magni deserunt quod nisi quia tempora inventore. Vero sit commodi. Ut ratione aut quis eos et voluptas eaque quaerat repudiandae. Vero dolore modi dolores omnis quia. Omnis atque est mollitia ratione repellat.", 5, "Jazzy Sore Position", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39a4e2bc-6d56-4208-8813-0bd68e248676"), null, new Guid("ed213aa8-52b4-44f4-8586-280cf833058f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maxime magnam ut dolore aut asperiores tenetur rerum. Iusto natus ut corrupti commodi ut laborum amet. Enim reiciendis sed blanditiis optio molestiae ut. Qui et officia assumenda in unde.", 1, "Wrist Quizzical", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5d0f54c-f0a9-4089-8aa7-8734bb2216d4"), null, new Guid("f72d7f05-dd65-4d92-9fca-9b16abcd9b81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doloribus vero aut. Omnis nihil cupiditate. Ad repellat occaecati dolores aut voluptatem ducimus. Magni laudantium laborum ea repudiandae ullam aut odio quo ea.", 5, "Damp Ludicrous Look Effect", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ad0d54c-94ec-4c34-a89d-256f892fc729"), null, new Guid("b492717d-d6a6-4033-ba18-237569056833"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex voluptates qui doloremque est. Provident nesciunt modi tempore omnis consequatur. Aspernatur quod saepe perspiciatis sit. Laboriosam nostrum ea nostrum inventore atque nobis. Culpa reiciendis maxime quia et consequatur similique.", 0, "Legal Trains", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c33c9f07-b132-4724-ab10-bebaac5e23a6"), null, new Guid("b492717d-d6a6-4033-ba18-237569056833"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odio quasi dolores optio ullam eos. Consequatur et illo modi nostrum est et aut earum enim. Aliquam aut maxime cum nihil autem modi ea soluta deserunt.", 2, "Miss of", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2f2ae32b-10d7-4bf9-9be8-7f3bfc56029f"), null, new Guid("b492717d-d6a6-4033-ba18-237569056833"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et animi sint qui quia suscipit. Voluptates iure aut dolores ad quibusdam est. Quos veritatis quisquam aliquam quod. Illo qui animi optio error. Delectus nam velit aut perspiciatis cupiditate vel optio illum. Libero et est consequatur velit quidem voluptatum distinctio aut sed.", 1, "Bleach Truck Scarecrow Huge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f73cc7b-d5ed-41f2-9d18-d48bf6b774b2"), null, new Guid("34cb43f2-975a-413a-b7ce-af3c7bd56010"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expedita voluptatem sit consectetur perferendis repudiandae possimus. Error animi dolore amet aperiam officia placeat quam voluptates. Qui qui illum id non necessitatibus. Aut earum vel ducimus error ut. Odio ea rerum quis. Molestias et asperiores voluptates.", 0, "Position and Elderly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a67412bf-562b-405e-844b-64c2aa476397"), null, new Guid("34cb43f2-975a-413a-b7ce-af3c7bd56010"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magni est ratione harum reiciendis quidem. Necessitatibus sit asperiores. Ut modi voluptatem doloribus odit. Neque minima laboriosam facilis numquam velit.", 3, "Evanescent Effect Hate Way", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c9b507e0-8b32-4169-aaad-3860101c15eb"), null, new Guid("34cb43f2-975a-413a-b7ce-af3c7bd56010"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hic nemo quo praesentium esse quia odio assumenda fugiat quis. Dolores numquam quas. Et ut consequatur quae accusamus officiis eum porro qui consequatur. Ipsam culpa voluptas ipsa quis commodi consequatur. Deserunt explicabo dolor omnis ad quod laborum blanditiis. Magnam rerum dicta natus tempora nobis commodi.", 0, "Knee Jazzy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2a7d5a20-45ae-4c8d-befd-e6311cbbc574"), null, new Guid("34cb43f2-975a-413a-b7ce-af3c7bd56010"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debitis fugit doloribus a delectus repellendus. Provident aliquam tempora commodi qui laboriosam omnis rerum itaque. Qui autem omnis quod praesentium. Commodi vero hic ipsa sunt. Ab qui modi voluptas voluptatibus saepe.", 3, "Wrap Wheel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("daab33f5-f1c3-43bb-b6db-78ca30ef9fe7"), null, new Guid("f8d57b4a-93c2-49b0-ad7d-205b050d0589"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natus ut ducimus dolor dolores. Eius natus perspiciatis perferendis ipsa aut consequatur hic. Autem nostrum consequuntur dolorem quae. Qui sit est ipsum deleniti esse ut labore. Ad eum aut id doloremque qui. Cupiditate et nemo laborum suscipit eum.", 5, "Too Swanky", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63f3d36b-688f-4d94-870c-2df346bcd04d"), null, new Guid("f011cc3a-36ac-4934-ae63-eaf81dca40ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesentium beatae eos. Possimus sequi dignissimos. Aperiam ipsum iure doloremque optio hic tenetur vitae laborum nihil. Odit qui aut blanditiis perspiciatis non neque corrupti dolores. Nesciunt non recusandae.", 1, "Swanky Dry Jazzy Ancient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a6a6559-0e31-4713-86d5-763d5b8acefb"), null, new Guid("f011cc3a-36ac-4934-ae63-eaf81dca40ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et unde voluptatem quod sed asperiores. Aut et omnis mollitia nobis et aut sint aut hic. Id libero nisi omnis sunt culpa eos. Facere repudiandae adipisci. Expedita voluptas non fuga accusantium quidem.", 4, "Drink Cent Pizzas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("59a16d22-29a6-4605-8cf9-476247fd3c07"), null, new Guid("f011cc3a-36ac-4934-ae63-eaf81dca40ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laudantium est facilis totam omnis dolor ab ratione. Fuga ipsum libero odio ratione repellendus harum omnis. Dolores in non. Soluta distinctio quod debitis ipsum. Voluptas ducimus cumque nostrum non praesentium porro iure eos nulla. Ut aspernatur id doloribus qui eos consequatur nisi sit id.", 3, "Of Miss Drink", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c097ad7-8420-4d57-93f0-58c0c8a274f3"), null, new Guid("ccedad14-4d55-4894-ae5d-54095d0a27af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quos sint ea expedita totam repellat aut consequuntur. Ipsam culpa molestiae optio aut itaque quibusdam. Nihil fugiat ipsum ut dignissimos minima. Voluptatem odio minima recusandae consequatur magni dolorem eos sit ut.", 0, "Evanescent Bleach", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7375c86a-1d1e-4e23-ad8d-46879bf8eff7"), null, new Guid("ccedad14-4d55-4894-ae5d-54095d0a27af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explicabo omnis aut. Minima vel nam sit quae quia alias tempora. Ut error deleniti sunt facere. Impedit dignissimos accusantium natus accusamus.", 2, "Drink Jazzy Sore", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3292c46e-4efd-4582-a519-4a83d6dc5ae7"), null, new Guid("ccedad14-4d55-4894-ae5d-54095d0a27af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut praesentium aut. Numquam quia quia reiciendis provident labore doloribus sit molestias. Voluptatem distinctio voluptatibus. Voluptatem id laboriosam. Hic temporibus et molestias neque saepe dolore aliquam. Nostrum sit est quos nihil.", 0, "Scarecrow and Whisper Elderly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78b4d5dd-ee25-4450-af4c-f21cdb4381e6"), null, new Guid("ccedad14-4d55-4894-ae5d-54095d0a27af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut sit in aliquam velit autem rerum sed. Cupiditate adipisci aut fugit vero. Ut cum commodi. Corporis ad qui. Ut commodi ducimus sit. Consequatur qui et vitae itaque ut et non.", 5, "Cloistered Way Church too", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33682348-bb3b-4759-94b8-a7e73e9fce97"), null, new Guid("ccedad14-4d55-4894-ae5d-54095d0a27af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit dignissimos officia vitae ut dignissimos nobis nostrum architecto. Non tempore non hic quaerat molestiae. Perferendis beatae et quaerat. Esse et temporibus ea aspernatur aut nihil similique.", 1, "Knee Jazzy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf405338-45ab-49bb-9dde-16df210a8d45"), null, new Guid("ccedad14-4d55-4894-ae5d-54095d0a27af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitae et doloremque quam rerum repellendus consequatur. Accusamus id qui. Dolor neque odio sit et minima ullam a harum dolorem. Eligendi repellat pariatur officiis reiciendis quia iusto.", 5, "Way Bolt Ancient Jazzy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85a3d3cf-152d-41ef-bf90-646629f83e7a"), null, new Guid("ccedad14-4d55-4894-ae5d-54095d0a27af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corrupti eum vero laboriosam voluptate necessitatibus laudantium nihil laborum. Aut at iure delectus omnis laudantium ut consequatur facere. Earum exercitationem quaerat eos nam consequatur nobis quas nesciunt et. Rerum ea nam dolorem voluptas vel doloribus quo. Tenetur voluptatem perspiciatis sit quod mollitia maiores. Modi atque consequatur a quo illum.", 5, "Way Bolt Ancient Jazzy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e96ae25-aba0-473a-9f3e-3eefeeecaf94"), null, new Guid("cf88ead6-3c75-4d54-bc3e-f82fe9cad801"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut libero sed asperiores molestias doloremque corporis error. Voluptatem dolor harum cum porro molestiae et ipsam. Voluptatem id iure.", 2, "Trains Damp Wrap Quizzical", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8560fc1e-863d-42c5-850b-62613595af62"), null, new Guid("709fa44c-e756-4d5b-935f-f329bad27f67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culpa adipisci sunt numquam possimus a et. Maxime voluptas sequi pariatur similique tempore non. Commodi quo deleniti et voluptatum provident cupiditate. Magnam blanditiis quam possimus minus harum hic et voluptate qui. Sed dolor aut ut modi molestiae asperiores delectus.", 5, "Bolt Enjoy Passenger", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5e3c254-019b-45c1-83ef-058a6027c3c2"), null, new Guid("709fa44c-e756-4d5b-935f-f329bad27f67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quam harum et placeat debitis. Nobis ipsa quos sit est nihil sunt quod dignissimos. Qui animi ut esse qui alias est voluptates.", 3, "Bleach Sneeze Ancient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("260fd54e-d2fc-40da-b325-48ad508bb296"), null, new Guid("709fa44c-e756-4d5b-935f-f329bad27f67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis optio ut voluptatem ipsum similique nulla. Praesentium est ut officia eum vel cum esse omnis fuga. Perferendis quod impedit. Quia ea qui quod. Aut quae impedit vitae eius.", 5, "Wrap Wheel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("340f9692-514c-4a39-8982-59562647f46d"), null, new Guid("709fa44c-e756-4d5b-935f-f329bad27f67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut unde voluptatem. Quae debitis dignissimos quidem tempora enim recusandae ut. Sequi alias repellat sint eveniet quam. Facere voluptatum reiciendis sequi sed quisquam inventore alias porro. Velit vel quas est ut totam aspernatur nihil quibusdam dolorem. Aut soluta cumque enim nihil dolores dolorem omnis odit reprehenderit.", 3, "For Legal Whisper", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d88de03b-593c-4355-9380-c7fd25ecd828"), null, new Guid("7abaa6ec-03bd-4451-ac8b-1d9870c538be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excepturi ex saepe consequatur officiis. In et quia vero. Est porro aliquam atque sit. Facilis omnis enim sunt aspernatur veritatis facilis. Velit est suscipit dolorem.", 0, "Legal Trains", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e5fc34f-76c2-4cfc-aafe-5c1b670505e5"), null, new Guid("34cb43f2-975a-413a-b7ce-af3c7bd56010"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed consequuntur recusandae expedita et harum dolor sint excepturi. Sed nobis aperiam ea. Quia distinctio blanditiis. Non animi accusantium temporibus nostrum. Nisi et accusamus molestias nesciunt veniam omnis omnis nesciunt. Ullam magnam ea nesciunt.", 2, "Bleach Miss Huge Wrap", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b0ca137-1a60-4c0b-902f-98ae41899d71"), null, new Guid("cd6145a1-f051-4069-8ba2-101c1a3280ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia quia sunt sunt enim ut quis. Eos occaecati rerum ipsam consequatur enim vel ratione recusandae. Nam consequuntur recusandae et ex assumenda saepe iusto ut consectetur. Sit architecto error quia. Ut omnis neque amet eveniet a nemo voluptas ut.", 3, "Bleach Truck Evanescent Look", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d52ac398-7610-4cdb-af8c-98b9745410b6"), null, new Guid("cd6145a1-f051-4069-8ba2-101c1a3280ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doloribus veritatis a quia omnis inventore sit facilis qui. Consequatur modi qui cupiditate vel sed. Reiciendis officiis quae minima natus quia et a. Aspernatur incidunt laboriosam et doloremque reprehenderit ab qui possimus voluptatibus. Laborum voluptas distinctio ut in dolores modi eligendi. Illo modi ea dolorum reiciendis modi est minus error molestiae.", 5, "Whisper Helpful", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("448bd6ea-8386-4867-92dc-0e836963f188"), null, new Guid("cd6145a1-f051-4069-8ba2-101c1a3280ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolor repellendus occaecati voluptas porro nulla facilis dolorem numquam cum. Et dolore ipsam quia et quod non. Quia sint vero. Assumenda molestias vero et reprehenderit. Sit occaecati ut. Quas est qui a molestias aut voluptatem.", 5, "Strange Vivacious", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6933cef-87f8-4a00-bf2e-8779c6356c54"), null, new Guid("b492717d-d6a6-4033-ba18-237569056833"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corporis dignissimos rerum aut est est repudiandae cum qui. Laboriosam nam tenetur reiciendis eum. Cumque libero minus at maiores. Dolorem laboriosam quo delectus natus optio inventore. Dolorum temporibus neque nihil iusto.", 3, "Bolt Enjoy Passenger", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("290ef181-a495-4157-b9eb-bd9023c415f6"), null, new Guid("b492717d-d6a6-4033-ba18-237569056833"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem dolor odit unde itaque. Error qui deserunt non hic provident labore. Sit delectus repudiandae dolorum voluptates. Ullam inventore consectetur ex soluta qui consequuntur nihil. Sit ipsa atque.", 0, "Bleach Truck Scarecrow Huge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("faa1a96d-7774-4707-85bc-70762774086d"), null, new Guid("3cca5fa3-6519-48fe-8402-1761fa5aa421"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Officiis voluptas voluptates vel quasi voluptate molestias placeat tenetur. Perferendis id voluptas accusantium itaque recusandae atque iusto laborum. Nihil consequuntur qui odio fugiat suscipit beatae ut aut. Recusandae sed et ratione maiores velit. Porro in est sed aut optio quo inventore aut omnis. Possimus sit placeat voluptates dolores aut ratione.", 4, "Elderly too", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70182258-587a-4cec-88c8-aa250fff2213"), null, new Guid("3cca5fa3-6519-48fe-8402-1761fa5aa421"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum quas dolores. Neque laudantium dolorum molestiae eius et. Vero nostrum odio. Aliquam minima dolorem corporis deserunt aut voluptas voluptatem. Similique qui sed et porro.", 1, "Helpful Juice Legal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c32fcea7-05a8-48e6-9cab-5ed0a9addfb5"), null, new Guid("3cca5fa3-6519-48fe-8402-1761fa5aa421"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consectetur nostrum odit ipsa. Voluptas excepturi incidunt voluptas doloremque corporis deleniti fugiat. Aut et et voluptas ut veritatis maxime.", 0, "Drink Jazzy Sore", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a439710d-a4c3-4423-a229-cedd35b96683"), null, new Guid("3cca5fa3-6519-48fe-8402-1761fa5aa421"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vel voluptas qui eum earum veniam et qui. Perferendis sed iure nulla ipsa qui. Voluptates aut quia aut non voluptatem omnis odit.", 5, "Wrap Scarecrow", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b26fa588-b1d8-4523-8936-25f64b3efb48"), null, new Guid("0d99810c-be91-4a7e-9e23-73b5450f3172"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neque illo ducimus eum ut in ad eum blanditiis. Voluptate tempora cumque quis quis vel. Quos molestiae perspiciatis qui nam voluptate molestias sunt qui. Nam vel repellendus sunt.", 3, "Cloistered Vivacious", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e4e8d7d-e2b2-4c1e-bb24-2d532910fd43"), null, new Guid("0d99810c-be91-4a7e-9e23-73b5450f3172"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et non molestias aut nesciunt est iure ipsa. Reprehenderit amet in quia suscipit asperiores cumque alias. Repudiandae sapiente recusandae sit distinctio.", 5, "Elderly too", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("46c00703-f6c0-4760-807b-d8ab0b8d2216"), null, new Guid("39db8301-6476-4835-b751-311367a4400a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatibus officiis magni autem. Enim officiis explicabo accusantium sit. Similique quo quo et repudiandae id dolor et veniam.", 3, "Quizzical Pizzas Swanky Wheel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a7fc5c68-65f4-44bc-9892-523e712c1e53"), null, new Guid("5108553c-8071-4a73-b06e-4697df428ee2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ad occaecati voluptatibus nemo error laboriosam eligendi ut. Officiis unde possimus ut aliquam voluptatem explicabo tenetur. Enim quia eius corporis quasi nesciunt eligendi aut.", 3, "Jazzy Sore Position", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb434ce3-09c6-4a78-8e9e-0ea45fd8c2c8"), null, new Guid("e886fdf7-48ea-4512-87dc-1588be8e0b58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debitis eos quo error mollitia. Ut optio ea. Esse voluptatum ipsa consequuntur ipsam reiciendis soluta animi.", 0, "Bleach Sneeze Ancient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("479a9ae3-f3b8-4cf7-b0d2-b6b7b6f5239a"), null, new Guid("5108553c-8071-4a73-b06e-4697df428ee2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neque in beatae nobis et veritatis. Quae omnis suscipit unde. Harum pariatur sunt maxime perspiciatis iusto maxime similique provident aut. Ea quia eos omnis rerum et. Iusto amet odio laborum ratione similique.", 2, "Bleach Miss Huge Wrap", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e94da56-94fa-4199-8a17-ba806654a990"), null, new Guid("5108553c-8071-4a73-b06e-4697df428ee2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incidunt tempora rem ut molestias consectetur autem quibusdam voluptatem earum. Omnis tempora quia culpa non autem eos soluta. Nostrum maiores voluptatibus aut molestiae sed nemo.", 4, "Position the Dry", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6df7e7dc-8529-4947-bc8c-f01284c6c1eb"), null, new Guid("5108553c-8071-4a73-b06e-4697df428ee2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis modi vel enim recusandae consectetur culpa ut sed vel. Optio aliquam non blanditiis inventore aliquam numquam optio neque. Perferendis sed et maxime laudantium voluptatem dolores.", 2, "Scarecrow Pizzas Way Elderly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e1cce7a-f7d7-46a8-be24-3348273f762e"), null, new Guid("b78e7df4-acab-40c7-888e-3c24bfae4280"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem voluptates tempore quia temporibus consequuntur. Omnis inventore consequatur rem. Commodi aliquam officiis mollitia. Rerum sit dolor occaecati.", 1, "Ancient Juice", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("54f9dd9f-66c5-4d06-9368-2015f25999a1"), null, new Guid("b78e7df4-acab-40c7-888e-3c24bfae4280"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia officia quaerat. Autem vero eos odio autem vitae est consequuntur. Voluptates repellendus veniam eos provident corporis quaerat. Aliquam totam similique est veritatis dicta. Delectus alias quidem nesciunt ipsa est rem quas cupiditate aut. Aut facere perferendis dolor dolorem neque.", 5, "For Legal Whisper", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("373b2e8c-74bd-42ba-8c55-34b205967c79"), null, new Guid("b78e7df4-acab-40c7-888e-3c24bfae4280"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatum quidem tempore qui harum et. Blanditiis quam deleniti qui iste molestias. Perferendis voluptate rerum aliquam ut. Rerum cupiditate id et dolore.", 2, "Trains Damp Wrap Quizzical", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("18e9cf71-8c15-4f2c-b6d0-a50ed0006a5c"), null, new Guid("b78e7df4-acab-40c7-888e-3c24bfae4280"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Similique et deleniti voluptas illum odio. Nemo ut quia voluptas dolor laborum provident ut consequatur aut. Et facilis quibusdam minima aut. Modi saepe labore laborum non dolor.", 4, "Helpful Evanescent Wrist Huge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b49af1fc-d722-4814-9971-6b9985d01319"), null, new Guid("d6a8397a-fb9a-427c-b8d2-974cc90eef41"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iusto excepturi quas occaecati laboriosam molestias dolores repellendus sunt. Aut omnis ad dolor magnam fugit minima officia. Quidem quae mollitia voluptatum dolore est recusandae et. Natus deserunt neque nobis.", 1, "Scarecrow and Whisper Elderly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae34e3c3-11c9-4df2-89dd-9a35273aefb2"), null, new Guid("d6a8397a-fb9a-427c-b8d2-974cc90eef41"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui omnis fugiat sed maiores voluptas illum ea est iusto. Iste odit nam. Ea et distinctio consequatur perferendis voluptatem corrupti laboriosam. Voluptas accusantium aut quas enim. Ea et et dignissimos excepturi corrupti. Doloribus qui inventore voluptatibus provident voluptas illum qui.", 5, "And Passenger Bolt Way", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff24cef5-b24d-40a1-bb37-0705f7300fec"), null, new Guid("cd6145a1-f051-4069-8ba2-101c1a3280ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorum aperiam neque expedita similique voluptatibus. Ab commodi molestiae explicabo. Accusantium dicta suscipit. Vel explicabo velit vero rerum repudiandae cupiditate iure voluptas voluptate. Beatae ducimus non sunt fugiat facere maiores earum tempora inventore. Enim aut dolor cum qui omnis ut.", 2, "Legal Trains", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("09a380b7-8a20-46b5-b37d-aecbad24bc69"), null, new Guid("cd6145a1-f051-4069-8ba2-101c1a3280ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cum et quia incidunt amet rerum eveniet voluptatibus pariatur necessitatibus. Aliquid nihil officiis culpa nam deleniti et. Atque incidunt sed ipsam. In nihil eaque enim perspiciatis amet.", 3, "Drink Jazzy Sore", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6453c4e-eaf6-4949-83dc-fa1d3f501911"), null, new Guid("5108553c-8071-4a73-b06e-4697df428ee2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soluta autem dolorum aliquam architecto deserunt provident. Eveniet necessitatibus est tempora consectetur vel quaerat nihil deserunt officia. Eveniet eum eos reprehenderit. Illum tenetur aperiam. Suscipit voluptatem corrupti odit similique dolorem. Itaque recusandae aliquam voluptatem nihil officiis hic ex beatae.", 3, "Elderly of Bleach", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("be39c70c-a43b-4b83-95ad-0d984b95e621"), null, new Guid("e886fdf7-48ea-4512-87dc-1588be8e0b58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem deleniti blanditiis. Consequatur consequatur consequatur. Minus labore beatae officiis aut ea distinctio iste. Asperiores quam quia minus ratione sunt distinctio animi autem.", 2, "Position and Elderly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_AppUserId",
                table: "Announcements",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserBooks_BookId",
                table: "AppUserBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_IdentityId",
                table: "AppUsers",
                column: "IdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AnnouncementId",
                table: "Books",
                column: "AnnouncementId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AnnouncementId",
                table: "Comments",
                column: "AnnouncementId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AppUserId",
                table: "Comments",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserBooks");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
