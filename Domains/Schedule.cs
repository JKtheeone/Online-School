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
        public int ScheduleId { get; set; }

        public string Science { get; set; }

        public int NumOfHours { get; set; }

        public int TeacherId { get; set; }

        public int PlanId { get; set; }

        public Schedule() { }

        public Schedule(int scheduleId, string science, int numOfHours,int teacherId,int planId)
        {
            ScheduleId = scheduleId;
            Science = science;
            NumOfHours = numOfHours;
            TeacherId = teacherId;
            PlanId = planId;
        }

    }
}