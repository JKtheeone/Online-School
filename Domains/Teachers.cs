using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Teachers
    {
        public string FullName { get; set; }

        public string Specification { get; set; }

        public int TeacherID { get; set; }


        Teachers(string FullName,string Specification,int TeacherID)
        {
            this.FullName = FullName;
            this.Specification = Specification;
            this.TeacherID = TeacherID;
        }

    }
}