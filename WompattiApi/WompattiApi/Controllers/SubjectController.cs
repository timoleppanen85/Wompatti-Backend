using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WompattiApi.Models;
using WompattiApi.Services;

namespace WompattiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _subjectService;

        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpGet("{id}")]
        public ActionResult<Subject> ReadQuestion(long id)
        {
            return new JsonResult(_subjectService.ReadSubject(id));
        }
        
        [HttpGet]
        public ActionResult<List<Subject>> ReadSubjects()
        {
            return new JsonResult(_subjectService.ReadSubjects());
        }
    }
}