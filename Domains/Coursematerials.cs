using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Coursematerial
    {
        public int MaterialId { get; set; }

        public string Author { get; set; }

        public string Type { get; set; }

        public Coursematerial() { }


        public Coursematerial(int materialId,string author,string type)
        {
            MaterialId = materialId;
            Author = author;
            Type = type;
        }

    }
}