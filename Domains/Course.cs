using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Course
    {
        public int CourseID { get; set; }

        public int GroupID { get; set; }

        public int MaterialID { get; set; }

        public int SchneduleID { get; set; }

        Course(int CourseID, int GroupID, int MaterialID, int ScheduleID)
        {
            this.CourseID = CourseID;
            this.GroupID = GroupID;
            this.MaterialID = MaterialID;
            this.SchneduleID = ScheduleID;

        }

    }
}