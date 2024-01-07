using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductCatalogue.Migrations
{
    /// <inheritdoc />
    public partial class Properties1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PropertyValue",
                table: "PropertyDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PropertyValue",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
