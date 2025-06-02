using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class usersDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Users_UserId",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Bookings");

            migrationBuilder.AddColumn<string>(
                name: "BookedEmail",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Url = table.Column<string>(type: "text", nullable: false),
                    WorkspaceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Workspaces_WorkspaceId",
                        column: x => x.WorkspaceId,
                        principalTable: "Workspaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Workspaces",
                columns: new[] { "Id", "Capacity", "Type" },
                values: new object[,]
                {
                    { 1, 10, "OpenSpace" },
                    { 2, 5, "PrivateRoom" },
                    { 3, 20, "MeetingRoom" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Url", "WorkspaceId" },
                values: new object[,]
                {
                    { 1, "https://cdn-jdbmd.nitrocdn.com/yEMHtyTSADNOgebFqynalakIQNihDGqu/assets/images/optimized/rev-80fa023/www.officernd.com/wp-content/uploads/2024/07/word-image-34624-2", 1 },
                    { 2, "https://content.instantoffices.com/sc/Prod/images/centres/1600width/47176/47176-428809", 2 },
                    { 3, "https://aticco.com/wp-content/uploads/2024/07/que-es-coworking-1", 3 },
                    { 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRwO67LL1AF8SOl89ImJauhzQWmX9zcT5x30A&s", 1 },
                    { 5, "https://spaces-wp.imgix.net/2018/08/LochrinSquare_839x474.png?auto=compress,format&q=50", 2 },
                    { 6, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS8MYQytEm9aEhoY58aEibJAo8Uh8xvgGBSAw&s", 3 },
                    { 7, "https://coworkingmag.com/wp-content/uploads/sites/76/2018/01/a-tech-stop-hang-out-room.jpg", 1 },
                    { 8, "https://s5.cdn.ventureburn.com/wp-content/uploads/sites/2/2022/12/1-10.jpg", 2 },
                    { 9, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQO8ytvVSigHK0MXeck4XYOPurAdJqTpfeH7w&s", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_WorkspaceId",
                table: "Images",
                column: "WorkspaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "Workspaces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workspaces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workspaces",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "BookedEmail",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Bookings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Users_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
