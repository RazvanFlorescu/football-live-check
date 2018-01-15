using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FootballLiveCheck.Data.Migrations
{
    public partial class CreatedArenaIdAndCurrentStateInMatchesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leagues_Region_RegionId",
                table: "Leagues");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Leagues_LeagueId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Outcome_OutcomeId",
                table: "Matches");

            migrationBuilder.DropTable(
                name: "Outcome");

            migrationBuilder.DropIndex(
                name: "IX_Matches_LeagueId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_OutcomeId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "OutcomeId",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "CurrentStateId",
                table: "Matches",
                newName: "CurrentState");

            migrationBuilder.AddColumn<int>(
                name: "ArenaId",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Leagues",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Leagues_Region_RegionId",
                table: "Leagues",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leagues_Region_RegionId",
                table: "Leagues");

            migrationBuilder.DropColumn(
                name: "ArenaId",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "CurrentState",
                table: "Matches",
                newName: "CurrentStateId");

            migrationBuilder.AddColumn<Guid>(
                name: "OutcomeId",
                table: "Matches",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Leagues",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Outcome",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AfterExtraTime = table.Column<bool>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Winner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outcome", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_LeagueId",
                table: "Matches",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_OutcomeId",
                table: "Matches",
                column: "OutcomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leagues_Region_RegionId",
                table: "Leagues",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Leagues_LeagueId",
                table: "Matches",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Outcome_OutcomeId",
                table: "Matches",
                column: "OutcomeId",
                principalTable: "Outcome",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
