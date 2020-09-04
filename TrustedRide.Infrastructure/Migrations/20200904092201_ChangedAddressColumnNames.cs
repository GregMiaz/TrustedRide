using Microsoft.EntityFrameworkCore.Migrations;

namespace TrustedRide.Infrastructure.Migrations
{
    public partial class ChangedAddressColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "AddressField1",
                table: "Orders",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressField2",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressField1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AddressField2",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "Orders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
