using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreMVCWeb.Migrations
{
    public partial class init2 : Migration
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

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "7b4b038c-c685-4bcf-baca-35ba43d64638", "Admin", "ADMIN" },
                    { "2", "0cf83d80-05a4-46b8-908c-50c1c035cc5c", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "955c3bcd-9e3b-405a-b69c-0f4bd51fce9d", "AQAAAAEAACcQAAAAEBjGNBaCGZUusA/q0Nr+4ttX/XFtyXC0v8dIluqsWQI/C9q0/xN/NbPI8zp9EgI3sA==", "01953595-e1a7-4f16-8d58-4ac5f5a56aa9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9ad1e2d-6ef1-4e2f-97ae-3b23d95f9039", "AQAAAAEAACcQAAAAEG68i5swXteDl1TCx/h6e2xkzaw+/0Sfu/KUR3r/HZ3V7HIUkTypoXBdc8L8ojEqgw==", "e4c4d115-387e-42f3-a116-0a0bce229184" });
        }
    }
}
