using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSDProject.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "b3aec230-b948-40d2-8cbc-507869db7c45", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAew7ckZG6KnCxXwbEple5RXLb6PuEDP+hc+LYYZ9+lL5eJtCa5nKZyD/gIz8mbm9A==", null, false, "cb30a0a4-92a4-4f08-9e4b-0a281b63dd10", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { "Id", "CompanyDescription", "CompanyFoundedYear", "CompanyIndustry", "CompanyLocation", "CompanyName", "CompanyWebsite", "ContactEmail", "ContactNumber", "ContactPerson", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "NVIDIA pioneered accelerated computing to tackle challenges no one else can solve. Our work in AI and digital twins is transforming the world's largest industries and profoundly impacting society.", "05/04/1993", "Consumer electronics", "Santa Clara, California, U.S.", "Nvidia Corporation", "www.nvidia.com", null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "IMDA is a driving force behind Singapore's digital transformation efforts by building the foundations of its digital infrastructure and driving digital innovation for a vibrant digital workforce and a safe and inclusive digital society that can thrive in today's fast-evolving digital landscape in Singapore.", "01/10/2016", "Infocomm and Media", "10 Pasir Panjang Road, #03-01, Mapletree Business City, Singapore 117438", "InfoCommunications Media Development Authority", "www.imda.gov.sg", null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CompanyID", "CreatedBy", "DateCreated", "DateUpdated", "JobCategory", "JobDeadline", "JobDescription", "JobEducation", "JobLevel", "JobLocation", "JobSalary", "JobTitle", "StaffID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "You will be working on our clients project that will involve building out the founding Engineering team based in Singapore. This is a Backend Engineer position that is data-focused. This is a unique position given that you will have the opportunity to work on the backend to the entire ELT data pipeline for our client and at the same time be working closely with customers to understand their needs.", "Expert proficiency in SQL & any popular backend languages e.g Python, Javascript/Typescript, Go etc", "Advisor", "Tampines", "110000", "Software Engineer", null, null },
                    { 2, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage the open source repositories, ensuring all codes are properly structured, tagged, and are in working order. Create, track, manage, and engage the community on issues relating to the codebase, including bugs and feature requests.", "Proficient with CI/CD tools and concepts, such as Lint, PyTest, and automated build and test approaches. Knowledge of security IAST and SCA tools is a plus", "Employee", "Pasir Panjang", "120000", "Software Engineer (AI Verify)", null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
