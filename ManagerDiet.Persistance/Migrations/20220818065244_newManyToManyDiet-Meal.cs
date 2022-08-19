using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagerDiet.Persistance.Migrations
{
    public partial class newManyToManyDietMeal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Diets_DietId",
                table: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_Meals_DietId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "DietId",
                table: "Meals");

            migrationBuilder.CreateTable(
                name: "DietMeal",
                columns: table => new
                {
                    DietsId = table.Column<int>(type: "int", nullable: false),
                    MealsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietMeal", x => new { x.DietsId, x.MealsId });
                    table.ForeignKey(
                        name: "FK_DietMeal_Diets_DietsId",
                        column: x => x.DietsId,
                        principalTable: "Diets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DietMeal_Meals_MealsId",
                        column: x => x.MealsId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DietMeal_MealsId",
                table: "DietMeal",
                column: "MealsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DietMeal");

            migrationBuilder.AddColumn<int>(
                name: "DietId",
                table: "Meals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meals_DietId",
                table: "Meals",
                column: "DietId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Diets_DietId",
                table: "Meals",
                column: "DietId",
                principalTable: "Diets",
                principalColumn: "Id");
        }
    }
}
