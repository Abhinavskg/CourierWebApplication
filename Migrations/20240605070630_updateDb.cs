using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierWebApp.Migrations
{
    /// <inheritdoc />
    public partial class updateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Customer",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06603f82-a17f-4b74-bd1c-5e3dbe2c8e3e", "AQAAAAIAAYagAAAAEEz7lvufSdeSFL3bHGIv19Sie+NG6ZB5jcXOCu6vG2i0anVskKCcsPwRbrl4dIGRRg==", "3a0bee5e-dfdd-4a1a-95a4-0f505366934f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab7b536a-94e9-409f-a7c7-a619c86e13b4", "AQAAAAIAAYagAAAAELzJgQDYf51174vFlEILQgCfASNCmAA/Ke/OJKhQ6JvgBJ0oMOYAeawwAj88Ahbt3g==", "b8040c2f-90e4-4a78-98b8-2030eee26351" });
        }
    }
}
