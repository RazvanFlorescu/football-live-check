using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FootballLiveCheck.Data.Migrations
{
    public partial class UpdateTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "Points",
                table: "Teams",
                newName: "ApiId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Teams",
                newName: "ShortName");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShirtUrl",
                table: "Teams",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ShirtUrl",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "ShortName",
                table: "Teams",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ApiId",
                table: "Teams",
                newName: "Points");

            migrationBuilder.AddColumn<Guid>(
                name: "LeagueId",
                table: "Teams",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
