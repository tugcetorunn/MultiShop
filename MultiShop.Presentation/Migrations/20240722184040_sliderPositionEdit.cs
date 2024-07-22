using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiShop.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class sliderPositionEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CategoryName",
                value: "Phone");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 6,
                column: "Position",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 7,
                column: "Position",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CategoryName",
                value: "Phonfe");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 6,
                column: "Position",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 7,
                column: "Position",
                value: 2);
        }
    }
}
