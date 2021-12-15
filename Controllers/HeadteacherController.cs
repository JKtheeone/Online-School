using getone.Domains;
using getone.Storages;
using Microsoft.AspNetCore.Mvc;

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
        public HeadTeacher Create(HeadTeacher headteacher)
        {
            Storage.HeadTeacherStorage.Create(headteacher);
             return headteacher;
        }

        [HttpGet]
        public HeadTeacher Read(int hTeacherId)
        {
            return Storage.HeadTeacherStorage.Read(hTeacherId);
        }

        [HttpPut]
        public HeadTeacher Update(int hTeacherId, HeadTeacher newHeadteacher)
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
