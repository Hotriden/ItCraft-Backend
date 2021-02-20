using Microsoft.EntityFrameworkCore.Migrations;

namespace ItCraftTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "Name" },
                values: new object[,]
                {
                    { 1, false, "Vasya" },
                    { 2, false, "Petya" },
                    { 3, false, "Katya" },
                    { 4, false, "Olya" },
                    { 5, false, "Masha" },
                    { 6, false, "Grisha" },
                    { 7, false, "John" },
                    { 8, false, "Pavel" },
                    { 9, false, "Rita" },
                    { 10, false, "Sveta" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
