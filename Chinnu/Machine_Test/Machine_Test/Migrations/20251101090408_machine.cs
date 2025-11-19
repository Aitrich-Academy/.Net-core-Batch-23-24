using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

<<<<<<<< HEAD:Chinnu/Machine_Test/Machine_Test/Migrations/20251101090408_machine.cs
namespace Machine_Test.Migrations
{
    /// <inheritdoc />
    public partial class machine : Migration
========
namespace Razor_ServiceRepo.Migrations
{
    /// <inheritdoc />
    public partial class serviceRepo : Migration
>>>>>>>> 73448bdaf4ef445f3952b497bfc0a9db31b692de:Razor/Razor_ServiceRepo_Demo/Razor_ServiceRepo/Migrations/20251013190844_serviceRepo.cs
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
