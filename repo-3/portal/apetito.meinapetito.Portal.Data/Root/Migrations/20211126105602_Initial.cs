﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apetito.meinapetito.Portal.Data.Root.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerNumbersOfUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerNumber = table.Column<int>(type: "int", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerNumbersOfUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SortimentsOfCustomerNumbers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerNumber = table.Column<int>(type: "int", nullable: false),
                    SortimentCode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SortimentsOfCustomerNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    B2CUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AspNetUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerNumbersOfUsers_UserId_CustomerNumber",
                table: "CustomerNumbersOfUsers",
                columns: new[] { "UserId", "CustomerNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SortimentsOfCustomerNumbers_CustomerNumber_SortimentCode",
                table: "SortimentsOfCustomerNumbers",
                columns: new[] { "CustomerNumber", "SortimentCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_B2CUserId",
                table: "Users",
                column: "B2CUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserEmail",
                table: "Users",
                column: "UserEmail",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerNumbersOfUsers");

            migrationBuilder.DropTable(
                name: "SortimentsOfCustomerNumbers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
