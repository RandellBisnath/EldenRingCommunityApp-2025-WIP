using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldenRingCommunityApp.Migrations
{
    /// <inheritdoc />
    public partial class tutorialsImplemented : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YouTubeVideoId",
                table: "Tutorials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YouTubeVideoId",
                table: "Tutorials");
        }
    }
}
