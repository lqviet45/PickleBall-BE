using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PickleBall.Persistence.migrations
{
    /// <inheritdoc />
    public partial class AddorderCodeToTrans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "TransactionProduct",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "TransactionProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "OrderCode",
                table: "Transaction",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "TransactionProduct");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "TransactionProduct");

            migrationBuilder.DropColumn(
                name: "OrderCode",
                table: "Transaction");
        }
    }
}
