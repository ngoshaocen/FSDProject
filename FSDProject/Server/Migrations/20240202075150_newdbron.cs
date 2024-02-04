using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSDProject.Server.Migrations
{
    /// <inheritdoc />
    public partial class newdbron : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsultationSessions_Consultants_ConsultantID",
                table: "ConsultationSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsultationSessions_JobSeekers_JobSeekerID",
                table: "ConsultationSessions");

            migrationBuilder.AlterColumn<int>(
                name: "JobSeekerID",
                table: "ConsultationSessions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ConsultantID",
                table: "ConsultationSessions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CSessionType",
                table: "ConsultationSessions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bbdd4b3-10f3-4d30-bbdc-e9ce5f8866c1", "AQAAAAIAAYagAAAAELXyYpslLN7Azfs3pU8USBheKNYwA/i6FSHQKjJjIUY4SlI75jxJ/hGnIkZqXG0Uzw==", "80e35a7d-f041-4d70-bb65-84808dee4cdf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8090b62-0e8c-4631-a3fb-717ebe2a55ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad571ebb-5e68-449e-b092-2424bd134d34", "AQAAAAIAAYagAAAAEAYZ1WV/FBa4LYMnh1f+eQAD/BU6EsQO1Bl9BVmhPFxQmVEbZfgcSd1Dyn1uLcgBhw==", "fbc867eb-20c2-48cc-a8b1-77800c624d02" });

            migrationBuilder.UpdateData(
                table: "ConsultationSessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CSessionDate",
                value: new DateTime(2024, 2, 9, 15, 51, 50, 167, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "ConsultationSessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CSessionDate",
                value: new DateTime(2024, 2, 16, 15, 51, 50, 167, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultationSessions_Consultants_ConsultantID",
                table: "ConsultationSessions",
                column: "ConsultantID",
                principalTable: "Consultants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultationSessions_JobSeekers_JobSeekerID",
                table: "ConsultationSessions",
                column: "JobSeekerID",
                principalTable: "JobSeekers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsultationSessions_Consultants_ConsultantID",
                table: "ConsultationSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsultationSessions_JobSeekers_JobSeekerID",
                table: "ConsultationSessions");

            migrationBuilder.AlterColumn<int>(
                name: "JobSeekerID",
                table: "ConsultationSessions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConsultantID",
                table: "ConsultationSessions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CSessionType",
                table: "ConsultationSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1de37611-0ab2-4ba2-874e-35add8d76b60", "AQAAAAIAAYagAAAAEPd0ZALRDs9j2ek6KQ48hYU0ffQnKbXKUTd+s35lOrBaHGhmmusDJYCoZYGEtXyWjw==", "cfde052d-3365-4db2-a297-37915b3a87e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8090b62-0e8c-4631-a3fb-717ebe2a55ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7f28c06-dbfd-41b3-bd89-4a9c855fb78d", "AQAAAAIAAYagAAAAENz/pH153QjA4ISqR/RLqOOlzTWLZAM8G1s6UN+rtYip1slgVxvEBQ8bvXn3neeu+A==", "143f1d3b-1eb9-4378-a9b4-9d2e5c14acc3" });

            migrationBuilder.UpdateData(
                table: "ConsultationSessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CSessionDate",
                value: new DateTime(2024, 2, 7, 22, 28, 47, 826, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "ConsultationSessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CSessionDate",
                value: new DateTime(2024, 2, 14, 22, 28, 47, 826, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultationSessions_Consultants_ConsultantID",
                table: "ConsultationSessions",
                column: "ConsultantID",
                principalTable: "Consultants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultationSessions_JobSeekers_JobSeekerID",
                table: "ConsultationSessions",
                column: "JobSeekerID",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
