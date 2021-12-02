using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class StudentBase
    {
        public string Email { get; set; }

        public string FullName { get; set; }

        public int Group { get; set; }

        public StudentBase() { }

        public StudentBase(string email, string fullName, int group)
        {
            Email = email;
            FullName = fullName;
            Group = group;
        }

    }
}