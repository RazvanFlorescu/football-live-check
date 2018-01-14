using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FootballLiveCheck.Data.Migrations
{
    public partial class ChangedDeleteBehaviorToRestrict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leagues_Region_RegionId",
                table: "Leagues");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_AwayTeamId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_HomeTeamId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Leagues_LeagueId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Outcome_OutcomeId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Season_SeasonId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Arena_ArenaId",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_ArenaId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Matches_AwayTeamId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_HomeTeamId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Teams",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ArenaId",
                table: "Teams",
                newName: "DbId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Season",
                newName: "DbId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Region",
                newName: "DbId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Matches",
                newName: "DbId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Leagues",
                newName: "DbId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Arena",
                newName: "DbId");

            migrationBuilder.AddColumn<int>(
                name: "TeamDbId",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "DbId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TeamDbId",
                table: "Matches",
                column: "TeamDbId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arena_Teams_DbId",
                table: "Arena",
                column: "DbId",
                principalTable: "Teams",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Season_SeasonId",
                table: "Matches",
                column: "SeasonId",
                principalTable: "Season",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_TeamDbId",
                table: "Matches",
                column: "TeamDbId",
                principalTable: "Teams",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arena_Teams_DbId",
                table: "Arena");

            migrationBuilder.DropForeignKey(
                name: "FK_Leagues_Region_RegionId",
                table: "Leagues");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Leagues_LeagueId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Outcome_OutcomeId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Season_SeasonId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_TeamDbId",
                table: "Matches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Matches_TeamDbId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "TeamDbId",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Teams",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "DbId",
                table: "Teams",
                newName: "ArenaId");

            migrationBuilder.RenameColumn(
                name: "DbId",
                table: "Season",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DbId",
                table: "Region",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DbId",
                table: "Matches",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DbId",
                table: "Leagues",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DbId",
                table: "Arena",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ArenaId",
                table: "Teams",
                column: "ArenaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_AwayTeamId",
                table: "Matches",
                column: "AwayTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HomeTeamId",
                table: "Matches",
                column: "HomeTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leagues_Region_RegionId",
                table: "Leagues",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_AwayTeamId",
                table: "Matches",
                column: "AwayTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_HomeTeamId",
                table: "Matches",
                column: "HomeTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Leagues_LeagueId",
                table: "Matches",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Outcome_OutcomeId",
                table: "Matches",
                column: "OutcomeId",
                principalTable: "Outcome",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Season_SeasonId",
                table: "Matches",
                column: "SeasonId",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Arena_ArenaId",
                table: "Teams",
                column: "ArenaId",
                principalTable: "Arena",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
