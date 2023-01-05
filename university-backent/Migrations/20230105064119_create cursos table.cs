using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace universitybackent.Migrations
{
    /// <inheritdoc />
    public partial class createcursostable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcioncorta = table.Column<string>(name: "descripcion_corta", type: "nvarchar(280)", maxLength: 280, nullable: false),
                    Descripcionlarga = table.Column<string>(name: "Descripcion_larga", type: "nvarchar(700)", maxLength: 700, nullable: false),
                    publicoobjetivo = table.Column<string>(name: "publico_objetivo", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    objetivo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    requicitos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    nivel = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
