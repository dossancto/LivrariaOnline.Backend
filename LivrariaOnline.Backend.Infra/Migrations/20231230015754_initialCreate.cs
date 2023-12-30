using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LivrariaOnline.Backend.Infra.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(21)", maxLength: 21, nullable: false),
                    Address = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    CEP = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: false),
                    City = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Latitude = table.Column<string>(type: "text", nullable: false),
                    Longitude = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(21)", maxLength: 21, nullable: false),
                    RolesJson = table.Column<string>(type: "text", nullable: false),
                    AddressId = table.Column<string>(type: "character varying(21)", nullable: true),
                    Name = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    Email = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    EmailStatus = table.Column<int>(type: "integer", nullable: false),
                    HashedPassword = table.Column<string>(type: "text", nullable: false),
                    Salt = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserAddress_AddressId",
                        column: x => x.AddressId,
                        principalTable: "UserAddress",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserEmailConfirmation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(21)", maxLength: 21, nullable: false),
                    UserId = table.Column<string>(type: "character varying(21)", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    ValidTill = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GeneratedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GenerationType = table.Column<int>(type: "integer", nullable: false),
                    Expired = table.Column<bool>(type: "boolean", nullable: false),
                    Confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    ConfirmedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEmailConfirmation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEmailConfirmation_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserEmailConfirmation_Code",
                table: "UserEmailConfirmation",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmailConfirmation_UserId",
                table: "UserEmailConfirmation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressId",
                table: "Users",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserEmailConfirmation");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserAddress");
        }
    }
}
