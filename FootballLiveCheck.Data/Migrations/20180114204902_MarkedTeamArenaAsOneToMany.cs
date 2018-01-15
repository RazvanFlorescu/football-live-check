using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FootballLiveCheck.Data.Migrations
{
    public partial class MarkedTeamArenaAsOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teams_ArenaId",
                table: "Teams");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ArenaId",
                table: "Teams",
                column: "ArenaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teams_ArenaId",
                table: "Teams");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ArenaId",
                table: "Teams",
                column: "ArenaId",
                unique: true,
                filter: "[ArenaId] IS NOT NULL");
        }
    }
}
