using OnlineSurveyAPI.DBContexts;
using OnlineSurveyAPI.Model;
using OnlineSurveyAPI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSurveyAPI.Repository
{
    public class SurveyRepository : ISurveyRepository
    {
        private readonly SurveyDBContext _dbContext;

        public SurveyRepository(SurveyDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Survey GetSurveyById(int id)
        {
            return _dbContext.Surveys.Find(id);
        }

        public IEnumerable<Survey> GetSurveys()
        {
            return _dbContext.Surveys.ToList();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
