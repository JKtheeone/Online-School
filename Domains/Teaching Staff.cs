using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Teaching_Stuff
    {
        public int TeacherID { get; set; }

        public string Specifications { get; set; }


        Teaching_Stuff(int TeacherID,string Specifications)
        {
            this.TeacherID = TeacherID;
            this.Specifications = Specifications;
        }

    }
}