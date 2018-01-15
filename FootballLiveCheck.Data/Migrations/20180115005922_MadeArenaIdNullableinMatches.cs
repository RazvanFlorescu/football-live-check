using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FootballLiveCheck.Data.Migrations
{
    public partial class MadeArenaIdNullableinMatches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ArenaId",
                table: "Matches",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ArenaId",
                table: "Matches",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
