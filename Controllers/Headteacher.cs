using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Controllers
{
    [ApiController]
    [Route("/Headteacher")]
    public class TeachersController : ControllerBase
    {

        [HttpPost("сoursecreation")]
        public string сoursecreation(string str)
        {
            return str; // создание курса
        }
        [HttpPost("drawingcurriculum")]
        public string drawingcurriculum(string str)
        {
            return str;// составление учебного плана
        }
        [HttpPost("сhoosingteacher")]
        public string сhoosingteacher(string str)
        {
            return str;// выбор преподавателя для курса
        }
        [HttpPost("addingstudents")]
        public string addingstudents(string str)
        {
            return str;// добавление студентов на курс
        }
    }
}