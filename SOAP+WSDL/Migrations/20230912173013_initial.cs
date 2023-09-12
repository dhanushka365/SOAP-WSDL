using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SOAP_WSDL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[,]
                {
                    { new Guid("15b508b6-0b06-4a17-b9fa-c4e7bcc4d780"), "Support" },
                    { new Guid("407196ae-4e83-423f-adb0-b04f5ef1cfef"), "Quality Assuarance" },
                    { new Guid("85ee90c9-fea5-42f4-a937-15e5ffe04e44"), "Human Resource" },
                    { new Guid("e55e6a1a-80f8-465c-bcec-5aa8aeae5d5b"), "Managed Services" },
                    { new Guid("f984f49c-3c1f-437e-8c0f-632e57db0283"), "Engineering" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
