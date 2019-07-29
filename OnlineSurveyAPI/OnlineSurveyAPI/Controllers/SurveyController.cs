using Microsoft.AspNetCore.Mvc;
using OnlineSurveyAPI.Repository;
using OnlineSurveyAPI.Repository.Interfaces;
using System.Collections.Generic;

namespace OnlineSurveyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly ISurveyRepository _surveyRepository;

        public SurveyController(SurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var surveys = _surveyRepository.GetSurveys();
            return new OkObjectResult(surveys);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var surveys = _surveyRepository.GetSurveyById(id);
            return new OkObjectResult(surveys);
        }

        // POST: api/Survey
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Survey/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
