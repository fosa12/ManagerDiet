﻿// <auto-generated />
using System;
using ManagerDiet.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManagerDiet.Persistance.Migrations
{
    [DbContext(typeof(DietDbContext))]
    [Migration("20220823183548_AddedNewPropKCALInMealv2")]
    partial class AddedNewPropKCALInMealv2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DietMeal", b =>
                {
                    b.Property<int>("DietsId")
                        .HasColumnType("int");

                    b.Property<int>("MealsId")
                        .HasColumnType("int");

                    b.HasKey("DietsId", "MealsId");

                    b.HasIndex("MealsId");

                    b.ToTable("DietMeal");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.CaloricDemand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Activity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DailyRequirementCarbo")
                        .HasColumnType("float");

                    b.Property<double>("DailyRequirementFat")
                        .HasColumnType("float");

                    b.Property<double>("DailyRequirementKcal")
                        .HasColumnType("float");

                    b.Property<double>("DailyRequirementProtein")
                        .HasColumnType("float");

                    b.Property<string>("Goal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("UserInformationId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("UserInformationId")
                        .IsUnique();

                    b.ToTable("CaloricDemands");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.DayInDiet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateDayInDiet")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("UserInformationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserInformationId");

                    b.ToTable("DayInDiets");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.Diet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DietDescryption")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DietName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DietShortDescryption")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GlycemicIndex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuantityCarbo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuantityFat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuantityProtein")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Diets");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.EatedMeal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DayInDietId")
                        .HasColumnType("int");

                    b.Property<int>("EatedGrams")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("WhenEated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DayInDietId");

                    b.HasIndex("MealId");

                    b.ToTable("EatedMeals");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MealId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlycemicIndex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KCAL")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PreparationTimeInMin")
                        .HasColumnType("int");

                    b.Property<int>("QuantityCarboInGrams")
                        .HasColumnType("int");

                    b.Property<int>("QuantityFatInGrams")
                        .HasColumnType("int");

                    b.Property<int>("QuantityProteinInGrams")
                        .HasColumnType("int");

                    b.Property<double>("QuantitySaturatedFatInGrams")
                        .HasColumnType("float");

                    b.Property<double>("QuantitySugar")
                        .HasColumnType("float");

                    b.Property<string>("Recipe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.UserInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DietId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DietId");

                    b.ToTable("UserInformations");
                });

            modelBuilder.Entity("DietMeal", b =>
                {
                    b.HasOne("ManagerDiet.Domain.Entities.Diet", null)
                        .WithMany()
                        .HasForeignKey("DietsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManagerDiet.Domain.Entities.Meal", null)
                        .WithMany()
                        .HasForeignKey("MealsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.CaloricDemand", b =>
                {
                    b.HasOne("ManagerDiet.Domain.Entities.UserInformation", "UserInformation")
                        .WithOne("CaloricDemand")
                        .HasForeignKey("ManagerDiet.Domain.Entities.CaloricDemand", "UserInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInformation");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.DayInDiet", b =>
                {
                    b.HasOne("ManagerDiet.Domain.Entities.UserInformation", "UserInformation")
                        .WithMany("DayInDiets")
                        .HasForeignKey("UserInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInformation");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.EatedMeal", b =>
                {
                    b.HasOne("ManagerDiet.Domain.Entities.DayInDiet", "DayInDiet")
                        .WithMany("EatedMeals")
                        .HasForeignKey("DayInDietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManagerDiet.Domain.Entities.Meal", "Meal")
                        .WithMany("EatedMeals")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DayInDiet");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.Ingredient", b =>
                {
                    b.HasOne("ManagerDiet.Domain.Entities.Meal", "Meal")
                        .WithMany("Ingredients")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.UserInformation", b =>
                {
                    b.HasOne("ManagerDiet.Domain.Entities.Diet", "Diet")
                        .WithMany("UserInformations")
                        .HasForeignKey("DietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("ManagerDiet.Domain.ValueObjects.PersonName", "UserInformationName", b1 =>
                        {
                            b1.Property<int>("UserInformationId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("UserInformationId");

                            b1.ToTable("UserInformations");

                            b1.WithOwner()
                                .HasForeignKey("UserInformationId");
                        });

                    b.Navigation("Diet");

                    b.Navigation("UserInformationName")
                        .IsRequired();
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.DayInDiet", b =>
                {
                    b.Navigation("EatedMeals");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.Diet", b =>
                {
                    b.Navigation("UserInformations");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.Meal", b =>
                {
                    b.Navigation("EatedMeals");

                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("ManagerDiet.Domain.Entities.UserInformation", b =>
                {
                    b.Navigation("CaloricDemand")
                        .IsRequired();

                    b.Navigation("DayInDiets");
                });
#pragma warning restore 612, 618
        }
    }
}