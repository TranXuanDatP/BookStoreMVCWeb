using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreMVCWeb.Migrations
{
    public partial class SeedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "7fcadde8-cc69-4fbb-ae01-3a66bbe011c3", "Admin", "ADMIN" },
                    { "2", "6c28c3eb-481b-46d8-8164-303fdb1664b7", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab4085e5-d9e8-4a31-8062-7b2beb05f6a7", "AQAAAAEAACcQAAAAEAreCpUKCzMRM4KME0cWGTFLaumUxBUYUk/ZxsiOOjyb7kgO5+zPEcSo0DaPtoS/iw==", "6af45dfb-a315-4104-b0b6-ce64af4c0973" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fdb1830-6c0b-4b12-8dfd-e7bbd23c56bc", "AQAAAAEAACcQAAAAECYPAQDvi3Lo0iewry3THBn9Fki3HvIfg0Ip9bYqE76hXLvxAW4ulT6TDyNgBzTjwQ==", "8899002e-b153-43b9-8d91-06d3ea42e7b8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c3a5f7e-60a2-4589-bb73-5c78e96d7e5c", "AQAAAAEAACcQAAAAELhEri/xbaAuAC71L4KQXGzJj5O5Myca8pJvkK6ZTFpBgvUbjBAQARQPJSh2Wu8x6w==", "e61fd89e-fb89-4508-add3-2c80d40f6239" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2054692-b49e-4b08-ac4d-4eff36dbd9e5", "AQAAAAEAACcQAAAAEBRbq5BqOntuqAzetxLJJ+muOXSDsBsRj2RhIdTPo8vBn2M80KjxTCof6t2053WY3g==", "f5f1a7a0-6617-4499-aba2-97050f384332" });
        }
    }
}
