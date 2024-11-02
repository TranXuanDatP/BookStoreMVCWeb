using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreMVCWeb.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d64f85e8-bf31-4c9c-ae55-2ab9e52ba590", "AQAAAAEAACcQAAAAEFdDu+lO39FvXaRKE4mRj21jFZqFSVZAv0bFDt+R9zPN3YA68MP4XuxXomS08uVyig==", "16660e26-8d6b-4474-82f6-a19484411bf6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c34dc9c-db91-4fdb-bd5b-dd1196f92eaf", "AQAAAAEAACcQAAAAEF0Zkqc9G8tBKMc05WFTakVdjbgX+n8PioYeoGOF8A9fkyQ9+T7KGYE9wqmAsTrC1w==", "d1d3b34f-3672-4f54-8dfb-d5ec8aa46c46" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
