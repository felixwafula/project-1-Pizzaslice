using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzaslice.Data.Migrations
{
    public partial class ChangedPizzaProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Cheeses_MyCheeseCheeseId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crusts_MyCrustCrustId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Meats_MyMeatMeatId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sauces_MySauceSauceId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_MySizeSizeId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Veggies_MyVeggieVeggieId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_MyCheeseCheeseId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_MyCrustCrustId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_MyMeatMeatId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_MySauceSauceId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_MySizeSizeId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_MyVeggieVeggieId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "MyCheeseCheeseId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "MyCrustCrustId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "MyMeatMeatId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "MySauceSauceId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "MySizeSizeId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "MyVeggieVeggieId",
                table: "Pizzas");

            migrationBuilder.AddColumn<string>(
                name: "MyCheese",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MyCrust",
                table: "Pizzas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MyMeat",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MySauce",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MySize",
                table: "Pizzas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MyVeggie",
                table: "Pizzas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyCheese",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "MyCrust",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "MyMeat",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "MySauce",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "MySize",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "MyVeggie",
                table: "Pizzas");

            migrationBuilder.AddColumn<int>(
                name: "MyCheeseCheeseId",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyCrustCrustId",
                table: "Pizzas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MyMeatMeatId",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MySauceSauceId",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MySizeSizeId",
                table: "Pizzas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MyVeggieVeggieId",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_MyCheeseCheeseId",
                table: "Pizzas",
                column: "MyCheeseCheeseId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_MyCrustCrustId",
                table: "Pizzas",
                column: "MyCrustCrustId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_MyMeatMeatId",
                table: "Pizzas",
                column: "MyMeatMeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_MySauceSauceId",
                table: "Pizzas",
                column: "MySauceSauceId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_MySizeSizeId",
                table: "Pizzas",
                column: "MySizeSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_MyVeggieVeggieId",
                table: "Pizzas",
                column: "MyVeggieVeggieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Cheeses_MyCheeseCheeseId",
                table: "Pizzas",
                column: "MyCheeseCheeseId",
                principalTable: "Cheeses",
                principalColumn: "CheeseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crusts_MyCrustCrustId",
                table: "Pizzas",
                column: "MyCrustCrustId",
                principalTable: "Crusts",
                principalColumn: "CrustId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Meats_MyMeatMeatId",
                table: "Pizzas",
                column: "MyMeatMeatId",
                principalTable: "Meats",
                principalColumn: "MeatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sauces_MySauceSauceId",
                table: "Pizzas",
                column: "MySauceSauceId",
                principalTable: "Sauces",
                principalColumn: "SauceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sizes_MySizeSizeId",
                table: "Pizzas",
                column: "MySizeSizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Veggies_MyVeggieVeggieId",
                table: "Pizzas",
                column: "MyVeggieVeggieId",
                principalTable: "Veggies",
                principalColumn: "VeggieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
