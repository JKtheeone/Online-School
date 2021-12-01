using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class HeadTeacher
    {
        public int HTeacherId { get; set }

        public string FullName { get; set }

        public HeadTeacher() { }

        public HeadTeacher(int hTeacherId , string fullname)
        {
            HTeacherID = hTeacherId;
            FullName = fullname;
        }

    }
}