using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreMVCWeb.Migrations
{
    public partial class addCateinBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Books",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7b4b038c-c685-4bcf-baca-35ba43d64638");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "0cf83d80-05a4-46b8-908c-50c1c035cc5c");

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

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: "adventure");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: "fictional");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Category",
                value: "adventure");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Category",
                value: "adventure");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Category",
                value: "romantic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Category",
                value: "technology");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f1de6e2f-c583-4ec5-b846-71bf94adc6ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "aee1dcb2-5124-49f9-96dd-4540079c8c5f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a4e1256-d272-44d5-be6c-eae846247b32", "AQAAAAEAACcQAAAAEJJrlLUZGdGgTmVrw0PY46CYegjleMvkkuopwfGqAvQkpxc4xGCDKWxp32/X/et6JA==", "22ca2ef0-647c-4bd8-bb3c-9d99db1c8a76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97957e86-d632-496d-bd10-c5a78b5a5fec", "AQAAAAEAACcQAAAAEGX33jzwNz+K3dfL6HUYvOzSRZ7pX+dPVACU1sC5zxzVUjbPDR5fNTQkA5MeJyyF0w==", "75b8ef23-73c0-48ba-91f3-8451eeee8641" });
        }
    }
}
