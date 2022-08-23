using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagerDiet.Persistance.Migrations
{
    public partial class AddedNewPropKCALInMealv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KCAL",
                table: "Meals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KCAL",
                table: "Meals");
        }
    }
}
