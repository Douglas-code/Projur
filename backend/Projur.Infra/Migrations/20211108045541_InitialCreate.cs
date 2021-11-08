using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projur.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(160)", maxLength: 160, nullable: true),
                    surname = table.Column<string>(type: "varchar(160)", maxLength: 160, nullable: true),
                    email = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true),
                    birth_date = table.Column<DateTime>(type: "date", nullable: false),
                    schooling = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_user", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_user");
        }
    }
}
