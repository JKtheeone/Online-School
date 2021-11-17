using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Head_Teacher
    {
        public int HTeacherID { get; set; }

        Head_Teacher(int HTeacherID)
        {
            this.HTeacherID = HTeacherID;
        }

    }
}