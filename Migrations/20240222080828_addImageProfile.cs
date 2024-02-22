using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCollage_EF_Rep_AsyncAwait.Migrations
{
    /// <inheritdoc />
    public partial class addImageProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageProfile",
                table: "Students",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageProfile",
                table: "Students");
        }
    }
}
