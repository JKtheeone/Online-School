using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
            Storage.TeacherStorage.Create(teacher)
            return teacher;
        }

        [HttpGet]
        public Teacher Read(string fullName)
        {
            return Storage.TeacherStorage.Read(fullName);
        }

        [HttpPut]
        public Teacher Update(string fullName, Teacher newTeacher)
        {
            return Storage.TeacherStorage.Update(fullName, newTeacher);
        }

        [HttpDelete]
        public bool Delete(string fullName)
        {
            return Storage.TeacherStorage.Delete(fullName);
        }
    }
}