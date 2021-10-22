using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Refactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coaches_Students_StudentId",
                table: "Coaches");

            migrationBuilder.DropIndex(
                name: "IX_Coaches_StudentId",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Coaches");

            migrationBuilder.AddColumn<Guid>(
                name: "CoachId",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FriendId",
                table: "Coaches",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_CoachId",
                table: "Students",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_FriendId",
                table: "Coaches",
                column: "FriendId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coaches_Coaches_FriendId",
                table: "Coaches",
                column: "FriendId",
                principalTable: "Coaches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Coaches_CoachId",
                table: "Students",
                column: "CoachId",
                principalTable: "Coaches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coaches_Coaches_FriendId",
                table: "Coaches");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Coaches_CoachId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CoachId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Coaches_FriendId",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FriendId",
                table: "Coaches");

            migrationBuilder.AddColumn<Guid>(
                name: "StudentId",
                table: "Coaches",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_StudentId",
                table: "Coaches",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coaches_Students_StudentId",
                table: "Coaches",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
