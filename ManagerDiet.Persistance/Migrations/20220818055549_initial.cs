using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagerDiet.Persistance.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DietName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DietShortDescryption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DietDescryption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GlycemicIndex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityProtein = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityCarbo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityFat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductsNeededToPrepareMeal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreparationTimeInMin = table.Column<int>(type: "int", nullable: false),
                    GlycemicIndex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityProteinInGrams = table.Column<int>(type: "int", nullable: false),
                    QuantityCarboInGrams = table.Column<int>(type: "int", nullable: false),
                    QuantitySimpleCarboInGrams = table.Column<double>(type: "float", nullable: false),
                    QuantityComplexCarboInGrams = table.Column<double>(type: "float", nullable: false),
                    QuantityFatInGrams = table.Column<int>(type: "int", nullable: false),
                    QuantitySaturatedFatInGrams = table.Column<double>(type: "float", nullable: false),
                    QuantityUnSaturatedFatInGrams = table.Column<double>(type: "float", nullable: false),
                    DietId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserInformationName_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserInformationName_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DietId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInformations_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaloricDemands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyRequirementKcal = table.Column<double>(type: "float", nullable: false),
                    DailyRequirementFat = table.Column<double>(type: "float", nullable: false),
                    DailyRequirementProtein = table.Column<double>(type: "float", nullable: false),
                    DailyRequirementCarbo = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Goal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    UserInformationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaloricDemands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaloricDemands_UserInformations_UserInformationId",
                        column: x => x.UserInformationId,
                        principalTable: "UserInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DayInDiets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDayInDiet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserInformationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayInDiets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DayInDiets_UserInformations_UserInformationId",
                        column: x => x.UserInformationId,
                        principalTable: "UserInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EatedMeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EatedGrams = table.Column<int>(type: "int", nullable: false),
                    WhenEated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayInDietId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EatedMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EatedMeals_DayInDiets_DayInDietId",
                        column: x => x.DayInDietId,
                        principalTable: "DayInDiets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EatedMeals_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaloricDemands_UserInformationId",
                table: "CaloricDemands",
                column: "UserInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DayInDiets_UserInformationId",
                table: "DayInDiets",
                column: "UserInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_EatedMeals_DayInDietId",
                table: "EatedMeals",
                column: "DayInDietId");

            migrationBuilder.CreateIndex(
                name: "IX_EatedMeals_MealId",
                table: "EatedMeals",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_DietId",
                table: "Meals",
                column: "DietId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformations_DietId",
                table: "UserInformations",
                column: "DietId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaloricDemands");

            migrationBuilder.DropTable(
                name: "EatedMeals");

            migrationBuilder.DropTable(
                name: "DayInDiets");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "UserInformations");

            migrationBuilder.DropTable(
                name: "Diets");
        }
    }
}
