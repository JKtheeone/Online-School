using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class EducationalPlan
    {
        public int PlanId { get; set; }

        public int NumOfSci { get; set; }

        public int Duration { get; set; }

        public int NumOfExam { get; set; }

        public EducationalPlan() { }

        public EducationalPlan(int planId, int numOfSci, int duration, int numOfExam)
        {
            PlanId = planId;
            NumOfSci = numOfSci;
            Duration = duration;
            NumOfExam = numOfExam;
        }

    }
}