using OnlineSurveyAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSurveyAPI.Repository.Interfaces
{
    interface ISurveyRepository
    {
        IEnumerable<Survey> GetSurveys();

        Survey GetSurveyById(int id);

        void Save();
    }
}
