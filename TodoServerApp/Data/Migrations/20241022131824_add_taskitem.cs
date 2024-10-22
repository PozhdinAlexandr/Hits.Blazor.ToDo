using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 22, 18, 18, 24, 137, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 10, 24, 18, 18, 24, 137, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 22, 18, 18, 24, 137, DateTimeKind.Local).AddTicks(9945), new DateTime(2024, 10, 27, 18, 18, 24, 137, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 22, 18, 18, 24, 137, DateTimeKind.Local).AddTicks(9947), new DateTime(2024, 11, 25, 18, 18, 24, 137, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 22, 18, 18, 24, 137, DateTimeKind.Local).AddTicks(9949), new DateTime(2024, 12, 13, 18, 18, 24, 137, DateTimeKind.Local).AddTicks(9949) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4273), new DateTime(2024, 10, 23, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4303), new DateTime(2024, 10, 26, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4305), new DateTime(2024, 11, 24, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4308), new DateTime(2024, 12, 12, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4308) });
        }
    }
}
