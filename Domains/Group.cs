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
        public int GroupId { get; set; }

        public int NumOfStu { get; set; }

        public string Speciality { get; set; }

        public Group() { }


        public Group(int groupId, int numOfStu, string speciality)
        {
            GroupId = groupId;
            NumOfStu = numOfStu;
            Speciality = speciality;
        }

    }
}