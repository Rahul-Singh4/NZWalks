using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations.NZWalksAuthDb
{
    /// <inheritdoc />
    public partial class WithAuthDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f35aaf9-6817-47bd-98c4-b2cc4fbd74c7", "6f35aaf9-6817-47bd-98c4-b2cc4fbd74c7", "Writer", "WRITER" },
                    { "77824af7-6aa7-4ce6-a60a-e345b0753af7", "77824af7-6aa7-4ce6-a60a-e345b0753af7", "Reader", "READER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f35aaf9-6817-47bd-98c4-b2cc4fbd74c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77824af7-6aa7-4ce6-a60a-e345b0753af7");
        }
    }
}
