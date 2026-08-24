using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp_EFCore_CodeFirstStrategy.Migrations
{
    /// <inheritdoc />
    public partial class RenameBookIdColumnToId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Books",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "BookId");
        }
    }
}
