using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RJP.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    PosterPath = table.Column<string>(nullable: true),
                    Adult = table.Column<bool>(nullable: false),
                    Overview = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OriginalTitle = table.Column<string>(nullable: true),
                    OriginalLanguage = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    BackdropPath = table.Column<string>(nullable: true),
                    Popularity = table.Column<decimal>(nullable: false),
                    VoteCount = table.Column<int>(nullable: false),
                    Video = table.Column<bool>(nullable: false),
                    VoteAverage = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
