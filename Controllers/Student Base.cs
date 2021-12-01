using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Controllers
{
    [ApiController]
    [Route("/StudentBase")]
    public class StudentBaseController : ControllerBase
    {
        [HttpPost]
        public StudentBase Create(StudentBase studentBase)
        {
            Storage.StudentBaseStorage.Create(studentBase)
            return studentBase;
        }

        [HttpGet]
        public StudentBase Read(string email)
        {
            return Storage.StudentBaseStorage.Read(email);
        }

        [HttpPut]
        public StudentBase Update(string email, StudentBase newStudentBase)
        {
            return Storage.StudentBaseStorage.Update(email, newStudentBase);
        }

        [HttpDelete]
        public bool Delete(string email)
        {
            return Storage.StudentBaseStorage.Delete(email);
        }
    }
}