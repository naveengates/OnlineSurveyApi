using Microsoft.EntityFrameworkCore;
using OnlineSurveyAPI.Model;

namespace OnlineSurveyAPI.DBContexts
{
    public class SurveyDBContext: DbContext
    {
        public SurveyDBContext(DbContextOptions<SurveyDBContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Survey> surveys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SurveyList>().HasData(
                new SurveyList
                {
                    Id = 001,
                    SurveyQuestion = "Question 001",
                    SurveyKey = "Answer 001"
                },
                new SurveyList
                {
                    Id = 002,
                    SurveyQuestion = "Question 002",
                    SurveyKey = "Answer 002"
                },
                new SurveyList
                {
                    Id = 003,
                    SurveyQuestion = "Question 003",
                    SurveyKey = "Answer 003"
                },
                new SurveyList
                {
                    Id = 004,
                    SurveyQuestion = "Question 004",
                    SurveyKey = "Answer 004"
                },
                new SurveyList
                {
                    Id = 005,
                    SurveyQuestion = "Question 005",
                    SurveyKey = "Answer 005"
                }
            );
        }
    }
}
