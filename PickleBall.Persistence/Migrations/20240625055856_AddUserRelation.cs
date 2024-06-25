using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PickleBall.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SupervisorId",
                table: "ApplicationUser",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DayOfBirth", "Email", "EmailConfirmed", "FirstName", "FullName", "IdentityId", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SupervisorId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0ac39d47-a580-388c-334e-c36e77d4acb7"), 0, "e4e16fb7-3856-49f1-82f0-f0d89604fd55", new DateTime(2020, 12, 10, 13, 2, 16, 826, DateTimeKind.Unspecified).AddTicks(5847), null, false, "Abraham", "Abraham Stracke", "eb2ed449-1097-bddf-55d3-64a3db4a109f", "Stracke", "Mayraburgh", false, null, null, null, null, null, false, null, new Guid("0ac39d47-a580-388c-334e-c36e77d4acb7"), false, null },
                    { new Guid("11cf08e5-9589-40c5-a761-187ed55224f6"), 0, "db5561e1-36d6-4df2-944e-78ad84d3a426", new DateTime(2020, 11, 30, 22, 3, 28, 773, DateTimeKind.Unspecified).AddTicks(9867), null, false, "June", "June Shields", "1b36a9ff-7c81-63ae-cbef-0d43492d904e", "Shields", "Port Reymundochester", false, null, null, null, null, null, false, null, new Guid("11cf08e5-9589-40c5-a761-187ed55224f6"), false, null },
                    { new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42"), 0, "9809981f-bf0a-4b05-b9f0-99e641a32dfb", new DateTime(2020, 9, 2, 9, 13, 59, 683, DateTimeKind.Unspecified).AddTicks(1295), null, false, "Alfredo", "Alfredo Hoeger", "57cedb03-32f6-c51c-87dc-332ddaa177a4", "Hoeger", "Alyshamouth", false, null, null, null, null, null, false, null, new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42"), false, null },
                    { new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d"), 0, "c28ad903-6b89-4162-872a-28b16840f933", new DateTime(2020, 11, 19, 23, 12, 48, 388, DateTimeKind.Unspecified).AddTicks(793), null, false, "Cristina", "Cristina Harvey", "fa6f8747-3f5d-bbef-55f9-f750e56dce5a", "Harvey", "South Evalynland", false, null, null, null, null, null, false, null, new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d"), false, null },
                    { new Guid("9588df2f-6267-6dd3-4359-1ec672055d47"), 0, "d3a4a4a1-a106-4156-88a3-852e4e6c18c1", new DateTime(2020, 8, 14, 2, 17, 17, 512, DateTimeKind.Unspecified).AddTicks(9172), null, false, "Evelyn", "Evelyn Crona", "d9a22f7b-de96-5381-83b1-6f0a58350ef0", "Crona", "Port Braintown", false, null, null, null, null, null, false, null, new Guid("9588df2f-6267-6dd3-4359-1ec672055d47"), false, null },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), 0, "981510e6-3b38-4a4a-a9fb-15478c898ce7", new DateTime(2020, 9, 30, 14, 49, 12, 324, DateTimeKind.Unspecified).AddTicks(1575), null, false, "Kim", "Kim Renner", "46e63ca8-ed80-6881-bd10-e2e3d1cca53c", "Renner", "Gilesview", false, null, null, null, null, null, false, null, new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), false, null },
                    { new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), 0, "2d0afb96-3191-46a4-97da-1f187d18b004", new DateTime(2020, 10, 11, 7, 47, 8, 409, DateTimeKind.Unspecified).AddTicks(1603), null, false, "Gayle", "Gayle Kuvalis", "cebdf523-6ef2-84d8-8d04-bd66760f9121", "Kuvalis", "Reichertville", false, null, null, null, null, null, false, null, new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), false, null },
                    { new Guid("dae37e73-50c0-d5c8-97c6-5a7041370998"), 0, "29cde6bf-c84a-4f33-a752-e1f49b9c900c", new DateTime(2020, 12, 9, 2, 5, 56, 377, DateTimeKind.Unspecified).AddTicks(5649), null, false, "Sheri", "Sheri Waelchi", "66e6e571-a162-719b-66b2-929c755de312", "Waelchi", "Carleyhaven", false, null, null, null, null, null, false, null, new Guid("dae37e73-50c0-d5c8-97c6-5a7041370998"), false, null },
                    { new Guid("f880aa64-7561-7503-de83-7f97fc4ce8a5"), 0, "77850755-0314-44f8-ae6b-e605f9787390", new DateTime(2020, 6, 2, 19, 21, 13, 627, DateTimeKind.Unspecified).AddTicks(678), null, false, "Carrie", "Carrie Batz", "5e5bee70-95c8-0dbb-2af5-da4042df1c3a", "Batz", "Port Norberto", false, null, null, null, null, null, false, null, new Guid("f880aa64-7561-7503-de83-7f97fc4ce8a5"), false, null }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2020, 1, 6, 11, 20, 48, 83, DateTimeKind.Unspecified).AddTicks(6269), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 11, 22, 2, 30, 11, 875, DateTimeKind.Unspecified).AddTicks(9674), new TimeSpan(0, 7, 0, 0, 0)), "Jakubowskiville" },
                    { 2, new DateTimeOffset(new DateTime(2020, 12, 27, 21, 33, 38, 736, DateTimeKind.Unspecified).AddTicks(9842), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 26, 21, 0, 47, 806, DateTimeKind.Unspecified).AddTicks(9375), new TimeSpan(0, 7, 0, 0, 0)), "Kilbackberg" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 3, new DateTimeOffset(new DateTime(2020, 4, 18, 16, 4, 20, 728, DateTimeKind.Unspecified).AddTicks(3117), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 6, 20, 43, 23, 19, DateTimeKind.Unspecified).AddTicks(2827), new TimeSpan(0, 7, 0, 0, 0)), "South Georgianaburgh" },
                    { 4, new DateTimeOffset(new DateTime(2020, 4, 8, 8, 6, 42, 657, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 8, 1, 56, 42, 864, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 7, 0, 0, 0)), "North Eulahborough" },
                    { 5, new DateTimeOffset(new DateTime(2020, 4, 22, 18, 58, 22, 478, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 28, 6, 34, 59, 431, DateTimeKind.Unspecified).AddTicks(2710), new TimeSpan(0, 7, 0, 0, 0)), "Tiffanyton" },
                    { 6, new DateTimeOffset(new DateTime(2020, 4, 24, 12, 34, 33, 312, DateTimeKind.Unspecified).AddTicks(9355), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 3, 16, 41, 6, 639, DateTimeKind.Unspecified).AddTicks(4618), new TimeSpan(0, 7, 0, 0, 0)), "North Evanhaven" },
                    { 7, new DateTimeOffset(new DateTime(2020, 7, 2, 1, 56, 13, 215, DateTimeKind.Unspecified).AddTicks(6503), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 15, 1, 34, 11, 827, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 7, 0, 0, 0)), "North Donnaburgh" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 8, new DateTimeOffset(new DateTime(2020, 5, 10, 20, 52, 37, 915, DateTimeKind.Unspecified).AddTicks(4484), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 19, 0, 47, 52, 520, DateTimeKind.Unspecified).AddTicks(7715), new TimeSpan(0, 7, 0, 0, 0)), "South Evelineport" },
                    { 9, new DateTimeOffset(new DateTime(2020, 12, 4, 19, 47, 4, 192, DateTimeKind.Unspecified).AddTicks(237), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 25, 21, 45, 20, 988, DateTimeKind.Unspecified).AddTicks(7780), new TimeSpan(0, 7, 0, 0, 0)), "Mertzview" },
                    { 10, new DateTimeOffset(new DateTime(2020, 8, 27, 6, 3, 16, 777, DateTimeKind.Unspecified).AddTicks(6594), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 19, 20, 46, 30, 233, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 7, 0, 0, 0)), "New Sebastian" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 11, new DateTimeOffset(new DateTime(2020, 10, 31, 3, 47, 15, 901, DateTimeKind.Unspecified).AddTicks(194), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 20, 2, 54, 43, 526, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 7, 0, 0, 0)), "Waltershire" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { 12, new DateTimeOffset(new DateTime(2020, 12, 14, 6, 8, 51, 693, DateTimeKind.Unspecified).AddTicks(8474), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 10, 3, 55, 22, 952, DateTimeKind.Unspecified).AddTicks(1296), new TimeSpan(0, 7, 0, 0, 0)), "Lubowitzfurt" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 13, new DateTimeOffset(new DateTime(2020, 3, 16, 0, 18, 20, 830, DateTimeKind.Unspecified).AddTicks(3603), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 1, 14, 34, 10, 735, DateTimeKind.Unspecified).AddTicks(4846), new TimeSpan(0, 7, 0, 0, 0)), "Russelborough" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 14, new DateTimeOffset(new DateTime(2020, 2, 4, 2, 42, 30, 340, DateTimeKind.Unspecified).AddTicks(4394), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 17, 14, 30, 51, 308, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 7, 0, 0, 0)), "Amaraburgh" },
                    { 15, new DateTimeOffset(new DateTime(2020, 5, 6, 7, 17, 1, 420, DateTimeKind.Unspecified).AddTicks(6102), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 8, 11, 12, 27, 58, 191, DateTimeKind.Unspecified).AddTicks(5620), new TimeSpan(0, 7, 0, 0, 0)), "Ryanberg" },
                    { 16, new DateTimeOffset(new DateTime(2020, 10, 28, 10, 59, 58, 655, DateTimeKind.Unspecified).AddTicks(6819), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 15, 21, 18, 31, 727, DateTimeKind.Unspecified).AddTicks(7011), new TimeSpan(0, 7, 0, 0, 0)), "Port Morganbury" },
                    { 17, new DateTimeOffset(new DateTime(2020, 4, 25, 21, 29, 23, 826, DateTimeKind.Unspecified).AddTicks(5985), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 6, 5, 21, 48, 101, DateTimeKind.Unspecified).AddTicks(5170), new TimeSpan(0, 7, 0, 0, 0)), "Lake Skye" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 18, new DateTimeOffset(new DateTime(2020, 10, 3, 15, 40, 12, 836, DateTimeKind.Unspecified).AddTicks(5869), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 5, 2, 15, 12, 50, 158, DateTimeKind.Unspecified).AddTicks(6323), new TimeSpan(0, 7, 0, 0, 0)), "Sawaynborough" },
                    { 19, new DateTimeOffset(new DateTime(2020, 4, 7, 19, 48, 40, 196, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 7, 22, 40, 45, 671, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, 7, 0, 0, 0)), "Jeffburgh" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 20, new DateTimeOffset(new DateTime(2020, 9, 27, 17, 41, 8, 63, DateTimeKind.Unspecified).AddTicks(6226), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 29, 21, 55, 51, 684, DateTimeKind.Unspecified).AddTicks(8544), new TimeSpan(0, 7, 0, 0, 0)), "Reichertport" },
                    { 21, new DateTimeOffset(new DateTime(2020, 2, 12, 17, 24, 44, 840, DateTimeKind.Unspecified).AddTicks(7113), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 2, 11, 19, 53, 21, 949, DateTimeKind.Unspecified).AddTicks(1782), new TimeSpan(0, 7, 0, 0, 0)), "East Clovis" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 22, new DateTimeOffset(new DateTime(2020, 4, 2, 20, 19, 20, 572, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 26, 13, 41, 52, 193, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 7, 0, 0, 0)), "New Merl" },
                    { 23, new DateTimeOffset(new DateTime(2020, 7, 12, 8, 29, 34, 78, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 22, 14, 2, 51, 750, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 7, 0, 0, 0)), "Fredericberg" },
                    { 24, new DateTimeOffset(new DateTime(2020, 2, 4, 12, 7, 51, 222, DateTimeKind.Unspecified).AddTicks(68), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 10, 23, 56, 58, 613, DateTimeKind.Unspecified).AddTicks(4561), new TimeSpan(0, 7, 0, 0, 0)), "Justonstad" },
                    { 25, new DateTimeOffset(new DateTime(2020, 5, 14, 1, 46, 1, 514, DateTimeKind.Unspecified).AddTicks(7233), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 13, 23, 8, 15, 823, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 7, 0, 0, 0)), "Dickinsonberg" },
                    { 26, new DateTimeOffset(new DateTime(2020, 6, 12, 10, 38, 42, 910, DateTimeKind.Unspecified).AddTicks(2775), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 15, 5, 23, 11, 158, DateTimeKind.Unspecified).AddTicks(3588), new TimeSpan(0, 7, 0, 0, 0)), "Andreston" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { 27, new DateTimeOffset(new DateTime(2020, 3, 3, 22, 30, 55, 391, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 5, 19, 40, 17, 984, DateTimeKind.Unspecified).AddTicks(1684), new TimeSpan(0, 7, 0, 0, 0)), "Port Stanleytown" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 28, new DateTimeOffset(new DateTime(2020, 12, 27, 10, 29, 24, 579, DateTimeKind.Unspecified).AddTicks(2079), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 18, 22, 4, 24, 934, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 7, 0, 0, 0)), "Nitzscheport" },
                    { 29, new DateTimeOffset(new DateTime(2020, 4, 16, 16, 37, 14, 265, DateTimeKind.Unspecified).AddTicks(5460), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 10, 8, 37, 12, 680, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 7, 0, 0, 0)), "West Sammy" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { 30, new DateTimeOffset(new DateTime(2020, 12, 28, 19, 20, 22, 432, DateTimeKind.Unspecified).AddTicks(6965), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 4, 22, 7, 40, 1, 142, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 7, 0, 0, 0)), "East Delfina" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 31, new DateTimeOffset(new DateTime(2020, 10, 11, 7, 47, 8, 409, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 3, 19, 6, 30, 41, 714, DateTimeKind.Unspecified).AddTicks(7448), new TimeSpan(0, 7, 0, 0, 0)), "Grimesfort" },
                    { 32, new DateTimeOffset(new DateTime(2020, 8, 9, 6, 59, 37, 33, DateTimeKind.Unspecified).AddTicks(3154), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 3, 28, 17, 11, 21, 446, DateTimeKind.Unspecified).AddTicks(9998), new TimeSpan(0, 7, 0, 0, 0)), "Port Eraberg" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 33, new DateTimeOffset(new DateTime(2020, 11, 13, 7, 45, 19, 607, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 9, 20, 42, 58, 424, DateTimeKind.Unspecified).AddTicks(7269), new TimeSpan(0, 7, 0, 0, 0)), "Jordynhaven" },
                    { 34, new DateTimeOffset(new DateTime(2020, 6, 15, 11, 36, 33, 861, DateTimeKind.Unspecified).AddTicks(7603), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 5, 16, 42, 44, 959, DateTimeKind.Unspecified).AddTicks(4274), new TimeSpan(0, 7, 0, 0, 0)), "North Ashlynnhaven" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 35, new DateTimeOffset(new DateTime(2020, 5, 12, 15, 22, 34, 259, DateTimeKind.Unspecified).AddTicks(5883), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 4, 13, 50, 6, 653, DateTimeKind.Unspecified).AddTicks(5869), new TimeSpan(0, 7, 0, 0, 0)), "Schmidtshire" },
                    { 36, new DateTimeOffset(new DateTime(2020, 10, 7, 6, 42, 30, 532, DateTimeKind.Unspecified).AddTicks(9483), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 20, 8, 24, 30, 596, DateTimeKind.Unspecified).AddTicks(5973), new TimeSpan(0, 7, 0, 0, 0)), "Port Alvinamouth" },
                    { 37, new DateTimeOffset(new DateTime(2020, 10, 12, 6, 44, 36, 651, DateTimeKind.Unspecified).AddTicks(734), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 30, 3, 13, 56, 240, DateTimeKind.Unspecified).AddTicks(6919), new TimeSpan(0, 7, 0, 0, 0)), "Sporerland" },
                    { 38, new DateTimeOffset(new DateTime(2020, 6, 20, 18, 3, 17, 130, DateTimeKind.Unspecified).AddTicks(2827), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 10, 23, 15, 48, 6, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 7, 0, 0, 0)), "East Joyceberg" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { 39, new DateTimeOffset(new DateTime(2020, 4, 21, 22, 23, 28, 2, DateTimeKind.Unspecified).AddTicks(2845), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 8, 6, 0, 38, 9, 279, DateTimeKind.Unspecified).AddTicks(7183), new TimeSpan(0, 7, 0, 0, 0)), "Jonasshire" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 40, new DateTimeOffset(new DateTime(2020, 8, 20, 2, 42, 5, 684, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 29, 17, 48, 19, 865, DateTimeKind.Unspecified).AddTicks(6258), new TimeSpan(0, 7, 0, 0, 0)), "Howellside" },
                    { 41, new DateTimeOffset(new DateTime(2020, 5, 5, 7, 40, 4, 153, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 5, 4, 40, 2, 547, DateTimeKind.Unspecified).AddTicks(6549), new TimeSpan(0, 7, 0, 0, 0)), "South Kaylastad" },
                    { 42, new DateTimeOffset(new DateTime(2020, 8, 31, 13, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 1, 19, 13, 11, 383, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 7, 0, 0, 0)), "Izabellamouth" },
                    { 43, new DateTimeOffset(new DateTime(2020, 10, 26, 4, 10, 53, 704, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 11, 14, 43, 3, 786, DateTimeKind.Unspecified).AddTicks(1844), new TimeSpan(0, 7, 0, 0, 0)), "Kobymouth" },
                    { 44, new DateTimeOffset(new DateTime(2020, 9, 11, 9, 21, 24, 742, DateTimeKind.Unspecified).AddTicks(5141), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 22, 12, 49, 53, 385, DateTimeKind.Unspecified).AddTicks(5153), new TimeSpan(0, 7, 0, 0, 0)), "South Amie" },
                    { 45, new DateTimeOffset(new DateTime(2020, 1, 13, 17, 20, 7, 146, DateTimeKind.Unspecified).AddTicks(8644), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 30, 20, 9, 54, 142, DateTimeKind.Unspecified).AddTicks(6302), new TimeSpan(0, 7, 0, 0, 0)), "West Wendy" },
                    { 46, new DateTimeOffset(new DateTime(2020, 1, 27, 16, 55, 50, 381, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 22, 7, 33, 11, 275, DateTimeKind.Unspecified).AddTicks(6197), new TimeSpan(0, 7, 0, 0, 0)), "North Kaci" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 47, new DateTimeOffset(new DateTime(2020, 2, 7, 14, 50, 43, 347, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 17, 23, 54, 58, 995, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 7, 0, 0, 0)), "Samantaport" },
                    { 48, new DateTimeOffset(new DateTime(2020, 4, 25, 8, 5, 58, 449, DateTimeKind.Unspecified).AddTicks(6619), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 4, 26, 23, 7, 4, 673, DateTimeKind.Unspecified).AddTicks(9507), new TimeSpan(0, 7, 0, 0, 0)), "East Warrenfort" },
                    { 49, new DateTimeOffset(new DateTime(2020, 6, 11, 10, 26, 47, 283, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 23, 18, 32, 16, 422, DateTimeKind.Unspecified).AddTicks(5192), new TimeSpan(0, 7, 0, 0, 0)), "New Preston" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 50, new DateTimeOffset(new DateTime(2020, 8, 19, 6, 2, 10, 193, DateTimeKind.Unspecified).AddTicks(6713), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 5, 5, 4, 23, 45, 761, DateTimeKind.Unspecified).AddTicks(4016), new TimeSpan(0, 7, 0, 0, 0)), "Port Marleyburgh" });

            migrationBuilder.InsertData(
                table: "Date",
                columns: new[] { "Id", "CreatedOnUtc", "DateStatus", "DateWorking", "IsDeleted", "ModifiedOnUtc" },
                values: new object[,]
                {
                    { new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"), new DateTimeOffset(new DateTime(2024, 6, 6, 22, 10, 49, 533, DateTimeKind.Unspecified).AddTicks(8630), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 3, 20, 19, 4, 0, 30, DateTimeKind.Local).AddTicks(8682), false, new DateTimeOffset(new DateTime(2024, 1, 13, 13, 26, 44, 369, DateTimeKind.Unspecified).AddTicks(7477), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"), new DateTimeOffset(new DateTime(2023, 7, 17, 0, 22, 53, 566, DateTimeKind.Unspecified).AddTicks(3015), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 12, 30, 5, 40, 44, 377, DateTimeKind.Local).AddTicks(6143), true, new DateTimeOffset(new DateTime(2023, 12, 17, 9, 30, 1, 567, DateTimeKind.Unspecified).AddTicks(2544), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"), new DateTimeOffset(new DateTime(2023, 10, 7, 5, 59, 55, 946, DateTimeKind.Unspecified).AddTicks(9454), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 12, 30, 23, 49, 30, 303, DateTimeKind.Local).AddTicks(7781), false, new DateTimeOffset(new DateTime(2023, 8, 19, 10, 37, 17, 146, DateTimeKind.Unspecified).AddTicks(5317), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("0b40e562-d9b5-504a-8985-07682b0d588f"), new DateTimeOffset(new DateTime(2023, 9, 27, 14, 56, 54, 221, DateTimeKind.Unspecified).AddTicks(1264), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 8, 22, 7, 2, 27, 22, DateTimeKind.Local).AddTicks(2313), true, new DateTimeOffset(new DateTime(2024, 6, 10, 0, 31, 45, 450, DateTimeKind.Unspecified).AddTicks(4354), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("15c913df-778a-5837-5d13-48652553d7ec"), new DateTimeOffset(new DateTime(2024, 3, 22, 1, 31, 31, 269, DateTimeKind.Unspecified).AddTicks(953), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 10, 6, 8, 40, 20, 180, DateTimeKind.Local).AddTicks(3666), true, new DateTimeOffset(new DateTime(2024, 3, 7, 20, 26, 31, 724, DateTimeKind.Unspecified).AddTicks(9731), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"), new DateTimeOffset(new DateTime(2023, 6, 27, 11, 18, 31, 353, DateTimeKind.Unspecified).AddTicks(5115), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 12, 15, 11, 34, 10, 702, DateTimeKind.Local).AddTicks(7918), false, new DateTimeOffset(new DateTime(2023, 8, 15, 12, 1, 8, 196, DateTimeKind.Unspecified).AddTicks(5746), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"), new DateTimeOffset(new DateTime(2023, 11, 1, 3, 9, 26, 387, DateTimeKind.Unspecified).AddTicks(6905), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 6, 18, 15, 37, 4, 470, DateTimeKind.Local).AddTicks(2081), true, new DateTimeOffset(new DateTime(2024, 4, 8, 4, 51, 31, 185, DateTimeKind.Unspecified).AddTicks(9751), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("2cedef5f-ad0e-74dc-db76-88646ffd2dc4"), new DateTimeOffset(new DateTime(2023, 11, 20, 16, 58, 18, 935, DateTimeKind.Unspecified).AddTicks(5506), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 6, 26, 0, 49, 5, 315, DateTimeKind.Local).AddTicks(7673), true, new DateTimeOffset(new DateTime(2024, 5, 22, 20, 23, 28, 806, DateTimeKind.Unspecified).AddTicks(3449), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("2dd53712-d464-ab85-d589-e18ec580c88b"), new DateTimeOffset(new DateTime(2023, 12, 6, 14, 2, 48, 860, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 2, 15, 3, 1, 46, 813, DateTimeKind.Local).AddTicks(1340), false, new DateTimeOffset(new DateTime(2023, 12, 14, 2, 17, 34, 67, DateTimeKind.Unspecified).AddTicks(2324), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), new DateTimeOffset(new DateTime(2024, 5, 19, 18, 39, 33, 734, DateTimeKind.Unspecified).AddTicks(1555), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 10, 12, 14, 39, 42, 154, DateTimeKind.Local).AddTicks(1925), true, new DateTimeOffset(new DateTime(2024, 2, 24, 20, 34, 11, 580, DateTimeKind.Unspecified).AddTicks(7799), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"), new DateTimeOffset(new DateTime(2023, 8, 17, 11, 0, 12, 864, DateTimeKind.Unspecified).AddTicks(9173), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 1, 9, 4, 45, 9, 509, DateTimeKind.Local).AddTicks(3154), true, new DateTimeOffset(new DateTime(2023, 7, 25, 23, 14, 4, 364, DateTimeKind.Unspecified).AddTicks(6323), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("33c32f2c-6294-2427-27ce-133348d2a829"), new DateTimeOffset(new DateTime(2023, 11, 2, 9, 44, 50, 544, DateTimeKind.Unspecified).AddTicks(5525), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 7, 16, 3, 57, 44, 643, DateTimeKind.Local).AddTicks(594), true, new DateTimeOffset(new DateTime(2024, 3, 19, 8, 32, 7, 520, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("41cd8dba-2c1f-9307-b7df-385c9a4619ab"), new DateTimeOffset(new DateTime(2023, 10, 27, 16, 34, 30, 354, DateTimeKind.Unspecified).AddTicks(9616), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 6, 29, 1, 35, 14, 811, DateTimeKind.Local).AddTicks(5042), false, new DateTimeOffset(new DateTime(2024, 3, 4, 4, 13, 38, 803, DateTimeKind.Unspecified).AddTicks(5319), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), new DateTimeOffset(new DateTime(2024, 2, 4, 5, 14, 31, 201, DateTimeKind.Unspecified).AddTicks(5884), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 7, 9, 18, 51, 28, 537, DateTimeKind.Local).AddTicks(1866), false, new DateTimeOffset(new DateTime(2023, 11, 19, 1, 32, 26, 410, DateTimeKind.Unspecified).AddTicks(3283), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"), new DateTimeOffset(new DateTime(2023, 8, 2, 3, 49, 38, 409, DateTimeKind.Unspecified).AddTicks(8495), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 8, 13, 23, 8, 19, 975, DateTimeKind.Local).AddTicks(8626), true, new DateTimeOffset(new DateTime(2023, 12, 11, 12, 53, 54, 58, DateTimeKind.Unspecified).AddTicks(54), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), new DateTimeOffset(new DateTime(2023, 7, 5, 7, 17, 37, 41, DateTimeKind.Unspecified).AddTicks(7103), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 4, 2, 17, 3, 37, 853, DateTimeKind.Local).AddTicks(2250), false, new DateTimeOffset(new DateTime(2023, 8, 23, 6, 19, 13, 322, DateTimeKind.Unspecified).AddTicks(8334), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), new DateTimeOffset(new DateTime(2024, 5, 8, 15, 50, 10, 419, DateTimeKind.Unspecified).AddTicks(7499), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 9, 9, 1, 39, 51, 185, DateTimeKind.Local).AddTicks(1261), true, new DateTimeOffset(new DateTime(2024, 4, 5, 19, 43, 31, 713, DateTimeKind.Unspecified).AddTicks(6379), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), new DateTimeOffset(new DateTime(2024, 5, 20, 7, 2, 35, 384, DateTimeKind.Unspecified).AddTicks(6635), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 6, 22, 8, 19, 17, 495, DateTimeKind.Local).AddTicks(2494), true, new DateTimeOffset(new DateTime(2023, 9, 13, 4, 22, 10, 993, DateTimeKind.Unspecified).AddTicks(3300), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("65d2756d-3dd3-155c-3a97-87de8ded6a3a"), new DateTimeOffset(new DateTime(2024, 3, 9, 12, 40, 38, 410, DateTimeKind.Unspecified).AddTicks(2212), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 12, 16, 9, 34, 49, 795, DateTimeKind.Local).AddTicks(7314), true, new DateTimeOffset(new DateTime(2023, 7, 14, 5, 19, 17, 962, DateTimeKind.Unspecified).AddTicks(3698), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), new DateTimeOffset(new DateTime(2024, 6, 21, 7, 48, 37, 104, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 7, 8, 20, 2, 9, 779, DateTimeKind.Local).AddTicks(8201), true, new DateTimeOffset(new DateTime(2023, 8, 27, 11, 29, 50, 453, DateTimeKind.Unspecified).AddTicks(6392), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("72ff2f81-65bc-ae2b-5287-501db8b47d7f"), new DateTimeOffset(new DateTime(2023, 10, 30, 11, 52, 19, 350, DateTimeKind.Unspecified).AddTicks(4395), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 5, 23, 22, 23, 0, 281, DateTimeKind.Local).AddTicks(3952), true, new DateTimeOffset(new DateTime(2023, 8, 10, 4, 18, 33, 653, DateTimeKind.Unspecified).AddTicks(2002), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"), new DateTimeOffset(new DateTime(2023, 12, 22, 0, 31, 11, 149, DateTimeKind.Unspecified).AddTicks(2687), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 5, 13, 16, 20, 19, 436, DateTimeKind.Local).AddTicks(7027), false, new DateTimeOffset(new DateTime(2024, 5, 7, 20, 51, 45, 957, DateTimeKind.Unspecified).AddTicks(4246), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("7ee018f5-529b-b002-62f6-8e93af65c0a8"), new DateTimeOffset(new DateTime(2024, 3, 25, 11, 40, 10, 96, DateTimeKind.Unspecified).AddTicks(3980), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 8, 13, 8, 12, 1, 739, DateTimeKind.Local).AddTicks(8686), false, new DateTimeOffset(new DateTime(2024, 3, 29, 9, 0, 35, 973, DateTimeKind.Unspecified).AddTicks(6311), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), new DateTimeOffset(new DateTime(2024, 5, 14, 22, 52, 50, 718, DateTimeKind.Unspecified).AddTicks(1877), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 4, 23, 17, 1, 54, 101, DateTimeKind.Local).AddTicks(679), false, new DateTimeOffset(new DateTime(2024, 4, 28, 16, 9, 21, 566, DateTimeKind.Unspecified).AddTicks(1248), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"), new DateTimeOffset(new DateTime(2024, 2, 29, 8, 36, 32, 951, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 7, 10, 15, 31, 50, 33, DateTimeKind.Local).AddTicks(1481), false, new DateTimeOffset(new DateTime(2024, 2, 2, 10, 28, 25, 798, DateTimeKind.Unspecified).AddTicks(3866), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), new DateTimeOffset(new DateTime(2023, 11, 8, 10, 52, 33, 174, DateTimeKind.Unspecified).AddTicks(7461), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 12, 28, 10, 57, 34, 485, DateTimeKind.Local).AddTicks(5233), false, new DateTimeOffset(new DateTime(2024, 6, 19, 4, 6, 42, 717, DateTimeKind.Unspecified).AddTicks(9578), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"), new DateTimeOffset(new DateTime(2023, 8, 26, 20, 34, 13, 919, DateTimeKind.Unspecified).AddTicks(8058), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 12, 19, 23, 20, 4, 711, DateTimeKind.Local).AddTicks(1793), false, new DateTimeOffset(new DateTime(2024, 2, 15, 19, 7, 27, 236, DateTimeKind.Unspecified).AddTicks(6788), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"), new DateTimeOffset(new DateTime(2024, 1, 12, 20, 20, 27, 644, DateTimeKind.Unspecified).AddTicks(4107), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 3, 6, 3, 41, 58, 848, DateTimeKind.Local).AddTicks(7513), true, new DateTimeOffset(new DateTime(2023, 12, 26, 5, 5, 41, 315, DateTimeKind.Unspecified).AddTicks(6180), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"), new DateTimeOffset(new DateTime(2024, 1, 2, 5, 8, 43, 503, DateTimeKind.Unspecified).AddTicks(1587), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 2, 23, 1, 14, 19, 133, DateTimeKind.Local).AddTicks(1690), false, new DateTimeOffset(new DateTime(2024, 4, 8, 19, 12, 38, 546, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new DateTimeOffset(new DateTime(2023, 10, 1, 21, 3, 0, 718, DateTimeKind.Unspecified).AddTicks(9037), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 10, 12, 5, 3, 15, 790, DateTimeKind.Local).AddTicks(3988), true, new DateTimeOffset(new DateTime(2024, 5, 23, 23, 11, 32, 200, DateTimeKind.Unspecified).AddTicks(1082), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("97581a8f-780f-3896-228c-51e74509eb80"), new DateTimeOffset(new DateTime(2024, 3, 22, 6, 40, 3, 126, DateTimeKind.Unspecified).AddTicks(1715), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 10, 5, 12, 51, 19, 870, DateTimeKind.Local).AddTicks(8108), true, new DateTimeOffset(new DateTime(2023, 9, 22, 10, 54, 46, 747, DateTimeKind.Unspecified).AddTicks(4035), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 23, 33, 559, DateTimeKind.Unspecified).AddTicks(6000), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 7, 15, 20, 2, 38, 14, DateTimeKind.Local).AddTicks(1007), true, new DateTimeOffset(new DateTime(2023, 10, 26, 2, 43, 39, 64, DateTimeKind.Unspecified).AddTicks(2922), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"), new DateTimeOffset(new DateTime(2023, 11, 19, 5, 50, 12, 24, DateTimeKind.Unspecified).AddTicks(2146), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 3, 29, 5, 10, 18, 506, DateTimeKind.Local).AddTicks(7592), true, new DateTimeOffset(new DateTime(2024, 1, 17, 11, 17, 9, 578, DateTimeKind.Unspecified).AddTicks(9318), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a951f11b-2234-b35b-f424-5420ad1a71ce"), new DateTimeOffset(new DateTime(2023, 10, 28, 17, 22, 40, 823, DateTimeKind.Unspecified).AddTicks(9717), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 3, 5, 11, 54, 47, 757, DateTimeKind.Local).AddTicks(8273), true, new DateTimeOffset(new DateTime(2023, 11, 5, 18, 59, 36, 926, DateTimeKind.Unspecified).AddTicks(8071), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a99052b6-a953-00fb-7f94-ad45509c5449"), new DateTimeOffset(new DateTime(2024, 5, 5, 20, 26, 26, 131, DateTimeKind.Unspecified).AddTicks(5938), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 2, 8, 5, 18, 9, 598, DateTimeKind.Local).AddTicks(3127), true, new DateTimeOffset(new DateTime(2024, 5, 7, 22, 55, 47, 136, DateTimeKind.Unspecified).AddTicks(6243), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), new DateTimeOffset(new DateTime(2024, 2, 29, 21, 53, 28, 770, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 12, 14, 0, 7, 7, 452, DateTimeKind.Local).AddTicks(6197), false, new DateTimeOffset(new DateTime(2024, 5, 27, 10, 35, 31, 217, DateTimeKind.Unspecified).AddTicks(1108), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("c764ce19-c657-b651-c26d-f786a83ce646"), new DateTimeOffset(new DateTime(2024, 4, 26, 3, 33, 5, 798, DateTimeKind.Unspecified).AddTicks(304), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 2, 22, 3, 13, 50, 82, DateTimeKind.Local).AddTicks(7932), false, new DateTimeOffset(new DateTime(2023, 11, 24, 13, 38, 49, 208, DateTimeKind.Unspecified).AddTicks(806), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("c962b121-02f9-08e5-cf11-8995c540a761"), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 3, 21, 803, DateTimeKind.Unspecified).AddTicks(3193), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 2, 15, 5, 57, 49, 953, DateTimeKind.Local).AddTicks(1926), false, new DateTimeOffset(new DateTime(2024, 5, 24, 5, 58, 42, 991, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), new DateTimeOffset(new DateTime(2024, 2, 29, 13, 51, 13, 604, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 11, 8, 10, 17, 26, 790, DateTimeKind.Local).AddTicks(2479), false, new DateTimeOffset(new DateTime(2023, 9, 3, 4, 4, 32, 280, DateTimeKind.Unspecified).AddTicks(3375), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"), new DateTimeOffset(new DateTime(2024, 5, 21, 20, 31, 51, 96, DateTimeKind.Unspecified).AddTicks(9267), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 7, 12, 20, 43, 52, 737, DateTimeKind.Local).AddTicks(5104), false, new DateTimeOffset(new DateTime(2024, 2, 11, 9, 59, 25, 339, DateTimeKind.Unspecified).AddTicks(3413), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("d40d725e-c366-8b4f-8503-1295b3ba6483"), new DateTimeOffset(new DateTime(2023, 10, 4, 22, 5, 34, 588, DateTimeKind.Unspecified).AddTicks(3112), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 8, 16, 2, 18, 51, 876, DateTimeKind.Local).AddTicks(1495), false, new DateTimeOffset(new DateTime(2023, 7, 10, 17, 26, 43, 165, DateTimeKind.Unspecified).AddTicks(746), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"), new DateTimeOffset(new DateTime(2024, 6, 23, 6, 47, 14, 928, DateTimeKind.Unspecified).AddTicks(1916), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 8, 2, 20, 50, 53, 604, DateTimeKind.Local).AddTicks(6118), true, new DateTimeOffset(new DateTime(2023, 10, 17, 23, 37, 57, 738, DateTimeKind.Unspecified).AddTicks(1356), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), new DateTimeOffset(new DateTime(2023, 12, 25, 6, 30, 19, 958, DateTimeKind.Unspecified).AddTicks(2600), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 5, 28, 9, 41, 33, 328, DateTimeKind.Local).AddTicks(7826), true, new DateTimeOffset(new DateTime(2023, 9, 15, 22, 45, 29, 626, DateTimeKind.Unspecified).AddTicks(1623), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"), new DateTimeOffset(new DateTime(2024, 5, 11, 0, 22, 1, 57, DateTimeKind.Unspecified).AddTicks(4985), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2023, 8, 11, 19, 17, 59, 730, DateTimeKind.Local).AddTicks(6017), true, new DateTimeOffset(new DateTime(2023, 12, 16, 11, 36, 2, 16, DateTimeKind.Unspecified).AddTicks(5583), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), new DateTimeOffset(new DateTime(2023, 8, 5, 12, 54, 38, 856, DateTimeKind.Unspecified).AddTicks(6894), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 4, 28, 8, 1, 43, 120, DateTimeKind.Local).AddTicks(8718), true, new DateTimeOffset(new DateTime(2023, 7, 6, 16, 34, 47, 457, DateTimeKind.Unspecified).AddTicks(1095), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("e7e2d28b-02d4-3311-7a1c-f2134f0c6634"), new DateTimeOffset(new DateTime(2023, 8, 24, 11, 48, 9, 522, DateTimeKind.Unspecified).AddTicks(3086), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 10, 20, 12, 57, 43, 923, DateTimeKind.Local).AddTicks(9287), false, new DateTimeOffset(new DateTime(2023, 10, 10, 7, 47, 32, 620, DateTimeKind.Unspecified).AddTicks(5643), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), new DateTimeOffset(new DateTime(2023, 6, 29, 18, 46, 19, 858, DateTimeKind.Unspecified).AddTicks(7706), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 5, 12, 11, 46, 59, 245, DateTimeKind.Local).AddTicks(4421), true, new DateTimeOffset(new DateTime(2023, 12, 22, 3, 23, 21, 673, DateTimeKind.Unspecified).AddTicks(3416), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("f24616bd-e6a9-6c93-6269-33ef855ab90a"), new DateTimeOffset(new DateTime(2024, 5, 22, 11, 31, 52, 686, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2023, 9, 27, 5, 40, 1, 701, DateTimeKind.Local).AddTicks(9995), true, new DateTimeOffset(new DateTime(2024, 6, 10, 17, 2, 40, 506, DateTimeKind.Unspecified).AddTicks(3342), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), new DateTimeOffset(new DateTime(2024, 1, 3, 11, 59, 22, 294, DateTimeKind.Unspecified).AddTicks(2645), new TimeSpan(0, 7, 0, 0, 0)), "Closed", new DateTime(2024, 5, 14, 12, 11, 43, 450, DateTimeKind.Local).AddTicks(6547), true, new DateTimeOffset(new DateTime(2024, 2, 21, 18, 49, 30, 977, DateTimeKind.Unspecified).AddTicks(8966), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"), new DateTimeOffset(new DateTime(2023, 10, 6, 19, 32, 33, 400, DateTimeKind.Unspecified).AddTicks(8546), new TimeSpan(0, 7, 0, 0, 0)), "Open", new DateTime(2024, 1, 8, 9, 21, 2, 524, DateTimeKind.Local).AddTicks(7345), true, new DateTimeOffset(new DateTime(2024, 6, 16, 8, 12, 26, 39, DateTimeKind.Unspecified).AddTicks(4773), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DayOfBirth", "Email", "EmailConfirmed", "FirstName", "FullName", "IdentityId", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SupervisorId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d"), 0, "8d3318d3-39fa-421f-b235-0f08ea01272f", new DateTime(2020, 2, 15, 22, 25, 49, 504, DateTimeKind.Unspecified).AddTicks(7156), null, false, "Cesar", "Cesar D'Amore", "60cac736-031a-8499-17fd-2e0d492832ad", "D'Amore", "South Malachi", false, null, null, null, null, null, false, null, new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d"), false, null },
                    { new Guid("4fbc87d7-b534-95ce-0699-083d05b4056f"), 0, "5c512bae-a357-4740-a53f-c02c0fbd314e", new DateTime(2020, 10, 31, 4, 49, 30, 258, DateTimeKind.Unspecified).AddTicks(7983), null, false, "Rosemarie", "Rosemarie Bins", "ee128404-8a8e-fabf-9a60-dbef3ffb7207", "Bins", "New Isidrostad", false, null, null, null, null, null, false, null, new Guid("11cf08e5-9589-40c5-a761-187ed55224f6"), false, null },
                    { new Guid("5e457116-2bfb-9936-853d-5adc0468ba06"), 0, "b713f57e-c21b-4118-a8f8-a0f177692505", new DateTime(2020, 9, 21, 15, 24, 5, 101, DateTimeKind.Unspecified).AddTicks(3406), null, false, "Clay", "Clay Hills", "21c0576e-7134-0c2c-d1d6-a70dc0be6e42", "Hills", "Gaylordland", false, null, null, null, null, null, false, null, new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d"), false, null },
                    { new Guid("606f1107-4340-3d79-81f8-5d8b09c12c47"), 0, "df81868f-6647-4eb2-a6bb-61e2069d19f3", new DateTime(2020, 8, 16, 2, 16, 17, 355, DateTimeKind.Unspecified).AddTicks(2873), null, false, "Kimberly", "Kimberly Roberts", "d00c731a-22e1-2a78-d380-652c3a592a59", "Roberts", "East Monicaborough", false, null, null, null, null, null, false, null, new Guid("0ac39d47-a580-388c-334e-c36e77d4acb7"), false, null },
                    { new Guid("6100e542-8ed9-94dd-02eb-d05d806edcfa"), 0, "3d3a93e9-e1c3-4b45-a840-4a70d0cfd29e", new DateTime(2020, 5, 25, 8, 24, 54, 644, DateTimeKind.Unspecified).AddTicks(8273), null, false, "Kristie", "Kristie Labadie", "711c0772-c209-41d8-663f-88e46829d7af", "Labadie", "Caseymouth", false, null, null, null, null, null, false, null, new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), false, null },
                    { new Guid("779c3b8b-7dec-380d-7eeb-ec94e998eb0c"), 0, "2dbaf2e6-ef1b-4301-a88a-c731ba26f8eb", new DateTime(2020, 9, 8, 9, 39, 18, 144, DateTimeKind.Unspecified).AddTicks(9000), null, false, "Katherine", "Katherine Muller", "474c1fa7-ae73-0ce3-1006-428e31ba3452", "Muller", "South Eunaton", false, null, null, null, null, null, false, null, new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), false, null },
                    { new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc"), 0, "c1a413fc-69d5-4ff1-ac0c-401e9185b1b1", new DateTime(2020, 1, 20, 21, 3, 20, 574, DateTimeKind.Unspecified).AddTicks(2441), null, false, "Jerry", "Jerry O'Kon", "00af2f42-9ce6-645d-bfe6-9d7cdf8189f2", "O'Kon", "New Kelli", false, null, null, null, null, null, false, null, new Guid("dae37e73-50c0-d5c8-97c6-5a7041370998"), false, null },
                    { new Guid("81fda1d4-fa16-093d-7e66-c5fd012c2fc3"), 0, "f1e8609d-ccd1-4e08-8df9-783f328b03d3", new DateTime(2020, 10, 1, 0, 17, 10, 15, DateTimeKind.Unspecified).AddTicks(7373), null, false, "Phillip", "Phillip Hoppe", "40a4d600-2b2f-ee60-79b4-53e39036dfc7", "Hoppe", "Reichertberg", false, null, null, null, null, null, false, null, new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d"), false, null },
                    { new Guid("837c4af8-1b95-302e-d982-d3e35c19fca2"), 0, "2578fac4-c7af-4630-9170-07cc241bea9c", new DateTime(2020, 4, 1, 23, 20, 22, 263, DateTimeKind.Unspecified).AddTicks(3887), null, false, "Cassandra", "Cassandra Smitham", "a957cd73-8de9-2e76-3754-d34cf08bd2e2", "Smitham", "Maciehaven", false, null, null, null, null, null, false, null, new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), false, null },
                    { new Guid("8bdb736b-89b7-be24-1c15-31f7e7421644"), 0, "db5abe3d-4a07-4a2c-8d65-246a6d3dcfc8", new DateTime(2020, 10, 28, 22, 8, 12, 468, DateTimeKind.Unspecified).AddTicks(1632), null, false, "Hugo", "Hugo Gorczany", "243f0bad-197e-d4a8-f6bf-35f9c96c0c72", "Gorczany", "Murrayburgh", false, null, null, null, null, null, false, null, new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42"), false, null },
                    { new Guid("99b466ff-4c41-07d6-7020-a9f28b403607"), 0, "07f88a99-6037-4129-a900-660a37b5c160", new DateTime(2020, 5, 3, 18, 55, 34, 193, DateTimeKind.Unspecified).AddTicks(5341), null, false, "Sophie", "Sophie Klein", "c1cdd83b-62c0-ad47-43cd-22ef565bec52", "Klein", "Lourdesberg", false, null, null, null, null, null, false, null, new Guid("0ac39d47-a580-388c-334e-c36e77d4acb7"), false, null },
                    { new Guid("9fcce051-4f9f-f1f2-63d6-b684ab1f528f"), 0, "090d99e6-c461-4a5c-9592-14fda0e96d0e", new DateTime(2020, 4, 28, 17, 4, 12, 830, DateTimeKind.Unspecified).AddTicks(8171), null, false, "Donna", "Donna Kulas", "07c89a3b-31c8-b2f3-0b9f-f233689f2b10", "Kulas", "McLaughlinton", false, null, null, null, null, null, false, null, new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), false, null },
                    { new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f"), 0, "4229a927-3032-46f8-9fe1-71403f9395c3", new DateTime(2020, 6, 6, 14, 14, 59, 560, DateTimeKind.Unspecified).AddTicks(2355), null, false, "Danny", "Danny Armstrong", "2fd8dec3-11a8-7963-28c8-2ad32a72b863", "Armstrong", "Deckowtown", false, null, null, null, null, null, false, null, new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d"), false, null },
                    { new Guid("f12096d7-2697-2757-cded-e8d3504da036"), 0, "ae2e34a4-77a3-4397-91c7-0cd9693affd7", new DateTime(2020, 9, 11, 16, 37, 31, 237, DateTimeKind.Unspecified).AddTicks(1700), null, false, "Horace", "Horace Bechtelar", "20326fb8-3857-8460-a554-5ff507db5335", "Bechtelar", "Lake Anabelmouth", false, null, null, null, null, null, false, null, new Guid("0ac39d47-a580-388c-334e-c36e77d4acb7"), false, null },
                    { new Guid("f2fa31c8-ab7a-ac0b-5f1e-9b3f2bcd52f0"), 0, "dc3df2d3-ddb8-4e30-a1f5-fbf06597a05b", new DateTime(2020, 6, 16, 3, 22, 12, 109, DateTimeKind.Unspecified).AddTicks(4972), null, false, "Sheila", "Sheila McLaughlin", "edef5f70-0e2c-dcad-74db-7688646ffd2d", "McLaughlin", "Christiansenstad", false, null, null, null, null, null, false, null, new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), false, null },
                    { new Guid("f4b6b354-f64b-e238-6806-00f403e85ab4"), 0, "6e293a81-6c9a-41f7-bd34-c39191a1590a", new DateTime(2020, 2, 25, 21, 27, 30, 846, DateTimeKind.Unspecified).AddTicks(6440), null, false, "Brandy", "Brandy Mohr", "f6193d92-7585-9af0-6f12-4ce033c975f0", "Mohr", "South Ralphmouth", false, null, null, null, null, null, false, null, new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), false, null }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 1, 39, new DateTimeOffset(new DateTime(2020, 11, 22, 2, 30, 11, 875, DateTimeKind.Unspecified).AddTicks(9674), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 10, 18, 7, 9, 466, DateTimeKind.Unspecified).AddTicks(5804), new TimeSpan(0, 7, 0, 0, 0)), "East Winnifred" });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 2, 23, new DateTimeOffset(new DateTime(2020, 12, 29, 5, 34, 57, 8, DateTimeKind.Unspecified).AddTicks(8054), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 28, 7, 57, 47, 122, DateTimeKind.Unspecified).AddTicks(2925), new TimeSpan(0, 7, 0, 0, 0)), "North Novatown" },
                    { 3, 14, new DateTimeOffset(new DateTime(2020, 11, 29, 10, 12, 37, 137, DateTimeKind.Unspecified).AddTicks(6391), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 1, 18, 0, 40, 732, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, 7, 0, 0, 0)), "Darronchester" },
                    { 4, 17, new DateTimeOffset(new DateTime(2020, 5, 6, 19, 13, 45, 178, DateTimeKind.Unspecified).AddTicks(6852), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 1, 27, 18, 40, 14, 889, DateTimeKind.Unspecified).AddTicks(4474), new TimeSpan(0, 7, 0, 0, 0)), "Sonyafort" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 5, 35, new DateTimeOffset(new DateTime(2020, 12, 17, 20, 11, 26, 629, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 29, 4, 10, 31, 221, DateTimeKind.Unspecified).AddTicks(2731), new TimeSpan(0, 7, 0, 0, 0)), "Wuckertton" });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 6, 35, new DateTimeOffset(new DateTime(2020, 12, 17, 4, 3, 45, 443, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 23, 14, 5, 17, 780, DateTimeKind.Unspecified).AddTicks(6107), new TimeSpan(0, 7, 0, 0, 0)), "Marleyton" },
                    { 7, 25, new DateTimeOffset(new DateTime(2020, 7, 6, 4, 39, 34, 443, DateTimeKind.Unspecified).AddTicks(2006), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 8, 28, 18, 0, 20, 743, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 7, 0, 0, 0)), "Lynchtown" },
                    { 8, 33, new DateTimeOffset(new DateTime(2020, 5, 28, 2, 14, 44, 345, DateTimeKind.Unspecified).AddTicks(3713), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 26, 18, 4, 23, 383, DateTimeKind.Unspecified).AddTicks(8763), new TimeSpan(0, 7, 0, 0, 0)), "Antwonside" },
                    { 9, 22, new DateTimeOffset(new DateTime(2020, 8, 27, 6, 3, 16, 777, DateTimeKind.Unspecified).AddTicks(6594), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 19, 20, 46, 30, 233, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 7, 0, 0, 0)), "West Macyhaven" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 10, 40, new DateTimeOffset(new DateTime(2020, 6, 20, 2, 54, 43, 526, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 5, 29, 5, 5, 50, 377, DateTimeKind.Unspecified).AddTicks(5220), new TimeSpan(0, 7, 0, 0, 0)), "Wisozkville" },
                    { 11, 28, new DateTimeOffset(new DateTime(2020, 12, 4, 9, 2, 9, 344, DateTimeKind.Unspecified).AddTicks(5560), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 3, 3, 4, 6, 51, 355, DateTimeKind.Unspecified).AddTicks(4368), new TimeSpan(0, 7, 0, 0, 0)), "Amaliafort" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 12, 17, new DateTimeOffset(new DateTime(2020, 5, 21, 10, 14, 36, 581, DateTimeKind.Unspecified).AddTicks(468), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 13, 22, 5, 44, 562, DateTimeKind.Unspecified).AddTicks(7091), new TimeSpan(0, 7, 0, 0, 0)), "Cummeratastad" },
                    { 13, 46, new DateTimeOffset(new DateTime(2020, 9, 30, 14, 49, 12, 324, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 6, 7, 17, 1, 420, DateTimeKind.Unspecified).AddTicks(6102), new TimeSpan(0, 7, 0, 0, 0)), "South Sylvanmouth" },
                    { 14, 22, new DateTimeOffset(new DateTime(2020, 10, 28, 10, 59, 58, 655, DateTimeKind.Unspecified).AddTicks(6819), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 15, 21, 18, 31, 727, DateTimeKind.Unspecified).AddTicks(7011), new TimeSpan(0, 7, 0, 0, 0)), "Port Morganbury" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 15, 16, new DateTimeOffset(new DateTime(2020, 12, 6, 5, 21, 48, 101, DateTimeKind.Unspecified).AddTicks(5170), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 25, 18, 12, 56, 262, DateTimeKind.Unspecified).AddTicks(39), new TimeSpan(0, 7, 0, 0, 0)), "Trantowfurt" });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { 16, 40, new DateTimeOffset(new DateTime(2020, 4, 1, 19, 9, 10, 198, DateTimeKind.Unspecified).AddTicks(6035), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 1, 12, 30, 59, 578, DateTimeKind.Unspecified).AddTicks(1059), new TimeSpan(0, 7, 0, 0, 0)), "East Mallie" });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 17, 15, new DateTimeOffset(new DateTime(2020, 2, 14, 11, 51, 42, 831, DateTimeKind.Unspecified).AddTicks(6846), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 11, 23, 52, 24, 808, DateTimeKind.Unspecified).AddTicks(2624), new TimeSpan(0, 7, 0, 0, 0)), "Jaynemouth" },
                    { 18, 14, new DateTimeOffset(new DateTime(2020, 11, 3, 6, 58, 6, 227, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 20, 9, 51, 34, 696, DateTimeKind.Unspecified).AddTicks(1255), new TimeSpan(0, 7, 0, 0, 0)), "Hayesburgh" },
                    { 19, 45, new DateTimeOffset(new DateTime(2020, 4, 15, 16, 56, 23, 292, DateTimeKind.Unspecified).AddTicks(5470), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 2, 20, 19, 20, 572, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, 7, 0, 0, 0)), "West Laura" },
                    { 20, 39, new DateTimeOffset(new DateTime(2020, 7, 12, 8, 29, 34, 78, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 22, 14, 2, 51, 750, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 7, 0, 0, 0)), "Fredericberg" },
                    { 21, 28, new DateTimeOffset(new DateTime(2020, 2, 10, 23, 56, 58, 613, DateTimeKind.Unspecified).AddTicks(4561), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 18, 15, 20, 19, 783, DateTimeKind.Unspecified).AddTicks(8340), new TimeSpan(0, 7, 0, 0, 0)), "Kyraside" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 22, 10, new DateTimeOffset(new DateTime(2020, 6, 23, 12, 32, 12, 163, DateTimeKind.Unspecified).AddTicks(1880), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 10, 7, 11, 10, 478, DateTimeKind.Unspecified).AddTicks(5587), new TimeSpan(0, 7, 0, 0, 0)), "New Elianside" },
                    { 23, 28, new DateTimeOffset(new DateTime(2020, 1, 14, 7, 3, 14, 717, DateTimeKind.Unspecified).AddTicks(2686), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 2, 7, 2, 25, 59, 444, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, 7, 0, 0, 0)), "Port Dashawn" },
                    { 24, 42, new DateTimeOffset(new DateTime(2020, 6, 26, 5, 5, 27, 517, DateTimeKind.Unspecified).AddTicks(3764), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 27, 10, 29, 24, 579, DateTimeKind.Unspecified).AddTicks(2079), new TimeSpan(0, 7, 0, 0, 0)), "North Nicolafurt" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 25, 28, new DateTimeOffset(new DateTime(2020, 4, 16, 16, 37, 14, 265, DateTimeKind.Unspecified).AddTicks(5460), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 10, 8, 37, 12, 680, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 7, 0, 0, 0)), "West Sammy" },
                    { 26, 20, new DateTimeOffset(new DateTime(2020, 4, 22, 7, 40, 1, 142, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 25, 18, 3, 40, 322, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 7, 0, 0, 0)), "East Adela" },
                    { 27, 15, new DateTimeOffset(new DateTime(2020, 4, 11, 16, 24, 31, 394, DateTimeKind.Unspecified).AddTicks(8093), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 31, 22, 40, 32, 707, DateTimeKind.Unspecified).AddTicks(1272), new TimeSpan(0, 7, 0, 0, 0)), "Fadelmouth" },
                    { 28, 17, new DateTimeOffset(new DateTime(2020, 4, 18, 14, 47, 43, 613, DateTimeKind.Unspecified).AddTicks(5945), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 26, 3, 56, 4, 181, DateTimeKind.Unspecified).AddTicks(3568), new TimeSpan(0, 7, 0, 0, 0)), "West Noeliamouth" },
                    { 29, 7, new DateTimeOffset(new DateTime(2020, 11, 14, 22, 4, 26, 740, DateTimeKind.Unspecified).AddTicks(7614), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 29, 16, 59, 47, 928, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 7, 0, 0, 0)), "West Chelsie" },
                    { 30, 28, new DateTimeOffset(new DateTime(2020, 3, 13, 19, 58, 27, 22, DateTimeKind.Unspecified).AddTicks(4382), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 8, 1, 24, 49, 712, DateTimeKind.Unspecified).AddTicks(1259), new TimeSpan(0, 7, 0, 0, 0)), "Felicitafort" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 31, 50, new DateTimeOffset(new DateTime(2020, 12, 15, 7, 7, 39, 460, DateTimeKind.Unspecified).AddTicks(3107), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 22, 23, 16, 1, 633, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 7, 0, 0, 0)), "DuBuqueside" },
                    { 32, 27, new DateTimeOffset(new DateTime(2020, 11, 14, 2, 51, 15, 357, DateTimeKind.Unspecified).AddTicks(1856), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 12, 6, 44, 36, 651, DateTimeKind.Unspecified).AddTicks(734), new TimeSpan(0, 7, 0, 0, 0)), "Schimmelhaven" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 33, 49, new DateTimeOffset(new DateTime(2020, 6, 20, 18, 3, 17, 130, DateTimeKind.Unspecified).AddTicks(2827), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 10, 23, 15, 48, 6, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 7, 0, 0, 0)), "East Joyceberg" },
                    { 34, 33, new DateTimeOffset(new DateTime(2020, 8, 6, 0, 38, 9, 279, DateTimeKind.Unspecified).AddTicks(7183), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 28, 7, 53, 42, 511, DateTimeKind.Unspecified).AddTicks(3480), new TimeSpan(0, 7, 0, 0, 0)), "Waldochester" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 35, 22, new DateTimeOffset(new DateTime(2020, 4, 24, 10, 39, 2, 675, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 3, 10, 18, 5, 858, DateTimeKind.Unspecified).AddTicks(9703), new TimeSpan(0, 7, 0, 0, 0)), "Hillltown" },
                    { 36, 28, new DateTimeOffset(new DateTime(2020, 5, 14, 3, 12, 33, 783, DateTimeKind.Unspecified).AddTicks(19), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 25, 23, 20, 49, 11, DateTimeKind.Unspecified).AddTicks(1012), new TimeSpan(0, 7, 0, 0, 0)), "Madysonmouth" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 37, 29, new DateTimeOffset(new DateTime(2020, 4, 12, 16, 32, 10, 830, DateTimeKind.Unspecified).AddTicks(564), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 3, 8, 46, 37, 837, DateTimeKind.Unspecified).AddTicks(3973), new TimeSpan(0, 7, 0, 0, 0)), "Port Sandy" });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 38, 10, new DateTimeOffset(new DateTime(2020, 7, 2, 16, 6, 46, 253, DateTimeKind.Unspecified).AddTicks(505), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 12, 16, 1, 50, 166, DateTimeKind.Unspecified).AddTicks(222), new TimeSpan(0, 7, 0, 0, 0)), "South Israel" },
                    { 39, 35, new DateTimeOffset(new DateTime(2020, 1, 9, 22, 48, 48, 21, DateTimeKind.Unspecified).AddTicks(6003), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 1, 13, 17, 20, 7, 146, DateTimeKind.Unspecified).AddTicks(8644), new TimeSpan(0, 7, 0, 0, 0)), "Hermanbury" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[] { 40, 45, new DateTimeOffset(new DateTime(2020, 1, 27, 16, 55, 50, 381, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 22, 7, 33, 11, 275, DateTimeKind.Unspecified).AddTicks(6197), new TimeSpan(0, 7, 0, 0, 0)), "North Kaci" });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 41, 28, new DateTimeOffset(new DateTime(2020, 6, 17, 23, 54, 58, 995, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 7, 13, 11, 57, 707, DateTimeKind.Unspecified).AddTicks(2001), new TimeSpan(0, 7, 0, 0, 0)), "Kunzeside" },
                    { 42, 9, new DateTimeOffset(new DateTime(2020, 4, 26, 23, 7, 4, 673, DateTimeKind.Unspecified).AddTicks(9507), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 26, 0, 59, 44, 247, DateTimeKind.Unspecified).AddTicks(663), new TimeSpan(0, 7, 0, 0, 0)), "Shanahanchester" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 43, 30, new DateTimeOffset(new DateTime(2020, 10, 22, 18, 16, 15, 692, DateTimeKind.Unspecified).AddTicks(9480), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 12, 9, 55, 20, 6, DateTimeKind.Unspecified).AddTicks(2292), new TimeSpan(0, 7, 0, 0, 0)), "Lynchville" },
                    { 44, 35, new DateTimeOffset(new DateTime(2020, 5, 13, 6, 0, 41, 864, DateTimeKind.Unspecified).AddTicks(2368), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 20, 12, 26, 24, 637, DateTimeKind.Unspecified).AddTicks(7343), new TimeSpan(0, 7, 0, 0, 0)), "West Mae" },
                    { 45, 43, new DateTimeOffset(new DateTime(2020, 12, 13, 1, 13, 26, 561, DateTimeKind.Unspecified).AddTicks(7776), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 1, 9, 51, 56, 591, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 7, 0, 0, 0)), "Harveyfort" },
                    { 46, 22, new DateTimeOffset(new DateTime(2020, 10, 12, 11, 17, 55, 968, DateTimeKind.Unspecified).AddTicks(5274), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 26, 20, 48, 52, 824, DateTimeKind.Unspecified).AddTicks(8567), new TimeSpan(0, 7, 0, 0, 0)), "South Vicentemouth" },
                    { 47, 27, new DateTimeOffset(new DateTime(2020, 10, 31, 8, 24, 2, 344, DateTimeKind.Unspecified).AddTicks(9299), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 10, 11, 40, 2, 824, DateTimeKind.Unspecified).AddTicks(6583), new TimeSpan(0, 7, 0, 0, 0)), "Eleazarshire" },
                    { 48, 29, new DateTimeOffset(new DateTime(2020, 4, 23, 18, 37, 12, 850, DateTimeKind.Unspecified).AddTicks(7244), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 23, 4, 13, 30, 572, DateTimeKind.Unspecified).AddTicks(7043), new TimeSpan(0, 7, 0, 0, 0)), "Lake Giovanna" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { 49, 7, new DateTimeOffset(new DateTime(2020, 9, 4, 11, 12, 42, 393, DateTimeKind.Unspecified).AddTicks(1), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 11, 25, 14, 35, 46, 305, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 7, 0, 0, 0)), "Port Jacebury" },
                    { 50, 45, new DateTimeOffset(new DateTime(2020, 11, 6, 12, 35, 15, 882, DateTimeKind.Unspecified).AddTicks(9721), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 4, 7, 14, 17, 44, 211, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 7, 0, 0, 0)), "Ahmadstad" }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("1f41cd8d-072c-b793-df38-5c9a4619abd6"), 661.13m, new DateTimeOffset(new DateTime(2020, 9, 9, 15, 14, 43, 740, DateTimeKind.Unspecified).AddTicks(9573), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 3, 18, 19, 2, 30, 659, DateTimeKind.Unspecified).AddTicks(5111), new TimeSpan(0, 7, 0, 0, 0)), "Savings Account", new Guid("11cf08e5-9589-40c5-a761-187ed55224f6") },
                    { new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211"), 642.55m, new DateTimeOffset(new DateTime(2020, 12, 8, 10, 58, 47, 193, DateTimeKind.Unspecified).AddTicks(7078), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 3, 28, 19, 1, 11, 310, DateTimeKind.Unspecified).AddTicks(8367), new TimeSpan(0, 7, 0, 0, 0)), "Checking Account", new Guid("0ac39d47-a580-388c-334e-c36e77d4acb7") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("35498364-2209-f8c2-b165-9599800ff98b"), 264.98m, new DateTimeOffset(new DateTime(2020, 5, 17, 12, 46, 38, 960, DateTimeKind.Unspecified).AddTicks(2169), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 14, 22, 27, 25, 210, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("9b616743-64aa-d99f-f78f-1a58970f7896") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("39fa5661-2eba-2269-1baa-fed1aa195356"), 626.68m, new DateTimeOffset(new DateTime(2020, 8, 21, 10, 21, 42, 208, DateTimeKind.Unspecified).AddTicks(1087), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 18, 2, 52, 25, 812, DateTimeKind.Unspecified).AddTicks(1646), new TimeSpan(0, 7, 0, 0, 0)), "Auto Loan Account", new Guid("f880aa64-7561-7503-de83-7f97fc4ce8a5") },
                    { new Guid("72d6a72b-0a05-898f-22cd-5b94c9155554"), 335.15m, new DateTimeOffset(new DateTime(2020, 1, 1, 19, 13, 11, 383, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 18, 10, 15, 11, 277, DateTimeKind.Unspecified).AddTicks(4186), new TimeSpan(0, 7, 0, 0, 0)), "Investment Account", new Guid("dae37e73-50c0-d5c8-97c6-5a7041370998") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("754ae7f5-0365-4af8-7c83-951b2e30d982"), 521.95m, new DateTimeOffset(new DateTime(2020, 3, 9, 14, 43, 4, 588, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 14, 12, 5, 5, 564, DateTimeKind.Unspecified).AddTicks(3254), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d") },
                    { new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a"), 893.17m, new DateTimeOffset(new DateTime(2020, 6, 20, 3, 37, 10, 404, DateTimeKind.Unspecified).AddTicks(418), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 31, 9, 48, 1, 360, DateTimeKind.Unspecified).AddTicks(5294), new TimeSpan(0, 7, 0, 0, 0)), "Checking Account", new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("e6a9f246-6c93-6962-33ef-855ab90a53b0"), 41.48m, new DateTimeOffset(new DateTime(2020, 9, 23, 14, 5, 17, 780, DateTimeKind.Unspecified).AddTicks(6107), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 26, 15, 36, 7, 580, DateTimeKind.Unspecified).AddTicks(5040), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("9588df2f-6267-6dd3-4359-1ec672055d47") },
                    { new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), 780.24m, new DateTimeOffset(new DateTime(2020, 12, 1, 17, 19, 15, 553, DateTimeKind.Unspecified).AddTicks(9436), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 29, 11, 45, 11, 493, DateTimeKind.Unspecified).AddTicks(708), new TimeSpan(0, 7, 0, 0, 0)), "Investment Account", new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42") }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DayOfBirth", "Email", "EmailConfirmed", "FirstName", "FullName", "IdentityId", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SupervisorId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668"), 0, "bfde8935-6484-4eda-961c-2f2bbb4f07e8", new DateTime(2020, 9, 7, 17, 11, 49, 876, DateTimeKind.Unspecified).AddTicks(7390), null, false, "Francis", "Francis Haley", "9ebd31fb-7a97-6819-8f3d-caafeb3aed33", "Haley", "Huelsburgh", false, null, null, null, null, null, false, null, new Guid("81fda1d4-fa16-093d-7e66-c5fd012c2fc3"), false, null },
                    { new Guid("360f39a0-9ef3-42c7-47d5-608af0d59ff4"), 0, "dac412a5-0652-43d9-bb63-e3584d957e69", new DateTime(2020, 2, 8, 3, 46, 40, 326, DateTimeKind.Unspecified).AddTicks(8812), null, false, "Penny", "Penny Kunde", "33c5f94a-a6ab-8ea9-2040-31b5efaa0b5d", "Kunde", "South Verner", false, null, null, null, null, null, false, null, new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d"), false, null },
                    { new Guid("40059f0b-1d19-9002-1e10-8a95bc55cb73"), 0, "dbde0ff4-c29d-4657-945e-973998419f98", new DateTime(2020, 4, 2, 4, 0, 59, 423, DateTimeKind.Unspecified).AddTicks(7306), null, false, "Lonnie", "Lonnie Hauck", "c9905f98-650c-2c33-ff1f-9f4aba085d87", "Hauck", "East Darrenland", false, null, null, null, null, null, false, null, new Guid("f2fa31c8-ab7a-ac0b-5f1e-9b3f2bcd52f0"), false, null },
                    { new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25"), 0, "b26a7a39-1552-4675-891b-75764a1510ca", new DateTime(2020, 8, 18, 16, 26, 28, 918, DateTimeKind.Unspecified).AddTicks(4929), null, false, "Antonio", "Antonio Crist", "e7e376a6-fa69-3714-07d3-bec6d3906c4e", "Crist", "Lake Diamondton", false, null, null, null, null, null, false, null, new Guid("9fcce051-4f9f-f1f2-63d6-b684ab1f528f"), false, null },
                    { new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592"), 0, "501dfa0f-2ab8-4970-932f-7bdddafc24af", new DateTime(2020, 9, 16, 19, 44, 5, 367, DateTimeKind.Unspecified).AddTicks(9282), null, false, "Bertha", "Bertha Conn", "b0bb8a23-8e4a-8585-b33f-ce3e7d86eca0", "Conn", "Port Franco", false, null, null, null, null, null, false, null, new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d"), false, null },
                    { new Guid("7878f7dc-bd02-5290-3a26-8de4bc0e493e"), 0, "1870201f-32b5-4804-90b9-363b18e6b82d", new DateTime(2020, 10, 5, 17, 59, 41, 721, DateTimeKind.Unspecified).AddTicks(4731), null, false, "Carl", "Carl Labadie", "d1bf7d49-5dad-663f-62ab-0691ba4f7212", "Labadie", "Gislasonland", false, null, null, null, null, null, false, null, new Guid("5e457116-2bfb-9936-853d-5adc0468ba06"), false, null },
                    { new Guid("7bfb0e9a-450e-4de3-e61a-53cbbd200382"), 0, "6588699e-48fb-4b5e-a38d-3c74c7faf87d", new DateTime(2020, 6, 30, 12, 21, 19, 969, DateTimeKind.Unspecified).AddTicks(4611), null, false, "Edward", "Edward Hettinger", "f620ccfa-ffea-4203-48c1-5a3312c5695b", "Hettinger", "West Tianaburgh", false, null, null, null, null, null, false, null, new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d"), false, null },
                    { new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d"), 0, "57637341-fd19-4db5-a699-6daf1b9c1ec4", new DateTime(2020, 9, 3, 19, 39, 51, 938, DateTimeKind.Unspecified).AddTicks(5644), null, false, "Tamara", "Tamara Zboncak", "ddd97ae7-797b-13e1-5bbb-77889518dae7", "Zboncak", "Jaskolskiland", false, null, null, null, null, null, false, null, new Guid("6100e542-8ed9-94dd-02eb-d05d806edcfa"), false, null },
                    { new Guid("a4ba18a9-4a80-60ba-6b5e-7ddf7d9935d5"), 0, "a978518b-c854-43b7-ab87-8582b17cfdfe", new DateTime(2020, 8, 8, 16, 45, 48, 855, DateTimeKind.Unspecified).AddTicks(8752), null, false, "Julius", "Julius Feil", "4d7cdc97-2e5a-1622-1d0e-1f0c1a58155e", "Feil", "North Travisbury", false, null, null, null, null, null, false, null, new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d"), false, null },
                    { new Guid("b9091570-e0f7-593d-99e0-58bfd294d21a"), 0, "455b8860-b36a-4e24-abcd-bf7c718eca5d", new DateTime(2020, 8, 6, 23, 42, 39, 78, DateTimeKind.Unspecified).AddTicks(3070), null, false, "Darren", "Darren Kunze", "9ee3119c-4328-3f79-e77b-88bbe364ee3e", "Kunze", "West Julien", false, null, null, null, null, null, false, null, new Guid("f4b6b354-f64b-e238-6806-00f403e85ab4"), false, null },
                    { new Guid("d2f046ac-c105-40c7-eabf-733a9492edc5"), 0, "d050b498-ef2c-4e20-b96f-275229d0cbdb", new DateTime(2020, 2, 2, 22, 21, 38, 181, DateTimeKind.Unspecified).AddTicks(736), null, false, "Alison", "Alison Ondricka", "aa42f7bc-4e80-4075-063f-cb3fb0b39468", "Ondricka", "Mantefort", false, null, null, null, null, null, false, null, new Guid("606f1107-4340-3d79-81f8-5d8b09c12c47"), false, null },
                    { new Guid("dfd5e5a3-ad91-6e2a-8169-d69d496e5763"), 0, "697b25de-0bfa-4c8e-82c5-8094b61df35d", new DateTime(2020, 9, 30, 10, 27, 37, 878, DateTimeKind.Unspecified).AddTicks(6802), null, false, "Myrtle", "Myrtle Cummerata", "a1a4b064-b5a1-6239-54ea-94f627f5d5ee", "Cummerata", "Jaskolskitown", false, null, null, null, null, null, false, null, new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d"), false, null },
                    { new Guid("f0873793-18d6-4a84-5a2e-46f599ad27f6"), 0, "8f0222ae-0b20-46db-9aa5-9c140e35da10", new DateTime(2020, 2, 11, 3, 51, 58, 968, DateTimeKind.Unspecified).AddTicks(6050), null, false, "Levi", "Levi Sporer", "e3799374-871a-2703-18f6-68657ff0f5f8", "Sporer", "McDermottside", false, null, null, null, null, null, false, null, new Guid("f2fa31c8-ab7a-ac0b-5f1e-9b3f2bcd52f0"), false, null }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("0ae18c23-5a4e-0f8e-e3c1-25f2744b08ab"), 659.33m, new DateTimeOffset(new DateTime(2020, 4, 20, 1, 46, 59, 676, DateTimeKind.Unspecified).AddTicks(8701), new TimeSpan(0, 7, 0, 0, 0)), "Dolor ut eum consequuntur nam voluptatem.", new DateTimeOffset(new DateTime(2020, 2, 25, 3, 15, 37, 511, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, 7, 0, 0, 0)), "quam", new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc"), new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a") },
                    { new Guid("953b298b-2d7e-d55f-136d-3fc2a7f518e0"), 204.56m, new DateTimeOffset(new DateTime(2020, 2, 27, 14, 46, 6, 449, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 7, 0, 0, 0)), "Qui unde fugit placeat accusantium impedit.", new DateTimeOffset(new DateTime(2020, 4, 14, 14, 28, 36, 505, DateTimeKind.Unspecified).AddTicks(1912), new TimeSpan(0, 7, 0, 0, 0)), "vel", new Guid("9588df2f-6267-6dd3-4359-1ec672055d47"), new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("9ef052cd-d451-a89e-0515-b413c4587a03"), 463.38m, new DateTimeOffset(new DateTime(2020, 7, 27, 6, 25, 23, 35, DateTimeKind.Unspecified).AddTicks(811), new TimeSpan(0, 7, 0, 0, 0)), "Impedit animi iusto ad.", true, new DateTimeOffset(new DateTime(2020, 3, 4, 16, 13, 45, 498, DateTimeKind.Unspecified).AddTicks(911), new TimeSpan(0, 7, 0, 0, 0)), "id", new Guid("6100e542-8ed9-94dd-02eb-d05d806edcfa"), new Guid("1f41cd8d-072c-b793-df38-5c9a4619abd6") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("a2e64313-e8a4-bda0-6c2b-a7d672050a8f"), 555.27m, new DateTimeOffset(new DateTime(2020, 4, 12, 16, 32, 10, 830, DateTimeKind.Unspecified).AddTicks(564), new TimeSpan(0, 7, 0, 0, 0)), "Quod harum animi qui error suscipit repellat accusamus.", new DateTimeOffset(new DateTime(2020, 6, 3, 8, 46, 37, 837, DateTimeKind.Unspecified).AddTicks(3973), new TimeSpan(0, 7, 0, 0, 0)), "et", new Guid("6100e542-8ed9-94dd-02eb-d05d806edcfa"), new Guid("754ae7f5-0365-4af8-7c83-951b2e30d982") },
                    { new Guid("af4e7220-0f01-2605-0e56-6ab34b8a588c"), 102.34m, new DateTimeOffset(new DateTime(2020, 8, 2, 21, 47, 41, 346, DateTimeKind.Unspecified).AddTicks(6569), new TimeSpan(0, 7, 0, 0, 0)), "Sed repudiandae ea eligendi officia quam.", new DateTimeOffset(new DateTime(2020, 12, 21, 19, 8, 55, 858, DateTimeKind.Unspecified).AddTicks(5485), new TimeSpan(0, 7, 0, 0, 0)), "consequatur", new Guid("837c4af8-1b95-302e-d982-d3e35c19fca2"), new Guid("39fa5661-2eba-2269-1baa-fed1aa195356") },
                    { new Guid("b5e07e23-dc6f-5b08-8c43-8fffa9361b81"), 927.11m, new DateTimeOffset(new DateTime(2020, 10, 27, 16, 1, 0, 560, DateTimeKind.Unspecified).AddTicks(6586), new TimeSpan(0, 7, 0, 0, 0)), "Ut et dolores eveniet ut atque dicta.", new DateTimeOffset(new DateTime(2020, 1, 11, 0, 46, 2, 197, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 7, 0, 0, 0)), "non", new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d"), new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("0804decd-7b5c-9799-690f-47fb03e9ce3b"), 525.22m, new DateTimeOffset(new DateTime(2020, 7, 10, 3, 49, 13, 370, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 7, 18, 11, 18, 178, DateTimeKind.Unspecified).AddTicks(1665), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("2b65bc72-52ae-5087-1db8-b47d7fa37ad2"), 346.96m, new DateTimeOffset(new DateTime(2020, 6, 19, 20, 46, 30, 233, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 30, 14, 58, 39, 305, DateTimeKind.Unspecified).AddTicks(7133), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc") },
                    { new Guid("2cc304c0-f65d-fe35-7c8d-3740a4699010"), 548.64m, new DateTimeOffset(new DateTime(2020, 4, 1, 17, 14, 16, 94, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 31, 6, 7, 25, 223, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("6100e542-8ed9-94dd-02eb-d05d806edcfa") },
                    { new Guid("3f6d13d5-a7c2-18f5-e07e-9b5202b062f6"), 749.98m, new DateTimeOffset(new DateTime(2020, 12, 22, 4, 46, 57, 111, DateTimeKind.Unspecified).AddTicks(8518), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 17, 1, 57, 19, 303, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("837c4af8-1b95-302e-d982-d3e35c19fca2") },
                    { new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35"), 525.67m, new DateTimeOffset(new DateTime(2020, 1, 16, 19, 32, 49, 382, DateTimeKind.Unspecified).AddTicks(1356), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 20, 3, 5, 37, 566, DateTimeKind.Unspecified).AddTicks(2692), new TimeSpan(0, 7, 0, 0, 0)), "Checking Account", new Guid("779c3b8b-7dec-380d-7eeb-ec94e998eb0c") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("5fac0bab-9b1e-2b3f-cd52-f09e51d49ea8"), 530.62m, new DateTimeOffset(new DateTime(2020, 10, 16, 1, 26, 33, 383, DateTimeKind.Unspecified).AddTicks(181), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 1, 28, 1, 31, 35, 878, DateTimeKind.Unspecified).AddTicks(3399), new TimeSpan(0, 7, 0, 0, 0)), "Credit Card Account", new Guid("f12096d7-2697-2757-cded-e8d3504da036") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("6e2aad91-6981-9dd6-496e-5763a37c45fb"), 700.43m, new DateTimeOffset(new DateTime(2020, 2, 21, 23, 49, 53, 209, DateTimeKind.Unspecified).AddTicks(8892), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 11, 14, 5, 0, 996, DateTimeKind.Unspecified).AddTicks(306), new TimeSpan(0, 7, 0, 0, 0)), "Savings Account", new Guid("81fda1d4-fa16-093d-7e66-c5fd012c2fc3") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("8c223896-e751-0945-eb80-f68b20142b12"), 199.13m, new DateTimeOffset(new DateTime(2020, 2, 12, 17, 24, 44, 840, DateTimeKind.Unspecified).AddTicks(7113), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 2, 11, 19, 53, 21, 949, DateTimeKind.Unspecified).AddTicks(1782), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("f2fa31c8-ab7a-ac0b-5f1e-9b3f2bcd52f0") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), 892.58m, new DateTimeOffset(new DateTime(2020, 5, 15, 21, 53, 38, 112, DateTimeKind.Unspecified).AddTicks(1731), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 25, 15, 7, 47, 655, DateTimeKind.Unspecified).AddTicks(3846), new TimeSpan(0, 7, 0, 0, 0)), "Savings Account", new Guid("4fbc87d7-b534-95ce-0699-083d05b4056f") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("9433c32f-2762-2724-ce13-3348d2a829fd"), 645.53m, new DateTimeOffset(new DateTime(2020, 9, 24, 19, 33, 12, 457, DateTimeKind.Unspecified).AddTicks(6893), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 18, 21, 20, 53, 901, DateTimeKind.Unspecified).AddTicks(2209), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("99b466ff-4c41-07d6-7020-a9f28b403607") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("a740c595-1861-d57e-5224-f6098c56f3f8"), 990.24m, new DateTimeOffset(new DateTime(2020, 1, 17, 11, 42, 52, 284, DateTimeKind.Unspecified).AddTicks(5721), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 17, 18, 45, 58, 301, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") },
                    { new Guid("b08b3ca5-2236-4358-6761-9baa649fd9f7"), 71.36m, new DateTimeOffset(new DateTime(2020, 7, 25, 18, 12, 56, 262, DateTimeKind.Unspecified).AddTicks(39), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 26, 0, 27, 59, 557, DateTimeKind.Unspecified).AddTicks(9799), new TimeSpan(0, 7, 0, 0, 0)), "Investment Account", new Guid("8bdb736b-89b7-be24-1c15-31f7e7421644") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3"), 179.82m, new DateTimeOffset(new DateTime(2020, 2, 10, 1, 48, 33, 699, DateTimeKind.Unspecified).AddTicks(4541), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 8, 9, 39, 18, 144, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("f4b6b354-f64b-e238-6806-00f403e85ab4") },
                    { new Guid("b651c657-6dc2-86f7-a83c-e64680ed8168"), 50.35m, new DateTimeOffset(new DateTime(2020, 9, 11, 5, 47, 6, 910, DateTimeKind.Unspecified).AddTicks(4995), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 2, 4, 2, 42, 30, 340, DateTimeKind.Unspecified).AddTicks(4394), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("5e457116-2bfb-9936-853d-5adc0468ba06") },
                    { new Guid("edef5f70-0e2c-dcad-74db-7688646ffd2d"), 92.96m, new DateTimeOffset(new DateTime(2020, 9, 22, 18, 47, 21, 152, DateTimeKind.Unspecified).AddTicks(7159), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 22, 12, 6, 44, 103, DateTimeKind.Unspecified).AddTicks(5617), new TimeSpan(0, 7, 0, 0, 0)), "Savings Account", new Guid("606f1107-4340-3d79-81f8-5d8b09c12c47") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1"), 778.11m, new DateTimeOffset(new DateTime(2020, 9, 11, 1, 16, 16, 760, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 9, 10, 50, 29, 169, DateTimeKind.Unspecified).AddTicks(6939), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("9fcce051-4f9f-f1f2-63d6-b684ab1f528f") });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("048d35ff-36ae-cac7-601a-03998417fd2e"), new DateTimeOffset(new DateTime(2020, 11, 6, 17, 8, 49, 277, DateTimeKind.Unspecified).AddTicks(8392), new TimeSpan(0, 7, 0, 0, 0)), 2, true, new DateTimeOffset(new DateTime(2020, 2, 15, 22, 25, 49, 504, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 7, 0, 0, 0)), "East Jennyfer" },
                    { new Guid("0c666a36-75bf-3e04-b4b4-76bc6bf7a71f"), new DateTimeOffset(new DateTime(2020, 11, 2, 3, 38, 22, 486, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, 7, 0, 0, 0)), 26, true, new DateTimeOffset(new DateTime(2020, 4, 13, 1, 22, 27, 594, DateTimeKind.Unspecified).AddTicks(8521), new TimeSpan(0, 7, 0, 0, 0)), "East Louie" },
                    { new Guid("15d6a64d-3c92-41f9-295a-5fc931444a0a"), new DateTimeOffset(new DateTime(2020, 9, 22, 1, 44, 15, 282, DateTimeKind.Unspecified).AddTicks(3886), new TimeSpan(0, 7, 0, 0, 0)), 14, true, new DateTimeOffset(new DateTime(2020, 12, 17, 9, 57, 56, 948, DateTimeKind.Unspecified).AddTicks(857), new TimeSpan(0, 7, 0, 0, 0)), "South Marcelle" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("1aad2054-ce71-3a51-15ab-1e6d75d265d3"), new DateTimeOffset(new DateTime(2020, 12, 7, 3, 10, 6, 157, DateTimeKind.Unspecified).AddTicks(1279), new TimeSpan(0, 7, 0, 0, 0)), 3, new DateTimeOffset(new DateTime(2020, 6, 12, 16, 30, 49, 234, DateTimeKind.Unspecified).AddTicks(5625), new TimeSpan(0, 7, 0, 0, 0)), "Nitzscheview" },
                    { new Guid("1e329db5-c9fa-05fc-d497-5ed3d8499f7c"), new DateTimeOffset(new DateTime(2020, 5, 16, 19, 58, 48, 313, DateTimeKind.Unspecified).AddTicks(1696), new TimeSpan(0, 7, 0, 0, 0)), 15, new DateTimeOffset(new DateTime(2020, 2, 10, 13, 49, 17, 936, DateTimeKind.Unspecified).AddTicks(8525), new TimeSpan(0, 7, 0, 0, 0)), "Vonton" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("25654813-d753-37ec-74d8-f5f4529d9bde"), new DateTimeOffset(new DateTime(2020, 4, 4, 1, 43, 41, 908, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 7, 0, 0, 0)), 42, true, new DateTimeOffset(new DateTime(2020, 5, 18, 9, 28, 4, 850, DateTimeKind.Unspecified).AddTicks(202), new TimeSpan(0, 7, 0, 0, 0)), "South Vernamouth" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("2dbc398b-52a6-a98d-d070-fe5e751ab3d8"), new DateTimeOffset(new DateTime(2020, 10, 6, 8, 21, 21, 565, DateTimeKind.Unspecified).AddTicks(8784), new TimeSpan(0, 7, 0, 0, 0)), 3, new DateTimeOffset(new DateTime(2020, 1, 14, 7, 3, 14, 717, DateTimeKind.Unspecified).AddTicks(2686), new TimeSpan(0, 7, 0, 0, 0)), "South Genesisside" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("318e4206-34ba-5e52-7c82-b1c93efc319c"), new DateTimeOffset(new DateTime(2020, 8, 15, 6, 27, 26, 793, DateTimeKind.Unspecified).AddTicks(9351), new TimeSpan(0, 7, 0, 0, 0)), 33, true, new DateTimeOffset(new DateTime(2020, 12, 17, 6, 25, 21, 515, DateTimeKind.Unspecified).AddTicks(9986), new TimeSpan(0, 7, 0, 0, 0)), "West Makaylashire" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("3313ce27-d248-29a8-fd66-c566826226cd"), new DateTimeOffset(new DateTime(2020, 7, 5, 14, 37, 40, 355, DateTimeKind.Unspecified).AddTicks(7921), new TimeSpan(0, 7, 0, 0, 0)), 39, new DateTimeOffset(new DateTime(2020, 10, 20, 14, 17, 2, 493, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, 7, 0, 0, 0)), "Haleyburgh" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("3a6aed8d-5a99-4edd-8327-5c278eb6b17d"), new DateTimeOffset(new DateTime(2020, 2, 5, 17, 54, 17, 131, DateTimeKind.Unspecified).AddTicks(1998), new TimeSpan(0, 7, 0, 0, 0)), 43, true, new DateTimeOffset(new DateTime(2020, 7, 19, 0, 45, 33, 69, DateTimeKind.Unspecified).AddTicks(4658), new TimeSpan(0, 7, 0, 0, 0)), "Brantberg" },
                    { new Guid("3a7e3299-e0c5-5df7-64b0-a4a1a1b53962"), new DateTimeOffset(new DateTime(2020, 11, 22, 4, 33, 39, 260, DateTimeKind.Unspecified).AddTicks(5363), new TimeSpan(0, 7, 0, 0, 0)), 22, true, new DateTimeOffset(new DateTime(2020, 7, 9, 21, 4, 21, 808, DateTimeKind.Unspecified).AddTicks(701), new TimeSpan(0, 7, 0, 0, 0)), "Jovanihaven" },
                    { new Guid("3aab7684-df2f-9588-6762-d36d43591ec6"), new DateTimeOffset(new DateTime(2020, 6, 28, 13, 22, 3, 844, DateTimeKind.Unspecified).AddTicks(7697), new TimeSpan(0, 7, 0, 0, 0)), 14, true, new DateTimeOffset(new DateTime(2020, 11, 20, 9, 53, 55, 655, DateTimeKind.Unspecified).AddTicks(6105), new TimeSpan(0, 7, 0, 0, 0)), "Pollichville" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("3f9225cd-7acc-0d19-9b61-826df2719fea"), new DateTimeOffset(new DateTime(2020, 2, 5, 15, 55, 54, 163, DateTimeKind.Unspecified).AddTicks(3262), new TimeSpan(0, 7, 0, 0, 0)), 19, new DateTimeOffset(new DateTime(2020, 7, 8, 1, 29, 0, 604, DateTimeKind.Unspecified).AddTicks(5894), new TimeSpan(0, 7, 0, 0, 0)), "Selenashire" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("40179df0-b9b7-ccb0-8b46-fc9cb10a0aa2"), new DateTimeOffset(new DateTime(2020, 12, 3, 22, 12, 58, 497, DateTimeKind.Unspecified).AddTicks(2697), new TimeSpan(0, 7, 0, 0, 0)), 43, true, new DateTimeOffset(new DateTime(2020, 1, 22, 7, 39, 35, 63, DateTimeKind.Unspecified).AddTicks(1178), new TimeSpan(0, 7, 0, 0, 0)), "New Fleta" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("40e562d7-b50b-4ad9-5089-8507682b0d58"), new DateTimeOffset(new DateTime(2020, 12, 16, 11, 32, 50, 387, DateTimeKind.Unspecified).AddTicks(8566), new TimeSpan(0, 7, 0, 0, 0)), 22, new DateTimeOffset(new DateTime(2020, 12, 4, 10, 23, 21, 13, DateTimeKind.Unspecified).AddTicks(43), new TimeSpan(0, 7, 0, 0, 0)), "Lednermouth" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("41e6a2ec-4ff6-8a82-a45d-905ab4812ddc"), new DateTimeOffset(new DateTime(2020, 1, 16, 2, 32, 54, 970, DateTimeKind.Unspecified).AddTicks(5164), new TimeSpan(0, 7, 0, 0, 0)), 43, true, new DateTimeOffset(new DateTime(2020, 3, 5, 16, 48, 13, 498, DateTimeKind.Unspecified).AddTicks(6635), new TimeSpan(0, 7, 0, 0, 0)), "Schadenshire" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("4d8d10a4-6f02-8058-8923-f5bdcef26ed8"), new DateTimeOffset(new DateTime(2020, 4, 22, 7, 40, 1, 142, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 7, 0, 0, 0)), 20, new DateTimeOffset(new DateTime(2020, 11, 25, 18, 3, 40, 322, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 7, 0, 0, 0)), "East Adela" },
                    { new Guid("52ae2b65-5087-b81d-b47d-7fa37ad24f03"), new DateTimeOffset(new DateTime(2020, 10, 31, 3, 47, 15, 901, DateTimeKind.Unspecified).AddTicks(194), new TimeSpan(0, 7, 0, 0, 0)), 27, new DateTimeOffset(new DateTime(2020, 6, 20, 2, 54, 43, 526, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 7, 0, 0, 0)), "Lake Timmothyshire" },
                    { new Guid("54f608ca-598f-a8ca-8e37-a92300d6a440"), new DateTimeOffset(new DateTime(2020, 3, 11, 17, 31, 40, 530, DateTimeKind.Unspecified).AddTicks(2693), new TimeSpan(0, 7, 0, 0, 0)), 4, new DateTimeOffset(new DateTime(2020, 1, 6, 13, 50, 57, 171, DateTimeKind.Unspecified).AddTicks(5185), new TimeSpan(0, 7, 0, 0, 0)), "South Nat" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("5e10e0ee-80ca-3b8b-9c77-ec7d0d387eeb"), new DateTimeOffset(new DateTime(2020, 7, 19, 3, 21, 29, 954, DateTimeKind.Unspecified).AddTicks(8676), new TimeSpan(0, 7, 0, 0, 0)), 10, true, new DateTimeOffset(new DateTime(2020, 1, 26, 22, 15, 55, 693, DateTimeKind.Unspecified).AddTicks(6533), new TimeSpan(0, 7, 0, 0, 0)), "West Reganburgh" },
                    { new Guid("60447f7b-fee5-ba9d-8dcd-411f2c0793b7"), new DateTimeOffset(new DateTime(2020, 8, 22, 11, 48, 58, 362, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 7, 0, 0, 0)), 35, true, new DateTimeOffset(new DateTime(2020, 10, 28, 13, 9, 22, 349, DateTimeKind.Unspecified).AddTicks(3), new TimeSpan(0, 7, 0, 0, 0)), "New Sallie" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("62b12191-f9c9-e502-08cf-118995c540a7"), new DateTimeOffset(new DateTime(2020, 11, 29, 16, 59, 47, 928, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 7, 0, 0, 0)), 16, new DateTimeOffset(new DateTime(2020, 2, 9, 19, 46, 7, 70, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 7, 0, 0, 0)), "East Brant" },
                    { new Guid("67435822-9b61-64aa-9fd9-f78f1a58970f"), new DateTimeOffset(new DateTime(2020, 7, 6, 8, 19, 13, 552, DateTimeKind.Unspecified).AddTicks(4105), new TimeSpan(0, 7, 0, 0, 0)), 18, new DateTimeOffset(new DateTime(2020, 9, 16, 14, 39, 44, 445, DateTimeKind.Unspecified).AddTicks(1211), new TimeSpan(0, 7, 0, 0, 0)), "New Nelleport" },
                    { new Guid("69816e2a-9dd6-6e49-5763-a37c45fb1f8b"), new DateTimeOffset(new DateTime(2020, 3, 7, 18, 23, 32, 899, DateTimeKind.Unspecified).AddTicks(5488), new TimeSpan(0, 7, 0, 0, 0)), 30, new DateTimeOffset(new DateTime(2020, 6, 30, 21, 14, 10, 69, DateTimeKind.Unspecified).AddTicks(920), new TimeSpan(0, 7, 0, 0, 0)), "New Ruthiehaven" },
                    { new Guid("71b6972b-725e-d40d-66c3-4f8b85031295"), new DateTimeOffset(new DateTime(2020, 2, 21, 13, 19, 56, 813, DateTimeKind.Unspecified).AddTicks(5536), new TimeSpan(0, 7, 0, 0, 0)), 49, new DateTimeOffset(new DateTime(2020, 9, 1, 3, 29, 29, 853, DateTimeKind.Unspecified).AddTicks(6931), new TimeSpan(0, 7, 0, 0, 0)), "South Vena" },
                    { new Guid("7fb44eaa-4255-9619-b8a3-64698dd7fdc7"), new DateTimeOffset(new DateTime(2020, 8, 11, 16, 15, 36, 138, DateTimeKind.Unspecified).AddTicks(9716), new TimeSpan(0, 7, 0, 0, 0)), 7, new DateTimeOffset(new DateTime(2020, 5, 26, 12, 33, 31, 347, DateTimeKind.Unspecified).AddTicks(7113), new TimeSpan(0, 7, 0, 0, 0)), "Port Kacie" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("86f76dc2-3ca8-46e6-80ed-8168bd10e2e3"), new DateTimeOffset(new DateTime(2020, 9, 30, 14, 49, 12, 324, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 7, 0, 0, 0)), 11, true, new DateTimeOffset(new DateTime(2020, 5, 6, 7, 17, 1, 420, DateTimeKind.Unspecified).AddTicks(6102), new TimeSpan(0, 7, 0, 0, 0)), "Port Ophelia" },
                    { new Guid("93e6a9f2-626c-3369-ef85-5ab90a53b0f5"), new DateTimeOffset(new DateTime(2020, 1, 15, 1, 34, 11, 827, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 7, 0, 0, 0)), 3, true, new DateTimeOffset(new DateTime(2020, 6, 11, 11, 41, 47, 844, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 7, 0, 0, 0)), "East Jessyca" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new DateTimeOffset(new DateTime(2020, 8, 30, 0, 38, 16, 925, DateTimeKind.Unspecified).AddTicks(600), new TimeSpan(0, 7, 0, 0, 0)), 36, new DateTimeOffset(new DateTime(2020, 9, 2, 6, 3, 4, 571, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), "Lake Ashtynton" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("9b7ee018-0252-62b0-f68e-93af65c0a83e"), new DateTimeOffset(new DateTime(2020, 8, 24, 17, 19, 52, 944, DateTimeKind.Unspecified).AddTicks(3262), new TimeSpan(0, 7, 0, 0, 0)), 38, true, new DateTimeOffset(new DateTime(2020, 3, 10, 11, 6, 7, 168, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 7, 0, 0, 0)), "East Magali" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("9ef052cd-d451-a89e-0515-b413c4587a03"), new DateTimeOffset(new DateTime(2020, 10, 4, 16, 11, 23, 444, DateTimeKind.Unspecified).AddTicks(1442), new TimeSpan(0, 7, 0, 0, 0)), 13, new DateTimeOffset(new DateTime(2020, 4, 17, 4, 55, 15, 710, DateTimeKind.Unspecified).AddTicks(8374), new TimeSpan(0, 7, 0, 0, 0)), "South Leland" },
                    { new Guid("a2e64313-e8a4-bda0-6c2b-a7d672050a8f"), new DateTimeOffset(new DateTime(2020, 5, 5, 7, 40, 4, 153, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 7, 0, 0, 0)), 13, new DateTimeOffset(new DateTime(2020, 4, 5, 4, 40, 2, 547, DateTimeKind.Unspecified).AddTicks(6549), new TimeSpan(0, 7, 0, 0, 0)), "South Lizeth" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("a8ffd52a-3d62-ea5c-e177-a771279a4944"), new DateTimeOffset(new DateTime(2020, 11, 15, 14, 45, 29, 658, DateTimeKind.Unspecified).AddTicks(2156), new TimeSpan(0, 7, 0, 0, 0)), 17, true, new DateTimeOffset(new DateTime(2020, 1, 20, 5, 43, 18, 148, DateTimeKind.Unspecified).AddTicks(7147), new TimeSpan(0, 7, 0, 0, 0)), "Bernhardport" },
                    { new Guid("a99052b6-a953-00fb-7f94-ad45509c5449"), new DateTimeOffset(new DateTime(2020, 12, 19, 7, 37, 48, 118, DateTimeKind.Unspecified).AddTicks(7773), new TimeSpan(0, 7, 0, 0, 0)), 19, true, new DateTimeOffset(new DateTime(2020, 9, 10, 2, 9, 48, 349, DateTimeKind.Unspecified).AddTicks(5114), new TimeSpan(0, 7, 0, 0, 0)), "Connland" },
                    { new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"), new DateTimeOffset(new DateTime(2020, 10, 9, 7, 57, 16, 113, DateTimeKind.Unspecified).AddTicks(3679), new TimeSpan(0, 7, 0, 0, 0)), 30, true, new DateTimeOffset(new DateTime(2020, 8, 12, 22, 25, 8, 850, DateTimeKind.Unspecified).AddTicks(578), new TimeSpan(0, 7, 0, 0, 0)), "East Alecburgh" },
                    { new Guid("ad659bb5-d5ce-14fa-8bef-7b2fa2d996de"), new DateTimeOffset(new DateTime(2020, 3, 5, 15, 28, 36, 484, DateTimeKind.Unspecified).AddTicks(6203), new TimeSpan(0, 7, 0, 0, 0)), 4, true, new DateTimeOffset(new DateTime(2020, 3, 19, 6, 43, 58, 413, DateTimeKind.Unspecified).AddTicks(8637), new TimeSpan(0, 7, 0, 0, 0)), "Watsicaborough" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("ae7c811b-cb63-0def-4349-2d904e1bf151"), new DateTimeOffset(new DateTime(2020, 9, 30, 11, 45, 51, 797, DateTimeKind.Unspecified).AddTicks(7003), new TimeSpan(0, 7, 0, 0, 0)), 42, new DateTimeOffset(new DateTime(2020, 5, 29, 17, 8, 54, 755, DateTimeKind.Unspecified).AddTicks(8622), new TimeSpan(0, 7, 0, 0, 0)), "Marilynetown" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("af49a2fc-2f96-0c5f-e2aa-42309edddf13"), new DateTimeOffset(new DateTime(2020, 2, 22, 2, 18, 31, 0, DateTimeKind.Unspecified).AddTicks(7504), new TimeSpan(0, 7, 0, 0, 0)), 25, true, new DateTimeOffset(new DateTime(2020, 12, 2, 1, 36, 47, 105, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 7, 0, 0, 0)), "Rolfsonburgh" },
                    { new Guid("b1f8c222-9565-8099-0ff9-8b293b957e2d"), new DateTimeOffset(new DateTime(2020, 10, 15, 6, 13, 43, 483, DateTimeKind.Unspecified).AddTicks(6951), new TimeSpan(0, 7, 0, 0, 0)), 26, true, new DateTimeOffset(new DateTime(2020, 1, 19, 21, 4, 39, 408, DateTimeKind.Unspecified).AddTicks(6184), new TimeSpan(0, 7, 0, 0, 0)), "West Sylviaport" },
                    { new Guid("b9c55050-58bd-e1e5-a445-366631090c34"), new DateTimeOffset(new DateTime(2020, 1, 30, 0, 4, 16, 189, DateTimeKind.Unspecified).AddTicks(8397), new TimeSpan(0, 7, 0, 0, 0)), 7, true, new DateTimeOffset(new DateTime(2020, 7, 4, 10, 2, 54, 109, DateTimeKind.Unspecified).AddTicks(7008), new TimeSpan(0, 7, 0, 0, 0)), "Port Robbieton" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("d354372e-f04c-d28b-e2e7-d40211337a1c"), new DateTimeOffset(new DateTime(2020, 3, 7, 12, 10, 55, 729, DateTimeKind.Unspecified).AddTicks(3142), new TimeSpan(0, 7, 0, 0, 0)), 39, new DateTimeOffset(new DateTime(2020, 8, 1, 17, 36, 45, 990, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 7, 0, 0, 0)), "Weldonmouth" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("d42c9ec7-fda1-1681-fa3d-097e66c5fd01"), new DateTimeOffset(new DateTime(2020, 8, 13, 16, 49, 29, 274, DateTimeKind.Unspecified).AddTicks(9976), new TimeSpan(0, 7, 0, 0, 0)), 15, true, new DateTimeOffset(new DateTime(2020, 11, 11, 3, 19, 44, 731, DateTimeKind.Unspecified).AddTicks(7409), new TimeSpan(0, 7, 0, 0, 0)), "Port Abeville" },
                    { new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"), new DateTimeOffset(new DateTime(2020, 11, 5, 20, 22, 45, 403, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 7, 0, 0, 0)), 8, true, new DateTimeOffset(new DateTime(2020, 3, 4, 6, 35, 3, 882, DateTimeKind.Unspecified).AddTicks(6650), new TimeSpan(0, 7, 0, 0, 0)), "Vivianhaven" },
                    { new Guid("df8b1dd6-47d6-6f87-fa5d-3fefbb55f9f7"), new DateTimeOffset(new DateTime(2020, 6, 8, 4, 40, 10, 158, DateTimeKind.Unspecified).AddTicks(5571), new TimeSpan(0, 7, 0, 0, 0)), 47, true, new DateTimeOffset(new DateTime(2020, 11, 19, 23, 12, 48, 388, DateTimeKind.Unspecified).AddTicks(793), new TimeSpan(0, 7, 0, 0, 0)), "Carleyside" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("f3568c09-55f8-ac7e-442d-01fb2b510c8e"), new DateTimeOffset(new DateTime(2020, 11, 23, 2, 38, 5, 756, DateTimeKind.Unspecified).AddTicks(7608), new TimeSpan(0, 7, 0, 0, 0)), 43, new DateTimeOffset(new DateTime(2020, 10, 31, 10, 23, 2, 508, DateTimeKind.Unspecified).AddTicks(9808), new TimeSpan(0, 7, 0, 0, 0)), "East Celestinoshire" },
                    { new Guid("f5f00e35-4ae7-6575-03f8-4a7c83951b2e"), new DateTimeOffset(new DateTime(2020, 6, 24, 3, 25, 2, 978, DateTimeKind.Unspecified).AddTicks(2546), new TimeSpan(0, 7, 0, 0, 0)), 31, new DateTimeOffset(new DateTime(2020, 3, 9, 14, 43, 4, 588, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 7, 0, 0, 0)), "Yvetteton" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "IsDeleted", "ModifiedOnUtc", "Name" },
                values: new object[,]
                {
                    { new Guid("f680eb09-208b-2b14-1237-d52d64d485ab"), new DateTimeOffset(new DateTime(2020, 4, 12, 9, 19, 15, 617, DateTimeKind.Unspecified).AddTicks(4047), new TimeSpan(0, 7, 0, 0, 0)), 36, true, new DateTimeOffset(new DateTime(2020, 8, 20, 0, 36, 20, 736, DateTimeKind.Unspecified).AddTicks(1106), new TimeSpan(0, 7, 0, 0, 0)), "Rosannamouth" },
                    { new Guid("f7895455-134e-0837-4c23-7ee0b56fdc08"), new DateTimeOffset(new DateTime(2020, 1, 9, 22, 48, 48, 21, DateTimeKind.Unspecified).AddTicks(6003), new TimeSpan(0, 7, 0, 0, 0)), 35, true, new DateTimeOffset(new DateTime(2020, 1, 13, 17, 20, 7, 146, DateTimeKind.Unspecified).AddTicks(8644), new TimeSpan(0, 7, 0, 0, 0)), "Hermanbury" },
                    { new Guid("fb470f69-e903-3bce-6577-08add2e94ecd"), new DateTimeOffset(new DateTime(2020, 8, 5, 12, 25, 58, 989, DateTimeKind.Unspecified).AddTicks(3117), new TimeSpan(0, 7, 0, 0, 0)), 39, true, new DateTimeOffset(new DateTime(2020, 10, 27, 4, 54, 36, 849, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, 7, 0, 0, 0)), "East Emmieside" }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CreatedOnUtc", "DistrictId", "ModifiedOnUtc", "Name" },
                values: new object[] { new Guid("feaa1b22-aad1-5319-5664-b0e4145d3dcc"), new DateTimeOffset(new DateTime(2020, 8, 6, 15, 10, 0, 460, DateTimeKind.Unspecified).AddTicks(8200), new TimeSpan(0, 7, 0, 0, 0)), 15, new DateTimeOffset(new DateTime(2020, 6, 28, 17, 59, 9, 490, DateTimeKind.Unspecified).AddTicks(5073), new TimeSpan(0, 7, 0, 0, 0)), "East Emelieton" });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DayOfBirth", "Email", "EmailConfirmed", "FirstName", "FullName", "IdentityId", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SupervisorId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0239ea8c-b559-0752-b2c0-92710f499696"), 0, "ec149ffc-7c24-41c3-b9b2-06836af97b32", new DateTime(2020, 10, 29, 9, 20, 29, 351, DateTimeKind.Unspecified).AddTicks(6256), null, false, "Harry", "Harry Schumm", "7b9c8e27-b616-0e1a-1a5a-283e9c9f2fe8", "Schumm", "Feeneymouth", false, null, null, null, null, null, false, null, new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d"), false, null },
                    { new Guid("4a1c6b89-d069-783e-490c-18783c5527ee"), 0, "4bdcc635-fe44-49de-9451-3b8733014f19", new DateTime(2020, 1, 9, 17, 2, 54, 100, DateTimeKind.Unspecified).AddTicks(8478), null, false, "Cornelius", "Cornelius Fritsch", "24997c0f-ad00-dee9-4851-bef57c713aed", "Fritsch", "South Damarischester", false, null, null, null, null, null, false, null, new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592"), false, null },
                    { new Guid("8026a67e-3b61-fd8d-5241-408b6939c3a4"), 0, "52a82e38-0909-4ed0-b711-18cd59c8ad76", new DateTime(2020, 7, 2, 10, 44, 13, 859, DateTimeKind.Unspecified).AddTicks(5186), null, false, "Elaine", "Elaine Abbott", "4beba8bb-5ef4-c802-76d5-5caf7391e5e8", "Abbott", "Arnulfomouth", false, null, null, null, null, null, false, null, new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d"), false, null },
                    { new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4"), 0, "42684f94-b501-421e-a95f-bc40cfd3885f", new DateTime(2020, 12, 17, 7, 59, 53, 123, DateTimeKind.Unspecified).AddTicks(1379), null, false, "Ida", "Ida Wunsch", "660b502b-2baf-20ff-724e-af010f05260e", "Wunsch", "Lincolnmouth", false, null, null, null, null, null, false, null, new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592"), false, null },
                    { new Guid("9d4a5ac2-9ed1-9582-50ad-507ae459e493"), 0, "a9575997-b5b4-42c9-a5ed-ab4e0e180432", new DateTime(2020, 10, 18, 22, 44, 55, 179, DateTimeKind.Unspecified).AddTicks(6123), null, false, "Wanda", "Wanda Osinski", "6192ca30-24b5-12db-cd34-42c7880e83b8", "Osinski", "Edmundside", false, null, null, null, null, null, false, null, new Guid("dfd5e5a3-ad91-6e2a-8169-d69d496e5763"), false, null },
                    { new Guid("9de1b233-b753-b150-4906-4d445720e8f1"), 0, "bb78795b-9bc9-44a4-8215-5fdaf5f2d42e", new DateTime(2020, 6, 30, 3, 9, 18, 69, DateTimeKind.Unspecified).AddTicks(4386), null, false, "Marshall", "Marshall Schoen", "95249b37-12ad-dd60-56ec-bde4f4c1d0a7", "Schoen", "Cummeratatown", false, null, null, null, null, null, false, null, new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592"), false, null },
                    { new Guid("a2f3dcda-df43-530a-0c96-53f4b2c78dd4"), 0, "e6237021-076e-4834-aaaa-bae36412712b", new DateTime(2020, 12, 5, 22, 1, 52, 348, DateTimeKind.Unspecified).AddTicks(2373), null, false, "Cedric", "Cedric Cassin", "bc52bcd2-6d7c-221c-c95e-2f6a009a544f", "Cassin", "New Josefina", false, null, null, null, null, null, false, null, new Guid("dfd5e5a3-ad91-6e2a-8169-d69d496e5763"), false, null },
                    { new Guid("b354e7ff-dc8e-00a4-4e16-dbdec031d490"), 0, "6878fa5f-3bc3-44df-ab24-7083c1ca6a4a", new DateTime(2020, 4, 26, 5, 33, 14, 206, DateTimeKind.Unspecified).AddTicks(236), null, false, "Brittany", "Brittany Halvorson", "4797692b-2f06-6d30-8e2a-9af28b4dcda1", "Halvorson", "Murphychester", false, null, null, null, null, null, false, null, new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592"), false, null },
                    { new Guid("c2a70e2a-ef63-4cd3-813e-6c0feb02be4e"), 0, "b8af1f8b-bb37-4f90-8f85-2a92642f99d2", new DateTime(2020, 2, 24, 8, 3, 19, 580, DateTimeKind.Unspecified).AddTicks(5577), null, false, "Amos", "Amos Sporer", "21d66fc3-0e9c-5c52-a0bb-1f3447fcccf8", "Sporer", "South Lowellberg", false, null, null, null, null, null, false, null, new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d"), false, null }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("01f4d29a-7bee-4b95-ca48-6fcecd1ce1a5"), null, new DateTimeOffset(new DateTime(2020, 1, 30, 9, 40, 57, 749, DateTimeKind.Unspecified).AddTicks(6706), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 1, new DateTimeOffset(new DateTime(2020, 2, 9, 22, 50, 6, 236, DateTimeKind.Unspecified).AddTicks(4648), new TimeSpan(0, 7, 0, 0, 0)), "Haley, Farrell and Kozey", 21.792022756204051m, new Guid("7878f7dc-bd02-5290-3a26-8de4bc0e493e"), new Guid("4d8d10a4-6f02-8058-8923-f5bdcef26ed8") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[,]
                {
                    { new Guid("042638ff-08ab-3154-8231-2f09aa954c72"), null, new DateTimeOffset(new DateTime(2020, 4, 27, 10, 44, 21, 803, DateTimeKind.Unspecified).AddTicks(2293), new TimeSpan(0, 7, 0, 0, 0)), 7, 3, new DateTimeOffset(new DateTime(2020, 1, 13, 12, 58, 57, 999, DateTimeKind.Unspecified).AddTicks(4997), new TimeSpan(0, 7, 0, 0, 0)), "Turner - Kshlerin", 80.781452214243571m, new Guid("7bfb0e9a-450e-4de3-e61a-53cbbd200382"), new Guid("15d6a64d-3c92-41f9-295a-5fc931444a0a") },
                    { new Guid("122899aa-bb86-c8b7-29dc-92551068fe1b"), null, new DateTimeOffset(new DateTime(2020, 7, 1, 20, 44, 50, 264, DateTimeKind.Unspecified).AddTicks(9572), new TimeSpan(0, 7, 0, 0, 0)), 6, 2, new DateTimeOffset(new DateTime(2020, 12, 18, 18, 25, 20, 831, DateTimeKind.Unspecified).AddTicks(4519), new TimeSpan(0, 7, 0, 0, 0)), "Cartwright - Wyman", 37.219605184262467m, new Guid("40059f0b-1d19-9002-1e10-8a95bc55cb73"), new Guid("3f9225cd-7acc-0d19-9b61-826df2719fea") },
                    { new Guid("1d5d7434-674a-4126-1a7a-5ad14ba33acd"), null, new DateTimeOffset(new DateTime(2020, 10, 17, 6, 48, 19, 264, DateTimeKind.Unspecified).AddTicks(2696), new TimeSpan(0, 7, 0, 0, 0)), 10, 5, new DateTimeOffset(new DateTime(2020, 7, 13, 22, 33, 19, 391, DateTimeKind.Unspecified).AddTicks(2717), new TimeSpan(0, 7, 0, 0, 0)), "Bogan, Buckridge and Emmerich", 13.550234152260376m, new Guid("b9091570-e0f7-593d-99e0-58bfd294d21a"), new Guid("25654813-d753-37ec-74d8-f5f4529d9bde") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("1de7f0c5-af98-25d1-a33a-f246ec74b73f"), null, new DateTimeOffset(new DateTime(2020, 1, 3, 5, 53, 55, 345, DateTimeKind.Unspecified).AddTicks(9427), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 3, new DateTimeOffset(new DateTime(2020, 2, 15, 19, 13, 31, 474, DateTimeKind.Unspecified).AddTicks(3540), new TimeSpan(0, 7, 0, 0, 0)), "Parker - Haley", 35.584712958235627m, new Guid("5e457116-2bfb-9936-853d-5adc0468ba06"), new Guid("f3568c09-55f8-ac7e-442d-01fb2b510c8e") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[,]
                {
                    { new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), null, new DateTimeOffset(new DateTime(2020, 9, 26, 19, 59, 34, 748, DateTimeKind.Unspecified).AddTicks(3633), new TimeSpan(0, 7, 0, 0, 0)), 9, 4, new DateTimeOffset(new DateTime(2020, 9, 21, 10, 59, 29, 298, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 7, 0, 0, 0)), "Swaniawski Group", 60.925609353429424m, new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668"), new Guid("f7895455-134e-0837-4c23-7ee0b56fdc08") },
                    { new Guid("268f4ff8-d5e1-09db-b31f-3e8190949cc6"), null, new DateTimeOffset(new DateTime(2020, 9, 20, 11, 36, 27, 384, DateTimeKind.Unspecified).AddTicks(5071), new TimeSpan(0, 7, 0, 0, 0)), 8, 4, new DateTimeOffset(new DateTime(2020, 8, 18, 6, 24, 6, 102, DateTimeKind.Unspecified).AddTicks(8087), new TimeSpan(0, 7, 0, 0, 0)), "Parisian Group", 97.409943337277449m, new Guid("779c3b8b-7dec-380d-7eeb-ec94e998eb0c"), new Guid("f7895455-134e-0837-4c23-7ee0b56fdc08") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("43dc6c04-a6ef-9572-3076-3d1c0b0b8d0b"), null, new DateTimeOffset(new DateTime(2020, 2, 17, 7, 7, 30, 475, DateTimeKind.Unspecified).AddTicks(7688), new TimeSpan(0, 7, 0, 0, 0)), true, 9, 4, new DateTimeOffset(new DateTime(2020, 3, 18, 1, 20, 40, 13, DateTimeKind.Unspecified).AddTicks(3796), new TimeSpan(0, 7, 0, 0, 0)), "Hilll Inc", 13.675860461628001m, new Guid("b9091570-e0f7-593d-99e0-58bfd294d21a"), new Guid("9ef052cd-d451-a89e-0515-b413c4587a03") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("558a8384-f60e-83e4-2bea-73f473f6909e"), null, new DateTimeOffset(new DateTime(2020, 12, 10, 16, 34, 33, 56, DateTimeKind.Unspecified).AddTicks(8448), new TimeSpan(0, 7, 0, 0, 0)), 9, 5, new DateTimeOffset(new DateTime(2020, 6, 2, 14, 10, 37, 915, DateTimeKind.Unspecified).AddTicks(2252), new TimeSpan(0, 7, 0, 0, 0)), "Hegmann - Lind", 82.649599482607849m, new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592"), new Guid("3f9225cd-7acc-0d19-9b61-826df2719fea") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[,]
                {
                    { new Guid("55f6523c-51b3-95d6-89d1-d290b43e07fd"), null, new DateTimeOffset(new DateTime(2020, 10, 31, 15, 50, 59, 21, DateTimeKind.Unspecified).AddTicks(6962), new TimeSpan(0, 7, 0, 0, 0)), true, 5, 2, new DateTimeOffset(new DateTime(2020, 9, 26, 20, 14, 14, 56, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 7, 0, 0, 0)), "Krajcik - Hills", 56.176642444067056m, new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d"), new Guid("2dbc398b-52a6-a98d-d070-fe5e751ab3d8") },
                    { new Guid("6582b0e9-0df0-e6c3-28f2-ec5e2b85796a"), null, new DateTimeOffset(new DateTime(2020, 8, 16, 2, 40, 0, 617, DateTimeKind.Unspecified).AddTicks(914), new TimeSpan(0, 7, 0, 0, 0)), true, 10, 2, new DateTimeOffset(new DateTime(2020, 2, 5, 3, 2, 46, 112, DateTimeKind.Unspecified).AddTicks(6829), new TimeSpan(0, 7, 0, 0, 0)), "Braun, Schumm and Cruickshank", 91.585037295047647m, new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d"), new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab") },
                    { new Guid("7b30d717-a76c-5e6e-81be-4dcf0abad890"), null, new DateTimeOffset(new DateTime(2020, 2, 22, 10, 15, 28, 40, DateTimeKind.Unspecified).AddTicks(2326), new TimeSpan(0, 7, 0, 0, 0)), true, 7, 2, new DateTimeOffset(new DateTime(2020, 9, 25, 22, 37, 0, 775, DateTimeKind.Unspecified).AddTicks(8687), new TimeSpan(0, 7, 0, 0, 0)), "Waters, Boehm and Schaefer", 21.847405506692545m, new Guid("606f1107-4340-3d79-81f8-5d8b09c12c47"), new Guid("f3568c09-55f8-ac7e-442d-01fb2b510c8e") },
                    { new Guid("7e5e390d-d9ab-d434-ecef-08c5ede18f13"), null, new DateTimeOffset(new DateTime(2020, 1, 10, 16, 41, 18, 689, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 3, new DateTimeOffset(new DateTime(2020, 10, 18, 15, 35, 10, 115, DateTimeKind.Unspecified).AddTicks(1147), new TimeSpan(0, 7, 0, 0, 0)), "Medhurst LLC", 86.540180205619018m, new Guid("99b466ff-4c41-07d6-7020-a9f28b403607"), new Guid("f3568c09-55f8-ac7e-442d-01fb2b510c8e") },
                    { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), null, new DateTimeOffset(new DateTime(2020, 10, 30, 23, 24, 1, 897, DateTimeKind.Unspecified).AddTicks(6029), new TimeSpan(0, 7, 0, 0, 0)), true, 9, 2, new DateTimeOffset(new DateTime(2020, 3, 16, 11, 24, 16, 769, DateTimeKind.Unspecified).AddTicks(6003), new TimeSpan(0, 7, 0, 0, 0)), "Prohaska, Wiegand and Botsford", 16.929811385427511m, new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42"), new Guid("d42c9ec7-fda1-1681-fa3d-097e66c5fd01") },
                    { new Guid("85c7be28-3ba8-977e-a626-54f8f5964a2b"), null, new DateTimeOffset(new DateTime(2020, 12, 1, 17, 32, 17, 159, DateTimeKind.Unspecified).AddTicks(6019), new TimeSpan(0, 7, 0, 0, 0)), true, 10, 1, new DateTimeOffset(new DateTime(2020, 1, 13, 12, 46, 56, 708, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 7, 0, 0, 0)), "Boyle Group", 39.24078106425742m, new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42"), new Guid("318e4206-34ba-5e52-7c82-b1c93efc319c") },
                    { new Guid("85f9d68b-8075-4ce4-4687-d3b0fee00f06"), null, new DateTimeOffset(new DateTime(2020, 2, 13, 14, 52, 23, 863, DateTimeKind.Unspecified).AddTicks(905), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 4, new DateTimeOffset(new DateTime(2020, 7, 24, 16, 53, 7, 978, DateTimeKind.Unspecified).AddTicks(561), new TimeSpan(0, 7, 0, 0, 0)), "Boyer - Hirthe", 77.382694328382046m, new Guid("dae37e73-50c0-d5c8-97c6-5a7041370998"), new Guid("2dbc398b-52a6-a98d-d070-fe5e751ab3d8") },
                    { new Guid("894bbc95-6ce2-cb29-8f17-449c7ebe9a77"), null, new DateTimeOffset(new DateTime(2020, 11, 30, 6, 11, 19, 68, DateTimeKind.Unspecified).AddTicks(1436), new TimeSpan(0, 7, 0, 0, 0)), true, 8, 3, new DateTimeOffset(new DateTime(2020, 3, 25, 5, 41, 45, 13, DateTimeKind.Unspecified).AddTicks(9552), new TimeSpan(0, 7, 0, 0, 0)), "Bartell LLC", 49.371613448658742m, new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d"), new Guid("a8ffd52a-3d62-ea5c-e177-a771279a4944") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("946cbe11-beeb-0694-f564-dda95675991f"), null, new DateTimeOffset(new DateTime(2020, 3, 10, 23, 25, 46, 890, DateTimeKind.Unspecified).AddTicks(3949), new TimeSpan(0, 7, 0, 0, 0)), 7, 4, new DateTimeOffset(new DateTime(2020, 4, 21, 4, 3, 52, 55, DateTimeKind.Unspecified).AddTicks(9465), new TimeSpan(0, 7, 0, 0, 0)), "Hansen - Bogan", 8.366615992675819m, new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), new Guid("40e562d7-b50b-4ad9-5089-8507682b0d58") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("9b0258ef-d34c-bfca-2865-b935f45efc20"), null, new DateTimeOffset(new DateTime(2020, 9, 24, 0, 59, 34, 45, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 7, 0, 0, 0)), true, 8, 5, new DateTimeOffset(new DateTime(2020, 12, 30, 10, 46, 37, 664, DateTimeKind.Unspecified).AddTicks(3713), new TimeSpan(0, 7, 0, 0, 0)), "Emard and Sons", 62.627828730562666m, new Guid("81fda1d4-fa16-093d-7e66-c5fd012c2fc3"), new Guid("1e329db5-c9fa-05fc-d497-5ed3d8499f7c") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("9d403be7-1591-a47f-eda5-1411ff876f4f"), null, new DateTimeOffset(new DateTime(2020, 12, 10, 19, 1, 48, 341, DateTimeKind.Unspecified).AddTicks(6960), new TimeSpan(0, 7, 0, 0, 0)), 5, 4, new DateTimeOffset(new DateTime(2020, 2, 8, 13, 13, 34, 699, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 7, 0, 0, 0)), "Koch, Abbott and Bosco", 98.507310797230939m, new Guid("6100e542-8ed9-94dd-02eb-d05d806edcfa"), new Guid("52ae2b65-5087-b81d-b47d-7fa37ad24f03") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[,]
                {
                    { new Guid("a00e7adf-e39c-17c1-6ce4-8e824e0221be"), null, new DateTimeOffset(new DateTime(2020, 4, 22, 20, 9, 5, 154, DateTimeKind.Unspecified).AddTicks(2417), new TimeSpan(0, 7, 0, 0, 0)), true, 7, 1, new DateTimeOffset(new DateTime(2020, 8, 9, 9, 3, 46, 841, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 7, 0, 0, 0)), "Kozey, Frami and Hermann", 53.099011978180651m, new Guid("f880aa64-7561-7503-de83-7f97fc4ce8a5"), new Guid("54f608ca-598f-a8ca-8e37-a92300d6a440") },
                    { new Guid("bc12e381-9af1-1ac4-c15e-a986da5b57bd"), null, new DateTimeOffset(new DateTime(2020, 7, 4, 21, 31, 16, 135, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 7, 0, 0, 0)), true, 5, 5, new DateTimeOffset(new DateTime(2020, 9, 5, 13, 8, 9, 133, DateTimeKind.Unspecified).AddTicks(1833), new TimeSpan(0, 7, 0, 0, 0)), "Will - Jacobson", 77.654878449465547m, new Guid("837c4af8-1b95-302e-d982-d3e35c19fca2"), new Guid("62b12191-f9c9-e502-08cf-118995c540a7") },
                    { new Guid("bfb312c3-362b-ec49-fcb7-61f2db22d65c"), null, new DateTimeOffset(new DateTime(2020, 5, 7, 18, 19, 46, 539, DateTimeKind.Unspecified).AddTicks(3603), new TimeSpan(0, 7, 0, 0, 0)), true, 5, 3, new DateTimeOffset(new DateTime(2020, 3, 29, 14, 17, 58, 420, DateTimeKind.Unspecified).AddTicks(4604), new TimeSpan(0, 7, 0, 0, 0)), "Schinner, Prosacco and Weissnat", 11.104404553819675m, new Guid("f4b6b354-f64b-e238-6806-00f403e85ab4"), new Guid("3313ce27-d248-29a8-fd66-c566826226cd") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[,]
                {
                    { new Guid("c34ae2e6-68cc-6e9c-d22e-1db28b88829e"), null, new DateTimeOffset(new DateTime(2020, 7, 11, 20, 57, 29, 788, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, 7, 0, 0, 0)), 7, 3, new DateTimeOffset(new DateTime(2020, 5, 29, 1, 45, 33, 538, DateTimeKind.Unspecified).AddTicks(4115), new TimeSpan(0, 7, 0, 0, 0)), "Kling - Murazik", 16.977870431252686m, new Guid("606f1107-4340-3d79-81f8-5d8b09c12c47"), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("c888dbdb-1c04-f09f-f960-26ada1097c5d"), null, new DateTimeOffset(new DateTime(2020, 11, 23, 18, 15, 37, 229, DateTimeKind.Unspecified).AddTicks(3465), new TimeSpan(0, 7, 0, 0, 0)), 8, 1, new DateTimeOffset(new DateTime(2020, 3, 14, 8, 24, 23, 786, DateTimeKind.Unspecified).AddTicks(5759), new TimeSpan(0, 7, 0, 0, 0)), "Purdy, Dickinson and Lesch", 77.014684300410856m, new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d"), new Guid("f680eb09-208b-2b14-1237-d52d64d485ab") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[,]
                {
                    { new Guid("c9b3ea50-4009-f618-ff5f-134b47a79f0f"), null, new DateTimeOffset(new DateTime(2020, 6, 6, 19, 16, 45, 616, DateTimeKind.Unspecified).AddTicks(7732), new TimeSpan(0, 7, 0, 0, 0)), true, 10, 2, new DateTimeOffset(new DateTime(2020, 6, 4, 23, 32, 46, 361, DateTimeKind.Unspecified).AddTicks(5458), new TimeSpan(0, 7, 0, 0, 0)), "Bergstrom - Connelly", 58.874999431369384m, new Guid("d2f046ac-c105-40c7-eabf-733a9492edc5"), new Guid("f7895455-134e-0837-4c23-7ee0b56fdc08") },
                    { new Guid("cf7d3633-3eee-94eb-b598-83a5ac711802"), null, new DateTimeOffset(new DateTime(2020, 9, 30, 21, 5, 52, 94, DateTimeKind.Unspecified).AddTicks(1626), new TimeSpan(0, 7, 0, 0, 0)), true, 8, 5, new DateTimeOffset(new DateTime(2020, 5, 30, 21, 34, 39, 566, DateTimeKind.Unspecified).AddTicks(3868), new TimeSpan(0, 7, 0, 0, 0)), "Morar, Nicolas and Smitham", 11.949796170904195m, new Guid("f0873793-18d6-4a84-5a2e-46f599ad27f6"), new Guid("40179df0-b9b7-ccb0-8b46-fc9cb10a0aa2") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("da46d4f4-4577-fb00-969b-e0dfb77ed0ff"), null, new DateTimeOffset(new DateTime(2020, 6, 1, 11, 0, 5, 239, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 7, 0, 0, 0)), 7, 2, new DateTimeOffset(new DateTime(2020, 8, 14, 12, 3, 3, 247, DateTimeKind.Unspecified).AddTicks(2258), new TimeSpan(0, 7, 0, 0, 0)), "Smitham - Erdman", 9.6517032192329464m, new Guid("8bdb736b-89b7-be24-1c15-31f7e7421644"), new Guid("d354372e-f04c-d28b-e2e7-d40211337a1c") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[,]
                {
                    { new Guid("dc880bf8-48e0-6c50-837a-3f2480a252fb"), null, new DateTimeOffset(new DateTime(2020, 9, 16, 5, 0, 14, 383, DateTimeKind.Unspecified).AddTicks(3676), new TimeSpan(0, 7, 0, 0, 0)), true, 10, 3, new DateTimeOffset(new DateTime(2020, 10, 11, 9, 1, 27, 812, DateTimeKind.Unspecified).AddTicks(6147), new TimeSpan(0, 7, 0, 0, 0)), "Heathcote Group", 9.0574244442663301m, new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), new Guid("25654813-d753-37ec-74d8-f5f4529d9bde") },
                    { new Guid("dcaebaaf-f809-9558-8919-c4f71079e80d"), null, new DateTimeOffset(new DateTime(2020, 2, 3, 15, 10, 11, 192, DateTimeKind.Unspecified).AddTicks(8881), new TimeSpan(0, 7, 0, 0, 0)), true, 7, 1, new DateTimeOffset(new DateTime(2020, 3, 4, 10, 38, 5, 432, DateTimeKind.Unspecified).AddTicks(660), new TimeSpan(0, 7, 0, 0, 0)), "Gerlach, Hodkiewicz and Schamberger", 83.282385148239529m, new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25"), new Guid("f680eb09-208b-2b14-1237-d52d64d485ab") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[,]
                {
                    { new Guid("de4ff2b1-a48b-873f-c7ca-08f63404c6ce"), null, new DateTimeOffset(new DateTime(2020, 1, 2, 12, 16, 42, 80, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 7, 0, 0, 0)), 9, 3, new DateTimeOffset(new DateTime(2020, 11, 17, 15, 22, 59, 830, DateTimeKind.Unspecified).AddTicks(8437), new TimeSpan(0, 7, 0, 0, 0)), "Doyle Inc", 92.671677268423021m, new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d"), new Guid("86f76dc2-3ca8-46e6-80ed-8168bd10e2e3") },
                    { new Guid("e9a30a4b-5518-1855-0a66-8a00ae6966ab"), null, new DateTimeOffset(new DateTime(2020, 2, 26, 0, 53, 9, 743, DateTimeKind.Unspecified).AddTicks(3922), new TimeSpan(0, 7, 0, 0, 0)), 7, 4, new DateTimeOffset(new DateTime(2020, 12, 9, 16, 42, 55, 877, DateTimeKind.Unspecified).AddTicks(5738), new TimeSpan(0, 7, 0, 0, 0)), "O'Kon - Muller", 9.727950949095169m, new Guid("f880aa64-7561-7503-de83-7f97fc4ce8a5"), new Guid("a2e64313-e8a4-bda0-6c2b-a7d672050a8f") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[,]
                {
                    { new Guid("f0bc8bcb-9c50-1a09-e65f-56c571a1badf"), null, new DateTimeOffset(new DateTime(2020, 9, 25, 4, 57, 4, 928, DateTimeKind.Unspecified).AddTicks(3903), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 1, new DateTimeOffset(new DateTime(2020, 8, 12, 18, 35, 15, 238, DateTimeKind.Unspecified).AddTicks(2060), new TimeSpan(0, 7, 0, 0, 0)), "Prosacco Group", 62.774082924599782m, new Guid("9fcce051-4f9f-f1f2-63d6-b684ab1f528f"), new Guid("4d8d10a4-6f02-8058-8923-f5bdcef26ed8") },
                    { new Guid("f7771a35-735e-edff-b14e-cd1606d57de8"), null, new DateTimeOffset(new DateTime(2020, 5, 18, 17, 34, 39, 269, DateTimeKind.Unspecified).AddTicks(5936), new TimeSpan(0, 7, 0, 0, 0)), true, 10, 5, new DateTimeOffset(new DateTime(2020, 7, 21, 21, 41, 43, 239, DateTimeKind.Unspecified).AddTicks(9690), new TimeSpan(0, 7, 0, 0, 0)), "Brakus - Larkin", 26.650296178949233m, new Guid("6100e542-8ed9-94dd-02eb-d05d806edcfa"), new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab") },
                    { new Guid("fa994fb6-2e25-c984-c137-9a968f6f9cb1"), null, new DateTimeOffset(new DateTime(2020, 6, 1, 20, 0, 41, 808, DateTimeKind.Unspecified).AddTicks(1083), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 1, new DateTimeOffset(new DateTime(2020, 7, 6, 6, 7, 9, 676, DateTimeKind.Unspecified).AddTicks(9796), new TimeSpan(0, 7, 0, 0, 0)), "Marvin - Dach", 47.775896016869602m, new Guid("9588df2f-6267-6dd3-4359-1ec672055d47"), new Guid("a2e64313-e8a4-bda0-6c2b-a7d672050a8f") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("ff8d9313-3631-7d5e-8223-78fc98684039"), null, new DateTimeOffset(new DateTime(2020, 5, 7, 5, 51, 8, 797, DateTimeKind.Unspecified).AddTicks(9424), new TimeSpan(0, 7, 0, 0, 0)), 7, 2, new DateTimeOffset(new DateTime(2020, 10, 18, 16, 18, 14, 115, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 7, 0, 0, 0)), "Towne - Murphy", 1.93935511118702341m, new Guid("360f39a0-9ef3-42c7-47d5-608af0d59ff4"), new Guid("86f76dc2-3ca8-46e6-80ed-8168bd10e2e3") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("06109627-6508-6080-35ad-238abbb04a8e"), 711.17m, new DateTimeOffset(new DateTime(2020, 4, 17, 18, 48, 56, 764, DateTimeKind.Unspecified).AddTicks(8306), new TimeSpan(0, 7, 0, 0, 0)), "Non voluptatem nam.", true, new DateTimeOffset(new DateTime(2020, 6, 4, 12, 44, 51, 393, DateTimeKind.Unspecified).AddTicks(8721), new TimeSpan(0, 7, 0, 0, 0)), "adipisci", new Guid("11cf08e5-9589-40c5-a761-187ed55224f6"), new Guid("8c223896-e751-0945-eb80-f68b20142b12") },
                    { new Guid("29a8d248-66fd-66c5-8262-26cdde04085c"), 628.74m, new DateTimeOffset(new DateTime(2020, 6, 22, 22, 37, 6, 953, DateTimeKind.Unspecified).AddTicks(9482), new TimeSpan(0, 7, 0, 0, 0)), "Iste ut consequatur veniam accusamus explicabo quia.", true, new DateTimeOffset(new DateTime(2020, 7, 10, 3, 49, 13, 370, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 7, 0, 0, 0)), "libero", new Guid("4fbc87d7-b534-95ce-0699-083d05b4056f"), new Guid("a740c595-1861-d57e-5224-f6098c56f3f8") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("2f96af49-0c5f-aae2-4230-9edddf13c915"), 857.80m, new DateTimeOffset(new DateTime(2020, 10, 4, 8, 50, 59, 933, DateTimeKind.Unspecified).AddTicks(6221), new TimeSpan(0, 7, 0, 0, 0)), "Aut animi incidunt.", new DateTimeOffset(new DateTime(2020, 9, 6, 9, 3, 19, 740, DateTimeKind.Unspecified).AddTicks(5129), new TimeSpan(0, 7, 0, 0, 0)), "vitae", new Guid("b9091570-e0f7-593d-99e0-58bfd294d21a"), new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("61cb6c4e-d08c-e867-a5e9-d2d209173f4e"), 827.81m, new DateTimeOffset(new DateTime(2020, 2, 8, 7, 52, 2, 282, DateTimeKind.Unspecified).AddTicks(2798), new TimeSpan(0, 7, 0, 0, 0)), "Inventore praesentium dolor voluptates itaque.", true, new DateTimeOffset(new DateTime(2020, 6, 23, 18, 1, 11, 435, DateTimeKind.Unspecified).AddTicks(2493), new TimeSpan(0, 7, 0, 0, 0)), "perspiciatis", new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42"), new Guid("9433c32f-2762-2724-ce13-3348d2a829fd") },
                    { new Guid("69626c93-ef33-5a85-b90a-53b0f5a84781"), 556.49m, new DateTimeOffset(new DateTime(2020, 5, 28, 2, 14, 44, 345, DateTimeKind.Unspecified).AddTicks(3713), new TimeSpan(0, 7, 0, 0, 0)), "Nisi atque rerum dolorum architecto saepe.", true, new DateTimeOffset(new DateTime(2020, 7, 26, 18, 4, 23, 383, DateTimeKind.Unspecified).AddTicks(8763), new TimeSpan(0, 7, 0, 0, 0)), "sit", new Guid("4fbc87d7-b534-95ce-0699-083d05b4056f"), new Guid("2cc304c0-f65d-fe35-7c8d-3740a4699010") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("8bf680eb-1420-122b-37d5-2d64d485abd5"), 775.09m, new DateTimeOffset(new DateTime(2020, 6, 20, 13, 18, 39, 4, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 7, 0, 0, 0)), "Ut rem ea distinctio omnis.", new DateTimeOffset(new DateTime(2020, 5, 30, 23, 36, 22, 165, DateTimeKind.Unspecified).AddTicks(5252), new TimeSpan(0, 7, 0, 0, 0)), "quisquam", new Guid("b9091570-e0f7-593d-99e0-58bfd294d21a"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("914042cc-dafa-ffd7-358d-04ae36c7ca60"), 703.91m, new DateTimeOffset(new DateTime(2020, 11, 6, 17, 8, 49, 277, DateTimeKind.Unspecified).AddTicks(8392), new TimeSpan(0, 7, 0, 0, 0)), "Rerum porro accusantium aliquam velit quos.", true, new DateTimeOffset(new DateTime(2020, 2, 15, 22, 25, 49, 504, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 7, 0, 0, 0)), "quo", new Guid("40059f0b-1d19-9002-1e10-8a95bc55cb73"), new Guid("1f41cd8d-072c-b793-df38-5c9a4619abd6") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), 731.59m, new DateTimeOffset(new DateTime(2020, 2, 8, 1, 56, 42, 864, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 7, 0, 0, 0)), "Laboriosam sit minus.", new DateTimeOffset(new DateTime(2020, 3, 9, 13, 40, 51, 467, DateTimeKind.Unspecified).AddTicks(5012), new TimeSpan(0, 7, 0, 0, 0)), "sunt", new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d"), new Guid("72d6a72b-0a05-898f-22cd-5b94c9155554") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"), 539.94m, new DateTimeOffset(new DateTime(2020, 10, 12, 10, 47, 18, 159, DateTimeKind.Unspecified).AddTicks(3036), new TimeSpan(0, 7, 0, 0, 0)), "Neque et libero fugit et dolores tempora quia molestias corrupti.", true, new DateTimeOffset(new DateTime(2020, 5, 13, 0, 24, 7, 623, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 7, 0, 0, 0)), "libero", new Guid("4fbc87d7-b534-95ce-0699-083d05b4056f"), new Guid("2cc304c0-f65d-fe35-7c8d-3740a4699010") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("b1835381-0a6f-3558-0ef0-f5e74a756503"), 485.62m, new DateTimeOffset(new DateTime(2020, 5, 14, 12, 5, 5, 564, DateTimeKind.Unspecified).AddTicks(3254), new TimeSpan(0, 7, 0, 0, 0)), "Pariatur dolorum laborum et doloribus et occaecati vel.", new DateTimeOffset(new DateTime(2020, 10, 26, 7, 27, 3, 231, DateTimeKind.Unspecified).AddTicks(2670), new TimeSpan(0, 7, 0, 0, 0)), "natus", new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d"), new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3") },
                    { new Guid("b35b2234-24f4-2054-ad1a-71ce513a15ab"), 854.79m, new DateTimeOffset(new DateTime(2020, 12, 7, 3, 10, 6, 157, DateTimeKind.Unspecified).AddTicks(1279), new TimeSpan(0, 7, 0, 0, 0)), "Autem ab repellat rerum odio.", new DateTimeOffset(new DateTime(2020, 6, 12, 16, 30, 49, 234, DateTimeKind.Unspecified).AddTicks(5625), new TimeSpan(0, 7, 0, 0, 0)), "officiis", new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), new Guid("0804decd-7b5c-9799-690f-47fb03e9ce3b") },
                    { new Guid("cd4ee9d2-9528-80df-ffff-977fca08f654"), 839.72m, new DateTimeOffset(new DateTime(2020, 9, 30, 20, 47, 59, 884, DateTimeKind.Unspecified).AddTicks(1661), new TimeSpan(0, 7, 0, 0, 0)), "Sit et rerum pariatur.", new DateTimeOffset(new DateTime(2020, 1, 18, 10, 13, 59, 453, DateTimeKind.Unspecified).AddTicks(3463), new TimeSpan(0, 7, 0, 0, 0)), "excepturi", new Guid("5e457116-2bfb-9936-853d-5adc0468ba06"), new Guid("2cc304c0-f65d-fe35-7c8d-3740a4699010") },
                    { new Guid("d27aa37f-034f-ce19-64c7-57c651b6c26d"), 811.22m, new DateTimeOffset(new DateTime(2020, 10, 17, 14, 30, 51, 308, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 7, 0, 0, 0)), "Assumenda laboriosam autem dolorem qui laborum ab nemo et.", new DateTimeOffset(new DateTime(2020, 7, 22, 17, 56, 42, 284, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 7, 0, 0, 0)), "architecto", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f"), new Guid("2b65bc72-52ae-5087-1db8-b47d7fa37ad2") },
                    { new Guid("d57e1861-2452-09f6-8c56-f3f8557eac44"), 776.26m, new DateTimeOffset(new DateTime(2020, 11, 23, 2, 38, 5, 756, DateTimeKind.Unspecified).AddTicks(7608), new TimeSpan(0, 7, 0, 0, 0)), "Vero autem nulla magni eius ipsum delectus.", new DateTimeOffset(new DateTime(2020, 10, 31, 10, 23, 2, 508, DateTimeKind.Unspecified).AddTicks(9808), new TimeSpan(0, 7, 0, 0, 0)), "ut", new Guid("f12096d7-2697-2757-cded-e8d3504da036"), new Guid("2b65bc72-52ae-5087-1db8-b47d7fa37ad2") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("d87437ec-f4f5-9d52-9bde-35a4eb67d140"), 627.06m, new DateTimeOffset(new DateTime(2020, 5, 23, 12, 40, 19, 76, DateTimeKind.Unspecified).AddTicks(9423), new TimeSpan(0, 7, 0, 0, 0)), "Molestias beatae assumenda et est aut aut nihil recusandae.", true, new DateTimeOffset(new DateTime(2020, 1, 19, 21, 10, 47, 394, DateTimeKind.Unspecified).AddTicks(5526), new TimeSpan(0, 7, 0, 0, 0)), "nam", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f"), new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("db033f39-57ce-32f6-1cc5-87dc332ddaa1"), 330.22m, new DateTimeOffset(new DateTime(2020, 7, 9, 21, 41, 55, 475, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 7, 0, 0, 0)), "Omnis sapiente ullam.", new DateTimeOffset(new DateTime(2020, 1, 23, 4, 28, 2, 804, DateTimeKind.Unspecified).AddTicks(1032), new TimeSpan(0, 7, 0, 0, 0)), "cupiditate", new Guid("f12096d7-2697-2757-cded-e8d3504da036"), new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("e6a2ec69-f641-824f-8aa4-5d905ab4812d"), 768.81m, new DateTimeOffset(new DateTime(2020, 10, 25, 5, 37, 5, 395, DateTimeKind.Unspecified).AddTicks(9988), new TimeSpan(0, 7, 0, 0, 0)), "A qui voluptatem qui rerum deserunt voluptas voluptas assumenda expedita.", true, new DateTimeOffset(new DateTime(2020, 3, 3, 16, 56, 56, 443, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, 7, 0, 0, 0)), "repellendus", new Guid("40059f0b-1d19-9002-1e10-8a95bc55cb73"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1") },
                    { new Guid("f2cebdf5-d86e-8d84-04bd-66760f9121b1"), 167.65m, new DateTimeOffset(new DateTime(2020, 6, 26, 3, 56, 4, 181, DateTimeKind.Unspecified).AddTicks(3568), new TimeSpan(0, 7, 0, 0, 0)), "Ut qui omnis ut nihil.", true, new DateTimeOffset(new DateTime(2020, 2, 18, 9, 55, 4, 315, DateTimeKind.Unspecified).AddTicks(9502), new TimeSpan(0, 7, 0, 0, 0)), "maiores", new Guid("7878f7dc-bd02-5290-3a26-8de4bc0e493e"), new Guid("5fac0bab-9b1e-2b3f-cd52-f09e51d49ea8") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("5f702285-9be0-b426-2e79-e32f70dde1ba"), 940.99m, new Guid("80a4ba18-ba4a-6b60-5e7d-df7d9935d59a"), new DateTimeOffset(new DateTime(2020, 5, 16, 21, 45, 3, 923, DateTimeKind.Unspecified).AddTicks(4913), new TimeSpan(0, 7, 0, 0, 0)), new Guid("953b298b-2d7e-d55f-136d-3fc2a7f518e0"), "Nulla ipsum totam consequatur omnis beatae nam.", true, new DateTimeOffset(new DateTime(2020, 10, 7, 1, 4, 50, 205, DateTimeKind.Unspecified).AddTicks(1735), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("f4b6b354-f64b-e238-6806-00f403e85ab4"), new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("df1097eb-55bd-64d3-a3db-4a109f23666b"), 11.04m, new Guid("7a647cf4-86de-48e8-fdde-1e2017543522"), new DateTimeOffset(new DateTime(2020, 8, 11, 6, 56, 14, 334, DateTimeKind.Unspecified).AddTicks(5153), new TimeSpan(0, 7, 0, 0, 0)), new Guid("0ae18c23-5a4e-0f8e-e3c1-25f2744b08ab"), "Quia tempora et hic culpa et ipsum quo nihil.", new DateTimeOffset(new DateTime(2020, 10, 18, 14, 0, 13, 916, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42"), new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("0c512bfb-868e-3e86-eded-bd69d81343e6"), 650.35m, new DateTimeOffset(new DateTime(2020, 6, 27, 5, 56, 4, 915, DateTimeKind.Unspecified).AddTicks(7087), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 11, 19, 59, 13, 581, DateTimeKind.Unspecified).AddTicks(3488), new TimeSpan(0, 7, 0, 0, 0)), "Checking Account", new Guid("7bfb0e9a-450e-4de3-e61a-53cbbd200382") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("2495c693-e3b9-7c6f-3898-b7dd200bc116"), 731.59m, new DateTimeOffset(new DateTime(2020, 11, 29, 10, 12, 37, 137, DateTimeKind.Unspecified).AddTicks(6391), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 1, 18, 0, 40, 732, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, 7, 0, 0, 0)), "Auto Loan Account", new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("2d49430d-4e90-f11b-51a9-34225bb3f424"), 189.96m, new DateTimeOffset(new DateTime(2020, 10, 22, 18, 16, 15, 692, DateTimeKind.Unspecified).AddTicks(9480), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 12, 9, 55, 20, 6, DateTimeKind.Unspecified).AddTicks(2292), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("f0873793-18d6-4a84-5a2e-46f599ad27f6") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("2f96af49-0c5f-aae2-4230-9edddf13c915"), 312.48m, new DateTimeOffset(new DateTime(2020, 2, 22, 2, 18, 31, 0, DateTimeKind.Unspecified).AddTicks(7504), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 2, 1, 36, 47, 105, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("b9091570-e0f7-593d-99e0-58bfd294d21a") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("3f5dfa6f-bbef-f955-f750-e56dce5a4d97"), 139.35m, new DateTimeOffset(new DateTime(2020, 3, 22, 8, 53, 34, 255, DateTimeKind.Unspecified).AddTicks(9394), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 21, 8, 31, 42, 675, DateTimeKind.Unspecified).AddTicks(8069), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("360f39a0-9ef3-42c7-47d5-608af0d59ff4") },
                    { new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), 714.22m, new DateTimeOffset(new DateTime(2020, 7, 15, 20, 22, 7, 462, DateTimeKind.Unspecified).AddTicks(1292), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 20, 7, 29, 16, 338, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, 7, 0, 0, 0)), "Credit Card Account", new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59"), 866.85m, new DateTimeOffset(new DateTime(2020, 5, 12, 6, 2, 28, 264, DateTimeKind.Unspecified).AddTicks(4242), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 2, 25, 11, 1, 34, 119, DateTimeKind.Unspecified).AddTicks(7386), new TimeSpan(0, 7, 0, 0, 0)), "Credit Card Account", new Guid("dfd5e5a3-ad91-6e2a-8169-d69d496e5763") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("ab153a51-6d1e-d275-65d3-3d5c153a9787"), 525.45m, new DateTimeOffset(new DateTime(2020, 4, 24, 14, 31, 53, 904, DateTimeKind.Unspecified).AddTicks(3217), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 14, 23, 41, 43, 347, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 7, 0, 0, 0)), "Credit Card Account", new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668") },
                    { new Guid("d3626795-436d-1e59-c672-055d47c2ed18"), 748.46m, new DateTimeOffset(new DateTime(2020, 2, 11, 9, 28, 0, 386, DateTimeKind.Unspecified).AddTicks(3550), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 21, 2, 53, 57, 178, DateTimeKind.Unspecified).AddTicks(2754), new TimeSpan(0, 7, 0, 0, 0)), "Savings Account", new Guid("40059f0b-1d19-9002-1e10-8a95bc55cb73") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("d405fcc9-5e97-d8d3-499f-7ce08d1783e3"), 782.81m, new DateTimeOffset(new DateTime(2020, 4, 5, 14, 28, 56, 88, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 29, 5, 57, 43, 860, DateTimeKind.Unspecified).AddTicks(3340), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("d2f046ac-c105-40c7-eabf-733a9492edc5") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("e07e234c-6fb5-08dc-5b8c-438fffa9361b"), 125.53m, new DateTimeOffset(new DateTime(2020, 6, 19, 20, 5, 33, 975, DateTimeKind.Unspecified).AddTicks(5038), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 27, 16, 55, 50, 381, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("a4ba18a9-4a80-60ba-6b5e-7ddf7d9935d5") },
                    { new Guid("e189d5ab-c58e-c880-8b39-bc2da6528da9"), 874.66m, new DateTimeOffset(new DateTime(2020, 10, 22, 12, 13, 20, 806, DateTimeKind.Unspecified).AddTicks(3387), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 2, 20, 8, 51, 675, DateTimeKind.Unspecified).AddTicks(6989), new TimeSpan(0, 7, 0, 0, 0)), "Investment Account", new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("f694ea54-f527-eed5-e010-5eca808b3b9c"), 41.27m, new DateTimeOffset(new DateTime(2020, 10, 22, 14, 51, 18, 56, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 12, 10, 55, 37, 787, DateTimeKind.Unspecified).AddTicks(2114), new TimeSpan(0, 7, 0, 0, 0)), "Auto Loan Account", new Guid("7878f7dc-bd02-5290-3a26-8de4bc0e493e") });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DayOfBirth", "Email", "EmailConfirmed", "FirstName", "FullName", "IdentityId", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SupervisorId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3b18d343-2ea5-4803-3f37-73c3e7b57871"), 0, "f9757c3e-cb21-4f9f-a1c3-3f8743143643", new DateTime(2020, 6, 3, 12, 8, 57, 912, DateTimeKind.Unspecified).AddTicks(7736), null, false, "Kara", "Kara Douglas", "e6ae1478-8f1b-c943-f57b-e72e6c001c6d", "Douglas", "Collinston", false, null, null, null, null, null, false, null, new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4"), false, null },
                    { new Guid("6b17d449-6d47-ded4-42e8-91b1dda61892"), 0, "0cdb0417-ff84-4d3b-858a-be5c58f91639", new DateTime(2020, 6, 7, 6, 38, 7, 852, DateTimeKind.Unspecified).AddTicks(7395), null, false, "Gina", "Gina Hartmann", "f4c19fd7-32fe-4a67-4067-265a24cc3c8b", "Hartmann", "Dulcemouth", false, null, null, null, null, null, false, null, new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4"), false, null },
                    { new Guid("6b601e2a-fd75-5bb7-5be1-196ca9cff63a"), 0, "bc4618e7-2867-4011-9bdc-468a8a92614e", new DateTime(2020, 2, 13, 7, 41, 38, 306, DateTimeKind.Unspecified).AddTicks(9474), null, false, "Jeannette", "Jeannette Gulgowski", "958622b0-9ce3-bd80-11a2-342663de9bee", "Gulgowski", "South Leilani", false, null, null, null, null, null, false, null, new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4"), false, null }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"), new Guid("85f9d68b-8075-4ce4-4687-d3b0fee00f06"), new DateTimeOffset(new DateTime(2020, 1, 22, 11, 23, 58, 503, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 23, 20, 31, 6, 504, DateTimeKind.Unspecified).AddTicks(6291), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4fbc87d7-b534-95ce-0699-083d05b4056f") },
                    { new Guid("0b40e562-d9b5-504a-8985-07682b0d588f"), new Guid("042638ff-08ab-3154-8231-2f09aa954c72"), new DateTimeOffset(new DateTime(2020, 4, 4, 1, 57, 59, 158, DateTimeKind.Unspecified).AddTicks(5478), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 16, 11, 32, 50, 387, DateTimeKind.Unspecified).AddTicks(8566), new TimeSpan(0, 7, 0, 0, 0)), new Guid("40059f0b-1d19-9002-1e10-8a95bc55cb73") },
                    { new Guid("15c913df-778a-5837-5d13-48652553d7ec"), new Guid("cf7d3633-3eee-94eb-b598-83a5ac711802"), new DateTimeOffset(new DateTime(2020, 9, 27, 12, 32, 36, 206, DateTimeKind.Unspecified).AddTicks(5096), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 13, 7, 27, 36, 662, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 7, 0, 0, 0)), new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("2dd53712-d464-ab85-d589-e18ec580c88b"), new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new DateTimeOffset(new DateTime(2020, 6, 13, 1, 3, 53, 798, DateTimeKind.Unspecified).AddTicks(765), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 20, 13, 18, 39, 4, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 7, 0, 0, 0)), new Guid("360f39a0-9ef3-42c7-47d5-608af0d59ff4") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"), new Guid("01f4d29a-7bee-4b95-ca48-6fcecd1ce1a5"), new DateTimeOffset(new DateTime(2020, 2, 22, 22, 1, 17, 802, DateTimeKind.Unspecified).AddTicks(3374), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 1, 31, 10, 15, 9, 302, DateTimeKind.Unspecified).AddTicks(522), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f4b6b354-f64b-e238-6806-00f403e85ab4") },
                    { new Guid("33c32f2c-6294-2427-27ce-133348d2a829"), new Guid("bfb312c3-362b-ec49-fcb7-61f2db22d65c"), new DateTimeOffset(new DateTime(2020, 5, 9, 20, 45, 55, 481, DateTimeKind.Unspecified).AddTicks(9440), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 24, 19, 33, 12, 457, DateTimeKind.Unspecified).AddTicks(6893), new TimeSpan(0, 7, 0, 0, 0)), new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("41cd8dba-2c1f-9307-b7df-385c9a4619ab"), new Guid("bc12e381-9af1-1ac4-c15e-a986da5b57bd"), new DateTimeOffset(new DateTime(2020, 5, 4, 3, 35, 35, 292, DateTimeKind.Unspecified).AddTicks(3871), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 9, 9, 15, 14, 43, 740, DateTimeKind.Unspecified).AddTicks(9573), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4a1c6b89-d069-783e-490c-18783c5527ee") },
                    { new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), new Guid("042638ff-08ab-3154-8231-2f09aa954c72"), new DateTimeOffset(new DateTime(2020, 8, 11, 16, 15, 36, 138, DateTimeKind.Unspecified).AddTicks(9716), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 5, 26, 12, 33, 31, 347, DateTimeKind.Unspecified).AddTicks(7113), new TimeSpan(0, 7, 0, 0, 0)), new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"), new Guid("85c7be28-3ba8-977e-a626-54f8f5964a2b"), new DateTimeOffset(new DateTime(2020, 2, 7, 14, 50, 43, 347, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 17, 23, 54, 58, 995, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), new Guid("da46d4f4-4577-fb00-969b-e0dfb77ed0ff"), new DateTimeOffset(new DateTime(2020, 1, 10, 18, 18, 41, 979, DateTimeKind.Unspecified).AddTicks(989), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 28, 17, 20, 18, 260, DateTimeKind.Unspecified).AddTicks(2219), new TimeSpan(0, 7, 0, 0, 0)), new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), new Guid("f0bc8bcb-9c50-1a09-e65f-56c571a1badf"), new DateTimeOffset(new DateTime(2020, 11, 14, 2, 51, 15, 357, DateTimeKind.Unspecified).AddTicks(1856), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 12, 6, 44, 36, 651, DateTimeKind.Unspecified).AddTicks(734), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7878f7dc-bd02-5290-3a26-8de4bc0e493e") },
                    { new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), new Guid("7b30d717-a76c-5e6e-81be-4dcf0abad890"), new DateTimeOffset(new DateTime(2020, 12, 27, 18, 49, 42, 41, DateTimeKind.Unspecified).AddTicks(5112), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 3, 22, 30, 55, 391, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668") },
                    { new Guid("72ff2f81-65bc-ae2b-5287-501db8b47d7f"), new Guid("01f4d29a-7bee-4b95-ca48-6fcecd1ce1a5"), new DateTimeOffset(new DateTime(2020, 5, 6, 22, 53, 24, 287, DateTimeKind.Unspecified).AddTicks(8952), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 2, 15, 15, 19, 38, 590, DateTimeKind.Unspecified).AddTicks(6557), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9588df2f-6267-6dd3-4359-1ec672055d47") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"), new Guid("a00e7adf-e39c-17c1-6ce4-8e824e0221be"), new DateTimeOffset(new DateTime(2020, 6, 28, 11, 32, 16, 86, DateTimeKind.Unspecified).AddTicks(6546), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 13, 7, 52, 50, 894, DateTimeKind.Unspecified).AddTicks(8104), new TimeSpan(0, 7, 0, 0, 0)), new Guid("837c4af8-1b95-302e-d982-d3e35c19fca2") },
                    { new Guid("7ee018f5-529b-b002-62f6-8e93af65c0a8"), new Guid("f7771a35-735e-edff-b14e-cd1606d57de8"), new DateTimeOffset(new DateTime(2020, 9, 30, 22, 41, 15, 33, DateTimeKind.Unspecified).AddTicks(7936), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 4, 20, 1, 40, 911, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc") },
                    { new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"), new Guid("cf7d3633-3eee-94eb-b598-83a5ac711802"), new DateTimeOffset(new DateTime(2020, 9, 5, 19, 37, 37, 889, DateTimeKind.Unspecified).AddTicks(2411), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 9, 21, 29, 30, 735, DateTimeKind.Unspecified).AddTicks(7543), new TimeSpan(0, 7, 0, 0, 0)), new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25") },
                    { new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), new Guid("7b30d717-a76c-5e6e-81be-4dcf0abad890"), new DateTimeOffset(new DateTime(2020, 5, 15, 21, 53, 38, 112, DateTimeKind.Unspecified).AddTicks(1731), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 25, 15, 7, 47, 655, DateTimeKind.Unspecified).AddTicks(3846), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4fbc87d7-b534-95ce-0699-083d05b4056f") },
                    { new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"), new Guid("ff8d9313-3631-7d5e-8223-78fc98684039"), new DateTimeOffset(new DateTime(2020, 3, 3, 7, 35, 18, 857, DateTimeKind.Unspecified).AddTicks(1849), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 23, 6, 8, 32, 174, DateTimeKind.Unspecified).AddTicks(578), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9de1b233-b753-b150-4906-4d445720e8f1") },
                    { new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"), new Guid("c888dbdb-1c04-f09f-f960-26ada1097c5d"), new DateTimeOffset(new DateTime(2020, 7, 9, 16, 9, 48, 440, DateTimeKind.Unspecified).AddTicks(5556), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 15, 6, 13, 43, 483, DateTimeKind.Unspecified).AddTicks(6951), new TimeSpan(0, 7, 0, 0, 0)), new Guid("0ac39d47-a580-388c-334e-c36e77d4acb7") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("97581a8f-780f-3896-228c-51e74509eb80"), new Guid("042638ff-08ab-3154-8231-2f09aa954c72"), new DateTimeOffset(new DateTime(2020, 9, 27, 17, 41, 8, 63, DateTimeKind.Unspecified).AddTicks(6226), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 29, 21, 55, 51, 684, DateTimeKind.Unspecified).AddTicks(8544), new TimeSpan(0, 7, 0, 0, 0)), new Guid("0239ea8c-b559-0752-b2c0-92710f499696") },
                    { new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), new Guid("bfb312c3-362b-ec49-fcb7-61f2db22d65c"), new DateTimeOffset(new DateTime(2020, 12, 18, 22, 24, 38, 496, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 2, 13, 44, 44, 1, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, 7, 0, 0, 0)), new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25") },
                    { new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"), new Guid("6582b0e9-0df0-e6c3-28f2-ec5e2b85796a"), new DateTimeOffset(new DateTime(2020, 5, 26, 16, 51, 16, 961, DateTimeKind.Unspecified).AddTicks(5992), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 24, 22, 18, 14, 516, DateTimeKind.Unspecified).AddTicks(3162), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6100e542-8ed9-94dd-02eb-d05d806edcfa") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("c764ce19-c657-b651-c26d-f786a83ce646"), new Guid("e9a30a4b-5518-1855-0a66-8a00ae6966ab"), new DateTimeOffset(new DateTime(2020, 11, 1, 14, 34, 10, 735, DateTimeKind.Unspecified).AddTicks(4846), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 6, 1, 0, 39, 54, 145, DateTimeKind.Unspecified).AddTicks(5346), new TimeSpan(0, 7, 0, 0, 0)), new Guid("0ac39d47-a580-388c-334e-c36e77d4acb7") },
                    { new Guid("c962b121-02f9-08e5-cf11-8995c540a761"), new Guid("894bbc95-6ce2-cb29-8f17-449c7ebe9a77"), new DateTimeOffset(new DateTime(2020, 11, 14, 22, 4, 26, 740, DateTimeKind.Unspecified).AddTicks(7614), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 29, 16, 59, 47, 928, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 7, 0, 0, 0)), new Guid("360f39a0-9ef3-42c7-47d5-608af0d59ff4") },
                    { new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), new Guid("bc12e381-9af1-1ac4-c15e-a986da5b57bd"), new DateTimeOffset(new DateTime(2020, 9, 6, 0, 52, 18, 542, DateTimeKind.Unspecified).AddTicks(1812), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 3, 10, 15, 5, 37, 217, DateTimeKind.Unspecified).AddTicks(7899), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") },
                    { new Guid("d40d725e-c366-8b4f-8503-1295b3ba6483"), new Guid("946cbe11-beeb-0694-f564-dda95675991f"), new DateTimeOffset(new DateTime(2020, 4, 11, 9, 6, 39, 525, DateTimeKind.Unspecified).AddTicks(7098), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 16, 4, 27, 48, 102, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, 7, 0, 0, 0)), new Guid("40059f0b-1d19-9002-1e10-8a95bc55cb73") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"), new Guid("85f9d68b-8075-4ce4-4687-d3b0fee00f06"), new DateTimeOffset(new DateTime(2020, 12, 29, 17, 48, 19, 865, DateTimeKind.Unspecified).AddTicks(6258), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 4, 24, 10, 39, 2, 675, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d2f046ac-c105-40c7-eabf-733a9492edc5") },
                    { new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), new Guid("c34ae2e6-68cc-6e9c-d22e-1db28b88829e"), new DateTimeOffset(new DateTime(2020, 7, 1, 17, 31, 24, 895, DateTimeKind.Unspecified).AddTicks(6730), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 23, 9, 46, 34, 563, DateTimeKind.Unspecified).AddTicks(5751), new TimeSpan(0, 7, 0, 0, 0)), new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d") },
                    { new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"), new Guid("de4ff2b1-a48b-873f-c7ca-08f63404c6ce"), new DateTimeOffset(new DateTime(2020, 11, 16, 11, 23, 5, 994, DateTimeKind.Unspecified).AddTicks(8886), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 22, 22, 37, 6, 953, DateTimeKind.Unspecified).AddTicks(9482), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc") },
                    { new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), new Guid("de4ff2b1-a48b-873f-c7ca-08f63404c6ce"), new DateTimeOffset(new DateTime(2020, 2, 10, 23, 55, 43, 794, DateTimeKind.Unspecified).AddTicks(671), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 1, 12, 3, 35, 52, 394, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 7, 0, 0, 0)), new Guid("81fda1d4-fa16-093d-7e66-c5fd012c2fc3") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("e7e2d28b-02d4-3311-7a1c-f2134f0c6634"), new Guid("7b30d717-a76c-5e6e-81be-4dcf0abad890"), new DateTimeOffset(new DateTime(2020, 2, 29, 22, 49, 14, 459, DateTimeKind.Unspecified).AddTicks(7189), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 16, 18, 48, 37, 557, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8bdb736b-89b7-be24-1c15-31f7e7421644") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), new Guid("7e5e390d-d9ab-d434-ecef-08c5ede18f13"), new DateTimeOffset(new DateTime(2020, 1, 5, 5, 47, 24, 796, DateTimeKind.Unspecified).AddTicks(1398), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 28, 14, 24, 26, 610, DateTimeKind.Unspecified).AddTicks(7106), new TimeSpan(0, 7, 0, 0, 0)), new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d") },
                    { new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), new Guid("1de7f0c5-af98-25d1-a33a-f246ec74b73f"), new DateTimeOffset(new DateTime(2020, 7, 10, 23, 0, 27, 231, DateTimeKind.Unspecified).AddTicks(6886), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 8, 29, 5, 50, 35, 915, DateTimeKind.Unspecified).AddTicks(3205), new TimeSpan(0, 7, 0, 0, 0)), new Guid("837c4af8-1b95-302e-d982-d3e35c19fca2") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[,]
                {
                    { new Guid("50714b05-b3c5-c1c9-35e3-3c33e18aaa4f"), null, new DateTimeOffset(new DateTime(2020, 3, 5, 10, 18, 47, 393, DateTimeKind.Unspecified).AddTicks(1646), new TimeSpan(0, 7, 0, 0, 0)), true, 7, 5, new DateTimeOffset(new DateTime(2020, 12, 12, 13, 29, 43, 525, DateTimeKind.Unspecified).AddTicks(8412), new TimeSpan(0, 7, 0, 0, 0)), "Padberg LLC", 37.466497067579326m, new Guid("8026a67e-3b61-fd8d-5241-408b6939c3a4"), new Guid("9b7ee018-0252-62b0-f68e-93af65c0a83e") },
                    { new Guid("6773f756-d8b1-22de-a543-ceb51d18f920"), null, new DateTimeOffset(new DateTime(2020, 9, 20, 3, 41, 1, 597, DateTimeKind.Unspecified).AddTicks(8794), new TimeSpan(0, 7, 0, 0, 0)), true, 5, 1, new DateTimeOffset(new DateTime(2020, 1, 19, 10, 27, 28, 732, DateTimeKind.Unspecified).AddTicks(9241), new TimeSpan(0, 7, 0, 0, 0)), "Schamberger - Daniel", 24.363352256530627m, new Guid("c2a70e2a-ef63-4cd3-813e-6c0feb02be4e"), new Guid("f7895455-134e-0837-4c23-7ee0b56fdc08") },
                    { new Guid("6c5f7fae-283c-7ad4-96e0-ad704663df22"), null, new DateTimeOffset(new DateTime(2020, 5, 10, 2, 26, 6, 597, DateTimeKind.Unspecified).AddTicks(724), new TimeSpan(0, 7, 0, 0, 0)), true, 10, 2, new DateTimeOffset(new DateTime(2020, 8, 3, 19, 39, 34, 936, DateTimeKind.Unspecified).AddTicks(8863), new TimeSpan(0, 7, 0, 0, 0)), "Reilly Group", 86.27331487986883m, new Guid("b354e7ff-dc8e-00a4-4e16-dbdec031d490"), new Guid("41e6a2ec-4ff6-8a82-a45d-905ab4812ddc") },
                    { new Guid("742e2a57-6231-e100-0c30-a46a4792353a"), null, new DateTimeOffset(new DateTime(2020, 6, 5, 23, 4, 24, 30, DateTimeKind.Unspecified).AddTicks(3641), new TimeSpan(0, 7, 0, 0, 0)), true, 5, 2, new DateTimeOffset(new DateTime(2020, 8, 31, 10, 26, 44, 245, DateTimeKind.Unspecified).AddTicks(4164), new TimeSpan(0, 7, 0, 0, 0)), "Terry - Braun", 69.544665281914525m, new Guid("0239ea8c-b559-0752-b2c0-92710f499696"), new Guid("5e10e0ee-80ca-3b8b-9c77-ec7d0d387eeb") },
                    { new Guid("7d5ba0c4-a164-7231-7cf6-1d1e6efaf5d8"), null, new DateTimeOffset(new DateTime(2020, 7, 23, 0, 27, 1, 813, DateTimeKind.Unspecified).AddTicks(2921), new TimeSpan(0, 7, 0, 0, 0)), true, 6, 1, new DateTimeOffset(new DateTime(2020, 4, 26, 16, 55, 16, 244, DateTimeKind.Unspecified).AddTicks(5501), new TimeSpan(0, 7, 0, 0, 0)), "Kub - Schinner", 16.216196894280712m, new Guid("b354e7ff-dc8e-00a4-4e16-dbdec031d490"), new Guid("feaa1b22-aad1-5319-5664-b0e4145d3dcc") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("8c512572-c2c5-6018-11b0-65448b8b5bf0"), null, new DateTimeOffset(new DateTime(2020, 6, 21, 8, 52, 46, 370, DateTimeKind.Unspecified).AddTicks(3412), new TimeSpan(0, 7, 0, 0, 0)), 9, 2, new DateTimeOffset(new DateTime(2020, 9, 23, 5, 14, 28, 502, DateTimeKind.Unspecified).AddTicks(2919), new TimeSpan(0, 7, 0, 0, 0)), "Okuneva - Botsford", 76.740535423504468m, new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4"), new Guid("3f9225cd-7acc-0d19-9b61-826df2719fea") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[,]
                {
                    { new Guid("915bf2ff-2a7a-a582-3585-cbee1ae797a3"), null, new DateTimeOffset(new DateTime(2020, 2, 18, 10, 8, 46, 180, DateTimeKind.Unspecified).AddTicks(6539), new TimeSpan(0, 7, 0, 0, 0)), true, 7, 3, new DateTimeOffset(new DateTime(2020, 6, 10, 0, 34, 36, 506, DateTimeKind.Unspecified).AddTicks(5814), new TimeSpan(0, 7, 0, 0, 0)), "Grant - Gaylord", 6.9783319937895697m, new Guid("4a1c6b89-d069-783e-490c-18783c5527ee"), new Guid("d354372e-f04c-d28b-e2e7-d40211337a1c") },
                    { new Guid("9a0a219e-f958-f1a7-0605-94327786d627"), null, new DateTimeOffset(new DateTime(2020, 5, 4, 7, 24, 17, 236, DateTimeKind.Unspecified).AddTicks(699), new TimeSpan(0, 7, 0, 0, 0)), true, 5, 1, new DateTimeOffset(new DateTime(2020, 6, 26, 22, 40, 19, 213, DateTimeKind.Unspecified).AddTicks(2153), new TimeSpan(0, 7, 0, 0, 0)), "Wuckert, Hoppe and Smitham", 55.242014613115186m, new Guid("a2f3dcda-df43-530a-0c96-53f4b2c78dd4"), new Guid("9ef052cd-d451-a89e-0515-b413c4587a03") },
                    { new Guid("c86c892d-3011-bfe7-3a4b-ce7101f5eece"), null, new DateTimeOffset(new DateTime(2020, 5, 7, 2, 49, 8, 701, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 7, 0, 0, 0)), true, 5, 3, new DateTimeOffset(new DateTime(2020, 9, 1, 11, 42, 45, 494, DateTimeKind.Unspecified).AddTicks(2649), new TimeSpan(0, 7, 0, 0, 0)), "Johnston, Muller and Jakubowski", 79.90526649910267m, new Guid("0239ea8c-b559-0752-b2c0-92710f499696"), new Guid("4d8d10a4-6f02-8058-8923-f5bdcef26ed8") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[,]
                {
                    { new Guid("dc2253fb-a284-69ca-546f-0a051ec36e98"), null, new DateTimeOffset(new DateTime(2020, 2, 21, 21, 3, 19, 689, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 7, 0, 0, 0)), 7, 4, new DateTimeOffset(new DateTime(2020, 11, 2, 4, 9, 35, 341, DateTimeKind.Unspecified).AddTicks(5923), new TimeSpan(0, 7, 0, 0, 0)), "Wilkinson, Macejkovic and Leffler", 5.2960079648979064m, new Guid("a2f3dcda-df43-530a-0c96-53f4b2c78dd4"), new Guid("3a7e3299-e0c5-5df7-64b0-a4a1a1b53962") },
                    { new Guid("e37263c1-54e5-503c-642e-44045c366f77"), null, new DateTimeOffset(new DateTime(2020, 10, 10, 18, 19, 1, 763, DateTimeKind.Unspecified).AddTicks(7432), new TimeSpan(0, 7, 0, 0, 0)), 5, 4, new DateTimeOffset(new DateTime(2020, 12, 31, 18, 17, 14, 180, DateTimeKind.Unspecified).AddTicks(5809), new TimeSpan(0, 7, 0, 0, 0)), "Kozey - Quigley", 91.25536192639516m, new Guid("0239ea8c-b559-0752-b2c0-92710f499696"), new Guid("9ef052cd-d451-a89e-0515-b413c4587a03") }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "IsDeleted", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("e9ce60a6-2ed5-9c3b-1203-98e89b09e05c"), null, new DateTimeOffset(new DateTime(2020, 11, 23, 1, 13, 48, 961, DateTimeKind.Unspecified).AddTicks(4951), new TimeSpan(0, 7, 0, 0, 0)), true, 9, 4, new DateTimeOffset(new DateTime(2020, 4, 22, 15, 59, 54, 455, DateTimeKind.Unspecified).AddTicks(6057), new TimeSpan(0, 7, 0, 0, 0)), "Schaden, Balistreri and Koss", 77.865351193987444m, new Guid("9de1b233-b753-b150-4906-4d445720e8f1"), new Guid("3a6aed8d-5a99-4edd-8327-5c278eb6b17d") });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("f774154c-4e4a-4a5f-d769-f094e08d73e6"), null, new DateTimeOffset(new DateTime(2020, 4, 7, 8, 49, 21, 428, DateTimeKind.Unspecified).AddTicks(9059), new TimeSpan(0, 7, 0, 0, 0)), 8, 4, new DateTimeOffset(new DateTime(2020, 6, 15, 16, 59, 16, 577, DateTimeKind.Unspecified).AddTicks(7467), new TimeSpan(0, 7, 0, 0, 0)), "Zboncak and Sons", 74.135529992699416m, new Guid("0239ea8c-b559-0752-b2c0-92710f499696"), new Guid("f3568c09-55f8-ac7e-442d-01fb2b510c8e") });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), new Guid("de4ff2b1-a48b-873f-c7ca-08f63404c6ce"), "Available", new DateTimeOffset(new DateTime(2024, 6, 1, 7, 10, 13, 227, DateTimeKind.Unspecified).AddTicks(9679), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 23, 0, 40, 24, 448, DateTimeKind.Unspecified).AddTicks(2413), new TimeSpan(0, 7, 0, 0, 0)), "quia", "voluptatum" },
                    { new Guid("0945e751-80eb-8bf6-2014-2b1237d52d64"), new Guid("dcaebaaf-f809-9558-8919-c4f71079e80d"), "Available", new DateTimeOffset(new DateTime(2023, 9, 26, 9, 18, 15, 611, DateTimeKind.Unspecified).AddTicks(2385), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 21, 2, 40, 47, 232, DateTimeKind.Unspecified).AddTicks(1938), new TimeSpan(0, 7, 0, 0, 0)), "esse", "quo" },
                    { new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"), new Guid("85c7be28-3ba8-977e-a626-54f8f5964a2b"), "Available", new DateTimeOffset(new DateTime(2024, 5, 31, 4, 25, 32, 808, DateTimeKind.Unspecified).AddTicks(226), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 2, 15, 58, 58, 727, DateTimeKind.Unspecified).AddTicks(8133), new TimeSpan(0, 7, 0, 0, 0)), "autem", "cupiditate" },
                    { new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"), new Guid("85c7be28-3ba8-977e-a626-54f8f5964a2b"), "Available", new DateTimeOffset(new DateTime(2023, 11, 10, 18, 13, 48, 872, DateTimeKind.Unspecified).AddTicks(9868), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 13, 22, 9, 17, 309, DateTimeKind.Unspecified).AddTicks(6977), new TimeSpan(0, 7, 0, 0, 0)), "natus", "pariatur" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("0bab7af2-5fac-9b1e-3f2b-cd52f09e51d4"), new Guid("7b30d717-a76c-5e6e-81be-4dcf0abad890"), "Available", new DateTimeOffset(new DateTime(2023, 7, 26, 12, 21, 8, 639, DateTimeKind.Unspecified).AddTicks(1333), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 14, 12, 9, 0, 253, DateTimeKind.Unspecified).AddTicks(1022), new TimeSpan(0, 7, 0, 0, 0)), "iusto", "voluptatem" },
                    { new Guid("0c037a58-9f75-ab3f-38a4-aa4eb47f5542"), new Guid("cf7d3633-3eee-94eb-b598-83a5ac711802"), "Available", new DateTimeOffset(new DateTime(2023, 7, 31, 12, 15, 40, 83, DateTimeKind.Unspecified).AddTicks(3261), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 11, 2, 15, 31, 59, 389, DateTimeKind.Unspecified).AddTicks(7079), new TimeSpan(0, 7, 0, 0, 0)), "consequuntur", "dolores" },
                    { new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), new Guid("ff8d9313-3631-7d5e-8223-78fc98684039"), "Booked", new DateTimeOffset(new DateTime(2023, 8, 19, 11, 24, 39, 817, DateTimeKind.Unspecified).AddTicks(9459), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 1, 31, 0, 49, 41, 263, DateTimeKind.Unspecified).AddTicks(805), new TimeSpan(0, 7, 0, 0, 0)), "facilis", "autem" },
                    { new Guid("0f7666bd-2191-62b1-c9f9-02e508cf1189"), new Guid("6582b0e9-0df0-e6c3-28f2-ec5e2b85796a"), "Available", new DateTimeOffset(new DateTime(2024, 3, 4, 9, 41, 53, 463, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 2, 15, 5, 57, 49, 929, DateTimeKind.Unspecified).AddTicks(5366), new TimeSpan(0, 7, 0, 0, 0)), "sint", "dolores" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("19469a5c-d6ab-8b1d-dfd6-47876ffa5d3f"), new Guid("894bbc95-6ce2-cb29-8f17-449c7ebe9a77"), "Booked", new DateTimeOffset(new DateTime(2023, 10, 25, 14, 47, 0, 274, DateTimeKind.Unspecified).AddTicks(4099), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 14, 11, 30, 283, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 7, 0, 0, 0)), "accusamus", "autem" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("28490d2e-ad32-cf01-c79e-2cd4a1fd8116"), new Guid("c888dbdb-1c04-f09f-f960-26ada1097c5d"), "Booked", new DateTimeOffset(new DateTime(2024, 2, 29, 20, 4, 22, 583, DateTimeKind.Unspecified).AddTicks(6120), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 6, 6, 22, 10, 49, 521, DateTimeKind.Unspecified).AddTicks(312), new TimeSpan(0, 7, 0, 0, 0)), "ea", "voluptatem" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("2f40a4d6-602b-79ee-b453-e39036dfc79c"), new Guid("122899aa-bb86-c8b7-29dc-92551068fe1b"), "Booked", new DateTimeOffset(new DateTime(2024, 5, 4, 19, 5, 13, 458, DateTimeKind.Unspecified).AddTicks(7117), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 30, 16, 55, 37, 972, DateTimeKind.Unspecified).AddTicks(3778), new TimeSpan(0, 7, 0, 0, 0)), "quisquam", "qui" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"), new Guid("7e5e390d-d9ab-d434-ecef-08c5ede18f13"), "Booked", new DateTimeOffset(new DateTime(2023, 9, 13, 15, 18, 53, 1, DateTimeKind.Unspecified).AddTicks(215), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 10, 20, 4, 29, 11, 328, DateTimeKind.Unspecified).AddTicks(2741), new TimeSpan(0, 7, 0, 0, 0)), "repudiandae", "porro" },
                    { new Guid("31c95f5a-4a44-610a-56fa-39ba2e69221b"), new Guid("e9a30a4b-5518-1855-0a66-8a00ae6966ab"), "Booked", new DateTimeOffset(new DateTime(2024, 6, 5, 2, 20, 53, 88, DateTimeKind.Unspecified).AddTicks(4022), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 12, 21, 54, 16, 639, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 7, 0, 0, 0)), "in", "vel" },
                    { new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"), new Guid("a00e7adf-e39c-17c1-6ce4-8e824e0221be"), "Booked", new DateTimeOffset(new DateTime(2023, 8, 5, 12, 47, 36, 256, DateTimeKind.Unspecified).AddTicks(4781), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 29, 1, 43, 25, 2, DateTimeKind.Unspecified).AddTicks(4885), new TimeSpan(0, 7, 0, 0, 0)), "nam", "consequuntur" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), new Guid("f7771a35-735e-edff-b14e-cd1606d57de8"), "Booked", new DateTimeOffset(new DateTime(2023, 10, 8, 5, 47, 38, 469, DateTimeKind.Unspecified).AddTicks(2483), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 8, 9, 21, 2, 501, DateTimeKind.Unspecified).AddTicks(1123), new TimeSpan(0, 7, 0, 0, 0)), "at", "nihil" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), new Guid("6582b0e9-0df0-e6c3-28f2-ec5e2b85796a"), "Available", new DateTimeOffset(new DateTime(2024, 2, 9, 5, 40, 41, 600, DateTimeKind.Unspecified).AddTicks(3493), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 31, 12, 53, 31, 963, DateTimeKind.Unspecified).AddTicks(5405), new TimeSpan(0, 7, 0, 0, 0)), "recusandae", "hic" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("582236b0-6743-9b61-aa64-9fd9f78f1a58"), new Guid("f0bc8bcb-9c50-1a09-e65f-56c571a1badf"), "Booked", new DateTimeOffset(new DateTime(2023, 10, 26, 4, 11, 45, 197, DateTimeKind.Unspecified).AddTicks(5195), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 25, 8, 8, 5, 237, DateTimeKind.Unspecified).AddTicks(4910), new TimeSpan(0, 7, 0, 0, 0)), "repellendus", "et" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("5837778a-135d-6548-2553-d7ec3774d8f5"), new Guid("55f6523c-51b3-95d6-89d1-d290b43e07fd"), "Available", new DateTimeOffset(new DateTime(2024, 3, 12, 1, 38, 2, 977, DateTimeKind.Unspecified).AddTicks(2346), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 26, 21, 12, 47, 627, DateTimeKind.Unspecified).AddTicks(9466), new TimeSpan(0, 7, 0, 0, 0)), "blanditiis", "aliquid" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"), new Guid("de4ff2b1-a48b-873f-c7ca-08f63404c6ce"), "Available", new DateTimeOffset(new DateTime(2023, 9, 26, 4, 13, 41, 921, DateTimeKind.Unspecified).AddTicks(6325), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 31, 16, 58, 10, 179, DateTimeKind.Unspecified).AddTicks(8026), new TimeSpan(0, 7, 0, 0, 0)), "consequatur", "rerum" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("6649549c-7feb-70fc-5fef-ed2c0eaddc74"), new Guid("01f4d29a-7bee-4b95-ca48-6fcecd1ce1a5"), "Booked", new DateTimeOffset(new DateTime(2024, 2, 9, 5, 25, 9, 41, DateTimeKind.Unspecified).AddTicks(5108), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 6, 25, 18, 36, 29, 590, DateTimeKind.Unspecified).AddTicks(5544), new TimeSpan(0, 7, 0, 0, 0)), "quia", "quo" },
                    { new Guid("69bdeded-13d8-e643-a2a4-e8a0bd6c2ba7"), new Guid("c9b3ea50-4009-f618-ff5f-134b47a79f0f"), "Booked", new DateTimeOffset(new DateTime(2023, 10, 17, 23, 37, 57, 714, DateTimeKind.Unspecified).AddTicks(4735), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 27, 23, 17, 0, 897, DateTimeKind.Unspecified).AddTicks(8744), new TimeSpan(0, 7, 0, 0, 0)), "saepe", "consequatur" },
                    { new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new Guid("9b0258ef-d34c-bfca-2865-b935f45efc20"), "Available", new DateTimeOffset(new DateTime(2024, 3, 15, 10, 57, 55, 568, DateTimeKind.Unspecified).AddTicks(9063), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 2, 23, 52, 15, 367, DateTimeKind.Unspecified).AddTicks(1422), new TimeSpan(0, 7, 0, 0, 0)), "est", "ab" },
                    { new Guid("81b45a90-dc2d-75d8-0729-b4372c2ad5ff"), new Guid("946cbe11-beeb-0694-f564-dda95675991f"), "Available", new DateTimeOffset(new DateTime(2024, 4, 18, 18, 36, 0, 445, DateTimeKind.Unspecified).AddTicks(8993), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 27, 5, 55, 51, 493, DateTimeKind.Unspecified).AddTicks(7874), new TimeSpan(0, 7, 0, 0, 0)), "voluptas", "expedita" },
                    { new Guid("8364bab3-3549-2209-c2f8-b1659599800f"), new Guid("6582b0e9-0df0-e6c3-28f2-ec5e2b85796a"), "Booked", new DateTimeOffset(new DateTime(2023, 11, 10, 1, 45, 33, 999, DateTimeKind.Unspecified).AddTicks(1945), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 9, 11, 26, 20, 249, DateTimeKind.Unspecified).AddTicks(5514), new TimeSpan(0, 7, 0, 0, 0)), "voluptatem", "voluptatem" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("8b1ffb45-1ea4-e025-e09e-2784cd25923f"), new Guid("c34ae2e6-68cc-6e9c-d22e-1db28b88829e"), "Available", new DateTimeOffset(new DateTime(2024, 4, 28, 8, 1, 43, 108, DateTimeKind.Unspecified).AddTicks(975), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 23, 23, 26, 58, 778, DateTimeKind.Unspecified).AddTicks(7199), new TimeSpan(0, 7, 0, 0, 0)), "veniam", "a" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("8bc880c5-bc39-a62d-528d-a9d070fe5e75"), new Guid("01f4d29a-7bee-4b95-ca48-6fcecd1ce1a5"), "Available", new DateTimeOffset(new DateTime(2024, 6, 6, 6, 8, 40, 571, DateTimeKind.Unspecified).AddTicks(8281), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 5, 23, 37, 37, 949, DateTimeKind.Unspecified).AddTicks(1704), new TimeSpan(0, 7, 0, 0, 0)), "et", "inventore" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59"), new Guid("cf7d3633-3eee-94eb-b598-83a5ac711802"), "Booked", new DateTimeOffset(new DateTime(2023, 8, 13, 7, 44, 47, 878, DateTimeKind.Unspecified).AddTicks(3583), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 4, 19, 1, 23, 314, DateTimeKind.Unspecified).AddTicks(2316), new TimeSpan(0, 7, 0, 0, 0)), "excepturi", "sit" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("6582b0e9-0df0-e6c3-28f2-ec5e2b85796a"), "Available", new DateTimeOffset(new DateTime(2024, 5, 26, 6, 59, 35, 771, DateTimeKind.Unspecified).AddTicks(1172), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 2, 22, 13, 37, 11, 963, DateTimeKind.Unspecified).AddTicks(5137), new TimeSpan(0, 7, 0, 0, 0)), "ut", "sunt" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"), new Guid("85c7be28-3ba8-977e-a626-54f8f5964a2b"), "Available", new DateTimeOffset(new DateTime(2023, 7, 4, 16, 55, 18, 515, DateTimeKind.Unspecified).AddTicks(8890), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 9, 14, 4, 262, DateTimeKind.Unspecified).AddTicks(2012), new TimeSpan(0, 7, 0, 0, 0)), "ut", "libero" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"), new Guid("f7771a35-735e-edff-b14e-cd1606d57de8"), "Available", new DateTimeOffset(new DateTime(2024, 2, 27, 22, 5, 36, 506, DateTimeKind.Unspecified).AddTicks(4035), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 11, 3, 11, 57, 41, 890, DateTimeKind.Unspecified).AddTicks(5476), new TimeSpan(0, 7, 0, 0, 0)), "et", "vero" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("a9ff8f43-1b36-7c81-ae63-cbef0d43492d"), new Guid("042638ff-08ab-3154-8231-2f09aa954c72"), "Booked", new DateTimeOffset(new DateTime(2023, 7, 5, 13, 44, 57, 236, DateTimeKind.Unspecified).AddTicks(6888), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 28, 1, 7, 11, 763, DateTimeKind.Unspecified).AddTicks(7819), new TimeSpan(0, 7, 0, 0, 0)), "atque", "dolor" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("aa6983e2-10a4-4d8d-026f-58808923f5bd"), new Guid("122899aa-bb86-c8b7-29dc-92551068fe1b"), "Booked", new DateTimeOffset(new DateTime(2024, 1, 31, 16, 57, 16, 485, DateTimeKind.Unspecified).AddTicks(1282), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 17, 20, 0, 2, 653, DateTimeKind.Unspecified).AddTicks(1318), new TimeSpan(0, 7, 0, 0, 0)), "impedit", "facere" },
                    { new Guid("ae2b65bc-8752-1d50-b8b4-7d7fa37ad24f"), new Guid("dcaebaaf-f809-9558-8919-c4f71079e80d"), "Booked", new DateTimeOffset(new DateTime(2023, 7, 22, 3, 22, 11, 155, DateTimeKind.Unspecified).AddTicks(7072), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 6, 22, 22, 25, 418, DateTimeKind.Unspecified).AddTicks(102), new TimeSpan(0, 7, 0, 0, 0)), "provident", "repellendus" },
                    { new Guid("c32f2c01-9433-2762-2427-ce133348d2a8"), new Guid("dc880bf8-48e0-6c50-837a-3f2480a252fb"), "Booked", new DateTimeOffset(new DateTime(2024, 3, 19, 8, 32, 7, 507, DateTimeKind.Unspecified).AddTicks(4854), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 13, 10, 19, 48, 951, DateTimeKind.Unspecified).AddTicks(174), new TimeSpan(0, 7, 0, 0, 0)), "earum", "facilis" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("e6a9f246-6c93-6962-33ef-855ab90a53b0"), new Guid("de4ff2b1-a48b-873f-c7ca-08f63404c6ce"), "Booked", new DateTimeOffset(new DateTime(2023, 12, 25, 14, 55, 8, 254, DateTimeKind.Unspecified).AddTicks(5253), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 9, 14, 33, 6, 866, DateTimeKind.Unspecified).AddTicks(6828), new TimeSpan(0, 7, 0, 0, 0)), "ipsa", "voluptatem" },
                    { new Guid("e88dd8c7-b5e7-329d-1efa-c9fc05d4975e"), new Guid("01f4d29a-7bee-4b95-ca48-6fcecd1ce1a5"), "Available", new DateTimeOffset(new DateTime(2024, 1, 9, 4, 45, 9, 485, DateTimeKind.Unspecified).AddTicks(6773), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 13, 1, 33, 55, 302, DateTimeKind.Unspecified).AddTicks(2440), new TimeSpan(0, 7, 0, 0, 0)), "doloremque", "dolor" },
                    { new Guid("ecc698c4-a3bd-d5e5-df91-ad2a6e8169d6"), new Guid("9b0258ef-d34c-bfca-2865-b935f45efc20"), "Available", new DateTimeOffset(new DateTime(2024, 3, 14, 9, 15, 0, 247, DateTimeKind.Unspecified).AddTicks(4249), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 4, 0, 25, 12, 996, DateTimeKind.Unspecified).AddTicks(80), new TimeSpan(0, 7, 0, 0, 0)), "totam", "quia" },
                    { new Guid("edc2475d-d718-e562-400b-b5d94a508985"), new Guid("894bbc95-6ce2-cb29-8f17-449c7ebe9a77"), "Available", new DateTimeOffset(new DateTime(2023, 12, 28, 7, 35, 19, 555, DateTimeKind.Unspecified).AddTicks(1036), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 17, 13, 17, 51, 515, DateTimeKind.Unspecified).AddTicks(4952), new TimeSpan(0, 7, 0, 0, 0)), "ut", "aut" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("f76bbc76-1fa7-474c-73ae-e30c1006428e"), new Guid("85f9d68b-8075-4ce4-4687-d3b0fee00f06"), "Booked", new DateTimeOffset(new DateTime(2024, 3, 2, 22, 38, 13, 194, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 15, 17, 51, 3, 280, DateTimeKind.Unspecified).AddTicks(9354), new TimeSpan(0, 7, 0, 0, 0)), "qui", "necessitatibus" });

            migrationBuilder.InsertData(
                table: "DateCourtGroup",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "DateId", "IsClosed", "IsDeleted", "ModifiedOnUtc" },
                values: new object[,]
                {
                    { new Guid("1203858b-b395-64ba-8349-350922c2f8b1"), new Guid("55f6523c-51b3-95d6-89d1-d290b43e07fd"), new DateTimeOffset(new DateTime(2023, 7, 24, 5, 42, 58, 627, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), false, false, new DateTimeOffset(new DateTime(2024, 1, 29, 6, 10, 19, 493, DateTimeKind.Unspecified).AddTicks(6403), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("1c7a3311-13f2-0c4f-6634-ac2b97b6715e"), new Guid("c34ae2e6-68cc-6e9c-d22e-1db28b88829e"), new DateTimeOffset(new DateTime(2023, 10, 11, 4, 4, 21, 269, DateTimeKind.Unspecified).AddTicks(1721), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"), true, false, new DateTimeOffset(new DateTime(2024, 4, 23, 4, 24, 13, 661, DateTimeKind.Unspecified).AddTicks(3775), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9"), new Guid("c9b3ea50-4009-f618-ff5f-134b47a79f0f"), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 1, 50, 557, DateTimeKind.Unspecified).AddTicks(7856), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), true, false, new DateTimeOffset(new DateTime(2023, 12, 13, 9, 4, 29, 41, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("29a8d248-66fd-66c5-8262-26cdde04085c"), new Guid("85c7be28-3ba8-977e-a626-54f8f5964a2b"), new DateTimeOffset(new DateTime(2023, 10, 25, 10, 20, 38, 933, DateTimeKind.Unspecified).AddTicks(2487), new TimeSpan(0, 7, 0, 0, 0)), new Guid("c962b121-02f9-08e5-cf11-8995c540a761"), false, false, new DateTimeOffset(new DateTime(2023, 11, 27, 7, 44, 36, 735, DateTimeKind.Unspecified).AddTicks(9870), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("2bfb012d-0c51-868e-863e-ededbd69d813"), new Guid("042638ff-08ab-3154-8231-2f09aa954c72"), new DateTimeOffset(new DateTime(2023, 10, 31, 15, 20, 22, 608, DateTimeKind.Unspecified).AddTicks(2812), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2dd53712-d464-ab85-d589-e18ec580c88b"), false, false, new DateTimeOffset(new DateTime(2023, 12, 20, 18, 54, 59, 981, DateTimeKind.Unspecified).AddTicks(9320), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"), new Guid("01f4d29a-7bee-4b95-ca48-6fcecd1ce1a5"), new DateTimeOffset(new DateTime(2023, 12, 16, 22, 51, 21, 792, DateTimeKind.Unspecified).AddTicks(2234), new TimeSpan(0, 7, 0, 0, 0)), new Guid("c764ce19-c657-b651-c26d-f786a83ce646"), true, true, new DateTimeOffset(new DateTime(2024, 2, 18, 3, 48, 52, 327, DateTimeKind.Unspecified).AddTicks(7573), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("3a51ce71-ab15-6d1e-75d2-65d33d5c153a"), new Guid("55f6523c-51b3-95d6-89d1-d290b43e07fd"), new DateTimeOffset(new DateTime(2023, 11, 30, 15, 48, 47, 525, DateTimeKind.Unspecified).AddTicks(504), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), false, false, new DateTimeOffset(new DateTime(2024, 4, 6, 0, 16, 51, 34, DateTimeKind.Unspecified).AddTicks(7559), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("3aab7684-df2f-9588-6762-d36d43591ec6"), new Guid("1d5d7434-674a-4126-1a7a-5ad14ba33acd"), new DateTimeOffset(new DateTime(2024, 4, 23, 17, 1, 54, 104, DateTimeKind.Unspecified).AddTicks(7247), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"), false, true, new DateTimeOffset(new DateTime(2023, 12, 22, 2, 20, 58, 911, DateTimeKind.Unspecified).AddTicks(34), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("4eaaa438-7fb4-4255-1996-b8a364698dd7"), new Guid("6582b0e9-0df0-e6c3-28f2-ec5e2b85796a"), new DateTimeOffset(new DateTime(2024, 2, 8, 18, 51, 30, 441, DateTimeKind.Unspecified).AddTicks(6865), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7ee018f5-529b-b002-62f6-8e93af65c0a8"), true, false, new DateTimeOffset(new DateTime(2023, 7, 9, 18, 51, 28, 540, DateTimeKind.Unspecified).AddTicks(8320), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"), new Guid("de4ff2b1-a48b-873f-c7ca-08f63404c6ce"), new DateTimeOffset(new DateTime(2023, 7, 14, 20, 41, 4, 632, DateTimeKind.Unspecified).AddTicks(1649), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), false, true, new DateTimeOffset(new DateTime(2023, 9, 26, 4, 13, 41, 948, DateTimeKind.Unspecified).AddTicks(9265), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("65bc72ff-ae2b-8752-501d-b8b47d7fa37a"), new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new DateTimeOffset(new DateTime(2023, 12, 13, 9, 45, 25, 299, DateTimeKind.Unspecified).AddTicks(9694), new TimeSpan(0, 7, 0, 0, 0)), new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"), true, false, new DateTimeOffset(new DateTime(2024, 5, 25, 3, 57, 34, 371, DateTimeKind.Unspecified).AddTicks(9258), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("67eba435-40d1-7d65-5050-c5b9bd58e5e1"), new Guid("1de7f0c5-af98-25d1-a33a-f246ec74b73f"), new DateTimeOffset(new DateTime(2023, 7, 19, 10, 12, 6, 337, DateTimeKind.Unspecified).AddTicks(6691), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), false, false, new DateTimeOffset(new DateTime(2023, 11, 16, 1, 39, 14, 143, DateTimeKind.Unspecified).AddTicks(1890), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("6ef2cebd-84d8-048d-bd66-760f9121b162"), new Guid("9d403be7-1591-a47f-eda5-1411ff876f4f"), new DateTimeOffset(new DateTime(2024, 2, 27, 15, 0, 32, 1, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 7, 0, 0, 0)), new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), false, true, new DateTimeOffset(new DateTime(2024, 3, 31, 13, 7, 7, 578, DateTimeKind.Unspecified).AddTicks(7778), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("76b4b43e-6bbc-a7f7-1f4c-4773aee30c10"), new Guid("f0bc8bcb-9c50-1a09-e65f-56c571a1badf"), new DateTimeOffset(new DateTime(2024, 2, 12, 14, 28, 29, 887, DateTimeKind.Unspecified).AddTicks(9087), new TimeSpan(0, 7, 0, 0, 0)), new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"), false, true, new DateTimeOffset(new DateTime(2024, 1, 11, 17, 31, 44, 819, DateTimeKind.Unspecified).AddTicks(7877), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new Guid("9b0258ef-d34c-bfca-2865-b935f45efc20"), new DateTimeOffset(new DateTime(2024, 6, 7, 19, 2, 22, 626, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), false, true, new DateTimeOffset(new DateTime(2024, 3, 15, 10, 57, 55, 585, DateTimeKind.Unspecified).AddTicks(3164), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("7fd8b31a-ccc5-e27d-8369-aaa4108d4d02"), new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new DateTimeOffset(new DateTime(2024, 5, 13, 11, 3, 20, 1, DateTimeKind.Unspecified).AddTicks(1567), new TimeSpan(0, 7, 0, 0, 0)), new Guid("15c913df-778a-5837-5d13-48652553d7ec"), true, true, new DateTimeOffset(new DateTime(2023, 12, 8, 21, 45, 8, 652, DateTimeKind.Unspecified).AddTicks(4508), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("89d5ab85-8ee1-80c5-c88b-39bc2da6528d"), new Guid("7b30d717-a76c-5e6e-81be-4dcf0abad890"), new DateTimeOffset(new DateTime(2024, 4, 16, 1, 12, 15, 872, DateTimeKind.Unspecified).AddTicks(5567), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), false, false, new DateTimeOffset(new DateTime(2024, 3, 27, 9, 7, 46, 741, DateTimeKind.Unspecified).AddTicks(9171), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8b3ca5cc-36b0-5822-4367-619baa649fd9"), new Guid("7b30d717-a76c-5e6e-81be-4dcf0abad890"), new DateTimeOffset(new DateTime(2024, 1, 18, 7, 11, 51, 328, DateTimeKind.Unspecified).AddTicks(2191), new TimeSpan(0, 7, 0, 0, 0)), new Guid("33c32f2c-6294-2427-27ce-133348d2a829"), true, false, new DateTimeOffset(new DateTime(2023, 8, 20, 13, 26, 54, 624, DateTimeKind.Unspecified).AddTicks(1953), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("953b298b-2d7e-d55f-136d-3fc2a7f518e0"), new Guid("de4ff2b1-a48b-873f-c7ca-08f63404c6ce"), new DateTimeOffset(new DateTime(2024, 2, 7, 10, 56, 48, 516, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"), true, false, new DateTimeOffset(new DateTime(2024, 1, 8, 15, 47, 57, 758, DateTimeKind.Unspecified).AddTicks(1738), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("6582b0e9-0df0-e6c3-28f2-ec5e2b85796a"), new DateTimeOffset(new DateTime(2024, 5, 23, 23, 11, 32, 203, DateTimeKind.Unspecified).AddTicks(6432), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"), false, true, new DateTimeOffset(new DateTime(2024, 5, 26, 6, 59, 35, 798, DateTimeKind.Unspecified).AddTicks(8776), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("9db5e7e8-1e32-c9fa-fc05-d4975ed3d849"), new Guid("894bbc95-6ce2-cb29-8f17-449c7ebe9a77"), new DateTimeOffset(new DateTime(2023, 8, 17, 11, 0, 12, 868, DateTimeKind.Unspecified).AddTicks(5734), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), true, true, new DateTimeOffset(new DateTime(2023, 7, 25, 23, 14, 4, 368, DateTimeKind.Unspecified).AddTicks(2884), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a72b6cbd-72d6-0a05-8f89-22cd5b94c915"), new Guid("da46d4f4-4577-fb00-969b-e0dfb77ed0ff"), new DateTimeOffset(new DateTime(2024, 2, 24, 2, 53, 59, 421, DateTimeKind.Unspecified).AddTicks(2745), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), false, false, new DateTimeOffset(new DateTime(2023, 6, 26, 8, 12, 6, 449, DateTimeKind.Unspecified).AddTicks(8004), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), new Guid("042638ff-08ab-3154-8231-2f09aa954c72"), new DateTimeOffset(new DateTime(2024, 5, 27, 10, 35, 31, 220, DateTimeKind.Unspecified).AddTicks(7707), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e7e2d28b-02d4-3311-7a1c-f2134f0c6634"), true, false, new DateTimeOffset(new DateTime(2023, 8, 14, 3, 4, 48, 833, DateTimeKind.Unspecified).AddTicks(9031), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("cee903fb-653b-0877-add2-e94ecd2895df"), new Guid("946cbe11-beeb-0694-f564-dda95675991f"), new DateTimeOffset(new DateTime(2024, 4, 20, 17, 53, 31, 915, DateTimeKind.Unspecified).AddTicks(7080), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"), true, true, new DateTimeOffset(new DateTime(2024, 1, 25, 19, 37, 3, 509, DateTimeKind.Unspecified).AddTicks(8605), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("dfd5e5a3-ad91-6e2a-8169-d69d496e5763"), new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new DateTimeOffset(new DateTime(2023, 8, 26, 20, 34, 13, 923, DateTimeKind.Unspecified).AddTicks(4498), new TimeSpan(0, 7, 0, 0, 0)), new Guid("15c913df-778a-5837-5d13-48652553d7ec"), true, false, new DateTimeOffset(new DateTime(2024, 2, 15, 19, 7, 27, 240, DateTimeKind.Unspecified).AddTicks(3301), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("e562d718-0b40-d9b5-4a50-898507682b0d"), new Guid("85c7be28-3ba8-977e-a626-54f8f5964a2b"), new DateTimeOffset(new DateTime(2023, 12, 16, 18, 20, 3, 678, DateTimeKind.Unspecified).AddTicks(9296), new TimeSpan(0, 7, 0, 0, 0)), new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"), false, true, new DateTimeOffset(new DateTime(2023, 9, 27, 14, 56, 54, 224, DateTimeKind.Unspecified).AddTicks(7827), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("ef5f70fc-2ced-ad0e-dc74-db7688646ffd"), new Guid("1d5d7434-674a-4126-1a7a-5ad14ba33acd"), new DateTimeOffset(new DateTime(2024, 5, 8, 19, 41, 36, 996, DateTimeKind.Unspecified).AddTicks(2937), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), false, true, new DateTimeOffset(new DateTime(2023, 11, 20, 16, 58, 18, 939, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("f052cd2b-519e-9ed4-a805-15b413c4587a"), new Guid("7e5e390d-d9ab-d434-ecef-08c5ede18f13"), new DateTimeOffset(new DateTime(2024, 1, 8, 3, 20, 52, 697, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 7, 0, 0, 0)), new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"), true, true, new DateTimeOffset(new DateTime(2023, 11, 16, 22, 49, 3, 17, DateTimeKind.Unspecified).AddTicks(1313), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("2aad91df-816e-d669-9d49-6e5763a37c45"), 992.63m, new DateTimeOffset(new DateTime(2020, 6, 30, 21, 14, 10, 69, DateTimeKind.Unspecified).AddTicks(920), new TimeSpan(0, 7, 0, 0, 0)), "Cumque vero rerum illum.", true, new DateTimeOffset(new DateTime(2020, 1, 11, 7, 22, 31, 921, DateTimeKind.Unspecified).AddTicks(4933), new TimeSpan(0, 7, 0, 0, 0)), "mollitia", new Guid("c2a70e2a-ef63-4cd3-813e-6c0feb02be4e"), new Guid("3f5dfa6f-bbef-f955-f750-e56dce5a4d97") },
                    { new Guid("2b94bacd-417a-aaf6-249c-e7305db0f8c2"), 533.10m, new DateTimeOffset(new DateTime(2020, 6, 4, 17, 8, 9, 461, DateTimeKind.Unspecified).AddTicks(4790), new TimeSpan(0, 7, 0, 0, 0)), "Aut qui sint autem sit.", true, new DateTimeOffset(new DateTime(2020, 3, 21, 21, 45, 40, 911, DateTimeKind.Unspecified).AddTicks(6633), new TimeSpan(0, 7, 0, 0, 0)), "hic", new Guid("0239ea8c-b559-0752-b2c0-92710f499696"), new Guid("edef5f70-0e2c-dcad-74db-7688646ffd2d") },
                    { new Guid("35f65d2c-7cfe-378d-40a4-6990103e9553"), 169.11m, new DateTimeOffset(new DateTime(2020, 6, 28, 17, 27, 34, 252, DateTimeKind.Unspecified).AddTicks(5063), new TimeSpan(0, 7, 0, 0, 0)), "Autem autem laborum nulla et asperiores officia sunt.", true, new DateTimeOffset(new DateTime(2020, 10, 5, 4, 9, 41, 591, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 7, 0, 0, 0)), "nulla", new Guid("9d4a5ac2-9ed1-9582-50ad-507ae459e493"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1") },
                    { new Guid("3d5d14e4-3fcc-7089-9fe4-9d676b30922d"), 904.33m, new DateTimeOffset(new DateTime(2020, 8, 29, 15, 9, 14, 0, DateTimeKind.Unspecified).AddTicks(2794), new TimeSpan(0, 7, 0, 0, 0)), "Incidunt maiores ab.", true, new DateTimeOffset(new DateTime(2020, 10, 11, 8, 44, 55, 723, DateTimeKind.Unspecified).AddTicks(1251), new TimeSpan(0, 7, 0, 0, 0)), "quis", new Guid("b354e7ff-dc8e-00a4-4e16-dbdec031d490"), new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"), 646.03m, new DateTimeOffset(new DateTime(2020, 9, 24, 11, 3, 6, 762, DateTimeKind.Unspecified).AddTicks(7284), new TimeSpan(0, 7, 0, 0, 0)), "Distinctio voluptatibus vel ipsa ut.", new DateTimeOffset(new DateTime(2020, 11, 23, 5, 32, 4, 349, DateTimeKind.Unspecified).AddTicks(9953), new TimeSpan(0, 7, 0, 0, 0)), "neque", new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42"), new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59") },
                    { new Guid("53c4e4fb-c85d-80e2-8ad9-652748a30f3c"), 202.26m, new DateTimeOffset(new DateTime(2020, 1, 31, 23, 20, 43, 293, DateTimeKind.Unspecified).AddTicks(6106), new TimeSpan(0, 7, 0, 0, 0)), "Nobis commodi voluptatibus amet quis laboriosam molestias facere.", new DateTimeOffset(new DateTime(2020, 12, 2, 20, 11, 19, 544, DateTimeKind.Unspecified).AddTicks(9834), new TimeSpan(0, 7, 0, 0, 0)), "eos", new Guid("11cf08e5-9589-40c5-a761-187ed55224f6"), new Guid("e189d5ab-c58e-c880-8b39-bc2da6528da9") },
                    { new Guid("71b6972b-725e-d40d-66c3-4f8b85031295"), 438.83m, new DateTimeOffset(new DateTime(2020, 1, 29, 16, 44, 3, 561, DateTimeKind.Unspecified).AddTicks(3346), new TimeSpan(0, 7, 0, 0, 0)), "Sit est a et deserunt sint architecto perspiciatis rerum.", new DateTimeOffset(new DateTime(2020, 8, 5, 17, 11, 24, 427, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, 7, 0, 0, 0)), "tenetur", new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668"), new Guid("d3626795-436d-1e59-c672-055d47c2ed18") },
                    { new Guid("cc3f9225-197a-9b0d-6182-6df2719fea1b"), 980.81m, new DateTimeOffset(new DateTime(2020, 6, 21, 13, 51, 57, 810, DateTimeKind.Unspecified).AddTicks(9401), new TimeSpan(0, 7, 0, 0, 0)), "Delectus voluptas minus veniam et nesciunt.", new DateTimeOffset(new DateTime(2020, 6, 21, 22, 35, 15, 640, DateTimeKind.Unspecified).AddTicks(1685), new TimeSpan(0, 7, 0, 0, 0)), "ut", new Guid("9de1b233-b753-b150-4906-4d445720e8f1"), new Guid("f694ea54-f527-eed5-e010-5eca808b3b9c") },
                    { new Guid("cd73f634-a957-8de9-762e-3754d34cf08b"), 748.96m, new DateTimeOffset(new DateTime(2020, 3, 7, 12, 10, 55, 729, DateTimeKind.Unspecified).AddTicks(3142), new TimeSpan(0, 7, 0, 0, 0)), "Vero quia rerum et omnis cupiditate aut sunt.", new DateTimeOffset(new DateTime(2020, 8, 1, 17, 36, 45, 990, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 7, 0, 0, 0)), "et", new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4"), new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("d42c9ec7-fda1-1681-fa3d-097e66c5fd01"), 869.35m, new DateTimeOffset(new DateTime(2020, 3, 9, 15, 42, 32, 800, DateTimeKind.Unspecified).AddTicks(2615), new TimeSpan(0, 7, 0, 0, 0)), "Eum eos alias ea.", true, new DateTimeOffset(new DateTime(2020, 6, 19, 16, 7, 36, 695, DateTimeKind.Unspecified).AddTicks(5449), new TimeSpan(0, 7, 0, 0, 0)), "alias", new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42"), new Guid("e189d5ab-c58e-c880-8b39-bc2da6528da9") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("f93c9215-2941-5f5a-c931-444a0a6156fa"), 40.81m, new DateTimeOffset(new DateTime(2020, 7, 9, 13, 54, 39, 511, DateTimeKind.Unspecified).AddTicks(9340), new TimeSpan(0, 7, 0, 0, 0)), "Eius quibusdam in voluptatum vel illo sed.", new DateTimeOffset(new DateTime(2020, 5, 4, 1, 0, 43, 596, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 7, 0, 0, 0)), "quia", new Guid("9fcce051-4f9f-f1f2-63d6-b684ab1f528f"), new Guid("2d49430d-4e90-f11b-51a9-34225bb3f424") },
                    { new Guid("fe70d0a9-755e-b31a-d87f-c5cc7de28369"), 828.21m, new DateTimeOffset(new DateTime(2020, 12, 27, 10, 29, 24, 579, DateTimeKind.Unspecified).AddTicks(2079), new TimeSpan(0, 7, 0, 0, 0)), "Facere facilis sint.", new DateTimeOffset(new DateTime(2020, 11, 18, 22, 4, 24, 934, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 7, 0, 0, 0)), "quasi", new Guid("d2f046ac-c105-40c7-eabf-733a9492edc5"), new Guid("2495c693-e3b9-7c6f-3898-b7dd200bc116") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9"), new Guid("042638ff-08ab-3154-8231-2f09aa954c72"), new DateTimeOffset(new DateTime(2020, 1, 27, 16, 55, 50, 381, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 7, 0, 0, 0)), "http://stanford.info", new DateTimeOffset(new DateTime(2020, 6, 22, 7, 33, 11, 275, DateTimeKind.Unspecified).AddTicks(6197), new TimeSpan(0, 7, 0, 0, 0)), new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("273ee7fa-1096-0806-6580-6035ad238abb"), new Guid("1de7f0c5-af98-25d1-a33a-f246ec74b73f"), new DateTimeOffset(new DateTime(2020, 4, 15, 19, 39, 29, 892, DateTimeKind.Unspecified).AddTicks(4558), new TimeSpan(0, 7, 0, 0, 0)), true, "https://april.net", new DateTimeOffset(new DateTime(2020, 10, 22, 7, 44, 14, 293, DateTimeKind.Unspecified).AddTicks(3072), new TimeSpan(0, 7, 0, 0, 0)), new Guid("11cf08e5-9589-40c5-a761-187ed55224f6") },
                    { new Guid("2d49430d-4e90-f11b-51a9-34225bb3f424"), new Guid("122899aa-bb86-c8b7-29dc-92551068fe1b"), new DateTimeOffset(new DateTime(2020, 4, 25, 0, 41, 21, 899, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, 7, 0, 0, 0)), true, "https://claire.biz", new DateTimeOffset(new DateTime(2020, 9, 10, 22, 55, 52, 695, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 7, 0, 0, 0)), new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d") },
                    { new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"), new Guid("dcaebaaf-f809-9558-8919-c4f71079e80d"), new DateTimeOffset(new DateTime(2020, 9, 17, 12, 39, 7, 938, DateTimeKind.Unspecified).AddTicks(2816), new TimeSpan(0, 7, 0, 0, 0)), true, "http://aracely.info", new DateTimeOffset(new DateTime(2020, 3, 3, 8, 13, 52, 588, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9d4a5ac2-9ed1-9582-50ad-507ae459e493") },
                    { new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), new Guid("85f9d68b-8075-4ce4-4687-d3b0fee00f06"), new DateTimeOffset(new DateTime(2020, 3, 7, 23, 54, 36, 924, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 7, 0, 0, 0)), true, "https://tracy.name", new DateTimeOffset(new DateTime(2020, 11, 15, 11, 56, 16, 868, DateTimeKind.Unspecified).AddTicks(8626), new TimeSpan(0, 7, 0, 0, 0)), new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), new Guid("7b30d717-a76c-5e6e-81be-4dcf0abad890"), new DateTimeOffset(new DateTime(2020, 7, 27, 0, 47, 48, 494, DateTimeKind.Unspecified).AddTicks(3600), new TimeSpan(0, 7, 0, 0, 0)), "https://kacie.info", new DateTimeOffset(new DateTime(2020, 6, 8, 19, 14, 36, 736, DateTimeKind.Unspecified).AddTicks(399), new TimeSpan(0, 7, 0, 0, 0)), new Guid("606f1107-4340-3d79-81f8-5d8b09c12c47") },
                    { new Guid("4431c95f-0a4a-5661-fa39-ba2e69221baa"), new Guid("fa994fb6-2e25-c984-c137-9a968f6f9cb1"), new DateTimeOffset(new DateTime(2020, 7, 9, 13, 54, 39, 511, DateTimeKind.Unspecified).AddTicks(9340), new TimeSpan(0, 7, 0, 0, 0)), "https://jarrell.net", new DateTimeOffset(new DateTime(2020, 5, 4, 1, 0, 43, 596, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 7, 0, 0, 0)), new Guid("11cf08e5-9589-40c5-a761-187ed55224f6") },
                    { new Guid("44ac7e55-012d-2bfb-510c-8e86863eeded"), new Guid("042638ff-08ab-3154-8231-2f09aa954c72"), new DateTimeOffset(new DateTime(2020, 11, 10, 23, 15, 48, 6, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 7, 0, 0, 0)), "http://cathrine.name", new DateTimeOffset(new DateTime(2020, 1, 23, 21, 48, 16, 487, DateTimeKind.Unspecified).AddTicks(5646), new TimeSpan(0, 7, 0, 0, 0)), new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("470f6997-03fb-cee9-3b65-7708add2e94e"), new Guid("946cbe11-beeb-0694-f564-dda95675991f"), new DateTimeOffset(new DateTime(2020, 2, 3, 23, 27, 2, 441, DateTimeKind.Unspecified).AddTicks(7051), new TimeSpan(0, 7, 0, 0, 0)), true, "https://noemy.com", new DateTimeOffset(new DateTime(2020, 8, 5, 12, 25, 58, 989, DateTimeKind.Unspecified).AddTicks(3117), new TimeSpan(0, 7, 0, 0, 0)), new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592") },
                    { new Guid("519ef052-9ed4-05a8-15b4-13c4587a030c"), new Guid("6582b0e9-0df0-e6c3-28f2-ec5e2b85796a"), new DateTimeOffset(new DateTime(2020, 5, 26, 16, 51, 16, 961, DateTimeKind.Unspecified).AddTicks(5992), new TimeSpan(0, 7, 0, 0, 0)), true, "http://jaleel.name", new DateTimeOffset(new DateTime(2020, 7, 24, 22, 18, 14, 516, DateTimeKind.Unspecified).AddTicks(3162), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6100e542-8ed9-94dd-02eb-d05d806edcfa") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), new Guid("01f4d29a-7bee-4b95-ca48-6fcecd1ce1a5"), new DateTimeOffset(new DateTime(2020, 3, 12, 19, 30, 16, 373, DateTimeKind.Unspecified).AddTicks(1082), new TimeSpan(0, 7, 0, 0, 0)), "http://matilde.com", new DateTimeOffset(new DateTime(2020, 10, 11, 7, 47, 8, 409, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7878f7dc-bd02-5290-3a26-8de4bc0e493e") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("6bbc76b4-a7f7-4c1f-4773-aee30c100642"), new Guid("7b30d717-a76c-5e6e-81be-4dcf0abad890"), new DateTimeOffset(new DateTime(2020, 9, 8, 9, 39, 18, 144, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 7, 0, 0, 0)), true, "https://frederic.info", new DateTimeOffset(new DateTime(2020, 10, 22, 4, 52, 8, 231, DateTimeKind.Unspecified).AddTicks(255), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f2fa31c8-ab7a-ac0b-5f1e-9b3f2bcd52f0") },
                    { new Guid("6e499dd6-6357-7ca3-45fb-1f8ba41e25e0"), new Guid("85f9d68b-8075-4ce4-4687-d3b0fee00f06"), new DateTimeOffset(new DateTime(2020, 5, 12, 9, 39, 6, 104, DateTimeKind.Unspecified).AddTicks(8526), new TimeSpan(0, 7, 0, 0, 0)), true, "https://reba.name", new DateTimeOffset(new DateTime(2020, 6, 16, 3, 28, 7, 196, DateTimeKind.Unspecified).AddTicks(445), new TimeSpan(0, 7, 0, 0, 0)), new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668") },
                    { new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436"), new Guid("042638ff-08ab-3154-8231-2f09aa954c72"), new DateTimeOffset(new DateTime(2020, 5, 1, 15, 32, 44, 760, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 7, 0, 0, 0)), true, "http://caleb.info", new DateTimeOffset(new DateTime(2020, 1, 10, 3, 56, 23, 465, DateTimeKind.Unspecified).AddTicks(9836), new TimeSpan(0, 7, 0, 0, 0)), new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("8752ae2b-1d50-b4b8-7d7f-a37ad24f0319"), new Guid("ff8d9313-3631-7d5e-8223-78fc98684039"), new DateTimeOffset(new DateTime(2020, 6, 20, 2, 54, 43, 526, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 7, 0, 0, 0)), "http://ozella.org", new DateTimeOffset(new DateTime(2020, 5, 29, 5, 5, 50, 377, DateTimeKind.Unspecified).AddTicks(5220), new TimeSpan(0, 7, 0, 0, 0)), new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("8bccb0b9-fc46-b19c-0a0a-a2dc4995e1e4"), new Guid("f7771a35-735e-edff-b14e-cd1606d57de8"), new DateTimeOffset(new DateTime(2020, 4, 5, 2, 17, 42, 549, DateTimeKind.Unspecified).AddTicks(7961), new TimeSpan(0, 7, 0, 0, 0)), true, "https://gianni.name", new DateTimeOffset(new DateTime(2020, 7, 6, 16, 41, 49, 314, DateTimeKind.Unspecified).AddTicks(9897), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d2f046ac-c105-40c7-eabf-733a9492edc5") },
                    { new Guid("8d52a62d-d0a9-fe70-5e75-1ab3d87fc5cc"), new Guid("7b30d717-a76c-5e6e-81be-4dcf0abad890"), new DateTimeOffset(new DateTime(2020, 12, 27, 18, 49, 42, 41, DateTimeKind.Unspecified).AddTicks(5112), new TimeSpan(0, 7, 0, 0, 0)), true, "http://tad.biz", new DateTimeOffset(new DateTime(2020, 3, 3, 22, 30, 55, 391, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668") },
                    { new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), new Guid("da46d4f4-4577-fb00-969b-e0dfb77ed0ff"), new DateTimeOffset(new DateTime(2020, 11, 6, 12, 35, 15, 882, DateTimeKind.Unspecified).AddTicks(9721), new TimeSpan(0, 7, 0, 0, 0)), true, "http://simone.name", new DateTimeOffset(new DateTime(2020, 4, 7, 14, 17, 44, 211, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("905da48a-b45a-2d81-dcd8-750729b4372c"), new Guid("cf7d3633-3eee-94eb-b598-83a5ac711802"), new DateTimeOffset(new DateTime(2020, 3, 25, 2, 2, 32, 631, DateTimeKind.Unspecified).AddTicks(2147), new TimeSpan(0, 7, 0, 0, 0)), true, "http://lucienne.name", new DateTimeOffset(new DateTime(2020, 5, 5, 0, 45, 40, 143, DateTimeKind.Unspecified).AddTicks(2959), new TimeSpan(0, 7, 0, 0, 0)), new Guid("0ac39d47-a580-388c-334e-c36e77d4acb7") },
                    { new Guid("93e6a9f2-626c-3369-ef85-5ab90a53b0f5"), new Guid("558a8384-f60e-83e4-2bea-73f473f6909e"), new DateTimeOffset(new DateTime(2020, 6, 11, 11, 41, 47, 844, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 7, 0, 0, 0)), true, "http://donna.biz", new DateTimeOffset(new DateTime(2020, 12, 25, 13, 22, 30, 637, DateTimeKind.Unspecified).AddTicks(1409), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4fbc87d7-b534-95ce-0699-083d05b4056f") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("de4ff2b1-a48b-873f-c7ca-08f63404c6ce"), new DateTimeOffset(new DateTime(2020, 8, 30, 0, 38, 16, 925, DateTimeKind.Unspecified).AddTicks(600), new TimeSpan(0, 7, 0, 0, 0)), "https://darron.net", new DateTimeOffset(new DateTime(2020, 9, 2, 6, 3, 4, 571, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9588df2f-6267-6dd3-4359-1ec672055d47") },
                    { new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), new Guid("01f4d29a-7bee-4b95-ca48-6fcecd1ce1a5"), new DateTimeOffset(new DateTime(2020, 4, 7, 19, 48, 40, 196, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 7, 0, 0, 0)), "https://nelle.name", new DateTimeOffset(new DateTime(2020, 7, 7, 22, 40, 45, 671, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4fbc87d7-b534-95ce-0699-083d05b4056f") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("9ec7cf01-d42c-fda1-8116-fa3d097e66c5"), new Guid("122899aa-bb86-c8b7-29dc-92551068fe1b"), new DateTimeOffset(new DateTime(2020, 12, 30, 16, 6, 44, 836, DateTimeKind.Unspecified).AddTicks(7234), new TimeSpan(0, 7, 0, 0, 0)), true, "http://maximillia.biz", new DateTimeOffset(new DateTime(2020, 10, 29, 23, 2, 1, 119, DateTimeKind.Unspecified).AddTicks(491), new TimeSpan(0, 7, 0, 0, 0)), new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d") },
                    { new Guid("a886f76d-e63c-8046-ed81-68bd10e2e3d1"), new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new DateTimeOffset(new DateTime(2020, 8, 11, 12, 27, 58, 191, DateTimeKind.Unspecified).AddTicks(5620), new TimeSpan(0, 7, 0, 0, 0)), true, "http://sylvan.net", new DateTimeOffset(new DateTime(2020, 7, 23, 23, 39, 33, 336, DateTimeKind.Unspecified).AddTicks(2445), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6100e542-8ed9-94dd-02eb-d05d806edcfa") },
                    { new Guid("b0645df7-a1a4-b5a1-3962-54ea94f627f5"), new Guid("bfb312c3-362b-ec49-fcb7-61f2db22d65c"), new DateTimeOffset(new DateTime(2020, 12, 18, 22, 24, 38, 496, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 7, 0, 0, 0)), true, "http://earnest.biz", new DateTimeOffset(new DateTime(2020, 5, 2, 13, 44, 44, 1, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, 7, 0, 0, 0)), new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("c61e5943-0572-475d-c2ed-18d762e5400b"), new Guid("122899aa-bb86-c8b7-29dc-92551068fe1b"), new DateTimeOffset(new DateTime(2020, 1, 20, 17, 43, 34, 304, DateTimeKind.Unspecified).AddTicks(9135), new TimeSpan(0, 7, 0, 0, 0)), "http://concepcion.biz", new DateTimeOffset(new DateTime(2020, 10, 25, 4, 35, 8, 60, DateTimeKind.Unspecified).AddTicks(6984), new TimeSpan(0, 7, 0, 0, 0)), new Guid("0239ea8c-b559-0752-b2c0-92710f499696") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("ce272427-3313-d248-a829-fd66c5668262"), new Guid("bfb312c3-362b-ec49-fcb7-61f2db22d65c"), new DateTimeOffset(new DateTime(2020, 9, 13, 9, 59, 26, 471, DateTimeKind.Unspecified).AddTicks(5189), new TimeSpan(0, 7, 0, 0, 0)), true, "http://agnes.net", new DateTimeOffset(new DateTime(2020, 7, 5, 14, 37, 40, 355, DateTimeKind.Unspecified).AddTicks(7921), new TimeSpan(0, 7, 0, 0, 0)), new Guid("dae37e73-50c0-d5c8-97c6-5a7041370998") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("e502f9c9-cf08-8911-95c5-40a761187ed5"), new Guid("dcaebaaf-f809-9558-8919-c4f71079e80d"), new DateTimeOffset(new DateTime(2020, 3, 4, 8, 32, 32, 852, DateTimeKind.Unspecified).AddTicks(7627), new TimeSpan(0, 7, 0, 0, 0)), "http://sigurd.name", new DateTimeOffset(new DateTime(2020, 3, 13, 19, 58, 27, 22, DateTimeKind.Unspecified).AddTicks(4382), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a2f3dcda-df43-530a-0c96-53f4b2c78dd4") },
                    { new Guid("e9a957cd-768d-372e-54d3-4cf08bd2e2e7"), new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new DateTimeOffset(new DateTime(2020, 12, 8, 10, 58, 47, 193, DateTimeKind.Unspecified).AddTicks(7078), new TimeSpan(0, 7, 0, 0, 0)), "https://macie.org", new DateTimeOffset(new DateTime(2020, 3, 28, 19, 1, 11, 310, DateTimeKind.Unspecified).AddTicks(8367), new TimeSpan(0, 7, 0, 0, 0)), new Guid("0ac39d47-a580-388c-334e-c36e77d4acb7") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), new Guid("9b0258ef-d34c-bfca-2865-b935f45efc20"), new DateTimeOffset(new DateTime(2020, 4, 10, 18, 50, 49, 172, DateTimeKind.Unspecified).AddTicks(2274), new TimeSpan(0, 7, 0, 0, 0)), true, "http://linda.org", new DateTimeOffset(new DateTime(2020, 6, 11, 16, 32, 45, 765, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9de1b233-b753-b150-4906-4d445720e8f1") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("f5a7c23f-e018-9b7e-5202-b062f68e93af"), new Guid("f7771a35-735e-edff-b14e-cd1606d57de8"), new DateTimeOffset(new DateTime(2020, 9, 30, 22, 41, 15, 33, DateTimeKind.Unspecified).AddTicks(7936), new TimeSpan(0, 7, 0, 0, 0)), "https://roosevelt.net", new DateTimeOffset(new DateTime(2020, 10, 4, 20, 1, 40, 911, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc") },
                    { new Guid("f608ca7f-8f54-ca59-a88e-37a92300d6a4"), new Guid("f7771a35-735e-edff-b14e-cd1606d57de8"), new DateTimeOffset(new DateTime(2020, 3, 11, 17, 31, 40, 530, DateTimeKind.Unspecified).AddTicks(2693), new TimeSpan(0, 7, 0, 0, 0)), "https://antonio.biz", new DateTimeOffset(new DateTime(2020, 1, 6, 13, 50, 57, 171, DateTimeKind.Unspecified).AddTicks(5185), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9d4a5ac2-9ed1-9582-50ad-507ae459e493") },
                    { new Guid("f955bbef-50f7-6de5-ce5a-4d978476ab3a"), new Guid("bc12e381-9af1-1ac4-c15e-a986da5b57bd"), new DateTimeOffset(new DateTime(2020, 11, 7, 22, 3, 20, 43, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 7, 0, 0, 0)), "http://selina.biz", new DateTimeOffset(new DateTime(2020, 3, 16, 3, 1, 38, 621, DateTimeKind.Unspecified).AddTicks(5180), new TimeSpan(0, 7, 0, 0, 0)), new Guid("606f1107-4340-3d79-81f8-5d8b09c12c47") },
                    { new Guid("fba953a9-7f00-ad94-4550-9c544966eb7f"), new Guid("894bbc95-6ce2-cb29-8f17-449c7ebe9a77"), new DateTimeOffset(new DateTime(2020, 6, 15, 17, 27, 56, 908, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 7, 0, 0, 0)), "http://alf.biz", new DateTimeOffset(new DateTime(2020, 6, 16, 5, 20, 55, 722, DateTimeKind.Unspecified).AddTicks(2799), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"), new Guid("9b0258ef-d34c-bfca-2865-b935f45efc20"), new DateTimeOffset(new DateTime(2020, 10, 19, 15, 3, 6, 182, DateTimeKind.Unspecified).AddTicks(4795), new TimeSpan(0, 7, 0, 0, 0)), true, "http://ulises.net", new DateTimeOffset(new DateTime(2020, 7, 5, 3, 46, 2, 269, DateTimeKind.Unspecified).AddTicks(9562), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9b616743-64aa-d99f-f78f-1a58970f7896") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("07858950-2b68-580d-8f71-c7d88de8e7b5"), 943.23m, new Guid("83178de0-bde3-b552-9b65-adced5fa148b"), new DateTimeOffset(new DateTime(2020, 3, 24, 20, 52, 15, 311, DateTimeKind.Unspecified).AddTicks(3062), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d57e1861-2452-09f6-8c56-f3f8557eac44"), "Commodi sit nostrum doloremque natus dolor praesentium.", new DateTimeOffset(new DateTime(2020, 10, 13, 14, 27, 47, 15, DateTimeKind.Unspecified).AddTicks(6990), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("8bdb736b-89b7-be24-1c15-31f7e7421644"), new Guid("72d6a72b-0a05-898f-22cd-5b94c9155554") },
                    { new Guid("10e0eed5-ca5e-8b80-3b9c-77ec7d0d387e"), 820.27m, new Guid("4ff641e6-8a82-5da4-905a-b4812ddcd875"), new DateTimeOffset(new DateTime(2020, 3, 19, 11, 48, 45, 194, DateTimeKind.Unspecified).AddTicks(3458), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d27aa37f-034f-ce19-64c7-57c651b6c26d"), "Qui non sed fuga doloribus.", new DateTimeOffset(new DateTime(2020, 1, 17, 18, 19, 32, 227, DateTimeKind.Unspecified).AddTicks(6697), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("11cf08e5-9589-40c5-a761-187ed55224f6"), new Guid("a740c595-1861-d57e-5224-f6098c56f3f8") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("122a97a1-f7c4-f517-d8b8-6d416f55c34a"), 379.09m, new Guid("e4513bd5-cac7-1b59-239d-c5acd311c12b"), new DateTimeOffset(new DateTime(2020, 10, 1, 6, 8, 19, 529, DateTimeKind.Unspecified).AddTicks(7088), new TimeSpan(0, 7, 0, 0, 0)), new Guid("61cb6c4e-d08c-e867-a5e9-d2d209173f4e"), "Ad labore laborum veritatis corrupti repellendus.", true, new DateTimeOffset(new DateTime(2020, 3, 20, 23, 13, 11, 163, DateTimeKind.Unspecified).AddTicks(2525), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25"), new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a") },
                    { new Guid("20c9a600-801c-9df0-1740-b7b9b0cc8b46"), 104.33m, new Guid("f7e0c53a-645d-a4b0-a1a1-b5396254ea94"), new DateTimeOffset(new DateTime(2020, 2, 9, 1, 36, 7, 503, DateTimeKind.Unspecified).AddTicks(1793), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"), "Ipsam nobis ex beatae earum iure fuga eveniet placeat.", true, new DateTimeOffset(new DateTime(2020, 11, 22, 4, 33, 39, 260, DateTimeKind.Unspecified).AddTicks(5363), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("d2f046ac-c105-40c7-eabf-733a9492edc5"), new Guid("0c512bfb-868e-3e86-eded-bd69d81343e6") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"), 351.42m, new Guid("507d6540-c550-bdb9-58e5-e1a445366631"), new DateTimeOffset(new DateTime(2020, 1, 19, 21, 10, 47, 394, DateTimeKind.Unspecified).AddTicks(5526), new TimeSpan(0, 7, 0, 0, 0)), new Guid("914042cc-dafa-ffd7-358d-04ae36c7ca60"), "Eum non cupiditate a provident.", new DateTimeOffset(new DateTime(2020, 8, 16, 16, 41, 46, 561, DateTimeKind.Unspecified).AddTicks(3937), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42"), new Guid("b651c657-6dc2-86f7-a83c-e64680ed8168") },
                    { new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), 714.22m, new Guid("c7cf01ad-2c9e-a1d4-fd81-16fa3d097e66"), new DateTimeOffset(new DateTime(2020, 12, 13, 9, 11, 54, 471, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b1835381-0a6f-3558-0ef0-f5e74a756503"), "Rerum porro accusantium aliquam velit quos.", new DateTimeOffset(new DateTime(2020, 7, 21, 0, 27, 49, 307, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("b9091570-e0f7-593d-99e0-58bfd294d21a"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("41d8c209-3f66-e488-6829-d7affbe4c453"), 663.27m, new Guid("bfceb585-a8f3-16cf-cdba-942b7a41f6aa"), new DateTimeOffset(new DateTime(2020, 1, 8, 1, 48, 0, 77, DateTimeKind.Unspecified).AddTicks(5484), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d87437ec-f4f5-9d52-9bde-35a4eb67d140"), "Nisi non illo eos sed eos est nobis commodi voluptatibus.", true, new DateTimeOffset(new DateTime(2020, 12, 23, 6, 9, 16, 831, DateTimeKind.Unspecified).AddTicks(677), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("81fda1d4-fa16-093d-7e66-c5fd012c2fc3"), new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"), 662.90m, new Guid("5f5a2941-31c9-4a44-0a61-56fa39ba2e69"), new DateTimeOffset(new DateTime(2020, 6, 25, 22, 38, 45, 908, DateTimeKind.Unspecified).AddTicks(5111), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a2e64313-e8a4-bda0-6c2b-a7d672050a8f"), "Vel ipsa ut enim odit similique natus voluptatem et enim.", new DateTimeOffset(new DateTime(2020, 10, 12, 13, 38, 39, 382, DateTimeKind.Unspecified).AddTicks(9631), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42"), new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59") },
                    { new Guid("487e1318-8926-dc97-7c4d-5a2e22161d0e"), 283.99m, new Guid("95ceb534-9906-3d08-05b4-056fad2672cc"), new DateTimeOffset(new DateTime(2020, 11, 18, 8, 43, 55, 142, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 7, 0, 0, 0)), new Guid("af4e7220-0f01-2605-0e56-6ab34b8a588c"), "Voluptas incidunt accusamus.", new DateTimeOffset(new DateTime(2020, 12, 31, 15, 46, 40, 575, DateTimeKind.Unspecified).AddTicks(190), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("9588df2f-6267-6dd3-4359-1ec672055d47"), new Guid("e07e234c-6fb5-08dc-5b8c-438fffa9361b") },
                    { new Guid("8a362423-e4dd-38b9-a363-09e8fcc69301"), 785.13m, new Guid("c62fe184-919c-bc81-0855-94e2b7053499"), new DateTimeOffset(new DateTime(2020, 9, 29, 4, 36, 13, 472, DateTimeKind.Unspecified).AddTicks(3735), new TimeSpan(0, 7, 0, 0, 0)), new Guid("db033f39-57ce-32f6-1cc5-87dc332ddaa1"), "Magni quia voluptas in et vel.", new DateTimeOffset(new DateTime(2020, 2, 1, 10, 34, 48, 275, DateTimeKind.Unspecified).AddTicks(7022), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("c2a70e2a-ef63-4cd3-813e-6c0feb02be4e"), new Guid("edef5f70-0e2c-dcad-74db-7688646ffd2d") },
                    { new Guid("ae2b65bc-8752-1d50-b8b4-7d7fa37ad24f"), 927.40m, new Guid("81ed8046-bd68-e210-e3d1-cca53c8bb036"), new DateTimeOffset(new DateTime(2020, 7, 23, 23, 39, 33, 336, DateTimeKind.Unspecified).AddTicks(2445), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8bf680eb-1420-122b-37d5-2d64d485abd5"), "Ipsum provident deserunt a unde quidem ab consequatur architecto eum.", new DateTimeOffset(new DateTime(2020, 11, 1, 12, 44, 6, 853, DateTimeKind.Unspecified).AddTicks(1360), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("360f39a0-9ef3-42c7-47d5-608af0d59ff4"), new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("b41e9ba8-71a4-7b18-0dfd-0318ea7471aa"), 914.69m, new Guid("2fb312ed-7f01-032d-d6c7-bf08c60ada4a"), new DateTimeOffset(new DateTime(2020, 3, 17, 13, 6, 22, 422, DateTimeKind.Unspecified).AddTicks(5169), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b35b2234-24f4-2054-ad1a-71ce513a15ab"), "Voluptas iste eos rerum magnam nihil.", true, new DateTimeOffset(new DateTime(2020, 4, 9, 17, 49, 37, 68, DateTimeKind.Unspecified).AddTicks(1039), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("f880aa64-7561-7503-de83-7f97fc4ce8a5"), new Guid("b651c657-6dc2-86f7-a83c-e64680ed8168") },
                    { new Guid("c2cfcbc3-451c-b6de-5290-a953a9fb007f"), 817.12m, new Guid("dcad0e2c-db74-8876-646f-fd2dc498c6ec"), new DateTimeOffset(new DateTime(2020, 11, 28, 7, 24, 33, 743, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e6a2ec69-f641-824f-8aa4-5d905ab4812d"), "Sint vel assumenda eos dolores aperiam nemo veniam amet.", true, new DateTimeOffset(new DateTime(2020, 9, 22, 18, 47, 21, 152, DateTimeKind.Unspecified).AddTicks(7159), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("0ac39d47-a580-388c-334e-c36e77d4acb7"), new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3") },
                    { new Guid("de96d9a2-5381-b183-6f0a-58350ef0f5e7"), 70.98m, new Guid("a2fc195c-af49-2f96-5f0c-e2aa42309edd"), new DateTimeOffset(new DateTime(2020, 1, 20, 7, 42, 9, 565, DateTimeKind.Unspecified).AddTicks(9209), new TimeSpan(0, 7, 0, 0, 0)), new Guid("69626c93-ef33-5a85-b90a-53b0f5a84781"), "Atque natus porro pariatur dolorum laborum et doloribus et occaecati.", true, new DateTimeOffset(new DateTime(2020, 4, 2, 15, 14, 46, 882, DateTimeKind.Unspecified).AddTicks(6824), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("d2f046ac-c105-40c7-eabf-733a9492edc5"), new Guid("e189d5ab-c58e-c880-8b39-bc2da6528da9") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("14fad5ce-ef8b-2f7b-a2d9-96de815383b1"), 786.33m, new DateTimeOffset(new DateTime(2020, 8, 23, 11, 12, 17, 756, DateTimeKind.Unspecified).AddTicks(788), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 5, 3, 15, 40, 794, DateTimeKind.Unspecified).AddTicks(8623), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("c2a70e2a-ef63-4cd3-813e-6c0feb02be4e") },
                    { new Guid("3f9f750c-38ab-aaa4-4eb4-7f55421996b8"), 139.90m, new DateTimeOffset(new DateTime(2020, 12, 2, 7, 59, 45, 228, DateTimeKind.Unspecified).AddTicks(5519), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 4, 14, 1, 24, 6, 981, DateTimeKind.Unspecified).AddTicks(1165), new TimeSpan(0, 7, 0, 0, 0)), "Credit Card Account", new Guid("a2f3dcda-df43-530a-0c96-53f4b2c78dd4") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("602b2f40-79ee-53b4-e390-36dfc79c1897"), 142.24m, new DateTimeOffset(new DateTime(2020, 5, 7, 3, 56, 42, 922, DateTimeKind.Unspecified).AddTicks(5669), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 26, 11, 55, 44, 937, DateTimeKind.Unspecified).AddTicks(301), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("b354e7ff-dc8e-00a4-4e16-dbdec031d490") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("89504ad9-0785-2b68-0d58-8f71c7d88de8"), 959.23m, new DateTimeOffset(new DateTime(2020, 4, 20, 7, 30, 2, 415, DateTimeKind.Unspecified).AddTicks(6905), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 10, 11, 1, 19, 31, 329, DateTimeKind.Unspecified).AddTicks(9863), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("9d4a5ac2-9ed1-9582-50ad-507ae459e493") },
                    { new Guid("9225cd84-cc3f-197a-0d9b-61826df2719f"), 281.91m, new DateTimeOffset(new DateTime(2020, 7, 27, 11, 15, 33, 143, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 3, 12, 43, 52, 682, DateTimeKind.Unspecified).AddTicks(7039), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("0239ea8c-b559-0752-b2c0-92710f499696") },
                    { new Guid("ad322849-cf01-9ec7-2cd4-a1fd8116fa3d"), 319.55m, new DateTimeOffset(new DateTime(2020, 12, 13, 9, 11, 54, 471, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 21, 0, 27, 49, 307, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 7, 0, 0, 0)), "Checking Account", new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4") },
                    { new Guid("c550507d-bdb9-e558-e1a4-45366631090c"), 127.93m, new DateTimeOffset(new DateTime(2020, 10, 7, 12, 3, 32, 557, DateTimeKind.Unspecified).AddTicks(1453), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 7, 10, 58, 11, 326, DateTimeKind.Unspecified).AddTicks(4310), new TimeSpan(0, 7, 0, 0, 0)), "Home Loan Account", new Guid("8026a67e-3b61-fd8d-5241-408b6939c3a4") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("c57fd8b3-7dcc-83e2-69aa-a4108d4d026f"), 13.45m, new DateTimeOffset(new DateTime(2020, 11, 18, 22, 4, 24, 934, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 6, 15, 8, 46, 13, 586, DateTimeKind.Unspecified).AddTicks(2313), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("9de1b233-b753-b150-4906-4d445720e8f1") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("d86ef2ce-8d84-bd04-6676-0f9121b162c9"), 325.58m, new DateTimeOffset(new DateTime(2020, 10, 7, 0, 8, 12, 512, DateTimeKind.Unspecified).AddTicks(5571), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 9, 6, 59, 37, 33, DateTimeKind.Unspecified).AddTicks(3154), new TimeSpan(0, 7, 0, 0, 0)), "Money Market Account", new Guid("4a1c6b89-d069-783e-490c-18783c5527ee") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"), new Guid("742e2a57-6231-e100-0c30-a46a4792353a"), new DateTimeOffset(new DateTime(2020, 4, 13, 17, 1, 0, 884, DateTimeKind.Unspecified).AddTicks(3627), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 24, 21, 38, 22, 83, DateTimeKind.Unspecified).AddTicks(9488), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4fbc87d7-b534-95ce-0699-083d05b4056f") },
                    { new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"), new Guid("742e2a57-6231-e100-0c30-a46a4792353a"), new DateTimeOffset(new DateTime(2020, 1, 2, 22, 19, 36, 290, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 20, 23, 2, 13, 133, DateTimeKind.Unspecified).AddTicks(9507), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9d4a5ac2-9ed1-9582-50ad-507ae459e493") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"), new Guid("dc2253fb-a284-69ca-546f-0a051ec36e98"), new DateTimeOffset(new DateTime(2020, 5, 8, 14, 10, 31, 325, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 10, 14, 15, 52, 36, 123, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("2cedef5f-ad0e-74dc-db76-88646ffd2dc4"), new Guid("6c5f7fae-283c-7ad4-96e0-ad704663df22"), new DateTimeOffset(new DateTime(2020, 5, 28, 3, 59, 23, 872, DateTimeKind.Unspecified).AddTicks(9311), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 11, 28, 7, 24, 33, 743, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4a1c6b89-d069-783e-490c-18783c5527ee") },
                    { new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), new Guid("915bf2ff-2a7a-a582-3585-cbee1ae797a3"), new DateTimeOffset(new DateTime(2020, 11, 25, 5, 40, 38, 671, DateTimeKind.Unspecified).AddTicks(5671), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 9, 1, 7, 35, 16, 518, DateTimeKind.Unspecified).AddTicks(1913), new TimeSpan(0, 7, 0, 0, 0)), new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d") },
                    { new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), new Guid("dc2253fb-a284-69ca-546f-0a051ec36e98"), new DateTimeOffset(new DateTime(2020, 11, 25, 18, 3, 40, 322, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 20, 15, 23, 15, 930, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("65d2756d-3dd3-155c-3a97-87de8ded6a3a"), new Guid("dc2253fb-a284-69ca-546f-0a051ec36e98"), new DateTimeOffset(new DateTime(2020, 9, 14, 23, 41, 43, 347, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 1, 19, 16, 20, 22, 899, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9d4a5ac2-9ed1-9582-50ad-507ae459e493") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), new Guid("f774154c-4e4a-4a5f-d769-f094e08d73e6"), new DateTimeOffset(new DateTime(2020, 11, 20, 9, 53, 55, 655, DateTimeKind.Unspecified).AddTicks(6105), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 4, 3, 10, 26, 503, DateTimeKind.Unspecified).AddTicks(5474), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f2fa31c8-ab7a-ac0b-5f1e-9b3f2bcd52f0") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"), new Guid("742e2a57-6231-e100-0c30-a46a4792353a"), new DateTimeOffset(new DateTime(2020, 7, 20, 7, 21, 32, 581, DateTimeKind.Unspecified).AddTicks(8433), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 7, 2, 16, 6, 46, 253, DateTimeKind.Unspecified).AddTicks(505), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6b601e2a-fd75-5bb7-5be1-196ca9cff63a") },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("7d5ba0c4-a164-7231-7cf6-1d1e6efaf5d8"), new DateTimeOffset(new DateTime(2020, 4, 8, 8, 4, 5, 656, DateTimeKind.Unspecified).AddTicks(5098), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 11, 29, 10, 12, 37, 137, DateTimeKind.Unspecified).AddTicks(6391), new TimeSpan(0, 7, 0, 0, 0)), new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d") },
                    { new Guid("a951f11b-2234-b35b-f424-5420ad1a71ce"), new Guid("85f9d68b-8075-4ce4-4687-d3b0fee00f06"), new DateTimeOffset(new DateTime(2020, 5, 5, 4, 23, 45, 761, DateTimeKind.Unspecified).AddTicks(4016), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 5, 13, 6, 0, 41, 864, DateTimeKind.Unspecified).AddTicks(2368), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6b601e2a-fd75-5bb7-5be1-196ca9cff63a") },
                    { new Guid("a99052b6-a953-00fb-7f94-ad45509c5449"), new Guid("c34ae2e6-68cc-6e9c-d22e-1db28b88829e"), new DateTimeOffset(new DateTime(2020, 11, 11, 7, 27, 31, 68, DateTimeKind.Unspecified).AddTicks(9756), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 11, 13, 9, 56, 52, 74, DateTimeKind.Unspecified).AddTicks(59), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6b17d449-6d47-ded4-42e8-91b1dda61892") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), new Guid("742e2a57-6231-e100-0c30-a46a4792353a"), new DateTimeOffset(new DateTime(2020, 9, 6, 8, 54, 33, 707, DateTimeKind.Unspecified).AddTicks(6387), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 12, 2, 21, 36, 36, 154, DateTimeKind.Unspecified).AddTicks(5293), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9d4a5ac2-9ed1-9582-50ad-507ae459e493") },
                    { new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"), new Guid("e37263c1-54e5-503c-642e-44045c366f77"), new DateTimeOffset(new DateTime(2020, 11, 27, 7, 32, 56, 34, DateTimeKind.Unspecified).AddTicks(3425), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 8, 18, 21, 0, 30, 276, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 7, 0, 0, 0)), new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25") }
                });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("f24616bd-e6a9-6c93-6269-33ef855ab90a"), new Guid("dc2253fb-a284-69ca-546f-0a051ec36e98"), new DateTimeOffset(new DateTime(2020, 11, 27, 22, 32, 57, 624, DateTimeKind.Unspecified).AddTicks(1397), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 17, 4, 3, 45, 443, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b9091570-e0f7-593d-99e0-58bfd294d21a") },
                    { new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"), new Guid("9a0a219e-f958-f1a7-0605-94327786d627"), new DateTimeOffset(new DateTime(2020, 4, 13, 6, 33, 38, 338, DateTimeKind.Unspecified).AddTicks(2487), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 12, 22, 19, 13, 30, 976, DateTimeKind.Unspecified).AddTicks(8713), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a4ba18a9-4a80-60ba-6b5e-7ddf7d9935d5") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("09f62452-568c-f8f3-557e-ac442d01fb2b"), "Pending", new Guid("f0bc8bcb-9c50-1a09-e65f-56c571a1badf"), new Guid("ecc698c4-a3bd-d5e5-df91-ad2a6e8169d6"), new DateTimeOffset(new DateTime(2020, 1, 13, 2, 49, 56, 24, DateTimeKind.Unspecified).AddTicks(3630), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2cedef5f-ad0e-74dc-db76-88646ffd2dc4"), true, new DateTimeOffset(new DateTime(2020, 11, 23, 2, 38, 5, 756, DateTimeKind.Unspecified).AddTicks(7608), new TimeSpan(0, 7, 0, 0, 0)), 1, "10:00 AM", new Guid("9d4a5ac2-9ed1-9582-50ad-507ae459e493") },
                    { new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), "Confirmed", new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new Guid("edc2475d-d718-e562-400b-b5d94a508985"), new DateTimeOffset(new DateTime(2020, 1, 9, 23, 46, 18, 401, DateTimeKind.Unspecified).AddTicks(4385), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), true, new DateTimeOffset(new DateTime(2020, 8, 19, 7, 8, 25, 325, DateTimeKind.Unspecified).AddTicks(2802), new TimeSpan(0, 7, 0, 0, 0)), 4, "1:00 PM", new Guid("f2fa31c8-ab7a-ac0b-5f1e-9b3f2bcd52f0") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("15d6a64d-3c92-41f9-295a-5fc931444a0a"), "Pending", new Guid("85c7be28-3ba8-977e-a626-54f8f5964a2b"), new Guid("5837778a-135d-6548-2553-d7ec3774d8f5"), new DateTimeOffset(new DateTime(2020, 6, 25, 22, 38, 45, 908, DateTimeKind.Unspecified).AddTicks(5111), new TimeSpan(0, 7, 0, 0, 0)), new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"), new DateTimeOffset(new DateTime(2020, 10, 12, 13, 38, 39, 382, DateTimeKind.Unspecified).AddTicks(9631), new TimeSpan(0, 7, 0, 0, 0)), 2, "7:00 AM", new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("1681fda1-3dfa-7e09-66c5-fd012c2fc333"), "Cancelled", new Guid("268f4ff8-d5e1-09db-b31f-3e8190949cc6"), new Guid("8bc880c5-bc39-a62d-528d-a9d070fe5e75"), new DateTimeOffset(new DateTime(2020, 10, 14, 0, 48, 9, 934, DateTimeKind.Unspecified).AddTicks(1552), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), true, new DateTimeOffset(new DateTime(2020, 8, 5, 23, 46, 0, 972, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, 7, 0, 0, 0)), 2, "8:00 PM", new Guid("f2fa31c8-ab7a-ac0b-5f1e-9b3f2bcd52f0") },
                    { new Guid("1e329db5-c9fa-05fc-d497-5ed3d8499f7c"), "Completed", new Guid("f0bc8bcb-9c50-1a09-e65f-56c571a1badf"), new Guid("81b45a90-dc2d-75d8-0729-b4372c2ad5ff"), new DateTimeOffset(new DateTime(2020, 4, 5, 14, 28, 56, 88, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, 7, 0, 0, 0)), new Guid("72ff2f81-65bc-ae2b-5287-501db8b47d7f"), true, new DateTimeOffset(new DateTime(2020, 10, 29, 5, 57, 43, 860, DateTimeKind.Unspecified).AddTicks(3340), new TimeSpan(0, 7, 0, 0, 0)), 3, "10:00 PM", new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("38dfb793-9a5c-1946-abd6-1d8bdfd64787"), "Pending", new Guid("bc12e381-9af1-1ac4-c15e-a986da5b57bd"), new Guid("0945e751-80eb-8bf6-2014-2b1237d52d64"), new DateTimeOffset(new DateTime(2020, 3, 16, 6, 2, 15, 902, DateTimeKind.Unspecified).AddTicks(9946), new TimeSpan(0, 7, 0, 0, 0)), new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), new DateTimeOffset(new DateTime(2020, 5, 2, 1, 48, 5, 235, DateTimeKind.Unspecified).AddTicks(4765), new TimeSpan(0, 7, 0, 0, 0)), 1, "9:00 PM", new Guid("6b601e2a-fd75-5bb7-5be1-196ca9cff63a") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"), "Completed", new Guid("dc2253fb-a284-69ca-546f-0a051ec36e98"), new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), new DateTimeOffset(new DateTime(2020, 8, 15, 6, 27, 26, 793, DateTimeKind.Unspecified).AddTicks(9351), new TimeSpan(0, 7, 0, 0, 0)), new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), true, new DateTimeOffset(new DateTime(2020, 12, 17, 6, 25, 21, 515, DateTimeKind.Unspecified).AddTicks(9986), new TimeSpan(0, 7, 0, 0, 0)), 2, "6:00 PM", new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42") },
                    { new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3"), "Completed", new Guid("e37263c1-54e5-503c-642e-44045c366f77"), new Guid("8364bab3-3549-2209-c2f8-b1659599800f"), new DateTimeOffset(new DateTime(2020, 4, 25, 0, 41, 21, 899, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, 7, 0, 0, 0)), new Guid("c962b121-02f9-08e5-cf11-8995c540a761"), true, new DateTimeOffset(new DateTime(2020, 9, 10, 22, 55, 52, 695, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 7, 0, 0, 0)), 1, "9:00 AM", new Guid("606f1107-4340-3d79-81f8-5d8b09c12c47") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("581a8ff7-0f97-9678-3822-8c51e74509eb"), "Confirmed", new Guid("9d403be7-1591-a47f-eda5-1411ff876f4f"), new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), new DateTimeOffset(new DateTime(2020, 11, 3, 6, 58, 6, 227, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 7, 0, 0, 0)), new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"), new DateTimeOffset(new DateTime(2020, 10, 20, 9, 51, 34, 696, DateTimeKind.Unspecified).AddTicks(1255), new TimeSpan(0, 7, 0, 0, 0)), 4, "12:00 PM", new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("66bd048d-0f76-2191-b162-c9f902e508cf"), "Confirmed", new Guid("8c512572-c2c5-6018-11b0-65448b8b5bf0"), new Guid("0bab7af2-5fac-9b1e-3f2b-cd52f09e51d4"), new DateTimeOffset(new DateTime(2020, 8, 22, 16, 58, 54, 890, DateTimeKind.Unspecified).AddTicks(6384), new TimeSpan(0, 7, 0, 0, 0)), new Guid("15c913df-778a-5837-5d13-48652553d7ec"), true, new DateTimeOffset(new DateTime(2020, 10, 27, 1, 43, 56, 227, DateTimeKind.Unspecified).AddTicks(1308), new TimeSpan(0, 7, 0, 0, 0)), 4, "9:00 AM", new Guid("3b18d343-2ea5-4803-3f37-73c3e7b57871") },
                    { new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0"), "Completed", new Guid("1d5d7434-674a-4126-1a7a-5ad14ba33acd"), new Guid("31c95f5a-4a44-610a-56fa-39ba2e69221b"), new DateTimeOffset(new DateTime(2020, 9, 4, 9, 6, 41, 467, DateTimeKind.Unspecified).AddTicks(4414), new TimeSpan(0, 7, 0, 0, 0)), new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"), true, new DateTimeOffset(new DateTime(2020, 5, 10, 22, 58, 46, 851, DateTimeKind.Unspecified).AddTicks(5853), new TimeSpan(0, 7, 0, 0, 0)), 3, "6:00 PM", new Guid("9de1b233-b753-b150-4906-4d445720e8f1") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("7cfe35f6-378d-a440-6990-103e95537207"), "Completed", new Guid("f0bc8bcb-9c50-1a09-e65f-56c571a1badf"), new Guid("0c037a58-9f75-ab3f-38a4-aa4eb47f5542"), new DateTimeOffset(new DateTime(2020, 12, 7, 5, 18, 40, 226, DateTimeKind.Unspecified).AddTicks(926), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), new DateTimeOffset(new DateTime(2020, 1, 2, 21, 45, 48, 245, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, 7, 0, 0, 0)), 2, "5:00 PM", new Guid("f2fa31c8-ab7a-ac0b-5f1e-9b3f2bcd52f0") },
                    { new Guid("81ed8046-bd68-e210-e3d1-cca53c8bb036"), "Cancelled", new Guid("ff8d9313-3631-7d5e-8223-78fc98684039"), new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"), new DateTimeOffset(new DateTime(2020, 12, 14, 3, 59, 0, 258, DateTimeKind.Unspecified).AddTicks(119), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), new DateTimeOffset(new DateTime(2020, 9, 6, 0, 52, 18, 542, DateTimeKind.Unspecified).AddTicks(1812), new TimeSpan(0, 7, 0, 0, 0)), 2, "9:00 AM", new Guid("f880aa64-7561-7503-de83-7f97fc4ce8a5") },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), "Confirmed", new Guid("7d5ba0c4-a164-7231-7cf6-1d1e6efaf5d8"), new Guid("0c037a58-9f75-ab3f-38a4-aa4eb47f5542"), new DateTimeOffset(new DateTime(2020, 4, 8, 8, 6, 42, 657, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), new DateTimeOffset(new DateTime(2020, 2, 8, 1, 56, 42, 864, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 7, 0, 0, 0)), 1, "12:00 PM", new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("9dd66981-6e49-6357-a37c-45fb1f8ba41e"), "Confirmed", new Guid("f0bc8bcb-9c50-1a09-e65f-56c571a1badf"), new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new DateTimeOffset(new DateTime(2020, 5, 12, 9, 39, 6, 104, DateTimeKind.Unspecified).AddTicks(8526), new TimeSpan(0, 7, 0, 0, 0)), new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), true, new DateTimeOffset(new DateTime(2020, 6, 16, 3, 28, 7, 196, DateTimeKind.Unspecified).AddTicks(445), new TimeSpan(0, 7, 0, 0, 0)), 3, "11:00 PM", new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d") },
                    { new Guid("9e3042aa-dfdd-c913-158a-7737585d1348"), "Completed", new Guid("9b0258ef-d34c-bfca-2865-b935f45efc20"), new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"), new DateTimeOffset(new DateTime(2020, 9, 27, 12, 32, 36, 206, DateTimeKind.Unspecified).AddTicks(5096), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), true, new DateTimeOffset(new DateTime(2020, 9, 13, 7, 27, 36, 662, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 7, 0, 0, 0)), 4, "7:00 PM", new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592") },
                    { new Guid("a4d60023-2f40-602b-ee79-b453e39036df"), "Pending", new Guid("9b0258ef-d34c-bfca-2865-b935f45efc20"), new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"), new DateTimeOffset(new DateTime(2020, 5, 7, 3, 56, 42, 922, DateTimeKind.Unspecified).AddTicks(5669), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), true, new DateTimeOffset(new DateTime(2020, 6, 26, 11, 55, 44, 937, DateTimeKind.Unspecified).AddTicks(301), new TimeSpan(0, 7, 0, 0, 0)), 2, "1:00 PM", new Guid("779c3b8b-7dec-380d-7eeb-ec94e998eb0c") },
                    { new Guid("a7b0d962-3624-666a-0cbf-75043eb4b476"), "Confirmed", new Guid("da46d4f4-4577-fb00-969b-e0dfb77ed0ff"), new Guid("8bc880c5-bc39-a62d-528d-a9d070fe5e75"), new DateTimeOffset(new DateTime(2020, 10, 12, 10, 47, 18, 159, DateTimeKind.Unspecified).AddTicks(3036), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"), true, new DateTimeOffset(new DateTime(2020, 5, 13, 0, 24, 7, 623, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 7, 0, 0, 0)), 1, "3:00 PM", new Guid("837c4af8-1b95-302e-d982-d3e35c19fca2") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("ab3f9f75-a438-4eaa-b47f-55421996b8a3"), "Pending", new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"), new Guid("8bc880c5-bc39-a62d-528d-a9d070fe5e75"), new DateTimeOffset(new DateTime(2020, 8, 16, 5, 52, 35, 375, DateTimeKind.Unspecified).AddTicks(4249), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), new DateTimeOffset(new DateTime(2020, 1, 15, 5, 52, 33, 474, DateTimeKind.Unspecified).AddTicks(5702), new TimeSpan(0, 7, 0, 0, 0)), 3, "5:00 PM", new Guid("f12096d7-2697-2757-cded-e8d3504da036") },
                    { new Guid("ab85d464-89d5-8ee1-c580-c88b39bc2da6"), "Pending", new Guid("c888dbdb-1c04-f09f-f960-26ada1097c5d"), new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new DateTimeOffset(new DateTime(2020, 5, 14, 1, 46, 1, 514, DateTimeKind.Unspecified).AddTicks(7233), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), new DateTimeOffset(new DateTime(2020, 9, 13, 23, 8, 15, 823, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 7, 0, 0, 0)), 4, "10:00 AM", new Guid("606f1107-4340-3d79-81f8-5d8b09c12c47") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("ae048d35-c736-60ca-1a03-998417fd2e0d"), "Cancelled", new Guid("fa994fb6-2e25-c984-c137-9a968f6f9cb1"), new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), new DateTimeOffset(new DateTime(2020, 5, 3, 1, 56, 51, 685, DateTimeKind.Unspecified).AddTicks(6891), new TimeSpan(0, 7, 0, 0, 0)), new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), true, new DateTimeOffset(new DateTime(2020, 7, 10, 1, 29, 6, 445, DateTimeKind.Unspecified).AddTicks(8774), new TimeSpan(0, 7, 0, 0, 0)), 4, "11:00 AM", new Guid("6100e542-8ed9-94dd-02eb-d05d806edcfa") },
                    { new Guid("b1b68e27-3e7d-0ff2-18e4-30ad7b7f4460"), "Pending", new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("28490d2e-ad32-cf01-c79e-2cd4a1fd8116"), new DateTimeOffset(new DateTime(2020, 5, 17, 15, 26, 23, 234, DateTimeKind.Unspecified).AddTicks(1259), new TimeSpan(0, 7, 0, 0, 0)), new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), true, new DateTimeOffset(new DateTime(2020, 1, 31, 22, 37, 24, 37, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 7, 0, 0, 0)), 3, "7:00 AM", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("b4b81d50-7f7d-7aa3-d24f-0319ce64c757"), "Pending", new Guid("042638ff-08ab-3154-8231-2f09aa954c72"), new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), new DateTimeOffset(new DateTime(2020, 3, 10, 3, 55, 22, 952, DateTimeKind.Unspecified).AddTicks(1296), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), new DateTimeOffset(new DateTime(2020, 12, 4, 9, 2, 9, 344, DateTimeKind.Unspecified).AddTicks(5560), new TimeSpan(0, 7, 0, 0, 0)), 3, "5:00 PM", new Guid("f2fa31c8-ab7a-ac0b-5f1e-9b3f2bcd52f0") },
                    { new Guid("b5a1a1a4-6239-ea54-94f6-27f5d5eee010"), "Completed", new Guid("a00e7adf-e39c-17c1-6ce4-8e824e0221be"), new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59"), new DateTimeOffset(new DateTime(2020, 8, 26, 22, 43, 21, 790, DateTimeKind.Unspecified).AddTicks(967), new TimeSpan(0, 7, 0, 0, 0)), new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), new DateTimeOffset(new DateTime(2020, 5, 5, 18, 2, 15, 671, DateTimeKind.Unspecified).AddTicks(304), new TimeSpan(0, 7, 0, 0, 0)), 1, "10:00 PM", new Guid("99b466ff-4c41-07d6-7020-a9f28b403607") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("b6de451c-9052-53a9-a9fb-007f94ad4550"), "Pending", new Guid("c34ae2e6-68cc-6e9c-d22e-1db28b88829e"), new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"), new DateTimeOffset(new DateTime(2020, 12, 19, 7, 37, 48, 118, DateTimeKind.Unspecified).AddTicks(7773), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), true, new DateTimeOffset(new DateTime(2020, 9, 10, 2, 9, 48, 349, DateTimeKind.Unspecified).AddTicks(5114), new TimeSpan(0, 7, 0, 0, 0)), 4, "9:00 AM", new Guid("8026a67e-3b61-fd8d-5241-408b6939c3a4") },
                    { new Guid("ccc57fd8-e27d-6983-aaa4-108d4d026f58"), "Cancelled", new Guid("1de7f0c5-af98-25d1-a33a-f246ec74b73f"), new Guid("8364bab3-3549-2209-c2f8-b1659599800f"), new DateTimeOffset(new DateTime(2020, 10, 10, 8, 37, 12, 680, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 7, 0, 0, 0)), new Guid("0b40e562-d9b5-504a-8985-07682b0d588f"), true, new DateTimeOffset(new DateTime(2020, 3, 31, 14, 40, 15, 887, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, 7, 0, 0, 0)), 2, "9:00 PM", new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("d718edc2-e562-0b40-b5d9-4a5089850768"), "Cancelled", new Guid("1de7f0c5-af98-25d1-a33a-f246ec74b73f"), new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), new DateTimeOffset(new DateTime(2020, 12, 16, 11, 32, 50, 387, DateTimeKind.Unspecified).AddTicks(8566), new TimeSpan(0, 7, 0, 0, 0)), new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"), new DateTimeOffset(new DateTime(2020, 12, 4, 10, 23, 21, 13, DateTimeKind.Unspecified).AddTicks(43), new TimeSpan(0, 7, 0, 0, 0)), 4, "3:00 PM", new Guid("a2f3dcda-df43-530a-0c96-53f4b2c78dd4") },
                    { new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), "Cancelled", new Guid("c34ae2e6-68cc-6e9c-d22e-1db28b88829e"), new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"), new DateTimeOffset(new DateTime(2020, 1, 24, 21, 13, 11, 271, DateTimeKind.Unspecified).AddTicks(4226), new TimeSpan(0, 7, 0, 0, 0)), new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"), new DateTimeOffset(new DateTime(2020, 5, 23, 12, 40, 19, 76, DateTimeKind.Unspecified).AddTicks(9423), new TimeSpan(0, 7, 0, 0, 0)), 1, "9:00 PM", new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("e64313d8-a4a2-a0e8-bd6c-2ba7d672050a"), "Cancelled", new Guid("9b0258ef-d34c-bfca-2865-b935f45efc20"), new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"), new DateTimeOffset(new DateTime(2020, 5, 14, 3, 12, 33, 783, DateTimeKind.Unspecified).AddTicks(19), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), true, new DateTimeOffset(new DateTime(2020, 5, 25, 23, 20, 49, 11, DateTimeKind.Unspecified).AddTicks(1012), new TimeSpan(0, 7, 0, 0, 0)), 3, "6:00 PM", new Guid("8bdb736b-89b7-be24-1c15-31f7e7421644") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("f0a70070-54b1-e1fd-fc18-10a5ccb2341f"), "Cancelled", new Guid("85f9d68b-8075-4ce4-4687-d3b0fee00f06"), new Guid("e6a9f246-6c93-6962-33ef-855ab90a53b0"), new DateTimeOffset(new DateTime(2020, 11, 28, 4, 38, 11, 532, DateTimeKind.Unspecified).AddTicks(5660), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), new DateTimeOffset(new DateTime(2020, 8, 23, 4, 35, 47, 929, DateTimeKind.Unspecified).AddTicks(2813), new TimeSpan(0, 7, 0, 0, 0)), 4, "8:00 PM", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") },
                    { new Guid("f8036575-7c4a-9583-1b2e-30d982d3e35c"), "Pending", new Guid("894bbc95-6ce2-cb29-8f17-449c7ebe9a77"), new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"), new DateTimeOffset(new DateTime(2020, 4, 22, 1, 45, 6, 301, DateTimeKind.Unspecified).AddTicks(9067), new TimeSpan(0, 7, 0, 0, 0)), new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"), new DateTimeOffset(new DateTime(2020, 6, 15, 13, 56, 51, 241, DateTimeKind.Unspecified).AddTicks(8170), new TimeSpan(0, 7, 0, 0, 0)), 3, "9:00 PM", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") },
                    { new Guid("fad5cead-8b14-7bef-2fa2-d996de815383"), "Confirmed", new Guid("cf7d3633-3eee-94eb-b598-83a5ac711802"), new Guid("ecc698c4-a3bd-d5e5-df91-ad2a6e8169d6"), new DateTimeOffset(new DateTime(2020, 8, 14, 2, 17, 17, 512, DateTimeKind.Unspecified).AddTicks(9172), new TimeSpan(0, 7, 0, 0, 0)), new Guid("41cd8dba-2c1f-9307-b7df-385c9a4619ab"), new DateTimeOffset(new DateTime(2020, 10, 5, 16, 46, 8, 349, DateTimeKind.Unspecified).AddTicks(3925), new TimeSpan(0, 7, 0, 0, 0)), 1, "10:00 PM", new Guid("360f39a0-9ef3-42c7-47d5-608af0d59ff4") }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("072c1f41-b793-38df-5c9a-4619abd61d8b"), 41.497987933223120m, new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"), "Outdoor", new DateTimeOffset(new DateTime(2020, 12, 10, 22, 17, 30, 126, DateTimeKind.Unspecified).AddTicks(4141), new TimeSpan(0, 7, 0, 0, 0)), 45.221606639782720m, new DateTimeOffset(new DateTime(2020, 11, 20, 2, 4, 19, 389, DateTimeKind.Unspecified).AddTicks(3563), new TimeSpan(0, 7, 0, 0, 0)), 22.389592515486120m },
                    { new Guid("09354983-c222-b1f8-6595-99800ff98b29"), 34.969137117717960m, new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"), "Indoor", new DateTimeOffset(new DateTime(2020, 10, 22, 15, 57, 42, 951, DateTimeKind.Unspecified).AddTicks(685), new TimeSpan(0, 7, 0, 0, 0)), 21.810305086807480m, new DateTimeOffset(new DateTime(2020, 8, 30, 12, 15, 24, 70, DateTimeKind.Unspecified).AddTicks(5666), new TimeSpan(0, 7, 0, 0, 0)), 20.569869191651160m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("0d197acc-619b-6d82-f271-9fea1b00a6c9"), 29.337506824795840m, new Guid("0c037a58-9f75-ab3f-38a4-aa4eb47f5542"), "Outdoor", new DateTimeOffset(new DateTime(2020, 9, 20, 1, 59, 57, 796, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 7, 0, 0, 0)), 48.588216322748080m, true, new DateTimeOffset(new DateTime(2020, 7, 27, 11, 15, 33, 143, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 7, 0, 0, 0)), 46.102314608219240m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9"), 45.934353394403280m, new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), "Indoor", new DateTimeOffset(new DateTime(2020, 1, 27, 16, 55, 50, 381, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 7, 0, 0, 0)), 29.193475273993560m, new DateTimeOffset(new DateTime(2020, 6, 22, 7, 33, 11, 275, DateTimeKind.Unspecified).AddTicks(6197), new TimeSpan(0, 7, 0, 0, 0)), 26.848064482606960m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("273ee7fa-1096-0806-6580-6035ad238abb"), 12.9623712985601160m, new Guid("0945e751-80eb-8bf6-2014-2b1237d52d64"), "Indoor", new DateTimeOffset(new DateTime(2020, 4, 15, 19, 39, 29, 892, DateTimeKind.Unspecified).AddTicks(4558), new TimeSpan(0, 7, 0, 0, 0)), 39.023068225487640m, true, new DateTimeOffset(new DateTime(2020, 10, 22, 7, 44, 14, 293, DateTimeKind.Unspecified).AddTicks(3072), new TimeSpan(0, 7, 0, 0, 0)), 31.353848884512600m },
                    { new Guid("2d49430d-4e90-f11b-51a9-34225bb3f424"), 17.565856579489000m, new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"), "Indoor", new DateTimeOffset(new DateTime(2020, 4, 25, 0, 41, 21, 899, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, 7, 0, 0, 0)), 17.676361448912120m, true, new DateTimeOffset(new DateTime(2020, 9, 10, 22, 55, 52, 695, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 7, 0, 0, 0)), 32.24751153134160m },
                    { new Guid("34660c4f-2bac-b697-715e-720dd466c34f"), 24.995305638292480m, new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"), "Indoor", new DateTimeOffset(new DateTime(2020, 1, 9, 23, 46, 18, 401, DateTimeKind.Unspecified).AddTicks(4385), new TimeSpan(0, 7, 0, 0, 0)), 43.996224475091440m, true, new DateTimeOffset(new DateTime(2020, 8, 19, 7, 8, 25, 325, DateTimeKind.Unspecified).AddTicks(2802), new TimeSpan(0, 7, 0, 0, 0)), 25.027168008977160m },
                    { new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), 47.389709482616600m, new Guid("edc2475d-d718-e562-400b-b5d94a508985"), "Outdoor", new DateTimeOffset(new DateTime(2020, 3, 7, 23, 54, 36, 924, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 7, 0, 0, 0)), 34.313879937079680m, true, new DateTimeOffset(new DateTime(2020, 11, 15, 11, 56, 16, 868, DateTimeKind.Unspecified).AddTicks(8626), new TimeSpan(0, 7, 0, 0, 0)), 38.207231586895520m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), 31.343363570674960m, new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), "Outdoor", new DateTimeOffset(new DateTime(2020, 7, 27, 0, 47, 48, 494, DateTimeKind.Unspecified).AddTicks(3600), new TimeSpan(0, 7, 0, 0, 0)), 25.554371408910680m, new DateTimeOffset(new DateTime(2020, 6, 8, 19, 14, 36, 736, DateTimeKind.Unspecified).AddTicks(399), new TimeSpan(0, 7, 0, 0, 0)), 48.443187772502760m },
                    { new Guid("4431c95f-0a4a-5661-fa39-ba2e69221baa"), 29.020952311819880m, new Guid("69bdeded-13d8-e643-a2a4-e8a0bd6c2ba7"), "Indoor", new DateTimeOffset(new DateTime(2020, 7, 9, 13, 54, 39, 511, DateTimeKind.Unspecified).AddTicks(9340), new TimeSpan(0, 7, 0, 0, 0)), 42.589324318146960m, new DateTimeOffset(new DateTime(2020, 5, 4, 1, 0, 43, 596, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 7, 0, 0, 0)), 32.97624585357320m },
                    { new Guid("44ac7e55-012d-2bfb-510c-8e86863eeded"), 16.728670171801320m, new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), "Indoor", new DateTimeOffset(new DateTime(2020, 11, 10, 23, 15, 48, 6, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 7, 0, 0, 0)), 30.902437428432720m, new DateTimeOffset(new DateTime(2020, 1, 23, 21, 48, 16, 487, DateTimeKind.Unspecified).AddTicks(5646), new TimeSpan(0, 7, 0, 0, 0)), 14.250296300393680m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("470f6997-03fb-cee9-3b65-7708add2e94e"), 40.453835292930640m, new Guid("19469a5c-d6ab-8b1d-dfd6-47876ffa5d3f"), "Indoor", new DateTimeOffset(new DateTime(2020, 2, 3, 23, 27, 2, 441, DateTimeKind.Unspecified).AddTicks(7051), new TimeSpan(0, 7, 0, 0, 0)), 13.4147814863430240m, true, new DateTimeOffset(new DateTime(2020, 8, 5, 12, 25, 58, 989, DateTimeKind.Unspecified).AddTicks(3117), new TimeSpan(0, 7, 0, 0, 0)), 45.387891789613240m },
                    { new Guid("519ef052-9ed4-05a8-15b4-13c4587a030c"), 28.513815989025800m, new Guid("0bab7af2-5fac-9b1e-3f2b-cd52f09e51d4"), "Indoor", new DateTimeOffset(new DateTime(2020, 5, 26, 16, 51, 16, 961, DateTimeKind.Unspecified).AddTicks(5992), new TimeSpan(0, 7, 0, 0, 0)), 34.217506639760680m, true, new DateTimeOffset(new DateTime(2020, 7, 24, 22, 18, 14, 516, DateTimeKind.Unspecified).AddTicks(3162), new TimeSpan(0, 7, 0, 0, 0)), 23.181302348701880m },
                    { new Guid("6bbc76b4-a7f7-4c1f-4773-aee30c100642"), 24.638009990862560m, new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), "Indoor", new DateTimeOffset(new DateTime(2020, 9, 8, 9, 39, 18, 144, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 7, 0, 0, 0)), 28.121369973812880m, true, new DateTimeOffset(new DateTime(2020, 10, 22, 4, 52, 8, 231, DateTimeKind.Unspecified).AddTicks(255), new TimeSpan(0, 7, 0, 0, 0)), 45.475480833777920m },
                    { new Guid("6d1eab15-d275-d365-3d5c-153a9787de8d"), 30.560953216888440m, new Guid("2f40a4d6-602b-79ee-b453-e39036dfc79c"), "Outdoor", new DateTimeOffset(new DateTime(2020, 9, 14, 23, 41, 43, 347, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 7, 0, 0, 0)), 48.779541160343000m, true, new DateTimeOffset(new DateTime(2020, 1, 19, 16, 20, 22, 899, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 7, 0, 0, 0)), 18.801006921008680m },
                    { new Guid("6e499dd6-6357-7ca3-45fb-1f8ba41e25e0"), 42.703130819230880m, new Guid("edc2475d-d718-e562-400b-b5d94a508985"), "Outdoor", new DateTimeOffset(new DateTime(2020, 5, 12, 9, 39, 6, 104, DateTimeKind.Unspecified).AddTicks(8526), new TimeSpan(0, 7, 0, 0, 0)), 30.121875545066720m, true, new DateTimeOffset(new DateTime(2020, 6, 16, 3, 28, 7, 196, DateTimeKind.Unspecified).AddTicks(445), new TimeSpan(0, 7, 0, 0, 0)), 45.454992668449400m },
                    { new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436"), 15.911027903627160m, new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), "Outdoor", new DateTimeOffset(new DateTime(2020, 5, 1, 15, 32, 44, 760, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 7, 0, 0, 0)), 29.254346126343280m, true, new DateTimeOffset(new DateTime(2020, 1, 10, 3, 56, 23, 465, DateTimeKind.Unspecified).AddTicks(9836), new TimeSpan(0, 7, 0, 0, 0)), 18.972684931462960m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("76db74dc-6488-fd6f-2dc4-98c6ecbda3e5"), 19.144105300840040m, new Guid("8b1ffb45-1ea4-e025-e09e-2784cd25923f"), "Indoor", new DateTimeOffset(new DateTime(2020, 8, 20, 20, 16, 23, 203, DateTimeKind.Unspecified).AddTicks(428), new TimeSpan(0, 7, 0, 0, 0)), 25.417034949835880m, new DateTimeOffset(new DateTime(2020, 2, 20, 19, 7, 51, 344, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, 7, 0, 0, 0)), 22.615303198162160m },
                    { new Guid("8752ae2b-1d50-b4b8-7d7f-a37ad24f0319"), 41.409060448132960m, new Guid("0f7666bd-2191-62b1-c9f9-02e508cf1189"), "Outdoor", new DateTimeOffset(new DateTime(2020, 6, 20, 2, 54, 43, 526, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 7, 0, 0, 0)), 47.092951683836480m, new DateTimeOffset(new DateTime(2020, 5, 29, 5, 5, 50, 377, DateTimeKind.Unspecified).AddTicks(5220), new TimeSpan(0, 7, 0, 0, 0)), 13.4290638209455960m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("8d52a62d-d0a9-fe70-5e75-1ab3d87fc5cc"), 46.40075152572280m, new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), "Outdoor", new DateTimeOffset(new DateTime(2020, 12, 27, 18, 49, 42, 41, DateTimeKind.Unspecified).AddTicks(5112), new TimeSpan(0, 7, 0, 0, 0)), 19.470145762651280m, true, new DateTimeOffset(new DateTime(2020, 3, 3, 22, 30, 55, 391, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), 25.166728447734720m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("8de07c9f-8317-bde3-52b5-9b65adced5fa"), 14.628293721297880m, new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"), "Indoor", new DateTimeOffset(new DateTime(2020, 1, 1, 19, 23, 54, 762, DateTimeKind.Unspecified).AddTicks(5849), new TimeSpan(0, 7, 0, 0, 0)), 40.83392113020360m, new DateTimeOffset(new DateTime(2020, 6, 20, 11, 8, 12, 390, DateTimeKind.Unspecified).AddTicks(389), new TimeSpan(0, 7, 0, 0, 0)), 24.827266118874440m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), 45.699026005202440m, new Guid("28490d2e-ad32-cf01-c79e-2cd4a1fd8116"), "Indoor", new DateTimeOffset(new DateTime(2020, 11, 6, 12, 35, 15, 882, DateTimeKind.Unspecified).AddTicks(9721), new TimeSpan(0, 7, 0, 0, 0)), 35.146202549872080m, true, new DateTimeOffset(new DateTime(2020, 4, 7, 14, 17, 44, 211, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 7, 0, 0, 0)), 29.681340539679560m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), 19.413829412969680m, new Guid("582236b0-6743-9b61-aa64-9fd9f78f1a58"), "Indoor", new DateTimeOffset(new DateTime(2020, 8, 30, 0, 38, 16, 925, DateTimeKind.Unspecified).AddTicks(600), new TimeSpan(0, 7, 0, 0, 0)), 39.252876876505520m, new DateTimeOffset(new DateTime(2020, 9, 2, 6, 3, 4, 571, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 7, 0, 0, 0)), 38.123531764430720m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("9ec7cf01-d42c-fda1-8116-fa3d097e66c5"), 37.960000069793320m, new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"), "Indoor", new DateTimeOffset(new DateTime(2020, 12, 30, 16, 6, 44, 836, DateTimeKind.Unspecified).AddTicks(7234), new TimeSpan(0, 7, 0, 0, 0)), 21.978269448493720m, true, new DateTimeOffset(new DateTime(2020, 10, 29, 23, 2, 1, 119, DateTimeKind.Unspecified).AddTicks(491), new TimeSpan(0, 7, 0, 0, 0)), 27.921385717541640m },
                    { new Guid("a886f76d-e63c-8046-ed81-68bd10e2e3d1"), 46.347439995197320m, new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), "Indoor", new DateTimeOffset(new DateTime(2020, 8, 11, 12, 27, 58, 191, DateTimeKind.Unspecified).AddTicks(5620), new TimeSpan(0, 7, 0, 0, 0)), 41.015568911570840m, true, new DateTimeOffset(new DateTime(2020, 7, 23, 23, 39, 33, 336, DateTimeKind.Unspecified).AddTicks(2445), new TimeSpan(0, 7, 0, 0, 0)), 27.732490532906960m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("c61e5943-0572-475d-c2ed-18d762e5400b"), 18.138722650771360m, new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"), "Outdoor", new DateTimeOffset(new DateTime(2020, 1, 20, 17, 43, 34, 304, DateTimeKind.Unspecified).AddTicks(9135), new TimeSpan(0, 7, 0, 0, 0)), 19.235869836637680m, new DateTimeOffset(new DateTime(2020, 10, 25, 4, 35, 8, 60, DateTimeKind.Unspecified).AddTicks(6984), new TimeSpan(0, 7, 0, 0, 0)), 22.203386822810120m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"), 42.70146971228600m, new Guid("31c95f5a-4a44-610a-56fa-39ba2e69221b"), "Indoor", new DateTimeOffset(new DateTime(2020, 1, 20, 7, 42, 9, 565, DateTimeKind.Unspecified).AddTicks(9209), new TimeSpan(0, 7, 0, 0, 0)), 13.7907609361180840m, true, new DateTimeOffset(new DateTime(2020, 4, 2, 15, 14, 46, 882, DateTimeKind.Unspecified).AddTicks(6824), new TimeSpan(0, 7, 0, 0, 0)), 48.106788004798240m },
                    { new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"), 37.407649395711560m, new Guid("aa6983e2-10a4-4d8d-026f-58808923f5bd"), "Outdoor", new DateTimeOffset(new DateTime(2020, 3, 4, 6, 35, 3, 882, DateTimeKind.Unspecified).AddTicks(6650), new TimeSpan(0, 7, 0, 0, 0)), 48.703171610228320m, true, new DateTimeOffset(new DateTime(2020, 11, 19, 3, 21, 24, 374, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 7, 0, 0, 0)), 16.042471139711560m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("e9a957cd-768d-372e-54d3-4cf08bd2e2e7"), 36.08567719631160m, new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), "Indoor", new DateTimeOffset(new DateTime(2020, 12, 8, 10, 58, 47, 193, DateTimeKind.Unspecified).AddTicks(7078), new TimeSpan(0, 7, 0, 0, 0)), 44.337673519895280m, new DateTimeOffset(new DateTime(2020, 3, 28, 19, 1, 11, 310, DateTimeKind.Unspecified).AddTicks(8367), new TimeSpan(0, 7, 0, 0, 0)), 34.618906166692680m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), 34.951667424734520m, new Guid("a9ff8f43-1b36-7c81-ae63-cbef0d43492d"), "Outdoor", new DateTimeOffset(new DateTime(2020, 4, 10, 18, 50, 49, 172, DateTimeKind.Unspecified).AddTicks(2274), new TimeSpan(0, 7, 0, 0, 0)), 49.536474402778080m, true, new DateTimeOffset(new DateTime(2020, 6, 11, 16, 32, 45, 765, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 7, 0, 0, 0)), 14.814202359325360m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("f955bbef-50f7-6de5-ce5a-4d978476ab3a"), 45.055789349161000m, new Guid("ae2b65bc-8752-1d50-b8b4-7d7fa37ad24f"), "Outdoor", new DateTimeOffset(new DateTime(2020, 11, 7, 22, 3, 20, 43, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 7, 0, 0, 0)), 18.614604626137120m, new DateTimeOffset(new DateTime(2020, 3, 16, 3, 1, 38, 621, DateTimeKind.Unspecified).AddTicks(5180), new TimeSpan(0, 7, 0, 0, 0)), 27.884660650922280m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), 32.382522030911640m, new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"), "Outdoor", new DateTimeOffset(new DateTime(2020, 11, 11, 16, 5, 48, 103, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 7, 0, 0, 0)), 10.8878830451927520m, true, new DateTimeOffset(new DateTime(2020, 3, 21, 18, 52, 52, 366, DateTimeKind.Unspecified).AddTicks(8117), new TimeSpan(0, 7, 0, 0, 0)), 32.662562552216720m },
                    { new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"), 47.889399490267680m, new Guid("a9ff8f43-1b36-7c81-ae63-cbef0d43492d"), "Indoor", new DateTimeOffset(new DateTime(2020, 10, 19, 15, 3, 6, 182, DateTimeKind.Unspecified).AddTicks(4795), new TimeSpan(0, 7, 0, 0, 0)), 38.713293945748960m, true, new DateTimeOffset(new DateTime(2020, 7, 5, 3, 46, 2, 269, DateTimeKind.Unspecified).AddTicks(9562), new TimeSpan(0, 7, 0, 0, 0)), 28.486481149907440m }
                });

            migrationBuilder.InsertData(
                table: "CourtGroup",
                columns: new[] { "Id", "ApplicationUserId", "CreatedOnUtc", "MaxSlots", "MinSlots", "ModifiedOnUtc", "Name", "Price", "UserId", "WardId" },
                values: new object[] { new Guid("92e3d544-7624-48a7-8558-e2cf0def022a"), null, new DateTimeOffset(new DateTime(2020, 9, 29, 5, 18, 50, 24, DateTimeKind.Unspecified).AddTicks(8325), new TimeSpan(0, 7, 0, 0, 0)), 9, 1, new DateTimeOffset(new DateTime(2020, 11, 5, 15, 35, 58, 431, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 7, 0, 0, 0)), "Dach Inc", 51.648856588010098m, new Guid("3b18d343-2ea5-4803-3f37-73c3e7b57871"), new Guid("25654813-d753-37ec-74d8-f5f4529d9bde") });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("4d5ace6d-8497-ab76-3a2f-df88956762d3"), new Guid("f774154c-4e4a-4a5f-d769-f094e08d73e6"), "Available", new DateTimeOffset(new DateTime(2023, 8, 29, 6, 26, 14, 944, DateTimeKind.Unspecified).AddTicks(9098), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 18, 8, 14, 4, 267, DateTimeKind.Unspecified).AddTicks(551), new TimeSpan(0, 7, 0, 0, 0)), "fugiat", "impedit" },
                    { new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"), new Guid("8c512572-c2c5-6018-11b0-65448b8b5bf0"), "Available", new DateTimeOffset(new DateTime(2023, 10, 10, 14, 56, 14, 342, DateTimeKind.Unspecified).AddTicks(5442), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 22, 3, 45, 1, 488, DateTimeKind.Unspecified).AddTicks(7087), new TimeSpan(0, 7, 0, 0, 0)), "fugit", "accusantium" },
                    { new Guid("87973a15-8dde-6aed-3a99-5add4e83275c"), new Guid("742e2a57-6231-e100-0c30-a46a4792353a"), "Available", new DateTimeOffset(new DateTime(2023, 10, 17, 7, 36, 7, 889, DateTimeKind.Unspecified).AddTicks(6460), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 17, 17, 12, 25, 611, DateTimeKind.Unspecified).AddTicks(6262), new TimeSpan(0, 7, 0, 0, 0)), "nisi", "reprehenderit" },
                    { new Guid("9f71f26d-1bea-a600-c920-1c80f09d1740"), new Guid("6773f756-d8b1-22de-a543-ceb51d18f920"), "Available", new DateTimeOffset(new DateTime(2023, 6, 27, 11, 18, 31, 340, DateTimeKind.Unspecified).AddTicks(7395), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 15, 12, 1, 8, 183, DateTimeKind.Unspecified).AddTicks(8027), new TimeSpan(0, 7, 0, 0, 0)), "non", "similique" },
                    { new Guid("bde38317-b552-659b-adce-d5fa148bef7b"), new Guid("915bf2ff-2a7a-a582-3585-cbee1ae797a3"), "Available", new DateTimeOffset(new DateTime(2024, 2, 29, 21, 53, 28, 746, DateTimeKind.Unspecified).AddTicks(5832), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 27, 10, 35, 31, 193, DateTimeKind.Unspecified).AddTicks(4741), new TimeSpan(0, 7, 0, 0, 0)), "repellat", "sunt" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"), new Guid("dc2253fb-a284-69ca-546f-0a051ec36e98"), "Available", new DateTimeOffset(new DateTime(2023, 7, 28, 7, 39, 54, 174, DateTimeKind.Unspecified).AddTicks(8843), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 10, 14, 22, 33, 31, 428, DateTimeKind.Unspecified).AddTicks(3235), new TimeSpan(0, 7, 0, 0, 0)), "modi", "voluptas" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("c9945bcd-5515-8954-f74e-1337084c237e"), new Guid("742e2a57-6231-e100-0c30-a46a4792353a"), "Booked", new DateTimeOffset(new DateTime(2024, 3, 5, 22, 20, 19, 781, DateTimeKind.Unspecified).AddTicks(4212), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 16, 1, 48, 48, 424, DateTimeKind.Unspecified).AddTicks(4227), new TimeSpan(0, 7, 0, 0, 0)), "qui", "illo" },
                    { new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"), new Guid("c86c892d-3011-bfe7-3a4b-ce7101f5eece"), "Available", new DateTimeOffset(new DateTime(2023, 9, 9, 12, 35, 15, 487, DateTimeKind.Unspecified).AddTicks(2536), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 6, 14, 12, 21, 600, DateTimeKind.Unspecified).AddTicks(6967), new TimeSpan(0, 7, 0, 0, 0)), "at", "suscipit" }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("f62452d5-8c09-f356-f855-7eac442d01fb"), new Guid("7d5ba0c4-a164-7231-7cf6-1d1e6efaf5d8"), "Available", new DateTimeOffset(new DateTime(2023, 8, 21, 0, 47, 46, 910, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 8, 15, 50, 10, 396, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 7, 0, 0, 0)), "provident", "autem" });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new Guid("742e2a57-6231-e100-0c30-a46a4792353a"), "Booked", new DateTimeOffset(new DateTime(2024, 3, 3, 18, 18, 5, 574, DateTimeKind.Unspecified).AddTicks(8965), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 6, 5, 4, 43, 153, DateTimeKind.Unspecified).AddTicks(8534), new TimeSpan(0, 7, 0, 0, 0)), "natus", "et" });

            migrationBuilder.InsertData(
                table: "DateCourtGroup",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "DateId", "IsClosed", "IsDeleted", "ModifiedOnUtc" },
                values: new object[,]
                {
                    { new Guid("001bea9f-c9a6-1c20-80f0-9d1740b7b9b0"), new Guid("742e2a57-6231-e100-0c30-a46a4792353a"), new DateTimeOffset(new DateTime(2023, 8, 5, 0, 44, 14, 489, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"), false, true, new DateTimeOffset(new DateTime(2024, 4, 11, 22, 3, 9, 722, DateTimeKind.Unspecified).AddTicks(6065), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("031a60ca-8499-fd17-2e0d-492832ad01cf"), new Guid("f774154c-4e4a-4a5f-d769-f094e08d73e6"), new DateTimeOffset(new DateTime(2024, 1, 5, 6, 1, 12, 459, DateTimeKind.Unspecified).AddTicks(5555), new TimeSpan(0, 7, 0, 0, 0)), new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"), true, true, new DateTimeOffset(new DateTime(2024, 5, 1, 16, 22, 57, 264, DateTimeKind.Unspecified).AddTicks(9546), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("3dfa1681-7e09-c566-fd01-2c2fc3339462"), new Guid("6c5f7fae-283c-7ad4-96e0-ad704663df22"), new DateTimeOffset(new DateTime(2023, 9, 2, 4, 41, 27, 866, DateTimeKind.Unspecified).AddTicks(5162), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), true, true, new DateTimeOffset(new DateTime(2023, 12, 13, 5, 6, 31, 761, DateTimeKind.Unspecified).AddTicks(7998), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3"), new Guid("50714b05-b3c5-c1c9-35e3-3c33e18aaa4f"), new DateTimeOffset(new DateTime(2024, 4, 17, 7, 31, 11, 488, DateTimeKind.Unspecified).AddTicks(7462), new TimeSpan(0, 7, 0, 0, 0)), new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), false, true, new DateTimeOffset(new DateTime(2024, 4, 16, 7, 15, 10, 759, DateTimeKind.Unspecified).AddTicks(1752), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("51c657c7-c2b6-f76d-86a8-3ce64680ed81"), new Guid("50714b05-b3c5-c1c9-35e3-3c33e18aaa4f"), new DateTimeOffset(new DateTime(2024, 3, 5, 18, 46, 1, 976, DateTimeKind.Unspecified).AddTicks(7133), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"), true, true, new DateTimeOffset(new DateTime(2023, 7, 29, 15, 41, 25, 406, DateTimeKind.Unspecified).AddTicks(6533), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("580a6fb1-0e35-f5f0-e74a-756503f84a7c"), new Guid("742e2a57-6231-e100-0c30-a46a4792353a"), new DateTimeOffset(new DateTime(2023, 11, 10, 18, 13, 48, 900, DateTimeKind.Unspecified).AddTicks(2821), new TimeSpan(0, 7, 0, 0, 0)), new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"), false, false, new DateTimeOffset(new DateTime(2023, 11, 13, 22, 9, 17, 336, DateTimeKind.Unspecified).AddTicks(9929), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("6239b5a1-ea54-f694-27f5-d5eee0105eca"), new Guid("c86c892d-3011-bfe7-3a4b-ce7101f5eece"), new DateTimeOffset(new DateTime(2023, 8, 5, 12, 47, 36, 272, DateTimeKind.Unspecified).AddTicks(8988), new TimeSpan(0, 7, 0, 0, 0)), new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), true, true, new DateTimeOffset(new DateTime(2023, 8, 29, 1, 43, 25, 18, DateTimeKind.Unspecified).AddTicks(9090), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436"), new Guid("7d5ba0c4-a164-7231-7cf6-1d1e6efaf5d8"), new DateTimeOffset(new DateTime(2023, 7, 6, 15, 53, 14, 492, DateTimeKind.Unspecified).AddTicks(2760), new TimeSpan(0, 7, 0, 0, 0)), new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), true, false, new DateTimeOffset(new DateTime(2023, 12, 11, 2, 13, 41, 380, DateTimeKind.Unspecified).AddTicks(9784), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0"), new Guid("f774154c-4e4a-4a5f-d769-f094e08d73e6"), new DateTimeOffset(new DateTime(2023, 9, 25, 12, 19, 17, 329, DateTimeKind.Unspecified).AddTicks(6365), new TimeSpan(0, 7, 0, 0, 0)), new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"), false, false, new DateTimeOffset(new DateTime(2023, 11, 13, 6, 40, 12, 607, DateTimeKind.Unspecified).AddTicks(1074), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a9f24616-93e6-626c-6933-ef855ab90a53"), new Guid("dc2253fb-a284-69ca-546f-0a051ec36e98"), new DateTimeOffset(new DateTime(2024, 3, 18, 3, 4, 12, 846, DateTimeKind.Unspecified).AddTicks(8202), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), true, true, new DateTimeOffset(new DateTime(2024, 3, 21, 4, 35, 2, 646, DateTimeKind.Unspecified).AddTicks(7145), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("af938ef6-c065-3ea8-cc42-4091fadad7ff"), new Guid("dc2253fb-a284-69ca-546f-0a051ec36e98"), new DateTimeOffset(new DateTime(2023, 9, 20, 11, 48, 55, 413, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 7, 0, 0, 0)), new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), false, true, new DateTimeOffset(new DateTime(2023, 12, 17, 14, 3, 27, 809, DateTimeKind.Unspecified).AddTicks(2396), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5"), new Guid("50714b05-b3c5-c1c9-35e3-3c33e18aaa4f"), new DateTimeOffset(new DateTime(2023, 9, 17, 15, 1, 27, 697, DateTimeKind.Unspecified).AddTicks(4975), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), false, true, new DateTimeOffset(new DateTime(2023, 10, 28, 13, 44, 35, 209, DateTimeKind.Unspecified).AddTicks(5789), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("b6de451c-9052-53a9-a9fb-007f94ad4550"), new Guid("e37263c1-54e5-503c-642e-44045c366f77"), new DateTimeOffset(new DateTime(2024, 2, 8, 5, 18, 9, 601, DateTimeKind.Unspecified).AddTicks(9578), new TimeSpan(0, 7, 0, 0, 0)), new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"), false, true, new DateTimeOffset(new DateTime(2023, 9, 18, 5, 20, 43, 101, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("c5958911-a740-1861-7ed5-5224f6098c56"), new Guid("e37263c1-54e5-503c-642e-44045c366f77"), new DateTimeOffset(new DateTime(2023, 6, 29, 2, 49, 1, 719, DateTimeKind.Unspecified).AddTicks(8088), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"), false, true, new DateTimeOffset(new DateTime(2023, 7, 12, 0, 41, 47, 350, DateTimeKind.Unspecified).AddTicks(7941), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("d6df8b1d-8747-fa6f-5d3f-efbb55f9f750"), new Guid("8c512572-c2c5-6018-11b0-65448b8b5bf0"), new DateTimeOffset(new DateTime(2023, 12, 1, 17, 39, 5, 224, DateTimeKind.Unspecified).AddTicks(7894), new TimeSpan(0, 7, 0, 0, 0)), new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), false, true, new DateTimeOffset(new DateTime(2024, 5, 14, 12, 11, 43, 454, DateTimeKind.Unspecified).AddTicks(3118), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("dca20a0a-9549-e4e1-78b1-99327e3ac5e0"), new Guid("9a0a219e-f958-f1a7-0605-94327786d627"), new DateTimeOffset(new DateTime(2023, 8, 2, 15, 58, 58, 744, DateTimeKind.Unspecified).AddTicks(2363), new TimeSpan(0, 7, 0, 0, 0)), new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), true, false, new DateTimeOffset(new DateTime(2023, 10, 23, 0, 36, 21, 467, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("dd5a993a-834e-5c27-278e-b6b17d3ef20f"), new Guid("7d5ba0c4-a164-7231-7cf6-1d1e6efaf5d8"), new DateTimeOffset(new DateTime(2024, 1, 24, 11, 33, 22, 652, DateTimeKind.Unspecified).AddTicks(6659), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"), true, true, new DateTimeOffset(new DateTime(2024, 2, 28, 0, 11, 37, 459, DateTimeKind.Unspecified).AddTicks(2302), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"), new Guid("6773f756-d8b1-22de-a543-ceb51d18f920"), new DateTimeOffset(new DateTime(2023, 8, 15, 22, 36, 16, 523, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, 7, 0, 0, 0)), new Guid("33c32f2c-6294-2427-27ce-133348d2a829"), false, false, new DateTimeOffset(new DateTime(2024, 4, 30, 9, 21, 40, 469, DateTimeKind.Unspecified).AddTicks(5628), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), new Guid("6773f756-d8b1-22de-a543-ceb51d18f920"), new DateTimeOffset(new DateTime(2023, 7, 6, 16, 34, 47, 460, DateTimeKind.Unspecified).AddTicks(7634), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), false, false, new DateTimeOffset(new DateTime(2024, 2, 11, 21, 48, 36, 297, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("fee56044-ba9d-cd8d-411f-2c0793b7df38"), new Guid("dc2253fb-a284-69ca-546f-0a051ec36e98"), new DateTimeOffset(new DateTime(2024, 4, 22, 2, 8, 17, 415, DateTimeKind.Unspecified).AddTicks(2313), new TimeSpan(0, 7, 0, 0, 0)), new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"), true, false, new DateTimeOffset(new DateTime(2024, 3, 6, 0, 33, 2, 750, DateTimeKind.Unspecified).AddTicks(4701), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("36b08b3c-5822-6743-619b-aa649fd9f78f"), 847.09m, new DateTimeOffset(new DateTime(2020, 9, 16, 14, 39, 44, 445, DateTimeKind.Unspecified).AddTicks(1211), new TimeSpan(0, 7, 0, 0, 0)), "Et nam placeat et corrupti.", true, new DateTimeOffset(new DateTime(2020, 4, 7, 19, 48, 40, 196, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 7, 0, 0, 0)), "repellendus", new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d"), new Guid("14fad5ce-ef8b-2f7b-a2d9-96de815383b1") },
                    { new Guid("49d8d35e-7c9f-8de0-1783-e3bd52b59b65"), 330.13m, new DateTimeOffset(new DateTime(2020, 6, 20, 11, 8, 12, 390, DateTimeKind.Unspecified).AddTicks(389), new TimeSpan(0, 7, 0, 0, 0)), "Fugit assumenda eius non repellat.", true, new DateTimeOffset(new DateTime(2020, 6, 6, 5, 41, 18, 639, DateTimeKind.Unspecified).AddTicks(8879), new TimeSpan(0, 7, 0, 0, 0)), "maiores", new Guid("6b601e2a-fd75-5bb7-5be1-196ca9cff63a"), new Guid("e07e234c-6fb5-08dc-5b8c-438fffa9361b") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("6de550f7-5ace-974d-8476-ab3a2fdf8895"), 794.94m, new DateTimeOffset(new DateTime(2020, 11, 4, 3, 10, 26, 503, DateTimeKind.Unspecified).AddTicks(5474), new TimeSpan(0, 7, 0, 0, 0)), "Delectus impedit qui enim autem est ipsum molestias fugit.", new DateTimeOffset(new DateTime(2020, 2, 26, 7, 15, 36, 324, DateTimeKind.Unspecified).AddTicks(3106), new TimeSpan(0, 7, 0, 0, 0)), "et", new Guid("11cf08e5-9589-40c5-a761-187ed55224f6"), new Guid("c57fd8b3-7dcc-83e2-69aa-a4108d4d026f") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[] { new Guid("7feb6649-70fc-ef5f-ed2c-0eaddc74db76"), 375.80m, new DateTimeOffset(new DateTime(2020, 9, 22, 18, 47, 21, 152, DateTimeKind.Unspecified).AddTicks(7159), new TimeSpan(0, 7, 0, 0, 0)), "Perspiciatis repellat magni mollitia sunt.", true, new DateTimeOffset(new DateTime(2020, 12, 22, 12, 6, 44, 103, DateTimeKind.Unspecified).AddTicks(5617), new TimeSpan(0, 7, 0, 0, 0)), "repellat", new Guid("779c3b8b-7dec-380d-7eeb-ec94e998eb0c"), new Guid("9225cd84-cc3f-197a-0d9b-61826df2719f") });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("94ea5462-27f6-d5f5-eee0-105eca808b3b"), 347.79m, new DateTimeOffset(new DateTime(2020, 9, 10, 6, 4, 10, 978, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 7, 0, 0, 0)), "Velit temporibus ipsa consectetur illo laboriosam qui.", new DateTimeOffset(new DateTime(2020, 7, 19, 3, 21, 29, 954, DateTimeKind.Unspecified).AddTicks(8676), new TimeSpan(0, 7, 0, 0, 0)), "expedita", new Guid("d2f046ac-c105-40c7-eabf-733a9492edc5"), new Guid("9225cd84-cc3f-197a-0d9b-61826df2719f") },
                    { new Guid("9cfc468b-0ab1-a20a-dc49-95e1e478b199"), 740.44m, new DateTimeOffset(new DateTime(2020, 9, 11, 1, 16, 16, 760, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 7, 0, 0, 0)), "Earum cupiditate quasi eveniet tempore omnis.", new DateTimeOffset(new DateTime(2020, 7, 9, 10, 50, 29, 169, DateTimeKind.Unspecified).AddTicks(6939), new TimeSpan(0, 7, 0, 0, 0)), "corrupti", new Guid("d2f046ac-c105-40c7-eabf-733a9492edc5"), new Guid("3f9f750c-38ab-aaa4-4eb4-7f55421996b8") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("a9d7c48c-e542-6100-d98e-dd9402ebd05d"), 299.81m, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 42, 50, 333, DateTimeKind.Unspecified).AddTicks(3690), new TimeSpan(0, 7, 0, 0, 0)), "Repellat quas molestiae itaque et doloremque incidunt nemo veritatis.", true, new DateTimeOffset(new DateTime(2020, 11, 13, 4, 40, 31, 274, DateTimeKind.Unspecified).AddTicks(1134), new TimeSpan(0, 7, 0, 0, 0)), "porro", new Guid("6b17d449-6d47-ded4-42e8-91b1dda61892"), new Guid("754ae7f5-0365-4af8-7c83-951b2e30d982") },
                    { new Guid("b50b40e5-4ad9-8950-8507-682b0d588f71"), 43.36m, new DateTimeOffset(new DateTime(2020, 1, 21, 19, 9, 49, 349, DateTimeKind.Unspecified).AddTicks(5881), new TimeSpan(0, 7, 0, 0, 0)), "A optio modi minus rerum voluptatem officiis.", true, new DateTimeOffset(new DateTime(2020, 5, 25, 17, 51, 7, 609, DateTimeKind.Unspecified).AddTicks(8780), new TimeSpan(0, 7, 0, 0, 0)), "architecto", new Guid("9d4a5ac2-9ed1-9582-50ad-507ae459e493"), new Guid("3f9f750c-38ab-aaa4-4eb4-7f55421996b8") },
                    { new Guid("e4e3def4-b2a1-c4a3-49f8-a662fe7e5157"), 356.77m, new DateTimeOffset(new DateTime(2020, 11, 15, 2, 8, 39, 796, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 7, 0, 0, 0)), "Ipsam mollitia atque atque et inventore laborum.", true, new DateTimeOffset(new DateTime(2020, 12, 23, 0, 6, 1, 196, DateTimeKind.Unspecified).AddTicks(4719), new TimeSpan(0, 7, 0, 0, 0)), "similique", new Guid("11cf08e5-9589-40c5-a761-187ed55224f6"), new Guid("c57fd8b3-7dcc-83e2-69aa-a4108d4d026f") },
                    { new Guid("ee602b2f-b479-e353-9036-dfc79c18976a"), 652.90m, new DateTimeOffset(new DateTime(2020, 11, 5, 20, 22, 45, 403, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 7, 0, 0, 0)), "Rerum corrupti voluptatem nobis delectus eos.", true, new DateTimeOffset(new DateTime(2020, 3, 4, 6, 35, 3, 882, DateTimeKind.Unspecified).AddTicks(6650), new TimeSpan(0, 7, 0, 0, 0)), "sint", new Guid("b354e7ff-dc8e-00a4-4e16-dbdec031d490"), new Guid("c57fd8b3-7dcc-83e2-69aa-a4108d4d026f") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("09354983-c222-b1f8-6595-99800ff98b29"), new Guid("f774154c-4e4a-4a5f-d769-f094e08d73e6"), new DateTimeOffset(new DateTime(2020, 10, 22, 15, 57, 42, 951, DateTimeKind.Unspecified).AddTicks(685), new TimeSpan(0, 7, 0, 0, 0)), "http://lindsey.biz", new DateTimeOffset(new DateTime(2020, 8, 30, 12, 15, 24, 70, DateTimeKind.Unspecified).AddTicks(5666), new TimeSpan(0, 7, 0, 0, 0)), new Guid("779c3b8b-7dec-380d-7eeb-ec94e998eb0c") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("0d197acc-619b-6d82-f271-9fea1b00a6c9"), new Guid("9d403be7-1591-a47f-eda5-1411ff876f4f"), new DateTimeOffset(new DateTime(2020, 9, 20, 1, 59, 57, 796, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 7, 0, 0, 0)), true, "https://jayme.org", new DateTimeOffset(new DateTime(2020, 7, 27, 11, 15, 33, 143, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3b18d343-2ea5-4803-3f37-73c3e7b57871") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("208bf680-2b14-3712-d52d-64d485abd589"), new Guid("7d5ba0c4-a164-7231-7cf6-1d1e6efaf5d8"), new DateTimeOffset(new DateTime(2020, 7, 12, 8, 29, 34, 78, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 7, 0, 0, 0)), "https://opal.net", new DateTimeOffset(new DateTime(2020, 8, 22, 14, 2, 51, 750, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6b17d449-6d47-ded4-42e8-91b1dda61892") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("34660c4f-2bac-b697-715e-720dd466c34f"), new Guid("e9ce60a6-2ed5-9c3b-1203-98e89b09e05c"), new DateTimeOffset(new DateTime(2020, 1, 9, 23, 46, 18, 401, DateTimeKind.Unspecified).AddTicks(4385), new TimeSpan(0, 7, 0, 0, 0)), true, "http://garret.org", new DateTimeOffset(new DateTime(2020, 8, 19, 7, 8, 25, 325, DateTimeKind.Unspecified).AddTicks(2802), new TimeSpan(0, 7, 0, 0, 0)), new Guid("99b466ff-4c41-07d6-7020-a9f28b403607") },
                    { new Guid("3d5d14e4-3fcc-7089-9fe4-9d676b30922d"), new Guid("55f6523c-51b3-95d6-89d1-d290b43e07fd"), new DateTimeOffset(new DateTime(2020, 10, 9, 1, 5, 9, 814, DateTimeKind.Unspecified).AddTicks(6427), new TimeSpan(0, 7, 0, 0, 0)), true, "http://jerome.org", new DateTimeOffset(new DateTime(2020, 1, 6, 21, 1, 13, 733, DateTimeKind.Unspecified).AddTicks(4917), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6b17d449-6d47-ded4-42e8-91b1dda61892") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("6cbda0e8-a72b-72d6-050a-8f8922cd5b94"), new Guid("742e2a57-6231-e100-0c30-a46a4792353a"), new DateTimeOffset(new DateTime(2020, 8, 31, 13, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 7, 0, 0, 0)), "https://loren.name", new DateTimeOffset(new DateTime(2020, 1, 1, 19, 13, 11, 383, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f4b6b354-f64b-e238-6806-00f403e85ab4") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("6d1eab15-d275-d365-3d5c-153a9787de8d"), new Guid("dc2253fb-a284-69ca-546f-0a051ec36e98"), new DateTimeOffset(new DateTime(2020, 9, 14, 23, 41, 43, 347, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 7, 0, 0, 0)), true, "http://jonathon.org", new DateTimeOffset(new DateTime(2020, 1, 19, 16, 20, 22, 899, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9d4a5ac2-9ed1-9582-50ad-507ae459e493") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("76db74dc-6488-fd6f-2dc4-98c6ecbda3e5"), new Guid("e37263c1-54e5-503c-642e-44045c366f77"), new DateTimeOffset(new DateTime(2020, 8, 20, 20, 16, 23, 203, DateTimeKind.Unspecified).AddTicks(428), new TimeSpan(0, 7, 0, 0, 0)), "http://danyka.info", new DateTimeOffset(new DateTime(2020, 2, 20, 19, 7, 51, 344, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f4b6b354-f64b-e238-6806-00f403e85ab4") },
                    { new Guid("835381de-6fb1-580a-350e-f0f5e74a7565"), new Guid("742e2a57-6231-e100-0c30-a46a4792353a"), new DateTimeOffset(new DateTime(2020, 4, 13, 17, 1, 0, 884, DateTimeKind.Unspecified).AddTicks(3627), new TimeSpan(0, 7, 0, 0, 0)), "https://anthony.org", new DateTimeOffset(new DateTime(2020, 2, 24, 21, 38, 22, 83, DateTimeKind.Unspecified).AddTicks(9488), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4fbc87d7-b534-95ce-0699-083d05b4056f") },
                    { new Guid("8de07c9f-8317-bde3-52b5-9b65adced5fa"), new Guid("915bf2ff-2a7a-a582-3585-cbee1ae797a3"), new DateTimeOffset(new DateTime(2020, 1, 1, 19, 23, 54, 762, DateTimeKind.Unspecified).AddTicks(5849), new TimeSpan(0, 7, 0, 0, 0)), "http://bettie.net", new DateTimeOffset(new DateTime(2020, 6, 20, 11, 8, 12, 390, DateTimeKind.Unspecified).AddTicks(389), new TimeSpan(0, 7, 0, 0, 0)), new Guid("779c3b8b-7dec-380d-7eeb-ec94e998eb0c") },
                    { new Guid("8f580d2b-c771-8dd8-e8e7-b59d321efac9"), new Guid("894bbc95-6ce2-cb29-8f17-449c7ebe9a77"), new DateTimeOffset(new DateTime(2020, 9, 16, 0, 17, 18, 289, DateTimeKind.Unspecified).AddTicks(5609), new TimeSpan(0, 7, 0, 0, 0)), "https://tyler.name", new DateTimeOffset(new DateTime(2020, 12, 21, 5, 10, 51, 604, DateTimeKind.Unspecified).AddTicks(516), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6b17d449-6d47-ded4-42e8-91b1dda61892") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[,]
                {
                    { new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"), new Guid("dc880bf8-48e0-6c50-837a-3f2480a252fb"), new DateTimeOffset(new DateTime(2020, 1, 20, 7, 42, 9, 565, DateTimeKind.Unspecified).AddTicks(9209), new TimeSpan(0, 7, 0, 0, 0)), true, "https://reba.com", new DateTimeOffset(new DateTime(2020, 4, 2, 15, 14, 46, 882, DateTimeKind.Unspecified).AddTicks(6824), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6b17d449-6d47-ded4-42e8-91b1dda61892") },
                    { new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"), new Guid("6773f756-d8b1-22de-a543-ceb51d18f920"), new DateTimeOffset(new DateTime(2020, 3, 4, 6, 35, 3, 882, DateTimeKind.Unspecified).AddTicks(6650), new TimeSpan(0, 7, 0, 0, 0)), true, "http://marlene.org", new DateTimeOffset(new DateTime(2020, 11, 19, 3, 21, 24, 374, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 7, 0, 0, 0)), new Guid("40059f0b-1d19-9002-1e10-8a95bc55cb73") }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("031a60ca-8499-fd17-2e0d-492832ad01cf"), new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"), new DateTimeOffset(new DateTime(2024, 1, 5, 6, 1, 12, 451, DateTimeKind.Unspecified).AddTicks(4697), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 1, 16, 22, 57, 256, DateTimeKind.Unspecified).AddTicks(8688), new TimeSpan(0, 7, 0, 0, 0)), "nam", "deleniti" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("1c7a3311-13f2-0c4f-6634-ac2b97b6715e"), new Guid("6649549c-7feb-70fc-5fef-ed2c0eaddc74"), new DateTimeOffset(new DateTime(2023, 10, 11, 4, 4, 21, 261, DateTimeKind.Unspecified).AddTicks(788), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 23, 4, 24, 13, 653, DateTimeKind.Unspecified).AddTicks(2843), new TimeSpan(0, 7, 0, 0, 0)), "temporibus", "velit" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("22389678-518c-45e7-09eb-80f68b20142b"), new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"), new DateTimeOffset(new DateTime(2023, 8, 7, 6, 23, 39, 898, DateTimeKind.Unspecified).AddTicks(7287), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 6, 8, 52, 17, 7, DateTimeKind.Unspecified).AddTicks(1958), new TimeSpan(0, 7, 0, 0, 0)), "nesciunt", "velit" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9"), new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 1, 50, 549, DateTimeKind.Unspecified).AddTicks(5981), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 13, 9, 4, 29, 33, DateTimeKind.Unspecified).AddTicks(5423), new TimeSpan(0, 7, 0, 0, 0)), "eveniet", "deleniti" },
                    { new Guid("29a8d248-66fd-66c5-8262-26cdde04085c"), new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), new DateTimeOffset(new DateTime(2023, 10, 25, 10, 20, 38, 925, DateTimeKind.Unspecified).AddTicks(1647), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 27, 7, 44, 36, 727, DateTimeKind.Unspecified).AddTicks(9030), new TimeSpan(0, 7, 0, 0, 0)), "velit", "et" },
                    { new Guid("2bfb012d-0c51-868e-863e-ededbd69d813"), new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), new DateTimeOffset(new DateTime(2023, 10, 31, 15, 20, 22, 600, DateTimeKind.Unspecified).AddTicks(910), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 20, 18, 54, 59, 973, DateTimeKind.Unspecified).AddTicks(7419), new TimeSpan(0, 7, 0, 0, 0)), "eos", "itaque" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("3dfa1681-7e09-c566-fd01-2c2fc3339462"), new Guid("8bc880c5-bc39-a62d-528d-a9d070fe5e75"), new DateTimeOffset(new DateTime(2023, 9, 2, 4, 41, 27, 858, DateTimeKind.Unspecified).AddTicks(4313), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 13, 5, 6, 31, 753, DateTimeKind.Unspecified).AddTicks(7149), new TimeSpan(0, 7, 0, 0, 0)), "alias", "ea" },
                    { new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3"), new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), new DateTimeOffset(new DateTime(2024, 4, 17, 7, 31, 11, 480, DateTimeKind.Unspecified).AddTicks(5596), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 16, 7, 15, 10, 750, DateTimeKind.Unspecified).AddTicks(9886), new TimeSpan(0, 7, 0, 0, 0)), "et", "iste" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("4eaaa438-7fb4-4255-1996-b8a364698dd7"), new Guid("0bab7af2-5fac-9b1e-3f2b-cd52f09e51d4"), new DateTimeOffset(new DateTime(2024, 2, 8, 18, 51, 30, 433, DateTimeKind.Unspecified).AddTicks(6165), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 9, 18, 51, 28, 532, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, 7, 0, 0, 0)), "et", "magni" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("51c657c7-c2b6-f76d-86a8-3ce64680ed81"), new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), new DateTimeOffset(new DateTime(2024, 3, 5, 18, 46, 1, 968, DateTimeKind.Unspecified).AddTicks(5115), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 29, 15, 41, 25, 398, DateTimeKind.Unspecified).AddTicks(4516), new TimeSpan(0, 7, 0, 0, 0)), "laborum", "ab" },
                    { new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"), new Guid("582236b0-6743-9b61-aa64-9fd9f78f1a58"), new DateTimeOffset(new DateTime(2023, 7, 14, 20, 41, 4, 623, DateTimeKind.Unspecified).AddTicks(9888), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 26, 4, 13, 41, 940, DateTimeKind.Unspecified).AddTicks(7505), new TimeSpan(0, 7, 0, 0, 0)), "consequatur", "asperiores" },
                    { new Guid("6239b5a1-ea54-f694-27f5-d5eee0105eca"), new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59"), new DateTimeOffset(new DateTime(2023, 8, 5, 12, 47, 36, 264, DateTimeKind.Unspecified).AddTicks(8237), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 29, 1, 43, 25, 10, DateTimeKind.Unspecified).AddTicks(8339), new TimeSpan(0, 7, 0, 0, 0)), "eius", "consequuntur" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("65bc72ff-ae2b-8752-501d-b8b47d7fa37a"), new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), new DateTimeOffset(new DateTime(2023, 12, 13, 9, 45, 25, 291, DateTimeKind.Unspecified).AddTicks(7667), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 25, 3, 57, 34, 363, DateTimeKind.Unspecified).AddTicks(7230), new TimeSpan(0, 7, 0, 0, 0)), "officiis", "ut" },
                    { new Guid("67eba435-40d1-7d65-5050-c5b9bd58e5e1"), new Guid("0945e751-80eb-8bf6-2014-2b1237d52d64"), new DateTimeOffset(new DateTime(2023, 7, 19, 10, 12, 6, 329, DateTimeKind.Unspecified).AddTicks(4967), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 16, 1, 39, 14, 135, DateTimeKind.Unspecified).AddTicks(167), new TimeSpan(0, 7, 0, 0, 0)), "aut", "nihil" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("6ef2cebd-84d8-048d-bd66-760f9121b162"), new Guid("0c037a58-9f75-ab3f-38a4-aa4eb47f5542"), new DateTimeOffset(new DateTime(2024, 2, 27, 15, 0, 31, 993, DateTimeKind.Unspecified).AddTicks(1819), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 31, 13, 7, 7, 570, DateTimeKind.Unspecified).AddTicks(5813), new TimeSpan(0, 7, 0, 0, 0)), "dolorem", "maiores" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0"), new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"), new DateTimeOffset(new DateTime(2023, 9, 25, 12, 19, 17, 321, DateTimeKind.Unspecified).AddTicks(5416), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 13, 6, 40, 12, 599, DateTimeKind.Unspecified).AddTicks(126), new TimeSpan(0, 7, 0, 0, 0)), "ut", "voluptatibus" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("76b4b43e-6bbc-a7f7-1f4c-4773aee30c10"), new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"), new DateTimeOffset(new DateTime(2024, 2, 12, 14, 28, 29, 879, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 1, 11, 17, 31, 44, 811, DateTimeKind.Unspecified).AddTicks(7715), new TimeSpan(0, 7, 0, 0, 0)), "cumque", "rerum" },
                    { new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new Guid("a9ff8f43-1b36-7c81-ae63-cbef0d43492d"), new DateTimeOffset(new DateTime(2024, 6, 7, 19, 2, 22, 618, DateTimeKind.Unspecified).AddTicks(1457), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 15, 10, 57, 55, 577, DateTimeKind.Unspecified).AddTicks(2418), new TimeSpan(0, 7, 0, 0, 0)), "est", "iste" },
                    { new Guid("7fd8b31a-ccc5-e27d-8369-aaa4108d4d02"), new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), new DateTimeOffset(new DateTime(2024, 5, 13, 11, 3, 19, 992, DateTimeKind.Unspecified).AddTicks(9592), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 8, 21, 45, 8, 644, DateTimeKind.Unspecified).AddTicks(2533), new TimeSpan(0, 7, 0, 0, 0)), "sint", "perferendis" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("89d5ab85-8ee1-80c5-c88b-39bc2da6528d"), new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new DateTimeOffset(new DateTime(2024, 4, 16, 1, 12, 15, 864, DateTimeKind.Unspecified).AddTicks(3583), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 27, 9, 7, 46, 733, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 7, 0, 0, 0)), "hic", "officiis" },
                    { new Guid("8b3ca5cc-36b0-5822-4367-619baa649fd9"), new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"), new DateTimeOffset(new DateTime(2024, 1, 18, 7, 11, 51, 320, DateTimeKind.Unspecified).AddTicks(187), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 20, 13, 26, 54, 615, DateTimeKind.Unspecified).AddTicks(9950), new TimeSpan(0, 7, 0, 0, 0)), "nobis", "quasi" },
                    { new Guid("8f54f608-ca59-8ea8-37a9-2300d6a4402f"), new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"), new DateTimeOffset(new DateTime(2023, 9, 4, 6, 30, 35, 588, DateTimeKind.Unspecified).AddTicks(4497), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 1, 2, 49, 52, 229, DateTimeKind.Unspecified).AddTicks(6991), new TimeSpan(0, 7, 0, 0, 0)), "occaecati", "maxime" },
                    { new Guid("953b298b-2d7e-d55f-136d-3fc2a7f518e0"), new Guid("582236b0-6743-9b61-aa64-9fd9f78f1a58"), new DateTimeOffset(new DateTime(2024, 2, 7, 10, 56, 48, 508, DateTimeKind.Unspecified).AddTicks(6822), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 8, 15, 47, 57, 750, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, 7, 0, 0, 0)), "repellat", "sed" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("0bab7af2-5fac-9b1e-3f2b-cd52f09e51d4"), new DateTimeOffset(new DateTime(2024, 5, 23, 23, 11, 32, 195, DateTimeKind.Unspecified).AddTicks(4349), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 26, 6, 59, 35, 790, DateTimeKind.Unspecified).AddTicks(6202), new TimeSpan(0, 7, 0, 0, 0)), "ut", "minus" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("a72b6cbd-72d6-0a05-8f89-22cd5b94c915"), new Guid("28490d2e-ad32-cf01-c79e-2cd4a1fd8116"), new DateTimeOffset(new DateTime(2024, 2, 24, 2, 53, 59, 413, DateTimeKind.Unspecified).AddTicks(855), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 6, 26, 8, 12, 6, 441, DateTimeKind.Unspecified).AddTicks(6114), new TimeSpan(0, 7, 0, 0, 0)), "qui", "error" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("a9f24616-93e6-626c-6933-ef855ab90a53"), new Guid("2f40a4d6-602b-79ee-b453-e39036dfc79c"), new DateTimeOffset(new DateTime(2024, 3, 18, 3, 4, 12, 838, DateTimeKind.Unspecified).AddTicks(6155), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 21, 4, 35, 2, 638, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, 7, 0, 0, 0)), "explicabo", "ipsa" },
                    { new Guid("af938ef6-c065-3ea8-cc42-4091fadad7ff"), new Guid("2f40a4d6-602b-79ee-b453-e39036dfc79c"), new DateTimeOffset(new DateTime(2023, 9, 20, 11, 48, 55, 405, DateTimeKind.Unspecified).AddTicks(2640), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 17, 14, 3, 27, 801, DateTimeKind.Unspecified).AddTicks(1530), new TimeSpan(0, 7, 0, 0, 0)), "sequi", "recusandae" },
                    { new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5"), new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"), new DateTimeOffset(new DateTime(2023, 9, 17, 15, 1, 27, 689, DateTimeKind.Unspecified).AddTicks(4237), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 10, 28, 13, 44, 35, 201, DateTimeKind.Unspecified).AddTicks(5051), new TimeSpan(0, 7, 0, 0, 0)), "voluptas", "voluptas" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"), new DateTimeOffset(new DateTime(2024, 5, 27, 10, 35, 31, 212, DateTimeKind.Unspecified).AddTicks(5916), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 14, 3, 4, 48, 825, DateTimeKind.Unspecified).AddTicks(7240), new TimeSpan(0, 7, 0, 0, 0)), "sunt", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("b6de451c-9052-53a9-a9fb-007f94ad4550"), new Guid("8b1ffb45-1ea4-e025-e09e-2784cd25923f"), new DateTimeOffset(new DateTime(2024, 2, 8, 5, 18, 9, 593, DateTimeKind.Unspecified).AddTicks(8884), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 18, 5, 20, 43, 93, DateTimeKind.Unspecified).AddTicks(761), new TimeSpan(0, 7, 0, 0, 0)), "voluptas", "sint" },
                    { new Guid("c5958911-a740-1861-7ed5-5224f6098c56"), new Guid("8b1ffb45-1ea4-e025-e09e-2784cd25923f"), new DateTimeOffset(new DateTime(2023, 6, 29, 2, 49, 1, 711, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 12, 0, 41, 47, 342, DateTimeKind.Unspecified).AddTicks(5985), new TimeSpan(0, 7, 0, 0, 0)), "voluptatibus", "quidem" },
                    { new Guid("cee903fb-653b-0877-add2-e94ecd2895df"), new Guid("19469a5c-d6ab-8b1d-dfd6-47876ffa5d3f"), new DateTimeOffset(new DateTime(2024, 4, 20, 17, 53, 31, 907, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 1, 25, 19, 37, 3, 501, DateTimeKind.Unspecified).AddTicks(7774), new TimeSpan(0, 7, 0, 0, 0)), "et", "voluptate" },
                    { new Guid("d6df8b1d-8747-fa6f-5d3f-efbb55f9f750"), new Guid("8364bab3-3549-2209-c2f8-b1659599800f"), new DateTimeOffset(new DateTime(2023, 12, 1, 17, 39, 5, 216, DateTimeKind.Unspecified).AddTicks(6060), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 14, 12, 11, 43, 446, DateTimeKind.Unspecified).AddTicks(1284), new TimeSpan(0, 7, 0, 0, 0)), "sequi", "rerum" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("dca20a0a-9549-e4e1-78b1-99327e3ac5e0"), new Guid("f76bbc76-1fa7-474c-73ae-e30c1006428e"), new DateTimeOffset(new DateTime(2023, 8, 2, 15, 58, 58, 736, DateTimeKind.Unspecified).AddTicks(1601), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 23, 0, 36, 21, 459, DateTimeKind.Unspecified).AddTicks(1675), new TimeSpan(0, 7, 0, 0, 0)), "cupiditate", "quasi" },
                    { new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"), new Guid("aa6983e2-10a4-4d8d-026f-58808923f5bd"), new DateTimeOffset(new DateTime(2023, 8, 15, 22, 36, 16, 515, DateTimeKind.Unspecified).AddTicks(859), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 30, 9, 21, 40, 461, DateTimeKind.Unspecified).AddTicks(4907), new TimeSpan(0, 7, 0, 0, 0)), "nobis", "delectus" },
                    { new Guid("dfd5e5a3-ad91-6e2a-8169-d69d496e5763"), new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"), new DateTimeOffset(new DateTime(2023, 8, 26, 20, 34, 13, 915, DateTimeKind.Unspecified).AddTicks(3818), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 15, 19, 7, 27, 232, DateTimeKind.Unspecified).AddTicks(2549), new TimeSpan(0, 7, 0, 0, 0)), "sint", "dolorem" },
                    { new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), new Guid("aa6983e2-10a4-4d8d-026f-58808923f5bd"), new DateTimeOffset(new DateTime(2023, 7, 6, 16, 34, 47, 452, DateTimeKind.Unspecified).AddTicks(6860), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 11, 21, 48, 36, 289, DateTimeKind.Unspecified).AddTicks(2105), new TimeSpan(0, 7, 0, 0, 0)), "sunt", "necessitatibus" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("e562d718-0b40-d9b5-4a50-898507682b0d"), new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"), new DateTimeOffset(new DateTime(2023, 12, 16, 18, 20, 3, 670, DateTimeKind.Unspecified).AddTicks(7498), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 27, 14, 56, 54, 216, DateTimeKind.Unspecified).AddTicks(6030), new TimeSpan(0, 7, 0, 0, 0)), "iusto", "voluptas" },
                    { new Guid("f052cd2b-519e-9ed4-a805-15b413c4587a"), new Guid("c32f2c01-9433-2762-2427-ce133348d2a8"), new DateTimeOffset(new DateTime(2024, 1, 8, 3, 20, 52, 689, DateTimeKind.Unspecified).AddTicks(9053), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 11, 16, 22, 49, 3, 9, DateTimeKind.Unspecified).AddTicks(605), new TimeSpan(0, 7, 0, 0, 0)), "quaerat", "sit" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[] { new Guid("fee56044-ba9d-cd8d-411f-2c0793b7df38"), new Guid("2f40a4d6-602b-79ee-b453-e39036dfc79c"), new DateTimeOffset(new DateTime(2024, 4, 22, 2, 8, 17, 407, DateTimeKind.Unspecified).AddTicks(472), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 6, 0, 33, 2, 742, DateTimeKind.Unspecified).AddTicks(2860), new TimeSpan(0, 7, 0, 0, 0)), "eos", "ea" });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("022b0a9c-ade3-e2c5-5965-1d09f1ff000d"), 703.60m, new Guid("6fed2434-4cfa-a569-b03b-d8cdc1c06247"), new DateTimeOffset(new DateTime(2020, 2, 9, 11, 14, 2, 130, DateTimeKind.Unspecified).AddTicks(853), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9ef052cd-d451-a89e-0515-b413c4587a03"), "Non at aliquam et.", true, new DateTimeOffset(new DateTime(2020, 4, 30, 15, 16, 41, 409, DateTimeKind.Unspecified).AddTicks(8424), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("837c4af8-1b95-302e-d982-d3e35c19fca2"), new Guid("602b2f40-79ee-53b4-e390-36dfc79c1897") },
                    { new Guid("030f5a58-a7ac-b018-f69d-1b2122d384ac"), 143.43m, new Guid("bb95c85e-2a0d-daf5-4042-df1c3a338091"), new DateTimeOffset(new DateTime(2020, 3, 27, 15, 26, 0, 285, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 7, 0, 0, 0)), new Guid("35f65d2c-7cfe-378d-40a4-6990103e9553"), "Facere illum voluptate sed nostrum harum maiores autem sit illo.", true, new DateTimeOffset(new DateTime(2020, 1, 9, 6, 14, 50, 548, DateTimeKind.Unspecified).AddTicks(3082), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("8bdb736b-89b7-be24-1c15-31f7e7421644"), new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35") },
                    { new Guid("19aad1fe-5653-b064-e414-5d3dcc3f8970"), 606.44m, new Guid("b43c1f24-e7fa-273e-9610-060865806035"), new DateTimeOffset(new DateTime(2020, 10, 25, 19, 57, 28, 344, DateTimeKind.Unspecified).AddTicks(7439), new TimeSpan(0, 7, 0, 0, 0)), new Guid("71b6972b-725e-d40d-66c3-4f8b85031295"), "Rerum omnis reprehenderit dolores et quis.", true, new DateTimeOffset(new DateTime(2020, 1, 22, 21, 25, 55, 196, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("6b601e2a-fd75-5bb7-5be1-196ca9cff63a"), new Guid("b651c657-6dc2-86f7-a83c-e64680ed8168") },
                    { new Guid("275c2783-b68e-7db1-3ef2-0f18e430ad7b"), 18.39m, new Guid("38dfb793-9a5c-1946-abd6-1d8bdfd64787"), new DateTimeOffset(new DateTime(2020, 9, 8, 6, 3, 51, 648, DateTimeKind.Unspecified).AddTicks(6833), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2b94bacd-417a-aaf6-249c-e7305db0f8c2"), "Voluptatem minus alias incidunt fuga repudiandae ut.", true, new DateTimeOffset(new DateTime(2020, 12, 10, 22, 17, 30, 126, DateTimeKind.Unspecified).AddTicks(4141), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("9588df2f-6267-6dd3-4359-1ec672055d47"), new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35") },
                    { new Guid("28cd4ee9-df95-ff80-ff97-7fca08f6548f"), 184.87m, new Guid("e353b479-3690-c7df-9c18-976a78c831fa"), new DateTimeOffset(new DateTime(2020, 7, 27, 23, 5, 39, 258, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cd4ee9d2-9528-80df-ffff-977fca08f654"), "Rerum pariatur magnam tenetur nihil architecto ipsam occaecati maxime.", true, new DateTimeOffset(new DateTime(2020, 5, 11, 2, 14, 21, 877, DateTimeKind.Unspecified).AddTicks(3781), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668"), new Guid("9225cd84-cc3f-197a-0d9b-61826df2719f") },
                    { new Guid("55bbef3f-f7f9-e550-6dce-5a4d978476ab"), 590.95m, new Guid("c61e5943-0572-475d-c2ed-18d762e5400b"), new DateTimeOffset(new DateTime(2020, 9, 11, 8, 8, 10, 513, DateTimeKind.Unspecified).AddTicks(3592), new TimeSpan(0, 7, 0, 0, 0)), new Guid("53c4e4fb-c85d-80e2-8ad9-652748a30f3c"), "Ratione autem et.", true, new DateTimeOffset(new DateTime(2020, 10, 18, 12, 44, 11, 421, DateTimeKind.Unspecified).AddTicks(2062), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("3b18d343-2ea5-4803-3f37-73c3e7b57871"), new Guid("754ae7f5-0365-4af8-7c83-951b2e30d982") },
                    { new Guid("57cd73f6-e9a9-768d-2e37-54d34cf08bd2"), 858.58m, new Guid("ac34660c-972b-71b6-5e72-0dd466c34f8b"), new DateTimeOffset(new DateTime(2020, 8, 16, 19, 1, 51, 174, DateTimeKind.Unspecified).AddTicks(5915), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2aad91df-816e-d669-9d49-6e5763a37c45"), "Rerum et omnis cupiditate aut.", true, new DateTimeOffset(new DateTime(2020, 2, 24, 22, 25, 44, 778, DateTimeKind.Unspecified).AddTicks(9717), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("4a1c6b89-d069-783e-490c-18783c5527ee"), new Guid("3f9f750c-38ab-aaa4-4eb4-7f55421996b8") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("62b12191-f9c9-e502-08cf-118995c540a7"), 89.14m, new Guid("2bfb012d-0c51-868e-863e-ededbd69d813"), new DateTimeOffset(new DateTime(2020, 6, 20, 18, 3, 17, 130, DateTimeKind.Unspecified).AddTicks(2827), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b5e07e23-dc6f-5b08-8c43-8fffa9361b81"), "Perspiciatis expedita aliquid dolorem et voluptatibus quidem doloribus tenetur quia.", new DateTimeOffset(new DateTime(2020, 11, 10, 23, 15, 48, 6, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("6b601e2a-fd75-5bb7-5be1-196ca9cff63a"), new Guid("3f5dfa6f-bbef-f955-f750-e56dce5a4d97") },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), 83.57m, new Guid("69626c93-ef33-5a85-b90a-53b0f5a84781"), new DateTimeOffset(new DateTime(2020, 7, 2, 1, 56, 13, 215, DateTimeKind.Unspecified).AddTicks(6503), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"), "Sit minus eveniet vel et.", new DateTimeOffset(new DateTime(2020, 1, 15, 1, 34, 11, 827, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d"), new Guid("72d6a72b-0a05-898f-22cd-5b94c9155554") },
                    { new Guid("97b5d36d-c630-542b-d79f-c1f4fe32674a"), 708.01m, new Guid("db164e00-c0de-d431-90de-3502965bb37c"), new DateTimeOffset(new DateTime(2020, 12, 30, 9, 58, 40, 129, DateTimeKind.Unspecified).AddTicks(2235), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f93c9215-2941-5f5a-c931-444a0a6156fa"), "Et dicta voluptas repellendus quia.", new DateTimeOffset(new DateTime(2020, 7, 10, 12, 35, 46, 929, DateTimeKind.Unspecified).AddTicks(2330), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("11cf08e5-9589-40c5-a761-187ed55224f6"), new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211") },
                    { new Guid("a5e0035e-4fba-0070-a7f0-b154fde1fc18"), 437.19m, new Guid("fe35f65d-8d7c-4037-a469-90103e955372"), new DateTimeOffset(new DateTime(2020, 2, 22, 15, 33, 3, 129, DateTimeKind.Unspecified).AddTicks(4022), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d42c9ec7-fda1-1681-fa3d-097e66c5fd01"), "Commodi eaque est asperiores illum provident sunt ex.", new DateTimeOffset(new DateTime(2020, 10, 31, 9, 51, 23, 722, DateTimeKind.Unspecified).AddTicks(1758), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("99b466ff-4c41-07d6-7020-a9f28b403607"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1") },
                    { new Guid("aa9b6167-9f64-f7d9-8f1a-58970f789638"), 732.98m, new Guid("d537122b-642d-85d4-abd5-89e18ec580c8"), new DateTimeOffset(new DateTime(2020, 7, 12, 8, 29, 34, 78, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 7, 0, 0, 0)), new Guid("29a8d248-66fd-66c5-8262-26cdde04085c"), "Dolor debitis quisquam cupiditate quaerat possimus.", new DateTimeOffset(new DateTime(2020, 8, 22, 14, 2, 51, 750, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("b9091570-e0f7-593d-99e0-58bfd294d21a"), new Guid("c550507d-bdb9-e558-e1a4-45366631090c") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("ad91dfd5-6e2a-6981-d69d-496e5763a37c"), 595.94m, new Guid("25cd8427-3f92-7acc-190d-9b61826df271"), new DateTimeOffset(new DateTime(2020, 8, 4, 11, 17, 22, 754, DateTimeKind.Unspecified).AddTicks(5856), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2f96af49-0c5f-aae2-4230-9edddf13c915"), "Cumque vero rerum illum.", true, new DateTimeOffset(new DateTime(2020, 1, 15, 15, 47, 35, 752, DateTimeKind.Unspecified).AddTicks(6317), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("f2fa31c8-ab7a-ac0b-5f1e-9b3f2bcd52f0"), new Guid("9225cd84-cc3f-197a-0d9b-61826df2719f") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("af4e7220-0f01-2605-0e56-6ab34b8a588c"), 499.98m, new Guid("42bab6e5-def4-e4e3-a1b2-a3c449f8a662"), new DateTimeOffset(new DateTime(2020, 8, 13, 18, 19, 17, 625, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fe70d0a9-755e-b31a-d87f-c5cc7de28369"), "Repudiandae ea eligendi officia.", new DateTimeOffset(new DateTime(2020, 5, 19, 11, 26, 12, 641, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("837c4af8-1b95-302e-d982-d3e35c19fca2"), new Guid("39fa5661-2eba-2269-1baa-fed1aa195356") },
                    { new Guid("bda0e8a4-2b6c-d6a7-7205-0a8f8922cd5b"), 453.12m, new Guid("6fb5e07e-08dc-8c5b-438f-ffa9361b817c"), new DateTimeOffset(new DateTime(2020, 6, 19, 20, 5, 33, 975, DateTimeKind.Unspecified).AddTicks(5038), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cc3f9225-197a-9b0d-6182-6df2719fea1b"), "Suscipit repellat accusamus quisquam in omnis sit.", new DateTimeOffset(new DateTime(2020, 1, 27, 16, 55, 50, 381, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("a2f3dcda-df43-530a-0c96-53f4b2c78dd4"), new Guid("5fac0bab-9b1e-2b3f-cd52-f09e51d49ea8") },
                    { new Guid("bdd8753b-eb6d-3480-646a-2cfb19c131d2"), 269.46m, new Guid("3330ce78-39f6-d4cc-c9e7-f969e2787cf3"), new DateTimeOffset(new DateTime(2020, 1, 21, 21, 37, 13, 425, DateTimeKind.Unspecified).AddTicks(4598), new TimeSpan(0, 7, 0, 0, 0)), new Guid("06109627-6508-6080-35ad-238abbb04a8e"), "Explicabo labore rerum cum vel suscipit voluptates repellendus repellendus.", new DateTimeOffset(new DateTime(2020, 1, 1, 5, 9, 13, 58, DateTimeKind.Unspecified).AddTicks(5793), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), new Guid("d86ef2ce-8d84-bd04-6676-0f9121b162c9") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("d52a2c37-a8ff-3d62-5cea-e177a771279a"), 510.61m, new Guid("75bf0c66-3e04-b4b4-76bc-6bf7a71f4c47"), new DateTimeOffset(new DateTime(2020, 10, 12, 10, 47, 18, 159, DateTimeKind.Unspecified).AddTicks(3036), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3d5d14e4-3fcc-7089-9fe4-9d676b30922d"), "Rerum ullam dolores modi.", true, new DateTimeOffset(new DateTime(2020, 5, 13, 0, 24, 7, 623, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668"), new Guid("d405fcc9-5e97-d8d3-499f-7ce08d1783e3") },
                    { new Guid("f4ce1a83-32f5-ed61-7e69-84c38a62f6f3"), 874.08m, new Guid("3d43bd8b-611b-f981-6b27-f458889dbfb2"), new DateTimeOffset(new DateTime(2020, 9, 4, 5, 55, 41, 304, DateTimeKind.Unspecified).AddTicks(6117), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), "Tempore quia ratione neque ratione exercitationem est sit.", true, new DateTimeOffset(new DateTime(2020, 4, 11, 19, 8, 56, 495, DateTimeKind.Unspecified).AddTicks(4390), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("8bdb736b-89b7-be24-1c15-31f7e7421644"), new Guid("602b2f40-79ee-53b4-e390-36dfc79c1897") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("f8b05d30-2fc2-7d4c-7e0b-670a682b5ace"), 157.14m, new Guid("084b74f2-88ab-d40c-bc0b-8fa62b500b66"), new DateTimeOffset(new DateTime(2020, 4, 20, 1, 46, 59, 676, DateTimeKind.Unspecified).AddTicks(8701), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cd73f634-a957-8de9-762e-3754d34cf08b"), "Corrupti ut tempora maiores sapiente quas.", new DateTimeOffset(new DateTime(2020, 2, 25, 3, 15, 37, 511, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("3b18d343-2ea5-4803-3f37-73c3e7b57871"), new Guid("a740c595-1861-d57e-5224-f6098c56f3f8") });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("1cc2cfcb-de45-52b6-90a9-53a9fb007f94"), 515.65m, new DateTimeOffset(new DateTime(2020, 8, 15, 16, 19, 14, 535, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 3, 25, 16, 21, 48, 34, DateTimeKind.Unspecified).AddTicks(8826), new TimeSpan(0, 7, 0, 0, 0)), "Savings Account", new Guid("3b18d343-2ea5-4803-3f37-73c3e7b57871") },
                    { new Guid("69680ceb-a2ec-41e6-f64f-828aa45d905a"), 498.20m, new DateTimeOffset(new DateTime(2020, 10, 10, 21, 35, 54, 200, DateTimeKind.Unspecified).AddTicks(5826), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2020, 11, 7, 21, 56, 17, 780, DateTimeKind.Unspecified).AddTicks(5085), new TimeSpan(0, 7, 0, 0, 0)), "Auto Loan Account", new Guid("6b601e2a-fd75-5bb7-5be1-196ca9cff63a") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Balance", "CreatedOnUtc", "ModifiedOnUtc", "Type", "UserId" },
                values: new object[] { new Guid("ac34660c-972b-71b6-5e72-0dd466c34f8b"), 850.06m, new DateTimeOffset(new DateTime(2020, 8, 7, 11, 50, 46, 224, DateTimeKind.Unspecified).AddTicks(1058), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 23, 2, 11, 18, 45, DateTimeKind.Unspecified).AddTicks(3838), new TimeSpan(0, 7, 0, 0, 0)), "Personal Loan Accoun", new Guid("6b17d449-6d47-ded4-42e8-91b1dda61892") });

            migrationBuilder.InsertData(
                table: "BookMark",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"), new Guid("92e3d544-7624-48a7-8558-e2cf0def022a"), new DateTimeOffset(new DateTime(2020, 12, 13, 9, 11, 54, 471, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 7, 21, 0, 27, 49, 307, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("0775d8dc-b429-2c37-2ad5-ffa8623d5cea"), "Completed", new Guid("946cbe11-beeb-0694-f564-dda95675991f"), new Guid("9f71f26d-1bea-a600-c920-1c80f09d1740"), new DateTimeOffset(new DateTime(2020, 8, 6, 15, 19, 49, 842, DateTimeKind.Unspecified).AddTicks(531), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"), new DateTimeOffset(new DateTime(2020, 9, 1, 7, 15, 55, 440, DateTimeKind.Unspecified).AddTicks(8434), new TimeSpan(0, 7, 0, 0, 0)), 1, "9:00 AM", new Guid("c2a70e2a-ef63-4cd3-813e-6c0feb02be4e") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("09354983-c222-b1f8-6595-99800ff98b29"), "Confirmed", new Guid("7e5e390d-d9ab-d434-ecef-08c5ede18f13"), new Guid("87973a15-8dde-6aed-3a99-5add4e83275c"), new DateTimeOffset(new DateTime(2020, 2, 3, 2, 35, 51, 337, DateTimeKind.Unspecified).AddTicks(9364), new TimeSpan(0, 7, 0, 0, 0)), new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), true, new DateTimeOffset(new DateTime(2020, 7, 9, 16, 9, 48, 440, DateTimeKind.Unspecified).AddTicks(5556), new TimeSpan(0, 7, 0, 0, 0)), 3, "10:00 AM", new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d197acc-619b-6d82-f271-9fea1b00a6c9"), "Confirmed", new Guid("85c7be28-3ba8-977e-a626-54f8f5964a2b"), new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new DateTimeOffset(new DateTime(2020, 11, 3, 12, 43, 52, 682, DateTimeKind.Unspecified).AddTicks(7039), new TimeSpan(0, 7, 0, 0, 0)), new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"), new DateTimeOffset(new DateTime(2020, 6, 21, 13, 51, 57, 810, DateTimeKind.Unspecified).AddTicks(9401), new TimeSpan(0, 7, 0, 0, 0)), 3, "11:00 AM", new Guid("f12096d7-2697-2757-cded-e8d3504da036") },
                    { new Guid("134ef789-0837-234c-7ee0-b56fdc085b8c"), "Confirmed", new Guid("85f9d68b-8075-4ce4-4687-d3b0fee00f06"), new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new DateTimeOffset(new DateTime(2020, 11, 16, 9, 2, 55, 491, DateTimeKind.Unspecified).AddTicks(5598), new TimeSpan(0, 7, 0, 0, 0)), new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), new DateTimeOffset(new DateTime(2020, 6, 19, 20, 5, 33, 975, DateTimeKind.Unspecified).AddTicks(5038), new TimeSpan(0, 7, 0, 0, 0)), 2, "10:00 PM", new Guid("360f39a0-9ef3-42c7-47d5-608af0d59ff4") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("19aad1fe-5653-b064-e414-5d3dcc3f8970"), "Completed", new Guid("55f6523c-51b3-95d6-89d1-d290b43e07fd"), new Guid("bde38317-b552-659b-adce-d5fa148bef7b"), new DateTimeOffset(new DateTime(2020, 6, 12, 15, 57, 25, 88, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, 7, 0, 0, 0)), new Guid("15c913df-778a-5837-5d13-48652553d7ec"), true, new DateTimeOffset(new DateTime(2020, 8, 10, 17, 33, 54, 43, DateTimeKind.Unspecified).AddTicks(5263), new TimeSpan(0, 7, 0, 0, 0)), 3, "3:00 PM", new Guid("6b601e2a-fd75-5bb7-5be1-196ca9cff63a") },
                    { new Guid("1f24a4b5-b43c-e7fa-3e27-961006086580"), "Cancelled", new Guid("122899aa-bb86-c8b7-29dc-92551068fe1b"), new Guid("f62452d5-8c09-f356-f855-7eac442d01fb"), new DateTimeOffset(new DateTime(2020, 12, 4, 21, 27, 47, 746, DateTimeKind.Unspecified).AddTicks(2103), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), true, new DateTimeOffset(new DateTime(2020, 4, 10, 10, 32, 3, 183, DateTimeKind.Unspecified).AddTicks(6585), new TimeSpan(0, 7, 0, 0, 0)), 1, "10:00 AM", new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d") },
                    { new Guid("5ace6de5-974d-7684-ab3a-2fdf88956762"), "Confirmed", new Guid("f774154c-4e4a-4a5f-d769-f094e08d73e6"), new Guid("9f71f26d-1bea-a600-c920-1c80f09d1740"), new DateTimeOffset(new DateTime(2020, 3, 16, 11, 9, 37, 19, DateTimeKind.Unspecified).AddTicks(6342), new TimeSpan(0, 7, 0, 0, 0)), new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), true, new DateTimeOffset(new DateTime(2020, 4, 23, 11, 52, 6, 400, DateTimeKind.Unspecified).AddTicks(5368), new TimeSpan(0, 7, 0, 0, 0)), 3, "8:00 PM", new Guid("7878f7dc-bd02-5290-3a26-8de4bc0e493e") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("626c93e6-3369-85ef-5ab9-0a53b0f5a847"), "Confirmed", new Guid("85c7be28-3ba8-977e-a626-54f8f5964a2b"), new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new DateTimeOffset(new DateTime(2020, 7, 7, 6, 1, 11, 341, DateTimeKind.Unspecified).AddTicks(1641), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), new DateTimeOffset(new DateTime(2020, 5, 10, 20, 52, 37, 915, DateTimeKind.Unspecified).AddTicks(4484), new TimeSpan(0, 7, 0, 0, 0)), 1, "3:00 PM", new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("66fd29a8-66c5-6282-26cd-de04085c7b99"), "Confirmed", new Guid("c86c892d-3011-bfe7-3a4b-ce7101f5eece"), new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"), new DateTimeOffset(new DateTime(2020, 2, 17, 6, 19, 4, 667, DateTimeKind.Unspecified).AddTicks(9922), new TimeSpan(0, 7, 0, 0, 0)), new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), true, new DateTimeOffset(new DateTime(2020, 11, 26, 18, 38, 26, 979, DateTimeKind.Unspecified).AddTicks(6726), new TimeSpan(0, 7, 0, 0, 0)), 4, "1:00 PM", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("6d1eab15-d275-d365-3d5c-153a9787de8d"), "Completed", new Guid("f774154c-4e4a-4a5f-d769-f094e08d73e6"), new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new DateTimeOffset(new DateTime(2020, 10, 31, 8, 24, 2, 344, DateTimeKind.Unspecified).AddTicks(9299), new TimeSpan(0, 7, 0, 0, 0)), new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), new DateTimeOffset(new DateTime(2020, 9, 10, 11, 40, 2, 824, DateTimeKind.Unspecified).AddTicks(6583), new TimeSpan(0, 7, 0, 0, 0)), 3, "12:00 PM", new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("ac0bab7a-1e5f-3f9b-2bcd-52f09e51d49e"), "Completed", new Guid("da46d4f4-4577-fb00-969b-e0dfb77ed0ff"), new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"), new DateTimeOffset(new DateTime(2020, 9, 4, 4, 8, 10, 654, DateTimeKind.Unspecified).AddTicks(210), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"), true, new DateTimeOffset(new DateTime(2020, 5, 17, 1, 27, 42, 136, DateTimeKind.Unspecified).AddTicks(8597), new TimeSpan(0, 7, 0, 0, 0)), 3, "10:00 AM", new Guid("f880aa64-7561-7503-de83-7f97fc4ce8a5") },
                    { new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"), "Confirmed", new Guid("de4ff2b1-a48b-873f-c7ca-08f63404c6ce"), new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"), new DateTimeOffset(new DateTime(2020, 7, 18, 18, 52, 51, 993, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f24616bd-e6a9-6c93-6269-33ef855ab90a"), true, new DateTimeOffset(new DateTime(2020, 3, 9, 16, 43, 9, 190, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 7, 0, 0, 0)), 2, "10:00 AM", new Guid("606f1107-4340-3d79-81f8-5d8b09c12c47") },
                    { new Guid("ce3fb385-7d3e-ec86-a0c0-8cc4d7a942e5"), "Confirmed", new Guid("92e3d544-7624-48a7-8558-e2cf0def022a"), new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"), new DateTimeOffset(new DateTime(2020, 12, 9, 11, 5, 6, 37, DateTimeKind.Unspecified).AddTicks(2375), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d40d725e-c366-8b4f-8503-1295b3ba6483"), true, new DateTimeOffset(new DateTime(2020, 8, 9, 7, 18, 24, 154, DateTimeKind.Unspecified).AddTicks(581), new TimeSpan(0, 7, 0, 0, 0)), 1, "5:00 PM", new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[,]
                {
                    { new Guid("d2ad0877-4ee9-28cd-95df-80ffff977fca"), "Cancelled", new Guid("f0bc8bcb-9c50-1a09-e65f-56c571a1badf"), new Guid("c9945bcd-5515-8954-f74e-1337084c237e"), new DateTimeOffset(new DateTime(2020, 10, 17, 8, 33, 56, 721, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"), new DateTimeOffset(new DateTime(2020, 10, 25, 15, 18, 43, 995, DateTimeKind.Unspecified).AddTicks(1361), new TimeSpan(0, 7, 0, 0, 0)), 4, "9:00 PM", new Guid("40059f0b-1d19-9002-1e10-8a95bc55cb73") },
                    { new Guid("e018f5a7-9b7e-0252-b062-f68e93af65c0"), "Confirmed", new Guid("122899aa-bb86-c8b7-29dc-92551068fe1b"), new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"), new DateTimeOffset(new DateTime(2020, 3, 10, 11, 6, 7, 168, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 7, 0, 0, 0)), new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"), new DateTimeOffset(new DateTime(2020, 11, 12, 4, 59, 22, 12, DateTimeKind.Unspecified).AddTicks(2576), new TimeSpan(0, 7, 0, 0, 0)), 1, "6:00 PM", new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d") },
                    { new Guid("eceb7e38-e994-eb98-0c68-69eca2e641f6"), "Confirmed", new Guid("bc12e381-9af1-1ac4-c15e-a986da5b57bd"), new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"), new DateTimeOffset(new DateTime(2020, 6, 16, 9, 38, 6, 363, DateTimeKind.Unspecified).AddTicks(5150), new TimeSpan(0, 7, 0, 0, 0)), new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), new DateTimeOffset(new DateTime(2020, 1, 12, 17, 15, 23, 855, DateTimeKind.Unspecified).AddTicks(9848), new TimeSpan(0, 7, 0, 0, 0)), 2, "2:00 PM", new Guid("f0873793-18d6-4a84-5a2e-46f599ad27f6") },
                    { new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1"), "Completed", new Guid("7b30d717-a76c-5e6e-81be-4dcf0abad890"), new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"), new DateTimeOffset(new DateTime(2020, 6, 23, 20, 31, 6, 504, DateTimeKind.Unspecified).AddTicks(6291), new TimeSpan(0, 7, 0, 0, 0)), new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"), new DateTimeOffset(new DateTime(2020, 12, 6, 15, 26, 37, 758, DateTimeKind.Unspecified).AddTicks(1670), new TimeSpan(0, 7, 0, 0, 0)), 2, "1:00 PM", new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f") }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("208bf680-2b14-3712-d52d-64d485abd589"), 40.994665897914520m, new Guid("c9945bcd-5515-8954-f74e-1337084c237e"), "Indoor", new DateTimeOffset(new DateTime(2020, 7, 12, 8, 29, 34, 78, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 7, 0, 0, 0)), 38.810013639186520m, new DateTimeOffset(new DateTime(2020, 8, 22, 14, 2, 51, 750, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 7, 0, 0, 0)), 43.817405139011040m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"), 12.9962871237640680m, new Guid("4d5ace6d-8497-ab76-3a2f-df88956762d3"), "Outdoor", new DateTimeOffset(new DateTime(2020, 9, 17, 12, 39, 7, 938, DateTimeKind.Unspecified).AddTicks(2816), new TimeSpan(0, 7, 0, 0, 0)), 28.152758226801080m, true, new DateTimeOffset(new DateTime(2020, 3, 3, 8, 13, 52, 588, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, 7, 0, 0, 0)), 21.987886229524320m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), 37.724649434781000m, new Guid("87973a15-8dde-6aed-3a99-5add4e83275c"), "Outdoor", new DateTimeOffset(new DateTime(2020, 3, 12, 19, 30, 16, 373, DateTimeKind.Unspecified).AddTicks(1082), new TimeSpan(0, 7, 0, 0, 0)), 13.9614699426859000m, new DateTimeOffset(new DateTime(2020, 10, 11, 7, 47, 8, 409, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, 7, 0, 0, 0)), 10.3490912357108160m },
                    { new Guid("6cbda0e8-a72b-72d6-050a-8f8922cd5b94"), 35.340576574830600m, new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"), "Indoor", new DateTimeOffset(new DateTime(2020, 8, 31, 13, 55, 4, 355, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 7, 0, 0, 0)), 34.046689674279960m, new DateTimeOffset(new DateTime(2020, 1, 1, 19, 13, 11, 383, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 7, 0, 0, 0)), 39.596232357246920m },
                    { new Guid("835381de-6fb1-580a-350e-f0f5e74a7565"), 12.8020571185285480m, new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"), "Indoor", new DateTimeOffset(new DateTime(2020, 4, 13, 17, 1, 0, 884, DateTimeKind.Unspecified).AddTicks(3627), new TimeSpan(0, 7, 0, 0, 0)), 46.640321219638160m, new DateTimeOffset(new DateTime(2020, 2, 24, 21, 38, 22, 83, DateTimeKind.Unspecified).AddTicks(9488), new TimeSpan(0, 7, 0, 0, 0)), 46.205515934250080m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("8bccb0b9-fc46-b19c-0a0a-a2dc4995e1e4"), 25.507539238551400m, new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"), "Outdoor", new DateTimeOffset(new DateTime(2020, 4, 5, 2, 17, 42, 549, DateTimeKind.Unspecified).AddTicks(7961), new TimeSpan(0, 7, 0, 0, 0)), 34.991066933139720m, true, new DateTimeOffset(new DateTime(2020, 7, 6, 16, 41, 49, 314, DateTimeKind.Unspecified).AddTicks(9897), new TimeSpan(0, 7, 0, 0, 0)), 47.670037614959320m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("8f580d2b-c771-8dd8-e8e7-b59d321efac9"), 47.726941219403840m, new Guid("f62452d5-8c09-f356-f855-7eac442d01fb"), "Indoor", new DateTimeOffset(new DateTime(2020, 9, 16, 0, 17, 18, 289, DateTimeKind.Unspecified).AddTicks(5609), new TimeSpan(0, 7, 0, 0, 0)), 34.071711685541880m, new DateTimeOffset(new DateTime(2020, 12, 21, 5, 10, 51, 604, DateTimeKind.Unspecified).AddTicks(516), new TimeSpan(0, 7, 0, 0, 0)), 45.005459727256320m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("905da48a-b45a-2d81-dcd8-750729b4372c"), 35.609711811696040m, new Guid("9f71f26d-1bea-a600-c920-1c80f09d1740"), "Indoor", new DateTimeOffset(new DateTime(2020, 3, 25, 2, 2, 32, 631, DateTimeKind.Unspecified).AddTicks(2147), new TimeSpan(0, 7, 0, 0, 0)), 33.649506561294880m, true, new DateTimeOffset(new DateTime(2020, 5, 5, 0, 45, 40, 143, DateTimeKind.Unspecified).AddTicks(2959), new TimeSpan(0, 7, 0, 0, 0)), 25.749126270296560m },
                    { new Guid("93e6a9f2-626c-3369-ef85-5ab90a53b0f5"), 20.864807502769320m, new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), "Indoor", new DateTimeOffset(new DateTime(2020, 6, 11, 11, 41, 47, 844, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 7, 0, 0, 0)), 20.530045056031120m, true, new DateTimeOffset(new DateTime(2020, 12, 25, 13, 22, 30, 637, DateTimeKind.Unspecified).AddTicks(1409), new TimeSpan(0, 7, 0, 0, 0)), 11.6208441563047680m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"), 39.967427900977160m, new Guid("87973a15-8dde-6aed-3a99-5add4e83275c"), "Indoor", new DateTimeOffset(new DateTime(2020, 4, 7, 19, 48, 40, 196, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 7, 0, 0, 0)), 30.052292579809320m, new DateTimeOffset(new DateTime(2020, 7, 7, 22, 40, 45, 671, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, 7, 0, 0, 0)), 36.59738646196080m });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("b0645df7-a1a4-b5a1-3962-54ea94f627f5"), 21.273646024648880m, new Guid("bde38317-b552-659b-adce-d5fa148bef7b"), "Outdoor", new DateTimeOffset(new DateTime(2020, 12, 18, 22, 24, 38, 496, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 7, 0, 0, 0)), 20.116299991550080m, true, new DateTimeOffset(new DateTime(2020, 5, 2, 13, 44, 44, 1, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, 7, 0, 0, 0)), 29.728197259701880m },
                    { new Guid("ce272427-3313-d248-a829-fd66c5668262"), 10.6581440012241440m, new Guid("bde38317-b552-659b-adce-d5fa148bef7b"), "Outdoor", new DateTimeOffset(new DateTime(2020, 9, 13, 9, 59, 26, 471, DateTimeKind.Unspecified).AddTicks(5189), new TimeSpan(0, 7, 0, 0, 0)), 40.983452178064480m, true, new DateTimeOffset(new DateTime(2020, 7, 5, 14, 37, 40, 355, DateTimeKind.Unspecified).AddTicks(7921), new TimeSpan(0, 7, 0, 0, 0)), 20.940376040963640m }
                });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "ModifiedOnUtc", "MorningCost" },
                values: new object[,]
                {
                    { new Guid("e502f9c9-cf08-8911-95c5-40a761187ed5"), 45.647683830767720m, new Guid("4d5ace6d-8497-ab76-3a2f-df88956762d3"), "Outdoor", new DateTimeOffset(new DateTime(2020, 3, 4, 8, 32, 32, 852, DateTimeKind.Unspecified).AddTicks(7627), new TimeSpan(0, 7, 0, 0, 0)), 31.805057349524040m, new DateTimeOffset(new DateTime(2020, 3, 13, 19, 58, 27, 22, DateTimeKind.Unspecified).AddTicks(4382), new TimeSpan(0, 7, 0, 0, 0)), 13.5291591675622200m },
                    { new Guid("f5a7c23f-e018-9b7e-5202-b062f68e93af"), 43.7032401718680m, new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"), "Outdoor", new DateTimeOffset(new DateTime(2020, 9, 30, 22, 41, 15, 33, DateTimeKind.Unspecified).AddTicks(7936), new TimeSpan(0, 7, 0, 0, 0)), 38.567956252288040m, new DateTimeOffset(new DateTime(2020, 10, 4, 20, 1, 40, 911, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 7, 0, 0, 0)), 38.297106729958720m },
                    { new Guid("f608ca7f-8f54-ca59-a88e-37a92300d6a4"), 12.9113730615523520m, new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"), "Outdoor", new DateTimeOffset(new DateTime(2020, 3, 11, 17, 31, 40, 530, DateTimeKind.Unspecified).AddTicks(2693), new TimeSpan(0, 7, 0, 0, 0)), 22.618399473195160m, new DateTimeOffset(new DateTime(2020, 1, 6, 13, 50, 57, 171, DateTimeKind.Unspecified).AddTicks(5185), new TimeSpan(0, 7, 0, 0, 0)), 38.126331580861640m },
                    { new Guid("fba953a9-7f00-ad94-4550-9c544966eb7f"), 11.3860198861854240m, new Guid("f62452d5-8c09-f356-f855-7eac442d01fb"), "Indoor", new DateTimeOffset(new DateTime(2020, 6, 15, 17, 27, 56, 908, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 7, 0, 0, 0)), 22.339875089162920m, new DateTimeOffset(new DateTime(2020, 6, 16, 5, 20, 55, 722, DateTimeKind.Unspecified).AddTicks(2799), new TimeSpan(0, 7, 0, 0, 0)), 15.309891628711440m }
                });

            migrationBuilder.InsertData(
                table: "CourtYard",
                columns: new[] { "Id", "CourtGroupId", "CourtYardStatus", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "Name", "Type" },
                values: new object[] { new Guid("6dc2b651-86f7-3ca8-e646-80ed8168bd10"), new Guid("92e3d544-7624-48a7-8558-e2cf0def022a"), "Booked", new DateTimeOffset(new DateTime(2023, 7, 28, 23, 5, 2, 876, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 15, 17, 57, 46, 880, DateTimeKind.Unspecified).AddTicks(1531), new TimeSpan(0, 7, 0, 0, 0)), "et", "dignissimos" });

            migrationBuilder.InsertData(
                table: "DateCourtGroup",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "DateId", "IsClosed", "IsDeleted", "ModifiedOnUtc" },
                values: new object[,]
                {
                    { new Guid("22389678-518c-45e7-09eb-80f68b20142b"), new Guid("92e3d544-7624-48a7-8558-e2cf0def022a"), new DateTimeOffset(new DateTime(2023, 8, 7, 6, 23, 39, 906, DateTimeKind.Unspecified).AddTicks(9281), new TimeSpan(0, 7, 0, 0, 0)), new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), true, true, new DateTimeOffset(new DateTime(2023, 8, 6, 8, 52, 17, 15, DateTimeKind.Unspecified).AddTicks(3952), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8f54f608-ca59-8ea8-37a9-2300d6a4402f"), new Guid("92e3d544-7624-48a7-8558-e2cf0def022a"), new DateTimeOffset(new DateTime(2023, 9, 4, 6, 30, 35, 596, DateTimeKind.Unspecified).AddTicks(5274), new TimeSpan(0, 7, 0, 0, 0)), new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), false, false, new DateTimeOffset(new DateTime(2023, 7, 1, 2, 49, 52, 237, DateTimeKind.Unspecified).AddTicks(7768), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("3a6aed8d-5a99-4edd-8327-5c278eb6b17d"), 129.28m, new DateTimeOffset(new DateTime(2020, 4, 7, 14, 17, 44, 211, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 7, 0, 0, 0)), "Qui quam quia aspernatur quos saepe et sit laborum voluptatem.", true, new DateTimeOffset(new DateTime(2020, 12, 30, 17, 55, 58, 49, DateTimeKind.Unspecified).AddTicks(2201), new TimeSpan(0, 7, 0, 0, 0)), "labore", new Guid("40059f0b-1d19-9002-1e10-8a95bc55cb73"), new Guid("ac34660c-972b-71b6-5e72-0dd466c34f8b") },
                    { new Guid("5e9bf4a4-e003-baa5-4f70-00a7f0b154fd"), 213.94m, new DateTimeOffset(new DateTime(2020, 3, 7, 14, 16, 37, 541, DateTimeKind.Unspecified).AddTicks(3979), new TimeSpan(0, 7, 0, 0, 0)), "Qui totam commodi iusto fuga commodi eaque est asperiores.", true, new DateTimeOffset(new DateTime(2020, 6, 20, 8, 12, 9, 102, DateTimeKind.Unspecified).AddTicks(7311), new TimeSpan(0, 7, 0, 0, 0)), "voluptate", new Guid("f4b6b354-f64b-e238-6806-00f403e85ab4"), new Guid("69680ceb-a2ec-41e6-f64f-828aa45d905a") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "Id", "Amount", "CreatedOnUtc", "Description", "ModifiedOnUtc", "Status", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("93072c1f-dfb7-5c38-9a46-19abd61d8bdf"), 939.59m, new DateTimeOffset(new DateTime(2020, 2, 17, 13, 24, 59, 634, DateTimeKind.Unspecified).AddTicks(5223), new TimeSpan(0, 7, 0, 0, 0)), "Fugit et consectetur.", new DateTimeOffset(new DateTime(2020, 12, 19, 22, 37, 15, 310, DateTimeKind.Unspecified).AddTicks(2095), new TimeSpan(0, 7, 0, 0, 0)), "ipsam", new Guid("7878f7dc-bd02-5290-3a26-8de4bc0e493e"), new Guid("69680ceb-a2ec-41e6-f64f-828aa45d905a") },
                    { new Guid("b8961942-64a3-8d69-d7fd-c7c3cbcfc21c"), 432.17m, new DateTimeOffset(new DateTime(2020, 9, 27, 6, 31, 14, 987, DateTimeKind.Unspecified).AddTicks(7085), new TimeSpan(0, 7, 0, 0, 0)), "Inventore impedit non est modi debitis voluptas voluptates optio.", new DateTimeOffset(new DateTime(2020, 3, 8, 0, 1, 7, 440, DateTimeKind.Unspecified).AddTicks(2699), new TimeSpan(0, 7, 0, 0, 0)), "error", new Guid("606f1107-4340-3d79-81f8-5d8b09c12c47"), new Guid("69680ceb-a2ec-41e6-f64f-828aa45d905a") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("072c1f41-b793-38df-5c9a-4619abd61d8b"), new Guid("92e3d544-7624-48a7-8558-e2cf0def022a"), new DateTimeOffset(new DateTime(2020, 12, 10, 22, 17, 30, 126, DateTimeKind.Unspecified).AddTicks(4141), new TimeSpan(0, 7, 0, 0, 0)), "http://paolo.org", new DateTimeOffset(new DateTime(2020, 11, 20, 2, 4, 19, 389, DateTimeKind.Unspecified).AddTicks(3563), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7bfb0e9a-450e-4de3-e61a-53cbbd200382") });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "CourtGroupId", "CreatedOnUtc", "IsDeleted", "MediaUrl", "ModifiedOnUtc", "UserId" },
                values: new object[] { new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"), new Guid("92e3d544-7624-48a7-8558-e2cf0def022a"), new DateTimeOffset(new DateTime(2020, 11, 11, 16, 5, 48, 103, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 7, 0, 0, 0)), true, "https://keely.com", new DateTimeOffset(new DateTime(2020, 3, 21, 18, 52, 52, 366, DateTimeKind.Unspecified).AddTicks(8117), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f12096d7-2697-2757-cded-e8d3504da036") });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("001bea9f-c9a6-1c20-80f0-9d1740b7b9b0"), new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"), new DateTimeOffset(new DateTime(2023, 8, 5, 0, 44, 14, 481, DateTimeKind.Unspecified).AddTicks(1420), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 11, 22, 3, 9, 714, DateTimeKind.Unspecified).AddTicks(5296), new TimeSpan(0, 7, 0, 0, 0)), "asperiores", "eos" },
                    { new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"), new Guid("87973a15-8dde-6aed-3a99-5add4e83275c"), new DateTimeOffset(new DateTime(2023, 12, 16, 22, 51, 21, 784, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 2, 18, 3, 48, 52, 319, DateTimeKind.Unspecified).AddTicks(5819), new TimeSpan(0, 7, 0, 0, 0)), "architecto", "blanditiis" },
                    { new Guid("3aab7684-df2f-9588-6762-d36d43591ec6"), new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"), new DateTimeOffset(new DateTime(2024, 4, 23, 17, 1, 54, 96, DateTimeKind.Unspecified).AddTicks(5422), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 22, 2, 20, 58, 902, DateTimeKind.Unspecified).AddTicks(8210), new TimeSpan(0, 7, 0, 0, 0)), "autem", "est" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("580a6fb1-0e35-f5f0-e74a-756503f84a7c"), new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"), new DateTimeOffset(new DateTime(2023, 11, 10, 18, 13, 48, 892, DateTimeKind.Unspecified).AddTicks(1040), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 13, 22, 9, 17, 328, DateTimeKind.Unspecified).AddTicks(8148), new TimeSpan(0, 7, 0, 0, 0)), "porro", "pariatur" },
                    { new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436"), new Guid("c9945bcd-5515-8954-f74e-1337084c237e"), new DateTimeOffset(new DateTime(2023, 7, 6, 15, 53, 14, 484, DateTimeKind.Unspecified).AddTicks(2030), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 11, 2, 13, 41, 372, DateTimeKind.Unspecified).AddTicks(9054), new TimeSpan(0, 7, 0, 0, 0)), "ratione", "deleniti" }
                });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("9db5e7e8-1e32-c9fa-fc05-d4975ed3d849"), new Guid("f62452d5-8c09-f356-f855-7eac442d01fb"), new DateTimeOffset(new DateTime(2023, 8, 17, 11, 0, 12, 860, DateTimeKind.Unspecified).AddTicks(3966), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 25, 23, 14, 4, 360, DateTimeKind.Unspecified).AddTicks(1116), new TimeSpan(0, 7, 0, 0, 0)), "praesentium", "quis" },
                    { new Guid("dd5a993a-834e-5c27-278e-b6b17d3ef20f"), new Guid("c9945bcd-5515-8954-f74e-1337084c237e"), new DateTimeOffset(new DateTime(2024, 1, 24, 11, 33, 22, 644, DateTimeKind.Unspecified).AddTicks(4806), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 2, 28, 0, 11, 37, 451, DateTimeKind.Unspecified).AddTicks(449), new TimeSpan(0, 7, 0, 0, 0)), "ut", "qui" },
                    { new Guid("ef5f70fc-2ced-ad0e-dc74-db7688646ffd"), new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"), new DateTimeOffset(new DateTime(2024, 5, 8, 19, 41, 36, 988, DateTimeKind.Unspecified).AddTicks(2250), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 11, 20, 16, 58, 18, 931, DateTimeKind.Unspecified).AddTicks(1264), new TimeSpan(0, 7, 0, 0, 0)), "perspiciatis", "repellat" }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("0b40e562-d9b5-504a-8985-07682b0d588f"), new Guid("ae048d35-c736-60ca-1a03-998417fd2e0d"), new DateTimeOffset(new DateTime(2023, 9, 27, 14, 56, 54, 232, DateTimeKind.Unspecified).AddTicks(4977), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 6, 10, 0, 31, 45, 461, DateTimeKind.Unspecified).AddTicks(8067), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d") },
                    { new Guid("15c913df-778a-5837-5d13-48652553d7ec"), new Guid("a7b0d962-3624-666a-0cbf-75043eb4b476"), new DateTimeOffset(new DateTime(2024, 3, 22, 1, 31, 31, 280, DateTimeKind.Unspecified).AddTicks(4681), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 7, 20, 26, 31, 736, DateTimeKind.Unspecified).AddTicks(3458), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8f54f608-ca59-8ea8-37a9-2300d6a4402f") },
                    { new Guid("2cedef5f-ad0e-74dc-db76-88646ffd2dc4"), new Guid("ccc57fd8-e27d-6983-aaa4-108d4d026f58"), new DateTimeOffset(new DateTime(2023, 11, 20, 16, 58, 18, 946, DateTimeKind.Unspecified).AddTicks(9089), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 22, 20, 23, 28, 817, DateTimeKind.Unspecified).AddTicks(7033), new TimeSpan(0, 7, 0, 0, 0)), new Guid("76b4b43e-6bbc-a7f7-1f4c-4773aee30c10") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("2dd53712-d464-ab85-d589-e18ec580c88b"), new Guid("ab3f9f75-a438-4eaa-b47f-55421996b8a3"), new DateTimeOffset(new DateTime(2023, 12, 6, 14, 2, 48, 872, DateTimeKind.Unspecified).AddTicks(93), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 14, 2, 17, 34, 78, DateTimeKind.Unspecified).AddTicks(6147), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d6df8b1d-8747-fa6f-5d3f-efbb55f9f750") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("33c32f2c-6294-2427-27ce-133348d2a829"), new Guid("9e3042aa-dfdd-c913-158a-7737585d1348"), new DateTimeOffset(new DateTime(2023, 11, 2, 9, 44, 50, 555, DateTimeKind.Unspecified).AddTicks(9129), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 3, 19, 8, 32, 7, 531, DateTimeKind.Unspecified).AddTicks(6584), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("41cd8dba-2c1f-9307-b7df-385c9a4619ab"), new Guid("b4b81d50-7f7d-7aa3-d24f-0319ce64c757"), new DateTimeOffset(new DateTime(2023, 10, 27, 16, 34, 30, 366, DateTimeKind.Unspecified).AddTicks(3334), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 4, 4, 13, 38, 814, DateTimeKind.Unspecified).AddTicks(9038), new TimeSpan(0, 7, 0, 0, 0)), new Guid("76b4b43e-6bbc-a7f7-1f4c-4773aee30c10") },
                    { new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"), new Guid("a4d60023-2f40-602b-ee79-b453e39036df"), new DateTimeOffset(new DateTime(2023, 7, 5, 7, 17, 37, 53, DateTimeKind.Unspecified).AddTicks(701), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 23, 6, 19, 13, 334, DateTimeKind.Unspecified).AddTicks(1933), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a72b6cbd-72d6-0a05-8f89-22cd5b94c915") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"), new DateTimeOffset(new DateTime(2024, 5, 8, 15, 50, 10, 431, DateTimeKind.Unspecified).AddTicks(1236), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 5, 19, 43, 31, 725, DateTimeKind.Unspecified).AddTicks(116), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b6de451c-9052-53a9-a9fb-007f94ad4550") },
                    { new Guid("72ff2f81-65bc-ae2b-5287-501db8b47d7f"), new Guid("38dfb793-9a5c-1946-abd6-1d8bdfd64787"), new DateTimeOffset(new DateTime(2023, 10, 30, 11, 52, 19, 361, DateTimeKind.Unspecified).AddTicks(8224), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 10, 4, 18, 33, 664, DateTimeKind.Unspecified).AddTicks(5831), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8b3ca5cc-36b0-5822-4367-619baa649fd9") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"), new Guid("a7b0d962-3624-666a-0cbf-75043eb4b476"), new DateTimeOffset(new DateTime(2024, 2, 29, 8, 36, 32, 963, DateTimeKind.Unspecified).AddTicks(2299), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 10, 28, 25, 809, DateTimeKind.Unspecified).AddTicks(7433), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5") },
                    { new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"), new Guid("09f62452-568c-f8f3-557e-ac442d01fb2b"), new DateTimeOffset(new DateTime(2023, 8, 26, 20, 34, 13, 931, DateTimeKind.Unspecified).AddTicks(1639), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 15, 19, 7, 27, 248, DateTimeKind.Unspecified).AddTicks(370), new TimeSpan(0, 7, 0, 0, 0)), new Guid("67eba435-40d1-7d65-5050-c5b9bd58e5e1") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3"), new DateTimeOffset(new DateTime(2023, 10, 1, 21, 3, 0, 730, DateTimeKind.Unspecified).AddTicks(2184), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 23, 23, 11, 32, 211, DateTimeKind.Unspecified).AddTicks(4888), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8f54f608-ca59-8ea8-37a9-2300d6a4402f") },
                    { new Guid("97581a8f-780f-3896-228c-51e74509eb80"), new Guid("ae048d35-c736-60ca-1a03-998417fd2e0d"), new DateTimeOffset(new DateTime(2024, 3, 22, 6, 40, 3, 137, DateTimeKind.Unspecified).AddTicks(5540), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 22, 10, 54, 46, 758, DateTimeKind.Unspecified).AddTicks(7860), new TimeSpan(0, 7, 0, 0, 0)), new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab") },
                    { new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"), new Guid("9e3042aa-dfdd-c913-158a-7737585d1348"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 23, 33, 570, DateTimeKind.Unspecified).AddTicks(9600), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 10, 26, 2, 43, 39, 75, DateTimeKind.Unspecified).AddTicks(6521), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5") },
                    { new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"), new Guid("9dd66981-6e49-6357-a37c-45fb1f8ba41e"), new DateTimeOffset(new DateTime(2023, 11, 19, 5, 50, 12, 35, DateTimeKind.Unspecified).AddTicks(5738), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 1, 17, 11, 17, 9, 590, DateTimeKind.Unspecified).AddTicks(2910), new TimeSpan(0, 7, 0, 0, 0)), new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("c962b121-02f9-08e5-cf11-8995c540a761"), new Guid("e64313d8-a4a2-a0e8-bd6c-2ba7d672050a"), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 3, 21, 814, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 24, 5, 58, 43, 2, DateTimeKind.Unspecified).AddTicks(4287), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d6df8b1d-8747-fa6f-5d3f-efbb55f9f750") },
                    { new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"), new Guid("b4b81d50-7f7d-7aa3-d24f-0319ce64c757"), new DateTimeOffset(new DateTime(2024, 2, 29, 13, 51, 13, 616, DateTimeKind.Unspecified).AddTicks(1113), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 3, 4, 4, 32, 291, DateTimeKind.Unspecified).AddTicks(7202), new TimeSpan(0, 7, 0, 0, 0)), new Guid("031a60ca-8499-fd17-2e0d-492832ad01cf") },
                    { new Guid("d40d725e-c366-8b4f-8503-1295b3ba6483"), new Guid("d718edc2-e562-0b40-b5d9-4a5089850768"), new DateTimeOffset(new DateTime(2023, 10, 4, 22, 5, 34, 599, DateTimeKind.Unspecified).AddTicks(6729), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 10, 17, 26, 43, 176, DateTimeKind.Unspecified).AddTicks(4363), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"), new Guid("fad5cead-8b14-7bef-2fa2-d996de815383"), new DateTimeOffset(new DateTime(2024, 6, 23, 6, 47, 14, 939, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 10, 17, 23, 37, 57, 749, DateTimeKind.Unspecified).AddTicks(5092), new TimeSpan(0, 7, 0, 0, 0)), new Guid("dca20a0a-9549-e4e1-78b1-99327e3ac5e0") },
                    { new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"), new Guid("b5a1a1a4-6239-ea54-94f6-27f5d5eee010"), new DateTimeOffset(new DateTime(2023, 12, 25, 6, 30, 19, 969, DateTimeKind.Unspecified).AddTicks(6328), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 15, 22, 45, 29, 637, DateTimeKind.Unspecified).AddTicks(5351), new TimeSpan(0, 7, 0, 0, 0)), new Guid("51c657c7-c2b6-f76d-86a8-3ce64680ed81") },
                    { new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"), new Guid("581a8ff7-0f97-9678-3822-8c51e74509eb"), new DateTimeOffset(new DateTime(2023, 8, 5, 12, 54, 38, 868, DateTimeKind.Unspecified).AddTicks(472), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 6, 16, 34, 47, 468, DateTimeKind.Unspecified).AddTicks(4672), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7fd8b31a-ccc5-e27d-8369-aaa4108d4d02") },
                    { new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"), new Guid("ab85d464-89d5-8ee1-c580-c88b39bc2da6"), new DateTimeOffset(new DateTime(2024, 1, 3, 11, 59, 22, 305, DateTimeKind.Unspecified).AddTicks(6361), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 2, 21, 18, 49, 30, 989, DateTimeKind.Unspecified).AddTicks(2682), new TimeSpan(0, 7, 0, 0, 0)), new Guid("22389678-518c-45e7-09eb-80f68b20142b") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84"), 939.44m, new Guid("bf3af6cf-1c49-d45e-0f73-96b51c2c318c"), new DateTimeOffset(new DateTime(2020, 6, 7, 22, 38, 2, 599, DateTimeKind.Unspecified).AddTicks(1503), new TimeSpan(0, 7, 0, 0, 0)), new Guid("49d8d35e-7c9f-8de0-1783-e3bd52b59b65"), "Nulla nobis et ut ut non ut sit suscipit.", new DateTimeOffset(new DateTime(2020, 12, 31, 22, 35, 20, 689, DateTimeKind.Unspecified).AddTicks(7086), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("3b18d343-2ea5-4803-3f37-73c3e7b57871"), new Guid("2cc304c0-f65d-fe35-7c8d-3740a4699010") },
                    { new Guid("1e5fac0b-3f9b-cd2b-52f0-9e51d49ea805"), 926.13m, new Guid("aaa438ab-b44e-557f-4219-96b8a364698d"), new DateTimeOffset(new DateTime(2020, 12, 2, 7, 59, 45, 228, DateTimeKind.Unspecified).AddTicks(5519), new TimeSpan(0, 7, 0, 0, 0)), new Guid("ee602b2f-b479-e353-9036-dfc79c18976a"), "Fuga quaerat sit laudantium id.", new DateTimeOffset(new DateTime(2020, 4, 14, 1, 24, 6, 981, DateTimeKind.Unspecified).AddTicks(1165), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4"), new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("33c32f2c-6294-2427-27ce-133348d2a829"), 285.17m, new Guid("7b5c0804-9799-0f69-47fb-03e9ce3b6577"), new DateTimeOffset(new DateTime(2020, 7, 10, 3, 49, 13, 370, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9cfc468b-0ab1-a20a-dc49-95e1e478b199"), "Ad sit est.", true, new DateTimeOffset(new DateTime(2020, 12, 7, 18, 11, 18, 178, DateTimeKind.Unspecified).AddTicks(1665), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25"), new Guid("d405fcc9-5e97-d8d3-499f-7ce08d1783e3") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("49430def-902d-1b4e-f151-a934225bb3f4"), 686.03m, new Guid("d365d275-5c3d-3a15-9787-de8ded6a3a99"), new DateTimeOffset(new DateTime(2020, 4, 24, 14, 31, 53, 904, DateTimeKind.Unspecified).AddTicks(3217), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f2cebdf5-d86e-8d84-04bd-66760f9121b1"), "Consequatur expedita quidem doloremque libero.", new DateTimeOffset(new DateTime(2020, 9, 14, 23, 41, 43, 347, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("8026a67e-3b61-fd8d-5241-408b6939c3a4"), new Guid("ac34660c-972b-71b6-5e72-0dd466c34f8b") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("4bf4b6b3-38f6-68e2-0600-f403e85ab410"), 154.27m, new Guid("b51df14c-3a1c-6aa4-7d9f-822ac2eed94c"), new DateTimeOffset(new DateTime(2020, 9, 21, 10, 22, 54, 680, DateTimeKind.Unspecified).AddTicks(954), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7feb6649-70fc-ef5f-ed2c-0eaddc74db76"), "Ut sunt eum.", true, new DateTimeOffset(new DateTime(2020, 4, 10, 19, 1, 41, 312, DateTimeKind.Unspecified).AddTicks(8063), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("f0873793-18d6-4a84-5a2e-46f599ad27f6"), new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("64bab395-4983-0935-22c2-f8b165959980"), 295.96m, new Guid("f5a7c23f-e018-9b7e-5202-b062f68e93af"), new DateTimeOffset(new DateTime(2020, 4, 17, 1, 57, 19, 303, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6de550f7-5ace-974d-8476-ab3a2fdf8895"), "Molestias consectetur laboriosam voluptates.", new DateTimeOffset(new DateTime(2020, 2, 27, 14, 46, 6, 449, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 7, 0, 0, 0)), "Cancelled", new Guid("99b466ff-4c41-07d6-7020-a9f28b403607"), new Guid("602b2f40-79ee-53b4-e390-36dfc79c1897") },
                    { new Guid("6d302f06-2a8e-f29a-8b4d-cda18c19b674"), 650.03m, new Guid("9b073640-dd34-cea5-c3ba-2cd8cece56fc"), new DateTimeOffset(new DateTime(2020, 1, 20, 15, 0, 44, 418, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e4e3def4-b2a1-c4a3-49f8-a662fe7e5157"), "Autem enim ipsa.", new DateTimeOffset(new DateTime(2020, 1, 30, 0, 59, 49, 871, DateTimeKind.Unspecified).AddTicks(4574), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("dae37e73-50c0-d5c8-97c6-5a7041370998"), new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f") },
                    { new Guid("8ea9a6ab-4020-b531-efaa-0b5dcff3688d"), 340.21m, new Guid("18a6ddb1-a192-09d2-4383-93efd0ca3d58"), new DateTimeOffset(new DateTime(2020, 3, 16, 17, 53, 14, 337, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 7, 0, 0, 0)), new Guid("94ea5462-27f6-d5f5-eee0-105eca808b3b"), "Cum nemo ducimus eligendi.", new DateTimeOffset(new DateTime(2020, 4, 8, 6, 59, 58, 723, DateTimeKind.Unspecified).AddTicks(6021), new TimeSpan(0, 7, 0, 0, 0)), "Confirmed", new Guid("360f39a0-9ef3-42c7-47d5-608af0d59ff4"), new Guid("69680ceb-a2ec-41e6-f64f-828aa45d905a") },
                    { new Guid("d31c4457-74c3-ad4a-6e5d-d27963c16e2a"), 245.19m, new Guid("96997b4e-c94f-f6e3-cea9-307486cf393f"), new DateTimeOffset(new DateTime(2020, 10, 1, 8, 52, 42, 524, DateTimeKind.Unspecified).AddTicks(6167), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a9d7c48c-e542-6100-d98e-dd9402ebd05d"), "Non dolores qui qui in aut sequi a.", new DateTimeOffset(new DateTime(2020, 6, 24, 13, 47, 21, 814, DateTimeKind.Unspecified).AddTicks(4889), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("7bfb0e9a-450e-4de3-e61a-53cbbd200382"), new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("df7c5d15-2500-c7ae-6439-d5b0dd579f03"), 275.58m, new Guid("a147e5b6-1409-7309-52d3-3334fea5f3e3"), new DateTimeOffset(new DateTime(2020, 12, 20, 14, 27, 14, 741, DateTimeKind.Unspecified).AddTicks(802), new TimeSpan(0, 7, 0, 0, 0)), new Guid("36b08b3c-5822-6743-619b-aa649fd9f78f"), "Qui deleniti porro.", true, new DateTimeOffset(new DateTime(2020, 1, 13, 18, 20, 4, 308, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("779c3b8b-7dec-380d-7eeb-ec94e998eb0c"), new Guid("c550507d-bdb9-e558-e1a4-45366631090c") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("fa4d9d8d-bfba-b0e0-5817-0205f5910bf9"), 523.05m, new Guid("a3fba1d5-1e52-9f33-be65-269180b8aaf5"), new DateTimeOffset(new DateTime(2020, 4, 6, 1, 39, 0, 120, DateTimeKind.Unspecified).AddTicks(3481), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b50b40e5-4ad9-8950-8507-682b0d588f71"), "Aut beatae ipsam amet et doloribus ullam et iusto.", new DateTimeOffset(new DateTime(2020, 1, 22, 9, 1, 9, 820, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("9588df2f-6267-6dd3-4359-1ec672055d47"), new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3") });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingStatus", "CourtGroupId", "CourtYardId", "CreatedOnUtc", "DateId", "IsDeleted", "ModifiedOnUtc", "NumberOfPlayers", "TimeRange", "UserId" },
                values: new object[] { new Guid("fadc6e80-d9f3-b790-2e46-a870e9198a1a"), "Completed", new Guid("cf7d3633-3eee-94eb-b598-83a5ac711802"), new Guid("6dc2b651-86f7-3ca8-e646-80ed8168bd10"), new DateTimeOffset(new DateTime(2020, 11, 14, 21, 38, 7, 950, DateTimeKind.Unspecified).AddTicks(484), new TimeSpan(0, 7, 0, 0, 0)), new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"), true, new DateTimeOffset(new DateTime(2020, 10, 7, 13, 2, 57, 632, DateTimeKind.Unspecified).AddTicks(5594), new TimeSpan(0, 7, 0, 0, 0)), 3, "5:00 PM", new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592") });

            migrationBuilder.InsertData(
                table: "Cost",
                columns: new[] { "Id", "Afternoon", "CourtYardId", "CourtYardType", "CreatedOnUtc", "EveningCost", "IsDeleted", "ModifiedOnUtc", "MorningCost" },
                values: new object[] { new Guid("3d5d14e4-3fcc-7089-9fe4-9d676b30922d"), 29.82647133051720m, new Guid("6dc2b651-86f7-3ca8-e646-80ed8168bd10"), "Indoor", new DateTimeOffset(new DateTime(2020, 10, 9, 1, 5, 9, 814, DateTimeKind.Unspecified).AddTicks(6427), new TimeSpan(0, 7, 0, 0, 0)), 46.16956572801320m, true, new DateTimeOffset(new DateTime(2020, 1, 6, 21, 1, 13, 733, DateTimeKind.Unspecified).AddTicks(4917), new TimeSpan(0, 7, 0, 0, 0)), 25.657718524177440m });

            migrationBuilder.InsertData(
                table: "Slot",
                columns: new[] { "Id", "CourtYardId", "CreatedOnUtc", "ModifiedOnUtc", "SlotName", "Status" },
                values: new object[,]
                {
                    { new Guid("1203858b-b395-64ba-8349-350922c2f8b1"), new Guid("6dc2b651-86f7-3ca8-e646-80ed8168bd10"), new DateTimeOffset(new DateTime(2023, 7, 24, 5, 42, 58, 619, DateTimeKind.Unspecified).AddTicks(4922), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 29, 6, 10, 19, 485, DateTimeKind.Unspecified).AddTicks(5478), new TimeSpan(0, 7, 0, 0, 0)), "perspiciatis", "rerum" },
                    { new Guid("3a51ce71-ab15-6d1e-75d2-65d33d5c153a"), new Guid("6dc2b651-86f7-3ca8-e646-80ed8168bd10"), new DateTimeOffset(new DateTime(2023, 11, 30, 15, 48, 47, 516, DateTimeKind.Unspecified).AddTicks(8646), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 6, 0, 16, 51, 26, DateTimeKind.Unspecified).AddTicks(5701), new TimeSpan(0, 7, 0, 0, 0)), "omnis", "sapiente" }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"), new Guid("5ace6de5-974d-7684-ab3a-2fdf88956762"), new DateTimeOffset(new DateTime(2024, 6, 6, 22, 10, 49, 545, DateTimeKind.Unspecified).AddTicks(2237), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 13, 13, 26, 44, 381, DateTimeKind.Unspecified).AddTicks(1083), new TimeSpan(0, 7, 0, 0, 0)), new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"), new Guid("fad5cead-8b14-7bef-2fa2-d996de815383"), new DateTimeOffset(new DateTime(2023, 7, 17, 0, 22, 53, 577, DateTimeKind.Unspecified).AddTicks(6586), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 17, 9, 30, 1, 578, DateTimeKind.Unspecified).AddTicks(6115), new TimeSpan(0, 7, 0, 0, 0)), new Guid("37778a15-5d58-4813-6525-53d7ec3774d8") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"), new Guid("66fd29a8-66c5-6282-26cd-de04085c7b99"), new DateTimeOffset(new DateTime(2023, 10, 7, 5, 59, 55, 958, DateTimeKind.Unspecified).AddTicks(3157), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 19, 10, 37, 17, 157, DateTimeKind.Unspecified).AddTicks(9020), new TimeSpan(0, 7, 0, 0, 0)), new Guid("37778a15-5d58-4813-6525-53d7ec3774d8") },
                    { new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"), new Guid("66fd29a8-66c5-6282-26cd-de04085c7b99"), new DateTimeOffset(new DateTime(2023, 6, 27, 11, 18, 31, 364, DateTimeKind.Unspecified).AddTicks(8689), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 8, 15, 12, 1, 8, 207, DateTimeKind.Unspecified).AddTicks(9320), new TimeSpan(0, 7, 0, 0, 0)), new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"), new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"), new DateTimeOffset(new DateTime(2023, 11, 1, 3, 9, 26, 399, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 4, 8, 4, 51, 31, 197, DateTimeKind.Unspecified).AddTicks(3347), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("31663645-0c09-f634-73cd-57a9e98d762e"), new Guid("ce3fb385-7d3e-ec86-a0c0-8cc4d7a942e5"), new DateTimeOffset(new DateTime(2024, 5, 19, 18, 39, 33, 745, DateTimeKind.Unspecified).AddTicks(5281), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 2, 24, 20, 34, 11, 592, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8f54f608-ca59-8ea8-37a9-2300d6a4402f") },
                    { new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"), new Guid("38dfb793-9a5c-1946-abd6-1d8bdfd64787"), new DateTimeOffset(new DateTime(2023, 8, 17, 11, 0, 12, 876, DateTimeKind.Unspecified).AddTicks(2884), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 25, 23, 14, 4, 376, DateTimeKind.Unspecified).AddTicks(34), new TimeSpan(0, 7, 0, 0, 0)), new Guid("580a6fb1-0e35-f5f0-e74a-756503f84a7c") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"), new Guid("ae048d35-c736-60ca-1a03-998417fd2e0d"), new DateTimeOffset(new DateTime(2024, 2, 4, 5, 14, 31, 212, DateTimeKind.Unspecified).AddTicks(9473), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 19, 1, 32, 26, 421, DateTimeKind.Unspecified).AddTicks(6871), new TimeSpan(0, 7, 0, 0, 0)), new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"), new Guid("09354983-c222-b1f8-6595-99800ff98b29"), new DateTimeOffset(new DateTime(2023, 8, 2, 3, 49, 38, 421, DateTimeKind.Unspecified).AddTicks(2226), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 11, 12, 53, 54, 69, DateTimeKind.Unspecified).AddTicks(3786), new TimeSpan(0, 7, 0, 0, 0)), new Guid("001bea9f-c9a6-1c20-80f0-9d1740b7b9b0") },
                    { new Guid("586f024d-8980-f523-bdce-f26ed8848d04"), new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"), new DateTimeOffset(new DateTime(2024, 5, 20, 7, 2, 35, 396, DateTimeKind.Unspecified).AddTicks(456), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 9, 13, 4, 22, 11, 4, DateTimeKind.Unspecified).AddTicks(7121), new TimeSpan(0, 7, 0, 0, 0)), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("65d2756d-3dd3-155c-3a97-87de8ded6a3a"), new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"), new DateTimeOffset(new DateTime(2024, 3, 9, 12, 40, 38, 421, DateTimeKind.Unspecified).AddTicks(5938), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 7, 14, 5, 19, 17, 973, DateTimeKind.Unspecified).AddTicks(7424), new TimeSpan(0, 7, 0, 0, 0)), new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0") },
                    { new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"), new Guid("19aad1fe-5653-b064-e414-5d3dcc3f8970"), new DateTimeOffset(new DateTime(2024, 6, 21, 7, 48, 37, 115, DateTimeKind.Unspecified).AddTicks(4454), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 8, 27, 11, 29, 50, 465, DateTimeKind.Unspecified).AddTicks(215), new TimeSpan(0, 7, 0, 0, 0)), new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"), new Guid("626c93e6-3369-85ef-5ab9-0a53b0f5a847"), new DateTimeOffset(new DateTime(2023, 12, 22, 0, 31, 11, 160, DateTimeKind.Unspecified).AddTicks(6279), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 7, 20, 51, 45, 968, DateTimeKind.Unspecified).AddTicks(7838), new TimeSpan(0, 7, 0, 0, 0)), new Guid("22389678-518c-45e7-09eb-80f68b20142b") },
                    { new Guid("7ee018f5-529b-b002-62f6-8e93af65c0a8"), new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1"), new DateTimeOffset(new DateTime(2024, 3, 25, 11, 40, 10, 107, DateTimeKind.Unspecified).AddTicks(7590), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 29, 9, 0, 35, 984, DateTimeKind.Unspecified).AddTicks(9921), new TimeSpan(0, 7, 0, 0, 0)), new Guid("001bea9f-c9a6-1c20-80f0-9d1740b7b9b0") },
                    { new Guid("88df2f3a-6795-d362-6d43-591ec672055d"), new Guid("e018f5a7-9b7e-0252-b062-f68e93af65c0"), new DateTimeOffset(new DateTime(2024, 5, 14, 22, 52, 50, 729, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 28, 16, 9, 21, 577, DateTimeKind.Unspecified).AddTicks(4964), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6ef2cebd-84d8-048d-bd66-760f9121b162") },
                    { new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"), new Guid("19aad1fe-5653-b064-e414-5d3dcc3f8970"), new DateTimeOffset(new DateTime(2023, 11, 8, 10, 52, 33, 186, DateTimeKind.Unspecified).AddTicks(1183), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 4, 6, 42, 729, DateTimeKind.Unspecified).AddTicks(3300), new TimeSpan(0, 7, 0, 0, 0)), new Guid("37778a15-5d58-4813-6525-53d7ec3774d8") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"), new Guid("66fd29a8-66c5-6282-26cd-de04085c7b99"), new DateTimeOffset(new DateTime(2024, 1, 12, 20, 20, 27, 655, DateTimeKind.Unspecified).AddTicks(7839), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 26, 5, 5, 41, 326, DateTimeKind.Unspecified).AddTicks(9913), new TimeSpan(0, 7, 0, 0, 0)), new Guid("dd5a993a-834e-5c27-278e-b6b17d3ef20f") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"), new Guid("1f24a4b5-b43c-e7fa-3e27-961006086580"), new DateTimeOffset(new DateTime(2024, 1, 2, 5, 8, 43, 514, DateTimeKind.Unspecified).AddTicks(5199), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 8, 19, 12, 38, 557, DateTimeKind.Unspecified).AddTicks(6596), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fee56044-ba9d-cd8d-411f-2c0793b7df38") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("a951f11b-2234-b35b-f424-5420ad1a71ce"), new Guid("fad5cead-8b14-7bef-2fa2-d996de815383"), new DateTimeOffset(new DateTime(2023, 10, 28, 17, 22, 40, 835, DateTimeKind.Unspecified).AddTicks(3445), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 11, 5, 18, 59, 36, 938, DateTimeKind.Unspecified).AddTicks(1799), new TimeSpan(0, 7, 0, 0, 0)), new Guid("dd5a993a-834e-5c27-278e-b6b17d3ef20f") },
                    { new Guid("a99052b6-a953-00fb-7f94-ad45509c5449"), new Guid("b5a1a1a4-6239-ea54-94f6-27f5d5eee010"), new DateTimeOffset(new DateTime(2024, 5, 5, 20, 26, 26, 142, DateTimeKind.Unspecified).AddTicks(9523), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 7, 22, 55, 47, 147, DateTimeKind.Unspecified).AddTicks(9828), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3aab7684-df2f-9588-6762-d36d43591ec6") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"), new Guid("66fd29a8-66c5-6282-26cd-de04085c7b99"), new DateTimeOffset(new DateTime(2024, 2, 29, 21, 53, 28, 781, DateTimeKind.Unspecified).AddTicks(5907), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 27, 10, 35, 31, 228, DateTimeKind.Unspecified).AddTicks(4815), new TimeSpan(0, 7, 0, 0, 0)), new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0") },
                    { new Guid("c764ce19-c657-b651-c26d-f786a83ce646"), new Guid("eceb7e38-e994-eb98-0c68-69eca2e641f6"), new DateTimeOffset(new DateTime(2024, 4, 26, 3, 33, 5, 809, DateTimeKind.Unspecified).AddTicks(4133), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 24, 13, 38, 49, 219, DateTimeKind.Unspecified).AddTicks(4635), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fee56044-ba9d-cd8d-411f-2c0793b7df38") },
                    { new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"), new Guid("0775d8dc-b429-2c37-2ad5-ffa8623d5cea"), new DateTimeOffset(new DateTime(2024, 5, 21, 20, 31, 51, 108, DateTimeKind.Unspecified).AddTicks(2995), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 11, 9, 59, 25, 350, DateTimeKind.Unspecified).AddTicks(7141), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5") }
                });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"), new Guid("581a8ff7-0f97-9678-3822-8c51e74509eb"), new DateTimeOffset(new DateTime(2024, 5, 11, 0, 22, 1, 68, DateTimeKind.Unspecified).AddTicks(8586), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 16, 11, 36, 2, 27, DateTimeKind.Unspecified).AddTicks(9184), new TimeSpan(0, 7, 0, 0, 0)), new Guid("001bea9f-c9a6-1c20-80f0-9d1740b7b9b0") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("e7e2d28b-02d4-3311-7a1c-f2134f0c6634"), new Guid("19aad1fe-5653-b064-e414-5d3dcc3f8970"), new DateTimeOffset(new DateTime(2023, 8, 24, 11, 48, 9, 533, DateTimeKind.Unspecified).AddTicks(6811), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 10, 7, 47, 32, 631, DateTimeKind.Unspecified).AddTicks(9367), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cee903fb-653b-0877-add2-e94ecd2895df") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[,]
                {
                    { new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"), new Guid("ac0bab7a-1e5f-3f9b-2bcd-52f09e51d49e"), new DateTimeOffset(new DateTime(2023, 6, 29, 18, 46, 19, 870, DateTimeKind.Unspecified).AddTicks(1275), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2023, 12, 22, 3, 23, 21, 684, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, 7, 0, 0, 0)), new Guid("89d5ab85-8ee1-80c5-c88b-39bc2da6528d") },
                    { new Guid("f24616bd-e6a9-6c93-6269-33ef855ab90a"), new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"), new DateTimeOffset(new DateTime(2024, 5, 22, 11, 31, 52, 698, DateTimeKind.Unspecified).AddTicks(644), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 6, 10, 17, 2, 40, 517, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f052cd2b-519e-9ed4-a805-15b413c4587a") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("5b56ef22-52ec-d864-59e6-7c64aa80f861"), 828.96m, new Guid("951d01c8-0f73-33be-d62e-4dc85eed4438"), new DateTimeOffset(new DateTime(2020, 11, 23, 23, 19, 9, 617, DateTimeKind.Unspecified).AddTicks(4741), new TimeSpan(0, 7, 0, 0, 0)), new Guid("93072c1f-dfb7-5c38-9a46-19abd61d8bdf"), "Vero facere id asperiores placeat.", true, new DateTimeOffset(new DateTime(2020, 1, 24, 15, 50, 26, 832, DateTimeKind.Unspecified).AddTicks(5728), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("6b601e2a-fd75-5bb7-5be1-196ca9cff63a"), new Guid("a740c595-1861-d57e-5224-f6098c56f3f8") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("8d52a62d-d0a9-fe70-5e75-1ab3d87fc5cc"), 898.73m, new Guid("80586f02-2389-bdf5-cef2-6ed8848d04bd"), new DateTimeOffset(new DateTime(2020, 4, 22, 7, 40, 1, 142, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3a6aed8d-5a99-4edd-8327-5c278eb6b17d"), "Eum quasi eaque.", new DateTimeOffset(new DateTime(2020, 11, 25, 18, 3, 40, 322, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("6b17d449-6d47-ded4-42e8-91b1dda61892"), new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "IsDeleted", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("8e4ab0bb-8585-3fb3-ce3e-7d86eca0c08c"), 68.80m, new Guid("f3fadc6e-90d9-2eb7-46a8-70e9198a1a68"), new DateTimeOffset(new DateTime(2020, 3, 3, 15, 33, 50, 50, DateTimeKind.Unspecified).AddTicks(4111), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b8961942-64a3-8d69-d7fd-c7c3cbcfc21c"), "Ullam debitis deserunt tempora deserunt reprehenderit veritatis qui beatae consequatur.", true, new DateTimeOffset(new DateTime(2020, 12, 3, 1, 33, 14, 860, DateTimeKind.Unspecified).AddTicks(1406), new TimeSpan(0, 7, 0, 0, 0)), "Completed", new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc"), new Guid("d3626795-436d-1e59-c672-055d47c2ed18") });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "BookingId", "CreatedOnUtc", "DepositId", "Description", "ModifiedOnUtc", "TransactionStatus", "UserId", "WalletId" },
                values: new object[] { new Guid("e3958622-809c-11bd-a234-2663de9bee82"), 675.63m, new Guid("4e33388c-6ec3-d477-acb7-e3eb93b33828"), new DateTimeOffset(new DateTime(2020, 6, 20, 22, 39, 44, 122, DateTimeKind.Unspecified).AddTicks(356), new TimeSpan(0, 7, 0, 0, 0)), new Guid("5e9bf4a4-e003-baa5-4f70-00a7f0b154fd"), "Blanditiis nostrum tempore.", new DateTimeOffset(new DateTime(2020, 4, 15, 0, 6, 0, 32, DateTimeKind.Unspecified).AddTicks(2055), new TimeSpan(0, 7, 0, 0, 0)), "Pending", new Guid("b354e7ff-dc8e-00a4-4e16-dbdec031d490"), new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211") });

            migrationBuilder.InsertData(
                table: "SlotBooking",
                columns: new[] { "Id", "BookingId", "CreatedOnUtc", "IsDeleted", "ModifiedOnUtc", "SlotId" },
                values: new object[] { new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"), new Guid("fadc6e80-d9f3-b790-2e46-a870e9198a1a"), new DateTimeOffset(new DateTime(2023, 10, 6, 19, 32, 33, 412, DateTimeKind.Unspecified).AddTicks(2154), new TimeSpan(0, 7, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 6, 16, 8, 12, 26, 50, DateTimeKind.Unspecified).AddTicks(8382), new TimeSpan(0, 7, 0, 0, 0)), new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42") });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_SupervisorId",
                table: "ApplicationUser",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_ApplicationUser_SupervisorId",
                table: "ApplicationUser",
                column: "SupervisorId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_ApplicationUser_SupervisorId",
                table: "ApplicationUser");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUser_SupervisorId",
                table: "ApplicationUser");

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("0b40e562-d9b5-504a-8985-07682b0d588f"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("15c913df-778a-5837-5d13-48652553d7ec"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("2cedef5f-ad0e-74dc-db76-88646ffd2dc4"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("2dd53712-d464-ab85-d589-e18ec580c88b"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("31663645-0c09-f634-73cd-57a9e98d762e"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("33c32f2c-6294-2427-27ce-133348d2a829"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("41cd8dba-2c1f-9307-b7df-385c9a4619ab"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("586f024d-8980-f523-bdce-f26ed8848d04"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("65d2756d-3dd3-155c-3a97-87de8ded6a3a"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("72ff2f81-65bc-ae2b-5287-501db8b47d7f"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("7ee018f5-529b-b002-62f6-8e93af65c0a8"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("88df2f3a-6795-d362-6d43-591ec672055d"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("97581a8f-780f-3896-228c-51e74509eb80"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("a951f11b-2234-b35b-f424-5420ad1a71ce"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("a99052b6-a953-00fb-7f94-ad45509c5449"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("c764ce19-c657-b651-c26d-f786a83ce646"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("c962b121-02f9-08e5-cf11-8995c540a761"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("d40d725e-c366-8b4f-8503-1295b3ba6483"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("e7e2d28b-02d4-3311-7a1c-f2134f0c6634"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("f24616bd-e6a9-6c93-6269-33ef855ab90a"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"));

            migrationBuilder.DeleteData(
                table: "BookMark",
                keyColumn: "Id",
                keyValue: new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("0d197acc-619b-6d82-f271-9fea1b00a6c9"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("134ef789-0837-234c-7ee0-b56fdc085b8c"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("15d6a64d-3c92-41f9-295a-5fc931444a0a"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("1681fda1-3dfa-7e09-66c5-fd012c2fc333"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("1e329db5-c9fa-05fc-d497-5ed3d8499f7c"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("66bd048d-0f76-2191-b162-c9f902e508cf"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("6d1eab15-d275-d365-3d5c-153a9787de8d"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("7cfe35f6-378d-a440-6990-103e95537207"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("81ed8046-bd68-e210-e3d1-cca53c8bb036"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("b1b68e27-3e7d-0ff2-18e4-30ad7b7f4460"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("b6de451c-9052-53a9-a9fb-007f94ad4550"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("d2ad0877-4ee9-28cd-95df-80ffff977fca"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("f0a70070-54b1-e1fd-fc18-10a5ccb2341f"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("f8036575-7c4a-9583-1b2e-30d982d3e35c"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("072c1f41-b793-38df-5c9a-4619abd61d8b"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("09354983-c222-b1f8-6595-99800ff98b29"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("0d197acc-619b-6d82-f271-9fea1b00a6c9"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("208bf680-2b14-3712-d52d-64d485abd589"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("273ee7fa-1096-0806-6580-6035ad238abb"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("2d49430d-4e90-f11b-51a9-34225bb3f424"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("34660c4f-2bac-b697-715e-720dd466c34f"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("3d5d14e4-3fcc-7089-9fe4-9d676b30922d"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("4431c95f-0a4a-5661-fa39-ba2e69221baa"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("44ac7e55-012d-2bfb-510c-8e86863eeded"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("470f6997-03fb-cee9-3b65-7708add2e94e"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("519ef052-9ed4-05a8-15b4-13c4587a030c"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("586f024d-8980-f523-bdce-f26ed8848d04"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("6bbc76b4-a7f7-4c1f-4773-aee30c100642"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("6cbda0e8-a72b-72d6-050a-8f8922cd5b94"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("6d1eab15-d275-d365-3d5c-153a9787de8d"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("6e499dd6-6357-7ca3-45fb-1f8ba41e25e0"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("76db74dc-6488-fd6f-2dc4-98c6ecbda3e5"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("835381de-6fb1-580a-350e-f0f5e74a7565"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("8752ae2b-1d50-b4b8-7d7f-a37ad24f0319"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("8bccb0b9-fc46-b19c-0a0a-a2dc4995e1e4"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("8d52a62d-d0a9-fe70-5e75-1ab3d87fc5cc"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("8de07c9f-8317-bde3-52b5-9b65adced5fa"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("8f580d2b-c771-8dd8-e8e7-b59d321efac9"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("905da48a-b45a-2d81-dcd8-750729b4372c"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("93e6a9f2-626c-3369-ef85-5ab90a53b0f5"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("9ec7cf01-d42c-fda1-8116-fa3d097e66c5"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("a886f76d-e63c-8046-ed81-68bd10e2e3d1"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("b0645df7-a1a4-b5a1-3962-54ea94f627f5"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("c61e5943-0572-475d-c2ed-18d762e5400b"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("ce272427-3313-d248-a829-fd66c5668262"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("e502f9c9-cf08-8911-95c5-40a761187ed5"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("e9a957cd-768d-372e-54d3-4cf08bd2e2e7"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("f5a7c23f-e018-9b7e-5202-b062f68e93af"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("f608ca7f-8f54-ca59-a88e-37a92300d6a4"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("f955bbef-50f7-6de5-ce5a-4d978476ab3a"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("fba953a9-7f00-ad94-4550-9c544966eb7f"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"));

            migrationBuilder.DeleteData(
                table: "Cost",
                keyColumn: "Id",
                keyValue: new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("43dc6c04-a6ef-9572-3076-3d1c0b0b8d0b"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("e88dd8c7-b5e7-329d-1efa-c9fc05d4975e"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("65d2756d-3dd3-155c-3a97-87de8ded6a3a"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("88df2f3a-6795-d362-6d43-591ec672055d"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("97581a8f-780f-3896-228c-51e74509eb80"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("a951f11b-2234-b35b-f424-5420ad1a71ce"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("a99052b6-a953-00fb-7f94-ad45509c5449"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("001bea9f-c9a6-1c20-80f0-9d1740b7b9b0"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("031a60ca-8499-fd17-2e0d-492832ad01cf"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("1203858b-b395-64ba-8349-350922c2f8b1"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("1c7a3311-13f2-0c4f-6634-ac2b97b6715e"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("22389678-518c-45e7-09eb-80f68b20142b"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("29a8d248-66fd-66c5-8262-26cdde04085c"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("2bfb012d-0c51-868e-863e-ededbd69d813"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("3a51ce71-ab15-6d1e-75d2-65d33d5c153a"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("3aab7684-df2f-9588-6762-d36d43591ec6"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("3dfa1681-7e09-c566-fd01-2c2fc3339462"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("4eaaa438-7fb4-4255-1996-b8a364698dd7"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("51c657c7-c2b6-f76d-86a8-3ce64680ed81"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("580a6fb1-0e35-f5f0-e74a-756503f84a7c"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("6239b5a1-ea54-f694-27f5-d5eee0105eca"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("65bc72ff-ae2b-8752-501d-b8b47d7fa37a"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("67eba435-40d1-7d65-5050-c5b9bd58e5e1"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("6ef2cebd-84d8-048d-bd66-760f9121b162"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("76b4b43e-6bbc-a7f7-1f4c-4773aee30c10"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("7fd8b31a-ccc5-e27d-8369-aaa4108d4d02"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("89d5ab85-8ee1-80c5-c88b-39bc2da6528d"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("8b3ca5cc-36b0-5822-4367-619baa649fd9"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("8f54f608-ca59-8ea8-37a9-2300d6a4402f"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("953b298b-2d7e-d55f-136d-3fc2a7f518e0"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("9db5e7e8-1e32-c9fa-fc05-d4975ed3d849"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("a72b6cbd-72d6-0a05-8f89-22cd5b94c915"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("a9f24616-93e6-626c-6933-ef855ab90a53"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("af938ef6-c065-3ea8-cc42-4091fadad7ff"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("b6de451c-9052-53a9-a9fb-007f94ad4550"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("c5958911-a740-1861-7ed5-5224f6098c56"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("cee903fb-653b-0877-add2-e94ecd2895df"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("d6df8b1d-8747-fa6f-5d3f-efbb55f9f750"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("dca20a0a-9549-e4e1-78b1-99327e3ac5e0"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("dd5a993a-834e-5c27-278e-b6b17d3ef20f"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("dfd5e5a3-ad91-6e2a-8169-d69d496e5763"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("e562d718-0b40-d9b5-4a50-898507682b0d"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("ef5f70fc-2ced-ad0e-dc74-db7688646ffd"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("f052cd2b-519e-9ed4-a805-15b413c4587a"));

            migrationBuilder.DeleteData(
                table: "DateCourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("fee56044-ba9d-cd8d-411f-2c0793b7df38"));

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("072c1f41-b793-38df-5c9a-4619abd61d8b"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("09354983-c222-b1f8-6595-99800ff98b29"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("0d197acc-619b-6d82-f271-9fea1b00a6c9"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("208bf680-2b14-3712-d52d-64d485abd589"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("273ee7fa-1096-0806-6580-6035ad238abb"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("2d49430d-4e90-f11b-51a9-34225bb3f424"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("34660c4f-2bac-b697-715e-720dd466c34f"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("3d5d14e4-3fcc-7089-9fe4-9d676b30922d"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("4431c95f-0a4a-5661-fa39-ba2e69221baa"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("44ac7e55-012d-2bfb-510c-8e86863eeded"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("470f6997-03fb-cee9-3b65-7708add2e94e"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("519ef052-9ed4-05a8-15b4-13c4587a030c"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("586f024d-8980-f523-bdce-f26ed8848d04"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("6bbc76b4-a7f7-4c1f-4773-aee30c100642"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("6cbda0e8-a72b-72d6-050a-8f8922cd5b94"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("6d1eab15-d275-d365-3d5c-153a9787de8d"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("6e499dd6-6357-7ca3-45fb-1f8ba41e25e0"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("76db74dc-6488-fd6f-2dc4-98c6ecbda3e5"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("835381de-6fb1-580a-350e-f0f5e74a7565"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("8752ae2b-1d50-b4b8-7d7f-a37ad24f0319"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("8bccb0b9-fc46-b19c-0a0a-a2dc4995e1e4"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("8d52a62d-d0a9-fe70-5e75-1ab3d87fc5cc"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("8de07c9f-8317-bde3-52b5-9b65adced5fa"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("8f580d2b-c771-8dd8-e8e7-b59d321efac9"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("905da48a-b45a-2d81-dcd8-750729b4372c"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("93e6a9f2-626c-3369-ef85-5ab90a53b0f5"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("9ec7cf01-d42c-fda1-8116-fa3d097e66c5"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("a886f76d-e63c-8046-ed81-68bd10e2e3d1"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("b0645df7-a1a4-b5a1-3962-54ea94f627f5"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("c61e5943-0572-475d-c2ed-18d762e5400b"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("ce272427-3313-d248-a829-fd66c5668262"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("e502f9c9-cf08-8911-95c5-40a761187ed5"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("e9a957cd-768d-372e-54d3-4cf08bd2e2e7"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("f5a7c23f-e018-9b7e-5202-b062f68e93af"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("f608ca7f-8f54-ca59-a88e-37a92300d6a4"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("f955bbef-50f7-6de5-ce5a-4d978476ab3a"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("fba953a9-7f00-ad94-4550-9c544966eb7f"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"));

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("1203858b-b395-64ba-8349-350922c2f8b1"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("1c7a3311-13f2-0c4f-6634-ac2b97b6715e"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("29a8d248-66fd-66c5-8262-26cdde04085c"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("2bfb012d-0c51-868e-863e-ededbd69d813"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("3a51ce71-ab15-6d1e-75d2-65d33d5c153a"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("3dfa1681-7e09-c566-fd01-2c2fc3339462"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("4eaaa438-7fb4-4255-1996-b8a364698dd7"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("6239b5a1-ea54-f694-27f5-d5eee0105eca"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("65bc72ff-ae2b-8752-501d-b8b47d7fa37a"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("953b298b-2d7e-d55f-136d-3fc2a7f518e0"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("9db5e7e8-1e32-c9fa-fc05-d4975ed3d849"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("a9f24616-93e6-626c-6933-ef855ab90a53"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("af938ef6-c065-3ea8-cc42-4091fadad7ff"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("c5958911-a740-1861-7ed5-5224f6098c56"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("dfd5e5a3-ad91-6e2a-8169-d69d496e5763"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("e562d718-0b40-d9b5-4a50-898507682b0d"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("ef5f70fc-2ced-ad0e-dc74-db7688646ffd"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("0b40e562-d9b5-504a-8985-07682b0d588f"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("15c913df-778a-5837-5d13-48652553d7ec"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("2cedef5f-ad0e-74dc-db76-88646ffd2dc4"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("2dd53712-d464-ab85-d589-e18ec580c88b"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("31663645-0c09-f634-73cd-57a9e98d762e"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("33c32f2c-6294-2427-27ce-133348d2a829"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("41cd8dba-2c1f-9307-b7df-385c9a4619ab"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("586f024d-8980-f523-bdce-f26ed8848d04"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("65d2756d-3dd3-155c-3a97-87de8ded6a3a"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("72ff2f81-65bc-ae2b-5287-501db8b47d7f"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("7ee018f5-529b-b002-62f6-8e93af65c0a8"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("88df2f3a-6795-d362-6d43-591ec672055d"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("97581a8f-780f-3896-228c-51e74509eb80"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("a951f11b-2234-b35b-f424-5420ad1a71ce"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("a99052b6-a953-00fb-7f94-ad45509c5449"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("c764ce19-c657-b651-c26d-f786a83ce646"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("c962b121-02f9-08e5-cf11-8995c540a761"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("d382d930-5ce3-fc19-a249-af962f5f0ce2"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("d40d725e-c366-8b4f-8503-1295b3ba6483"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("e7e2d28b-02d4-3311-7a1c-f2134f0c6634"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("f24616bd-e6a9-6c93-6269-33ef855ab90a"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"));

            migrationBuilder.DeleteData(
                table: "SlotBooking",
                keyColumn: "Id",
                keyValue: new Guid("ffd7dafa-8d35-ae04-36c7-ca601a039984"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("022b0a9c-ade3-e2c5-5965-1d09f1ff000d"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("030f5a58-a7ac-b018-f69d-1b2122d384ac"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("07858950-2b68-580d-8f71-c7d88de8e7b5"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("10e0eed5-ca5e-8b80-3b9c-77ec7d0d387e"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("122a97a1-f7c4-f517-d8b8-6d416f55c34a"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("19aad1fe-5653-b064-e414-5d3dcc3f8970"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("1c32f657-87c5-33dc-2dda-a177a4571d84"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("1e5fac0b-3f9b-cd2b-52f0-9e51d49ea805"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("20c9a600-801c-9df0-1740-b7b9b0cc8b46"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("275c2783-b68e-7db1-3ef2-0f18e430ad7b"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("28cd4ee9-df95-ff80-ff97-7fca08f6548f"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("33c32f2c-6294-2427-27ce-133348d2a829"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("41d8c209-3f66-e488-6829-d7affbe4c453"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("487e1318-8926-dc97-7c4d-5a2e22161d0e"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("49430def-902d-1b4e-f151-a934225bb3f4"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("4bf4b6b3-38f6-68e2-0600-f403e85ab410"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("55bbef3f-f7f9-e550-6dce-5a4d978476ab"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("57cd73f6-e9a9-768d-2e37-54d34cf08bd2"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("5b56ef22-52ec-d864-59e6-7c64aa80f861"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("5f702285-9be0-b426-2e79-e32f70dde1ba"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("62b12191-f9c9-e502-08cf-118995c540a7"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("64bab395-4983-0935-22c2-f8b165959980"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("6d302f06-2a8e-f29a-8b4d-cda18c19b674"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("8a362423-e4dd-38b9-a363-09e8fcc69301"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("8d52a62d-d0a9-fe70-5e75-1ab3d87fc5cc"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("8e4ab0bb-8585-3fb3-ce3e-7d86eca0c08c"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("8ea9a6ab-4020-b531-efaa-0b5dcff3688d"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("97b5d36d-c630-542b-d79f-c1f4fe32674a"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("a5e0035e-4fba-0070-a7f0-b154fde1fc18"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("aa9b6167-9f64-f7d9-8f1a-58970f789638"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("ad91dfd5-6e2a-6981-d69d-496e5763a37c"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("ae2b65bc-8752-1d50-b8b4-7d7fa37ad24f"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("af4e7220-0f01-2605-0e56-6ab34b8a588c"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("b41e9ba8-71a4-7b18-0dfd-0318ea7471aa"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("bda0e8a4-2b6c-d6a7-7205-0a8f8922cd5b"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("bdd8753b-eb6d-3480-646a-2cfb19c131d2"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("c2cfcbc3-451c-b6de-5290-a953a9fb007f"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("d31c4457-74c3-ad4a-6e5d-d27963c16e2a"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("d52a2c37-a8ff-3d62-5cea-e177a771279a"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("de96d9a2-5381-b183-6f0a-58350ef0f5e7"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("df1097eb-55bd-64d3-a3db-4a109f23666b"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("df7c5d15-2500-c7ae-6439-d5b0dd579f03"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("e3958622-809c-11bd-a234-2663de9bee82"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("f4ce1a83-32f5-ed61-7e69-84c38a62f6f3"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("f8b05d30-2fc2-7d4c-7e0b-670a682b5ace"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("fa4d9d8d-bfba-b0e0-5817-0205f5910bf9"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("1cc2cfcb-de45-52b6-90a9-53a9fb007f94"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("2f96af49-0c5f-aae2-4230-9edddf13c915"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("35498364-2209-f8c2-b165-9599800ff98b"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("3f6d13d5-a7c2-18f5-e07e-9b5202b062f6"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("6e2aad91-6981-9dd6-496e-5763a37c45fb"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("89504ad9-0785-2b68-0d58-8f71c7d88de8"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("ab153a51-6d1e-d275-65d3-3d5c153a9787"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("ad322849-cf01-9ec7-2cd4-a1fd8116fa3d"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("b08b3ca5-2236-4358-6761-9baa649fd9f7"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("e6a9f246-6c93-6962-33ef-855ab90a53b0"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("048d35ff-36ae-cac7-601a-03998417fd2e"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("0c666a36-75bf-3e04-b4b4-76bc6bf7a71f"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("1aad2054-ce71-3a51-15ab-1e6d75d265d3"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("3aab7684-df2f-9588-6762-d36d43591ec6"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("60447f7b-fee5-ba9d-8dcd-411f2c0793b7"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("67435822-9b61-64aa-9fd9-f78f1a58970f"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("69816e2a-9dd6-6e49-5763-a37c45fb1f8b"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("71b6972b-725e-d40d-66c3-4f8b85031295"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("7fb44eaa-4255-9619-b8a3-64698dd7fdc7"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("93e6a9f2-626c-3369-ef85-5ab90a53b0f5"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("a99052b6-a953-00fb-7f94-ad45509c5449"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("ad659bb5-d5ce-14fa-8bef-7b2fa2d996de"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("ae7c811b-cb63-0def-4349-2d904e1bf151"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("af49a2fc-2f96-0c5f-e2aa-42309edddf13"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("b1f8c222-9565-8099-0ff9-8b293b957e2d"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("b9c55050-58bd-e1e5-a445-366631090c34"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("df8b1dd6-47d6-6f87-fa5d-3fefbb55f9f7"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("f5f00e35-4ae7-6575-03f8-4a7c83951b2e"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("fb470f69-e903-3bce-6577-08add2e94ecd"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("0775d8dc-b429-2c37-2ad5-ffa8623d5cea"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("09354983-c222-b1f8-6595-99800ff98b29"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("09f62452-568c-f8f3-557e-ac442d01fb2b"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("19aad1fe-5653-b064-e414-5d3dcc3f8970"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("1f24a4b5-b43c-e7fa-3e27-961006086580"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("38dfb793-9a5c-1946-abd6-1d8bdfd64787"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("581a8ff7-0f97-9678-3822-8c51e74509eb"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("5ace6de5-974d-7684-ab3a-2fdf88956762"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("626c93e6-3369-85ef-5ab9-0a53b0f5a847"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("66fd29a8-66c5-6282-26cd-de04085c7b99"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("9dd66981-6e49-6357-a37c-45fb1f8ba41e"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("9e3042aa-dfdd-c913-158a-7737585d1348"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a4d60023-2f40-602b-ee79-b453e39036df"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a7b0d962-3624-666a-0cbf-75043eb4b476"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ab3f9f75-a438-4eaa-b47f-55421996b8a3"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ab85d464-89d5-8ee1-c580-c88b39bc2da6"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ac0bab7a-1e5f-3f9b-2bcd-52f09e51d49e"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ad0e2ced-74dc-76db-8864-6ffd2dc498c6"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ae048d35-c736-60ca-1a03-998417fd2e0d"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("b4b81d50-7f7d-7aa3-d24f-0319ce64c757"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("b5a1a1a4-6239-ea54-94f6-27f5d5eee010"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ccc57fd8-e27d-6983-aaa4-108d4d026f58"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ce3fb385-7d3e-ec86-a0c0-8cc4d7a942e5"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("d718edc2-e562-0b40-b5d9-4a5089850768"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("e018f5a7-9b7e-0252-b062-f68e93af65c0"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("e64313d8-a4a2-a0e8-bd6c-2ba7d672050a"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("eceb7e38-e994-eb98-0c68-69eca2e641f6"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("fad5cead-8b14-7bef-2fa2-d996de815383"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("fadc6e80-d9f3-b790-2e46-a870e9198a1a"));

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("1d5d7434-674a-4126-1a7a-5ad14ba33acd"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("268f4ff8-d5e1-09db-b31f-3e8190949cc6"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("50714b05-b3c5-c1c9-35e3-3c33e18aaa4f"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("558a8384-f60e-83e4-2bea-73f473f6909e"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("6c5f7fae-283c-7ad4-96e0-ad704663df22"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("9a0a219e-f958-f1a7-0605-94327786d627"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("bfb312c3-362b-ec49-fcb7-61f2db22d65c"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("e9ce60a6-2ed5-9c3b-1203-98e89b09e05c"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("0f7666bd-2191-62b1-c9f9-02e508cf1189"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("31c95f5a-4a44-610a-56fa-39ba2e69221b"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("4d5ace6d-8497-ab76-3a2f-df88956762d3"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("5837778a-135d-6548-2553-d7ec3774d8f5"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("6649549c-7feb-70fc-5fef-ed2c0eaddc74"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("69bdeded-13d8-e643-a2a4-e8a0bd6c2ba7"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("81b45a90-dc2d-75d8-0729-b4372c2ad5ff"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("a9ff8f43-1b36-7c81-ae63-cbef0d43492d"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("ae2b65bc-8752-1d50-b8b4-7d7fa37ad24f"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("e6a9f246-6c93-6962-33ef-855ab90a53b0"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("edc2475d-d718-e562-400b-b5d94a508985"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("01ad3228-c7cf-2c9e-d4a1-fd8116fa3d09"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("2dd53712-d464-ab85-d589-e18ec580c88b"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("33c32f2c-6294-2427-27ce-133348d2a829"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("72ff2f81-65bc-ae2b-5287-501db8b47d7f"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("786a9718-31c8-f2fa-7aab-0bac5f1e9b3f"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("7ee018f5-529b-b002-62f6-8e93af65c0a8"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("8a824ff6-5da4-5a90-b481-2ddcd8750729"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("91dfd5e5-2aad-816e-69d6-9d496e5763a3"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("9565b1f8-8099-f90f-8b29-3b957e2d5fd5"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("b552bde3-659b-cead-d5fa-148bef7b2fa2"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("c764ce19-c657-b651-c26d-f786a83ce646"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("de9b9d52-a435-67eb-d140-657d5050c5b9"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("decd2662-0804-7b5c-9997-690f47fb03e9"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("e7e2d28b-02d4-3311-7a1c-f2134f0c6634"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("fa6f8747-3f5d-bbef-55f9-f750e56dce5a"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("06109627-6508-6080-35ad-238abbb04a8e"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("0ae18c23-5a4e-0f8e-e3c1-25f2744b08ab"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("29a8d248-66fd-66c5-8262-26cdde04085c"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("2aad91df-816e-d669-9d49-6e5763a37c45"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("2b94bacd-417a-aaf6-249c-e7305db0f8c2"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("2f96af49-0c5f-aae2-4230-9edddf13c915"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("35f65d2c-7cfe-378d-40a4-6990103e9553"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("36b08b3c-5822-6743-619b-aa649fd9f78f"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("3a6aed8d-5a99-4edd-8327-5c278eb6b17d"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("3d5d14e4-3fcc-7089-9fe4-9d676b30922d"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("4206100c-318e-34ba-525e-7c82b1c93efc"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("49d8d35e-7c9f-8de0-1783-e3bd52b59b65"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("53c4e4fb-c85d-80e2-8ad9-652748a30f3c"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("5e9bf4a4-e003-baa5-4f70-00a7f0b154fd"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("61cb6c4e-d08c-e867-a5e9-d2d209173f4e"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("69626c93-ef33-5a85-b90a-53b0f5a84781"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("6de550f7-5ace-974d-8476-ab3a2fdf8895"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("71b6972b-725e-d40d-66c3-4f8b85031295"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("7feb6649-70fc-ef5f-ed2c-0eaddc74db76"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("8bf680eb-1420-122b-37d5-2d64d485abd5"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("914042cc-dafa-ffd7-358d-04ae36c7ca60"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("93072c1f-dfb7-5c38-9a46-19abd61d8bdf"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("94ea5462-27f6-d5f5-eee0-105eca808b3b"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("953b298b-2d7e-d55f-136d-3fc2a7f518e0"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("9a2771a7-4449-f54d-62d9-b0a724366a66"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("9cfc468b-0ab1-a20a-dc49-95e1e478b199"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("9ef052cd-d451-a89e-0515-b413c4587a03"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("a2e64313-e8a4-bda0-6c2b-a7d672050a8f"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("a9d7c48c-e542-6100-d98e-dd9402ebd05d"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("af4e7220-0f01-2605-0e56-6ab34b8a588c"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("b1835381-0a6f-3558-0ef0-f5e74a756503"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("b35b2234-24f4-2054-ad1a-71ce513a15ab"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("b50b40e5-4ad9-8950-8507-682b0d588f71"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("b5e07e23-dc6f-5b08-8c43-8fffa9361b81"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("b8961942-64a3-8d69-d7fd-c7c3cbcfc21c"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("cc3f9225-197a-9b0d-6182-6df2719fea1b"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("cd4ee9d2-9528-80df-ffff-977fca08f654"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("cd73f634-a957-8de9-762e-3754d34cf08b"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("d27aa37f-034f-ce19-64c7-57c651b6c26d"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("d42c9ec7-fda1-1681-fa3d-097e66c5fd01"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("d57e1861-2452-09f6-8c56-f3f8557eac44"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("d87437ec-f4f5-9d52-9bde-35a4eb67d140"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("db033f39-57ce-32f6-1cc5-87dc332ddaa1"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("e4e3def4-b2a1-c4a3-49f8-a662fe7e5157"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("e6a2ec69-f641-824f-8aa4-5d905ab4812d"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("ee602b2f-b479-e353-9036-dfc79c18976a"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("f2cebdf5-d86e-8d84-04bd-66760f9121b1"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("f93c9215-2941-5f5a-c931-444a0a6156fa"));

            migrationBuilder.DeleteData(
                table: "Deposit",
                keyColumn: "Id",
                keyValue: new Guid("fe70d0a9-755e-b31a-d87f-c5cc7de28369"));

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("001bea9f-c9a6-1c20-80f0-9d1740b7b9b0"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("031a60ca-8499-fd17-2e0d-492832ad01cf"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("22389678-518c-45e7-09eb-80f68b20142b"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("234c0837-e07e-6fb5-dc08-5b8c438fffa9"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("37778a15-5d58-4813-6525-53d7ec3774d8"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("3aab7684-df2f-9588-6762-d36d43591ec6"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("430defcb-2d49-4e90-1bf1-51a934225bb3"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("51c657c7-c2b6-f76d-86a8-3ce64680ed81"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("580a6fb1-0e35-f5f0-e74a-756503f84a7c"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("67eba435-40d1-7d65-5050-c5b9bd58e5e1"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("6ef2cebd-84d8-048d-bd66-760f9121b162"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("71a777e1-9a27-4449-4df5-62d9b0a72436"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("73f6340c-57cd-e9a9-8d76-2e3754d34cf0"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("76b4b43e-6bbc-a7f7-1f4c-4773aee30c10"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("7fd8b31a-ccc5-e27d-8369-aaa4108d4d02"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("89d5ab85-8ee1-80c5-c88b-39bc2da6528d"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("8b3ca5cc-36b0-5822-4367-619baa649fd9"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("8f54f608-ca59-8ea8-37a9-2300d6a4402f"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("a72b6cbd-72d6-0a05-8f89-22cd5b94c915"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("b45a905d-2d81-d8dc-7507-29b4372c2ad5"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("b6de451c-9052-53a9-a9fb-007f94ad4550"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("cee903fb-653b-0877-add2-e94ecd2895df"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("d6df8b1d-8747-fa6f-5d3f-efbb55f9f750"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("dca20a0a-9549-e4e1-78b1-99327e3ac5e0"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("dd5a993a-834e-5c27-278e-b6b17d3ef20f"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("e0251ea4-9ee0-8427-cd25-923fcc7a190d"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("f052cd2b-519e-9ed4-a805-15b413c4587a"));

            migrationBuilder.DeleteData(
                table: "Slot",
                keyColumn: "Id",
                keyValue: new Guid("fee56044-ba9d-cd8d-411f-2c0793b7df38"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("0c512bfb-868e-3e86-eded-bd69d81343e6"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("602b2f40-79ee-53b4-e390-36dfc79c1897"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("b651c657-6dc2-86f7-a83c-e64680ed8168"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("c550507d-bdb9-e558-e1a4-45366631090c"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("d405fcc9-5e97-d8d3-499f-7ce08d1783e3"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("d86ef2ce-8d84-bd04-6676-0f9121b162c9"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("8026a67e-3b61-fd8d-5241-408b6939c3a4"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("9d4a5ac2-9ed1-9582-50ad-507ae459e493"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("b9091570-e0f7-593d-99e0-58bfd294d21a"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("042638ff-08ab-3154-8231-2f09aa954c72"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("1de7f0c5-af98-25d1-a33a-f246ec74b73f"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("21a19a75-c397-f2f7-c138-1c350582a9e4"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("55f6523c-51b3-95d6-89d1-d290b43e07fd"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("946cbe11-beeb-0694-f564-dda95675991f"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("9d403be7-1591-a47f-eda5-1411ff876f4f"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("bc12e381-9af1-1ac4-c15e-a986da5b57bd"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("c9b3ea50-4009-f618-ff5f-134b47a79f0f"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("da46d4f4-4577-fb00-969b-e0dfb77ed0ff"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("e37263c1-54e5-503c-642e-44045c366f77"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("e9a30a4b-5518-1855-0a66-8a00ae6966ab"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("f774154c-4e4a-4a5f-d769-f094e08d73e6"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("fa994fb6-2e25-c984-c137-9a968f6f9cb1"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("04decd26-5c08-997b-9769-0f47fb03e9ce"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("0945e751-80eb-8bf6-2014-2b1237d52d64"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("0a0ab19c-dca2-9549-e1e4-78b199327e3a"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("0a6fb183-3558-f00e-f5e7-4a756503f84a"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("0bab7af2-5fac-9b1e-3f2b-cd52f09e51d4"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("0c037a58-9f75-ab3f-38a4-aa4eb47f5542"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("0c4f13f2-3466-2bac-97b6-715e720dd466"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("19469a5c-d6ab-8b1d-dfd6-47876ffa5d3f"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("28490d2e-ad32-cf01-c79e-2cd4a1fd8116"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("2f40a4d6-602b-79ee-b453-e39036dfc79c"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("30e4180f-7bad-447f-60e5-fe9dba8dcd41"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("39b5a1a1-5462-94ea-f627-f5d5eee0105e"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("4042cc3e-fa91-d7da-ff35-8d04ae36c7ca"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("40d167eb-7d65-5050-c5b9-bd58e5e1a445"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("582236b0-6743-9b61-aa64-9fd9f78f1a58"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("5ce3d382-fc19-49a2-af96-2f5f0ce2aa42"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("6d13d55f-c23f-f5a7-18e0-7e9b5202b062"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("6dc2b651-86f7-3ca8-e646-80ed8168bd10"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("7e380d7d-eceb-e994-98eb-0c6869eca2e6"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("8364bab3-3549-2209-c2f8-b1659599800f"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("87973a15-8dde-6aed-3a99-5add4e83275c"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("8b1ffb45-1ea4-e025-e09e-2784cd25923f"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("8bc880c5-bc39-a62d-528d-a9d070fe5e75"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("9f71f26d-1bea-a600-c920-1c80f09d1740"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("a957cd73-8de9-2e76-3754-d34cf08bd2e2"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("aa6983e2-10a4-4d8d-026f-58808923f5bd"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("bde38317-b552-659b-adce-d5fa148bef7b"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("c32f2c01-9433-2762-2427-ce133348d2a8"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("c3c7fdd7-cfcb-1cc2-45de-b65290a953a9"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("c9945bcd-5515-8954-f74e-1337084c237e"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("ecc698c4-a3bd-d5e5-df91-ad2a6e8169d6"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("f4b35b22-5424-ad20-1a71-ce513a15ab1e"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("f62452d5-8c09-f356-f855-7eac442d01fb"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("f76bbc76-1fa7-474c-73ae-e30c1006428e"));

            migrationBuilder.DeleteData(
                table: "CourtYard",
                keyColumn: "Id",
                keyValue: new Guid("fc3ec9b1-9c31-dd74-38f3-bcb0dede4da6"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("0b40e562-d9b5-504a-8985-07682b0d588f"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("15c913df-778a-5837-5d13-48652553d7ec"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("1bea9f71-a600-20c9-1c80-f09d1740b7b9"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("23a9378e-d600-40a4-2f2b-60ee79b453e3"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("2cedef5f-ad0e-74dc-db76-88646ffd2dc4"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("31663645-0c09-f634-73cd-57a9e98d762e"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("329db5e7-fa1e-fcc9-05d4-975ed3d8499f"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("41cd8dba-2c1f-9307-b7df-385c9a4619ab"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("42557fb4-9619-a3b8-6469-8dd7fdc7c3cb"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("438c5b08-ff8f-36a9-1b81-7cae63cbef0d"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("4ee9d2ad-28cd-df95-80ff-ff977fca08f6"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("568c09f6-f8f3-7e55-ac44-2d01fb2b510c"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("586f024d-8980-f523-bdce-f26ed8848d04"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("70d0a98d-5efe-1a75-b3d8-7fc5cc7de283"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("945bcd22-15c9-5455-89f7-4e1337084c23"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("a1a1a4b0-39b5-5462-ea94-f627f5d5eee0"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("a89ed451-1505-13b4-c458-7a030c759f3f"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("c962b121-02f9-08e5-cf11-8995c540a761"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("d1e3e210-a5cc-8b3c-b036-22584367619b"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("d40d725e-c366-8b4f-8503-1295b3ba6483"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("d869bded-4313-a2e6-a4e8-a0bd6c2ba7d6"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("ec779c3b-0d7d-7e38-ebec-94e998eb0c68"));

            migrationBuilder.DeleteData(
                table: "Date",
                keyColumn: "Id",
                keyValue: new Guid("f24616bd-e6a9-6c93-6269-33ef855ab90a"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("0804decd-7b5c-9799-690f-47fb03e9ce3b"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("14fad5ce-ef8b-2f7b-a2d9-96de815383b1"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("1f41cd8d-072c-b793-df38-5c9a4619abd6"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("2495c693-e3b9-7c6f-3898-b7dd200bc116"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("2b65bc72-52ae-5087-1db8-b47d7fa37ad2"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("2cc304c0-f65d-fe35-7c8d-3740a4699010"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("2d49430d-4e90-f11b-51a9-34225bb3f424"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("2e768de9-5437-4cd3-f08b-d2e2e7d40211"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("39fa5661-2eba-2269-1baa-fed1aa195356"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("3f5dfa6f-bbef-f955-f750-e56dce5a4d97"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("3f9f750c-38ab-aaa4-4eb4-7f55421996b8"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("53256548-ecd7-7437-d8f5-f4529d9bde35"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("5fac0bab-9b1e-2b3f-cd52-f09e51d49ea8"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("69680ceb-a2ec-41e6-f64f-828aa45d905a"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("72d6a72b-0a05-898f-22cd-5b94c9155554"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("754ae7f5-0365-4af8-7c83-951b2e30d982"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("8c223896-e751-0945-eb80-f68b20142b12"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("8e275c27-b1b6-3e7d-f20f-18e430ad7b7f"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("9225cd84-cc3f-197a-0d9b-61826df2719f"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("9433c32f-2762-2724-ce13-3348d2a829fd"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("9528cd4e-80df-ffff-977f-ca08f6548f59"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("a740c595-1861-d57e-5224-f6098c56f3f8"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("ac34660c-972b-71b6-5e72-0dd466c34f8b"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("b05d30e7-c2f8-4c2f-7d7e-0b670a682b5a"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("b43e0475-76b4-6bbc-f7a7-1f4c4773aee3"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("c57fd8b3-7dcc-83e2-69aa-a4108d4d026f"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("d3626795-436d-1e59-c672-055d47c2ed18"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("e07e234c-6fb5-08dc-5b8c-438fffa9361b"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("e189d5ab-c58e-c880-8b39-bc2da6528da9"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("edef5f70-0e2c-dcad-74db-7688646ffd2d"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("f694ea54-f527-eed5-e010-5eca808b3b9c"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("fc468bcc-b19c-0a0a-a2dc-4995e1e478b1"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("3313ce27-d248-29a8-fd66-c566826226cd"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("3a6aed8d-5a99-4edd-8327-5c278eb6b17d"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("41e6a2ec-4ff6-8a82-a45d-905ab4812ddc"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("9b7ee018-0252-62b0-f68e-93af65c0a83e"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("d42c9ec7-fda1-1681-fa3d-097e66c5fd01"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("225b3a21-fd1c-85f3-83c3-b73cddbbc668"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("4fbc87d7-b534-95ce-0699-083d05b4056f"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("6b17d449-6d47-ded4-42e8-91b1dda61892"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("6b601e2a-fd75-5bb7-5be1-196ca9cff63a"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("779c3b8b-7dec-380d-7eeb-ec94e998eb0c"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("7bfb0e9a-450e-4de3-e61a-53cbbd200382"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("7f5038db-db10-9886-e48c-3e1f519a4cfc"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("837c4af8-1b95-302e-d982-d3e35c19fca2"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("8bdb736b-89b7-be24-1c15-31f7e7421644"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("9588df2f-6267-6dd3-4359-1ec672055d47"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("9de1b233-b753-b150-4906-4d445720e8f1"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("a4ba18a9-4a80-60ba-6b5e-7ddf7d9935d5"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("d2f046ac-c105-40c7-eabf-733a9492edc5"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("f0b13370-7eb6-c004-aeec-7ae51d6ec47f"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("f12096d7-2697-2757-cded-e8d3504da036"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("f4b6b354-f64b-e238-6806-00f403e85ab4"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("01f4d29a-7bee-4b95-ca48-6fcecd1ce1a5"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("122899aa-bb86-c8b7-29dc-92551068fe1b"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("6582b0e9-0df0-e6c3-28f2-ec5e2b85796a"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("6773f756-d8b1-22de-a543-ceb51d18f920"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("742e2a57-6231-e100-0c30-a46a4792353a"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("7b30d717-a76c-5e6e-81be-4dcf0abad890"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("7d5ba0c4-a164-7231-7cf6-1d1e6efaf5d8"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("7e5e390d-d9ab-d434-ecef-08c5ede18f13"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("85c7be28-3ba8-977e-a626-54f8f5964a2b"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("85f9d68b-8075-4ce4-4687-d3b0fee00f06"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("894bbc95-6ce2-cb29-8f17-449c7ebe9a77"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("8c512572-c2c5-6018-11b0-65448b8b5bf0"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("915bf2ff-2a7a-a582-3585-cbee1ae797a3"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("92e3d544-7624-48a7-8558-e2cf0def022a"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("9b0258ef-d34c-bfca-2865-b935f45efc20"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("a00e7adf-e39c-17c1-6ce4-8e824e0221be"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("c34ae2e6-68cc-6e9c-d22e-1db28b88829e"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("c86c892d-3011-bfe7-3a4b-ce7101f5eece"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("c888dbdb-1c04-f09f-f960-26ada1097c5d"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("cf7d3633-3eee-94eb-b598-83a5ac711802"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("dc2253fb-a284-69ca-546f-0a051ec36e98"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("dc880bf8-48e0-6c50-837a-3f2480a252fb"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("dcaebaaf-f809-9558-8919-c4f71079e80d"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("de4ff2b1-a48b-873f-c7ca-08f63404c6ce"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("f0bc8bcb-9c50-1a09-e65f-56c571a1badf"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("f7771a35-735e-edff-b14e-cd1606d57de8"));

            migrationBuilder.DeleteData(
                table: "CourtGroup",
                keyColumn: "Id",
                keyValue: new Guid("ff8d9313-3631-7d5e-8223-78fc98684039"));

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("15d6a64d-3c92-41f9-295a-5fc931444a0a"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("40e562d7-b50b-4ad9-5089-8507682b0d58"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("52ae2b65-5087-b81d-b47d-7fa37ad24f03"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("62b12191-f9c9-e502-08cf-118995c540a7"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("9ef052cd-d451-a89e-0515-b413c4587a03"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("a2e64313-e8a4-bda0-6c2b-a7d672050a8f"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("0239ea8c-b559-0752-b2c0-92710f499696"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("11cf08e5-9589-40c5-a761-187ed55224f6"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("1b978c58-bd02-4da2-f9eb-ee93e5b6ba42"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("360f39a0-9ef3-42c7-47d5-608af0d59ff4"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("3b18d343-2ea5-4803-3f37-73c3e7b57871"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("40059f0b-1d19-9002-1e10-8a95bc55cb73"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("4a1c6b89-d069-783e-490c-18783c5527ee"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("52e69d65-b7db-d3d0-949c-155965a5ad25"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("606f1107-4340-3d79-81f8-5d8b09c12c47"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("7878f7dc-bd02-5290-3a26-8de4bc0e493e"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("81fda1d4-fa16-093d-7e66-c5fd012c2fc3"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("99b466ff-4c41-07d6-7020-a9f28b403607"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("a2f3dcda-df43-530a-0c96-53f4b2c78dd4"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("b354e7ff-dc8e-00a4-4e16-dbdec031d490"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("c2a70e2a-ef63-4cd3-813e-6c0feb02be4e"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("dae37e73-50c0-d5c8-97c6-5a7041370998"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("f0873793-18d6-4a84-5a2e-46f599ad27f6"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("f880aa64-7561-7503-de83-7f97fc4ce8a5"));

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("1e329db5-c9fa-05fc-d497-5ed3d8499f7c"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("25654813-d753-37ec-74d8-f5f4529d9bde"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("2dbc398b-52a6-a98d-d070-fe5e751ab3d8"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("318e4206-34ba-5e52-7c82-b1c93efc319c"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("3a7e3299-e0c5-5df7-64b0-a4a1a1b53962"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("3f9225cd-7acc-0d19-9b61-826df2719fea"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("40179df0-b9b7-ccb0-8b46-fc9cb10a0aa2"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("4d8d10a4-6f02-8058-8923-f5bdcef26ed8"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("54f608ca-598f-a8ca-8e37-a92300d6a440"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("5e10e0ee-80ca-3b8b-9c77-ec7d0d387eeb"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("86f76dc2-3ca8-46e6-80ed-8168bd10e2e3"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("a8ffd52a-3d62-ea5c-e177-a771279a4944"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("d354372e-f04c-d28b-e2e7-d40211337a1c"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("df3690e3-9cc7-9718-6a78-c831faf27aab"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("f3568c09-55f8-ac7e-442d-01fb2b510c8e"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("f680eb09-208b-2b14-1237-d52d64d485ab"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("f7895455-134e-0837-4c23-7ee0b56fdc08"));

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: new Guid("feaa1b22-aad1-5319-5664-b0e4145d3dcc"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("0ac39d47-a580-388c-334e-c36e77d4acb7"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("5e457116-2bfb-9936-853d-5adc0468ba06"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("8a80e2c8-65d9-4827-a30f-3c67e91e70a4"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("98fb7425-d052-7dbb-7741-3ff692b4dc3d"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("9fcce051-4f9f-f1f2-63d6-b684ab1f528f"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("dfd5e5a3-ad91-6e2a-8169-d69d496e5763"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("f2fa31c8-ab7a-ac0b-5f1e-9b3f2bcd52f0"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("6100e542-8ed9-94dd-02eb-d05d806edcfa"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("749c31fc-38dd-bcf3-b0de-de4da6d61592"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("13f21c7a-0c4f-3466-ac2b-97b6715e720d"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("9b616743-64aa-d99f-f78f-1a58970f7896"));

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: new Guid("24f4b35b-2054-1aad-71ce-513a15ab1e6d"));

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "ApplicationUser");
        }
    }
}
