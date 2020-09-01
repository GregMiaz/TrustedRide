using Microsoft.EntityFrameworkCore.Migrations;

namespace TrustedRide.Infrastructure.Migrations
{
    public partial class AddDealerCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DealerCartItems",
                columns: table => new
                {
                    DealerCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    DealerCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerCartItems", x => x.DealerCartItemId);
                    table.ForeignKey(
                        name: "FK_DealerCartItems_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DealerCartItems_CarId",
                table: "DealerCartItems",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DealerCartItems");
        }
    }
}
