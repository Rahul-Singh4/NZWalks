using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingdataforDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Easy" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Medium" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), "AKL", "Auckland", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Auckland_skyline_from_Mt_Eden.jpg/2560px-Auckland_skyline_from_Mt_Eden.jpg" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "WLG", "Wellington", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Wellington_skyline_from_Mt_Victoria.jpg/2560px-Wellington_skyline_from_Mt_Victoria.jpg" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "CHC", "Christchurch", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Christchurch_Cathedral.jpg/2560px-Christchurch_Cathedral.jpg" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "ZQN", "Queenstown", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Queenstown_skyline_from_Bobs_Peak.jpg/2560px-Queenstown_skyline_from_Bobs_Peak.jpg" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "ROT", "Rotorua", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Rotorua_skyline_from_Mt_Eden.jpg/2560px-Rotorua_skyline_from_Mt_Eden.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));
        }
    }
}
