using Microsoft.EntityFrameworkCore.Migrations;

namespace ArticleManagement.Migrations
{
    public partial class ArticleManagementContextAddArticleTopic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Topic",
                table: "Articles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Topic",
                table: "Articles");
        }
    }
}
