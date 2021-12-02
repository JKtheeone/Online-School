using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Techician
    {
        public int WorkerId { get; set; }

        public string FullName { get; set; }

        public Techician() { }

        public Techician(int workerId , string fullname)
        {
            WorkerId = workerId;
            FullName = fullname;
        }

    }
}