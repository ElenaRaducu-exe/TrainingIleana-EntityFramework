using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp_EFCore_CodeFirstStrategy.Migrations
{
    /// <inheritdoc />
    public partial class AddNumberPagesColumnToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberPages",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberPages",
                table: "Books");
        }
    }
}
