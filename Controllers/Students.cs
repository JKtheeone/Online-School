using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Controllers
{
    [ApiController]
    [Route("/Student")]
    public class StudentController : ControllerBase
    {

        [HttpPost("Filingapplication")]
        public string Filingapplication(string str)
        {
            return str; // Подача заявок на поступление
        }
        [HttpPost("Serviceevaluation")]
        public string Serviceevaluation(string str)
        {
            return str;// Оценка работы сервиса
        }
        [HttpPost]
        public Student Create(Student student)
        {
            Storage.StudentStorage.Create(student)
            return student;
        }

        [HttpGet]
        public Student Read(int studentId)
        {
            return Storage.StudentStorage.Read(studentId);
        }

        [HttpPut]
        public Student Update(int studentId, Student newStudent)
        {
            return Storage.StudentStorage.Update(studentId, newStudent);
        }

        [HttpDelete]
        public bool Delete(int studentId)
        {
            return Storage.StudentStorage.Delete(studentId);
        }
    }
}