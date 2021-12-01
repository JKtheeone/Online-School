using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class FeedbackJournal
    {
        public int RevId { get; set; }

        public int StudentId { get; set; }

        public string Category { get; set; }

        public FeedbackJournal() { }


        public FeedbackJournal(int revId, int studentId, string category)
        {
            RevId = revId;
            StudentId = studentId;
            Category = category;
        }

    }
}