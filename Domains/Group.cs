using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Group
    {
        public int GroupID { get; set; }

        public int NumOfStu { get; set; }

        public string Speciality { get; set; }


        Group(int GroupID, int NumOfStu, string Speciality)
        {
            this.GroupID = GroupID;
            this.NumOfStu = NumOfStu;
            this.Speciality = Speciality;
        }

    }
}