using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PickleBall.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveWalletFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourtGroup_Wallet_WalletId",
                table: "CourtGroup");

            migrationBuilder.DropIndex(
                name: "IX_CourtGroup_WalletId",
                table: "CourtGroup");

            migrationBuilder.DropColumn(
                name: "WalletId",
                table: "CourtGroup");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "WalletId",
                table: "CourtGroup",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_CourtGroup_WalletId",
                table: "CourtGroup",
                column: "WalletId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourtGroup_Wallet_WalletId",
                table: "CourtGroup",
                column: "WalletId",
                principalTable: "Wallet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
