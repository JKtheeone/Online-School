using getone.Domains;
using System.Collections.Generic;

namespace getone.Storages
{
    public class CourseStorage
    {
        private Dictionary<int, Course> Courses { get; } = new();

        public void Create(Course course)
        {
            Courses.Add(course.CourseId, course);
        }

        public Course Read(int courseId)
        {
            return Courses[courseId];
        }

        public Course Update(int courseId, Course newCourse)
        {
            Courses[courseId] = newCourse;
            return Courses[courseId];
        }

        public bool Delete(int courseId)
        {
            return Courses.Remove(courseId);
        }
    }
}