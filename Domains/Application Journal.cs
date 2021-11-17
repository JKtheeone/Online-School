using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

    namespace getone.Domains
{
    public class Application_Journal
    {
        public int ReqID { get; set; }

        public int StudentID { get; set; }

        public string Username { get; set; }

        public DateTime DateReq { get; set; }

        Application_Journal(int ReqID, int StudentID, string Username, DateTime DateReq)
        {
            this.ReqID = ReqID;
            this.StudentID = StudentID;
            this.Username = Username;
            this.DateReq = DateReq;
        }
        
    }
}


