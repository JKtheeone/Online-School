using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Students
    {
        public int StudentID { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Email { get; set; }

        Students(int StudentID,string FirstName,string SecondName,string Email)
        {
            this.StudentID = StudentID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.Email = Email;
        }

    }
}