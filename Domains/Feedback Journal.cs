using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Feedback_Journal
    {
        public int RevID { get; set; }

        public int StudentID { get; set; }

        public string Category { get; set; }


        Feedback_Journal(int RevID, int StudentID, string Category)
        {
            this.RevID = RevID;
            this.StudentID = StudentID;
            this.Category = Category;
        }

    }
}