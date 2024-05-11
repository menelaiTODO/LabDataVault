﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OLTPDatabaseCore.Migrations
{
    /// <inheritdoc />
    public partial class QuantityIntoOrderGoods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "OrderGoods",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity",
                table: "OrderGoods");
        }
    }
}
