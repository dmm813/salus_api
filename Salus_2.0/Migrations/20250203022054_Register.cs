using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salus_2._0.Migrations
{
    /// <inheritdoc />
    public partial class Register : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cargo = table.Column<int>(type: "int", nullable: false),
                    senhaHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    senhaSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    tokenDataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Register");
        }
    }
}
