using getone.Domains;
using getone.Storages;
using Microsoft.AspNetCore.Mvc;

namespace getone.Controllers
{
    [ApiController]
    [Route("/Teacher")]
    public class TeacherController : ControllerBase
    {

        [HttpPost("Teachingstudents")]
        public string Teachingstudents(string str)
        {
            return str; // обучение учащихся
        }
        [HttpPost("Providingmaterial")]
        public string Providingmaterial(string str)
        {
            return str;// предоставление дополнительного учебного материала
        }
        [HttpPost]
        public Teacher Create(Teacher teacher)
        {
            Storage.TeachersStorage.Create(teacher);
            return teacher;
        }

        [HttpGet]
        public Teacher Read(string fullName)
        {
            return Storage.TeachersStorage.Read(fullName);
        }

        [HttpPut]
        public Teacher Update(string fullName, Teacher newTeacher)
        {
            return Storage.TeachersStorage.Update(fullName, newTeacher);
        }

        [HttpDelete]
        public bool Delete(string fullName)
        {
            return Storage.TeachersStorage.Delete(fullName);
        }
    }
}