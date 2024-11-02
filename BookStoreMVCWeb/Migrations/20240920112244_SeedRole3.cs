using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreMVCWeb.Migrations
{
    public partial class SeedRole3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "fc48eb70-add8-46af-aa6b-2f74dd4ec3bb", "Admin", "ADMIN" },
                    { "2", "3b494169-75b8-45ea-ade4-912b6909320b", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca298a43-6925-4faf-995d-f8a1425174be", "AQAAAAEAACcQAAAAELVrf2E/y5fGl3xvgOXVUoHcoN470w1xKlFTkfR7fd9bB6ZkxM9RTKP0QoDGLF1rLA==", "d811b1bc-454f-4419-ab00-8d86e8f4d94a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca21f962-73b8-486a-908b-8096d30a9d1c", "AQAAAAEAACcQAAAAEJu9fJCMz8MNSLWCxYXaO4PxCy5c2cPDbV60C41ZW6sdfzWT6c5TRvD9S+YayAYBCQ==", "54e4de49-79d2-4055-a5cb-009508727edb" });
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
                values: new object[] { "d64f85e8-bf31-4c9c-ae55-2ab9e52ba590", "AQAAAAEAACcQAAAAEFdDu+lO39FvXaRKE4mRj21jFZqFSVZAv0bFDt+R9zPN3YA68MP4XuxXomS08uVyig==", "16660e26-8d6b-4474-82f6-a19484411bf6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c34dc9c-db91-4fdb-bd5b-dd1196f92eaf", "AQAAAAEAACcQAAAAEF0Zkqc9G8tBKMc05WFTakVdjbgX+n8PioYeoGOF8A9fkyQ9+T7KGYE9wqmAsTrC1w==", "d1d3b34f-3672-4f54-8dfb-d5ec8aa46c46" });
        }
    }
}
