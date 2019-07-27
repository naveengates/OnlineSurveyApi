using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSurveyAPI.Model
{
    public class Survey
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int SurveyId { get; set; }
        public string SurveyName { get; set; }
    }
}
