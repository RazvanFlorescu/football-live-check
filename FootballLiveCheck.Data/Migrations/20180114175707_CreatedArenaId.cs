using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FootballLiveCheck.Data.Migrations
{
    public partial class CreatedArenaId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arena_Teams_DbId",
                table: "Arena");

            migrationBuilder.AddColumn<int>(
                name: "ArenaId",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Capacity",
                table: "Arena",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ArenaId",
                table: "Teams",
                column: "ArenaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Arena_ArenaId",
                table: "Teams",
                column: "ArenaId",
                principalTable: "Arena",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Arena_ArenaId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_ArenaId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ArenaId",
                table: "Teams");

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Arena",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Arena_Teams_DbId",
                table: "Arena",
                column: "DbId",
                principalTable: "Teams",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
