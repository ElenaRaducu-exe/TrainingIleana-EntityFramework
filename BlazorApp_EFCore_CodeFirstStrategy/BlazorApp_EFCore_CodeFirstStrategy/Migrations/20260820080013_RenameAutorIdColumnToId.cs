using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp_EFCore_CodeFirstStrategy.Migrations
{
    /// <inheritdoc />
    public partial class RenameAutorIdColumnToId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AutorId",
                table: "Autors",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Autors",
                newName: "AutorId");
        }
    }
}
