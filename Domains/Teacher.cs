using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Teacher
    {
        public string FullName { get; set; }

        public string Specification { get; set; }

        public int TeacherId { get; set; }

        public Teacher() { }


        public Teacher(string fullName,string specification,int teacherId)
        {
            FullName = fullName;
            Specification = specification;
            TeacherId = teacherId;
        }

    }
}