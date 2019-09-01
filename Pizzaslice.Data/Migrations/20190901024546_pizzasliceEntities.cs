using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzaslice.Data.Migrations
{
    public partial class pizzasliceEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cheeses",
                columns: table => new
                {
                    CheeseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CheeseName = table.Column<string>(nullable: true),
                    CheesePrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheeses", x => x.CheeseId);
                });

            migrationBuilder.CreateTable(
                name: "Crusts",
                columns: table => new
                {
                    CrustId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CrustName = table.Column<string>(nullable: true),
                    CrustPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crusts", x => x.CrustId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationName = table.Column<string>(nullable: true),
                    LocationAddress = table.Column<string>(nullable: true),
                    LocationZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Meats",
                columns: table => new
                {
                    MeatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeatName = table.Column<string>(nullable: true),
                    MeatPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meats", x => x.MeatId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    totalPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Sauces",
                columns: table => new
                {
                    SauceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SauceName = table.Column<string>(nullable: true),
                    SaucePrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauces", x => x.SauceId);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SizeName = table.Column<string>(nullable: true),
                    SizePrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    UserPassword = table.Column<string>(nullable: true),
                    UserEmail = table.Column<string>(nullable: true),
                    UserZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Veggies",
                columns: table => new
                {
                    VeggieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VeggieName = table.Column<string>(nullable: true),
                    VeggiePrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veggies", x => x.VeggieId);
                });

            // migrationBuilder.CreateTable(
            //     name: "OrderHistories",
            //     columns: table => new
            //     {
            //         OrderHistoryId = table.Column<int>(nullable: false)
            //             .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //         UserId = table.Column<int>(nullable: true),
            //         LocationId1 = table.Column<int>(nullable: true),
            //         OrderId1 = table.Column<int>(nullable: true),
            //         USerOrderDate = table.Column<DateTime>(nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_OrderHistories", x => x.OrderHistoryId);
            //         table.ForeignKey(
            //             name: "FK_OrderHistories_Locations_LocationId1",
            //             column: x => x.LocationId1,
            //             principalTable: "Locations",
            //             principalColumn: "LocationId",
            //             onDelete: ReferentialAction.Restrict);
            //         table.ForeignKey(
            //             name: "FK_OrderHistories_Orders_OrderId1",
            //             column: x => x.OrderId1,
            //             principalTable: "Orders",
            //             principalColumn: "OrderId",
            //             onDelete: ReferentialAction.Restrict);
            //         table.ForeignKey(
            //             name: "FK_OrderHistories_Users_UserId",
            //             column: x => x.UserId,
            //             principalTable: "Users",
            //             principalColumn: "UserId",
            //             onDelete: ReferentialAction.Restrict);
            //     });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    PizzaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MyCrustCrustId = table.Column<int>(nullable: true),
                    MySizeSizeId = table.Column<int>(nullable: true),
                    MySauceSauceId = table.Column<int>(nullable: true),
                    MyCheeseCheeseId = table.Column<int>(nullable: true),
                    MyMeatMeatId = table.Column<int>(nullable: true),
                    MyVeggieVeggieId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.PizzaId);
                    table.ForeignKey(
                        name: "FK_Pizzas_Cheeses_MyCheeseCheeseId",
                        column: x => x.MyCheeseCheeseId,
                        principalTable: "Cheeses",
                        principalColumn: "CheeseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Crusts_MyCrustCrustId",
                        column: x => x.MyCrustCrustId,
                        principalTable: "Crusts",
                        principalColumn: "CrustId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Meats_MyMeatMeatId",
                        column: x => x.MyMeatMeatId,
                        principalTable: "Meats",
                        principalColumn: "MeatId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Sauces_MySauceSauceId",
                        column: x => x.MySauceSauceId,
                        principalTable: "Sauces",
                        principalColumn: "SauceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Sizes_MySizeSizeId",
                        column: x => x.MySizeSizeId,
                        principalTable: "Sizes",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Veggies_MyVeggieVeggieId",
                        column: x => x.MyVeggieVeggieId,
                        principalTable: "Veggies",
                        principalColumn: "VeggieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            // migrationBuilder.CreateIndex(
            //     name: "IX_OrderHistories_LocationId1",
            //     table: "OrderHistories",
            //     column: "LocationId1");

            // migrationBuilder.CreateIndex(
            //     name: "IX_OrderHistories_OrderId1",
            //     table: "OrderHistories",
            //     column: "OrderId1");

            // migrationBuilder.CreateIndex(
            //     name: "IX_OrderHistories_UserId",
            //     table: "OrderHistories",
            //     column: "UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_OrderId",
                table: "Pizzas",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "OrderHistories");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cheeses");

            migrationBuilder.DropTable(
                name: "Crusts");

            migrationBuilder.DropTable(
                name: "Meats");

            migrationBuilder.DropTable(
                name: "Sauces");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Veggies");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
