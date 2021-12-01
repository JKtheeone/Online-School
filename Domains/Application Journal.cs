using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

    namespace Online-School.Domains
{
    public class ApplicationJournal
    {
        public int ReqId { get; set; }

        public int StudentId { get; set; }

        public string Username { get; set; }

        public DateTime DateReq { get; set; }

        public ApplicationJournal() { }

        public ApplicationJournal(int reqId, int studentId, string username, DateTime dateReq)
        {
            ReqId = reqId;
            StudentId = studentId;
            Username = username;
            DateReq = dateReq;
        }
        
    }
}


