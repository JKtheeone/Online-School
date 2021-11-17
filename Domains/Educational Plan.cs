using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Educational_Plan
    {
        public int PlanID { get; set; }

        public int NumOfSci { get; set; }

        public int Duration { get; set; }

        public int NumOfExam { get; set; }

        Educational_Plan(int PlanID, int NumOfSci, int Duration, int NumOfExam)
        {
            this.PlanID = PlanID;
            this.NumOfSci = NumOfSci;
            this.Duration = Duration;
            this.NumOfExam = NumOfExam;
        }

    }
}