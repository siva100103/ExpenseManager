﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseManager.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    BudgetId = table.Column<string>(type: "varchar(36) CHARACTER SET utf8mb4", nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Month = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.BudgetId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "varchar(36) CHARACTER SET utf8mb4", nullable: false),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseId = table.Column<string>(type: "varchar(36) CHARACTER SET utf8mb4", nullable: false),
                    ExpenseCategoryId = table.Column<string>(nullable: true),
                    ExpenseAmount = table.Column<int>(nullable: false),
                    ExpenseTime = table.Column<DateTime>(nullable: false),
                    ExpenseNotes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Expenses");
        }
    }
}
