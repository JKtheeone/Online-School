using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Email { get; set; }

        public Student() { }

        public Student(int studentId,string firstName,string secondName,string email)
        {
            StudentId = studentId;
            FirstName = firstName;
            SecondName = secondName;
            Email = email;
        }

    }
}