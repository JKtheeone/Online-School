using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Student_Base
    {
        public string Email { get; set; }

        public string FullName { get; set; }

        public int Group { get; set; }

        Student_Base(string Email, string FullName, int Group)
        {
            this.Email = Email;
            this.FullName = FullName;
            this.Group = Group;
        }

    }
}