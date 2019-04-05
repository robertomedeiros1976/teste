using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FullstackDeveloperAssessment.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    VAT = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    SecretCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.VAT);
                });

            migrationBuilder.CreateTable(
                name: "PersonAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonVAT = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    StateProvinceRegion = table.Column<string>(maxLength: 50, nullable: false),
                    PostalZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    Country = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonAddresses_Persons_PersonVAT",
                        column: x => x.PersonVAT,
                        principalTable: "Persons",
                        principalColumn: "VAT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonVAT = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 30, nullable: false),
                    PersonVAT1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonTypes_Persons_PersonVAT",
                        column: x => x.PersonVAT,
                        principalTable: "Persons",
                        principalColumn: "VAT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonTypes_Persons_PersonVAT1",
                        column: x => x.PersonVAT1,
                        principalTable: "Persons",
                        principalColumn: "VAT",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddresses_PersonVAT",
                table: "PersonAddresses",
                column: "PersonVAT");

            migrationBuilder.CreateIndex(
                name: "IX_PersonTypes_PersonVAT",
                table: "PersonTypes",
                column: "PersonVAT");

            migrationBuilder.CreateIndex(
                name: "IX_PersonTypes_PersonVAT1",
                table: "PersonTypes",
                column: "PersonVAT1");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_PersonAddresses_VAT",
                table: "Persons",
                column: "VAT",
                principalTable: "PersonAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonAddresses_Persons_PersonVAT",
                table: "PersonAddresses");

            migrationBuilder.DropTable(
                name: "PersonTypes");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "PersonAddresses");
        }
    }
}
