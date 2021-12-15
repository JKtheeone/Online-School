using getone.Domains;
using getone.Storages;
using Microsoft.AspNetCore.Mvc;


namespace getone.Controllers
{
    [ApiController]
    [Route("/Course")]
    public class CourseController : ControllerBase
    {
        [HttpPost]
        public Course Create(Course course)
        {
            Storage.CourseStorage.Create(course);
            return course;
        }

        [HttpGet]
        public Course Read(int courseId)
        {
            return Storage.CourseStorage.Read(courseId);
        }

        [HttpPut]
        public Course Update(int courseId, Course newCourse)
        {
            return Storage.CourseStorage.Update(courseId, newCourse);
        }

        [HttpDelete]
        public bool Delete(int courseId)
        {
            return Storage.CourseStorage.Delete(courseId);
        }
    }
}