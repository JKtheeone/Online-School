using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Schedule
    {
        public int ScheduleID { get; set; }

        public string Science { get; set; }

        public int NumOfHours { get; set; }

        public int TeacherID { get; set; }

        public int PlanID { get; set; }

        Schedule(int ScheduleID, string Science, int NumOfHours,int TeacherID,int PlanId)
        {
            this.ScheduleID = ScheduleID;
            this.Science = Science;
            this.NumOfHours = NumOfHours;
            this.TeacherID = TeacherID;
            this.PlanID = PlanId;
        }

    }
}