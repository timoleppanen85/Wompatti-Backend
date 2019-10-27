using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WompattiApi.Models;
using WompattiApi.Services;

namespace WompattiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public ActionResult<List<Question>> ReadQuestions()
        {
            return new JsonResult(_questionService.ReadQuestions());
        }
    }
}