using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Domains
{
    public class Course
    {
        public int CourseId { get; set; }

        public int GroupId { get; set; }

        public int MaterialId { get; set; }

        public int SchneduleId { get; set; }

        public Course() { }

        public Course(int courseId, int groupId, int materialId, int scheduleId)
        {
            CourseId = courseId;
            GroupId = groupId;
            MaterialId = materialId;
            SchneduleId = scheduleId;

        }

    }
}