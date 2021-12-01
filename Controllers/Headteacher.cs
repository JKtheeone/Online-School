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
    public class HeadTeachersController : ControllerBase
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
        [HttpPost]
        public Headteacher Create(Headteacher headteacher)
        {
            Storage.HeadTeacherStorage.Create(headteacher)
             return headteacher;
        }

        [HttpGet]
        public Headteacher Read(int hTeacherId)
        {
            return Storage.HeadTeacherStorage.Read(hTeacherId);
        }

        [HttpPut]
        public Headteacher Update(int hTeacherId, Headteacher newHeadteacher)
        {
            return Storage.HeadTeacherStorage.Update(hTeacherId, newHeadteacher);
        }

        [HttpDelete]
        public bool Delete(int hTeacherId)
        {
            return Storage.HeadTeacherStorage.Delete(hTeacherId);
        }
    }
}
