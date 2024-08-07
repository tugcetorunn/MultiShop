
#nullable disable

namespace MultiShop.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class commentEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProductComments",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "ProductComments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 27,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 28,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 29,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 30,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 31,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 32,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 33,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 34,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 35,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 36,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 37,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 38,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 39,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 40,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 41,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 42,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 44,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 45,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 46,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 47,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 48,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 49,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 50,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 51,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 52,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 53,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 54,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 55,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 56,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 57,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 59,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 61,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 65,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 67,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 68,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 69,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 70,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 72,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 73,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 74,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 75,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 76,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 77,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 78,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 79,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 80,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 81,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 82,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 83,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 84,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 85,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 86,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 87,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 88,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 89,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 90,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 91,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 92,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 93,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 94,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 95,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 96,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 97,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 98,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 99,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 100,
                columns: new[] { "CreatedDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CategoryId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ProductComments");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProductComments");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "ProductComments");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CategoryId",
                value: 5);
        }
    }
}
