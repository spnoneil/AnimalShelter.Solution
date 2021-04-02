using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Breed", "DateAdded", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 1, "American Shorthair", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "Prof. Stankpawz" },
                    { 2, 5, "Abyssian", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "Princess P" },
                    { 3, 8, "Persian", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "Floofybooty" },
                    { 4, 3, "Manx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "Sir Ratdeath" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "DateAdded", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 10, "Labrador", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "Destructo" },
                    { 2, 2, "Scottish Terrier", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "Devin The Dog" },
                    { 3, 3, "Chi-weenie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "Rolf" },
                    { 4, 2, "Shih-tzu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "Beavis" }
                });

            migrationBuilder.InsertData(
                table: "OtherAnimals",
                columns: new[] { "OtherAnimalId", "Age", "DateAdded", "Gender", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hard to tell", "Billy the Squid", "Octopus" },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "SQUAAARK!", "Parrot or something" },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", ".NET", "Tarantula" },
                    { 4, 1000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "previously male", "Resident Steve-il", "Zombie" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OtherAnimals",
                keyColumn: "OtherAnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OtherAnimals",
                keyColumn: "OtherAnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OtherAnimals",
                keyColumn: "OtherAnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OtherAnimals",
                keyColumn: "OtherAnimalId",
                keyValue: 4);
        }
    }
}
