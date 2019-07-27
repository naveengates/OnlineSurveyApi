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
        public Survey GetSurveyById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Survey> GetSurveys()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
