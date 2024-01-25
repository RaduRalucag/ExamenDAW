using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenDAW.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asociativas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asociativas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eveniments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AsociativaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eveniments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_eveniments_asociativas_AsociativaId",
                        column: x => x.AsociativaId,
                        principalTable: "asociativas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "participants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AsociativaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Experienta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numar = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_participants_asociativas_AsociativaId",
                        column: x => x.AsociativaId,
                        principalTable: "asociativas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_eveniments_AsociativaId",
                table: "eveniments",
                column: "AsociativaId");

            migrationBuilder.CreateIndex(
                name: "IX_eveniments_Nume",
                table: "eveniments",
                column: "Nume",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_participants_AsociativaId",
                table: "participants",
                column: "AsociativaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eveniments");

            migrationBuilder.DropTable(
                name: "participants");

            migrationBuilder.DropTable(
                name: "asociativas");
        }
    }
}
