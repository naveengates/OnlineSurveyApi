using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineSurveyAPI.Migrations
{
    public partial class _20190727_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SurveyList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SurveyQuestion = table.Column<string>(nullable: true),
                    SurveyKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    SurveyId = table.Column<int>(nullable: false),
                    SurveyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SurveyList",
                columns: new[] { "Id", "SurveyKey", "SurveyQuestion" },
                values: new object[,]
                {
                    { 1, "Answer 001", "Question 001" },
                    { 2, "Answer 002", "Question 002" },
                    { 3, "Answer 003", "Question 003" },
                    { 4, "Answer 004", "Question 004" },
                    { 5, "Answer 005", "Question 005" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyList");

            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
