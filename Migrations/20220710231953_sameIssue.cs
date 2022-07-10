﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallStructuresTakeOffs.Migrations
{
    public partial class sameIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatchBasins_Projects_ProjectId",
                table: "CatchBasins");

            migrationBuilder.AlterColumn<long>(
                name: "ProjectId",
                table: "CatchBasins",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "ProjId",
                table: "CatchBasins",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddForeignKey(
                name: "FK_CatchBasins_Projects_ProjectId",
                table: "CatchBasins",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatchBasins_Projects_ProjectId",
                table: "CatchBasins");

            migrationBuilder.DropColumn(
                name: "ProjId",
                table: "CatchBasins");

            migrationBuilder.AlterColumn<long>(
                name: "ProjectId",
                table: "CatchBasins",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CatchBasins_Projects_ProjectId",
                table: "CatchBasins",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
