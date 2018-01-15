using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FootballLiveCheck.Data.Migrations
{
    public partial class MarkedArenaIdAsNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Arena_ArenaId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_ArenaId",
                table: "Teams");

            migrationBuilder.AlterColumn<int>(
                name: "ArenaId",
                table: "Teams",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ArenaId",
                table: "Teams",
                column: "ArenaId",
                unique: true,
                filter: "[ArenaId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Arena_ArenaId",
                table: "Teams",
                column: "ArenaId",
                principalTable: "Arena",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Arena_ArenaId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_ArenaId",
                table: "Teams");

            migrationBuilder.AlterColumn<int>(
                name: "ArenaId",
                table: "Teams",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
    }
}
