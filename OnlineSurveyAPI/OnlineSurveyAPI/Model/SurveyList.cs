using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSurveyAPI.Model
{
    public class SurveyList
    {
        public int Id { get; set; }
        public string SurveyQuestion { get; set; }
        public string SurveyKey { get; set; }
    }
}
