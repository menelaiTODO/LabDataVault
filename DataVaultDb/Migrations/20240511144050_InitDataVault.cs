using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataVaultDb.Migrations
{
    /// <inheritdoc />
    public partial class InitDataVault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyHub",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BKHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyHub", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsHub",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BKHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsHub", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OrderHub",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BKHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHub", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CompanySat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    company_hub_id = table.Column<int>(type: "int", nullable: false),
                    LoadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySat", x => x.id);
                    table.ForeignKey(
                        name: "FK_CompanySat_CompanyHub_company_hub_id",
                        column: x => x.company_hub_id,
                        principalTable: "CompanyHub",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GoodsSat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sale_price = table.Column<double>(type: "float", nullable: false),
                    goods_hub_id = table.Column<int>(type: "int", nullable: false),
                    LoadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsSat", x => x.id);
                    table.ForeignKey(
                        name: "FK_GoodsSat_GoodsHub_goods_hub_id",
                        column: x => x.goods_hub_id,
                        principalTable: "GoodsHub",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderCompanyLink",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_hub_id = table.Column<int>(type: "int", nullable: false),
                    company_hub_id = table.Column<int>(type: "int", nullable: false),
                    LoadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCompanyLink", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderCompanyLink_CompanyHub_company_hub_id",
                        column: x => x.company_hub_id,
                        principalTable: "CompanyHub",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderCompanyLink_OrderHub_order_hub_id",
                        column: x => x.order_hub_id,
                        principalTable: "OrderHub",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderGoodsLink",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_hub_id = table.Column<int>(type: "int", nullable: false),
                    goods_hub_id = table.Column<int>(type: "int", nullable: false),
                    LoadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderGoodsLink", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderGoodsLink_GoodsHub_goods_hub_id",
                        column: x => x.goods_hub_id,
                        principalTable: "GoodsHub",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderGoodsLink_OrderHub_order_hub_id",
                        column: x => x.order_hub_id,
                        principalTable: "OrderHub",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderSat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_id = table.Column<int>(type: "int", nullable: false),
                    shipment_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderHubId = table.Column<int>(type: "int", nullable: true),
                    LoadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSat", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderSat_OrderHub_OrderHubId",
                        column: x => x.OrderHubId,
                        principalTable: "OrderHub",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "OrderCompanyLinkSat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_company_link_id = table.Column<int>(type: "int", nullable: false),
                    LoadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCompanyLinkSat", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderCompanyLinkSat_OrderCompanyLink_order_company_link_id",
                        column: x => x.order_company_link_id,
                        principalTable: "OrderCompanyLink",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderGoodsLinkSat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_goods_link_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    LoadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderGoodsLinkSat", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderGoodsLinkSat_OrderGoodsLink_order_goods_link_id",
                        column: x => x.order_goods_link_id,
                        principalTable: "OrderGoodsLink",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanySat_company_hub_id",
                table: "CompanySat",
                column: "company_hub_id");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsSat_goods_hub_id",
                table: "GoodsSat",
                column: "goods_hub_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCompanyLink_company_hub_id",
                table: "OrderCompanyLink",
                column: "company_hub_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCompanyLink_order_hub_id",
                table: "OrderCompanyLink",
                column: "order_hub_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCompanyLinkSat_order_company_link_id",
                table: "OrderCompanyLinkSat",
                column: "order_company_link_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderGoodsLink_goods_hub_id",
                table: "OrderGoodsLink",
                column: "goods_hub_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderGoodsLink_order_hub_id",
                table: "OrderGoodsLink",
                column: "order_hub_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderGoodsLinkSat_order_goods_link_id",
                table: "OrderGoodsLinkSat",
                column: "order_goods_link_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSat_OrderHubId",
                table: "OrderSat",
                column: "OrderHubId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanySat");

            migrationBuilder.DropTable(
                name: "GoodsSat");

            migrationBuilder.DropTable(
                name: "OrderCompanyLinkSat");

            migrationBuilder.DropTable(
                name: "OrderGoodsLinkSat");

            migrationBuilder.DropTable(
                name: "OrderSat");

            migrationBuilder.DropTable(
                name: "OrderCompanyLink");

            migrationBuilder.DropTable(
                name: "OrderGoodsLink");

            migrationBuilder.DropTable(
                name: "CompanyHub");

            migrationBuilder.DropTable(
                name: "GoodsHub");

            migrationBuilder.DropTable(
                name: "OrderHub");
        }
    }
}
