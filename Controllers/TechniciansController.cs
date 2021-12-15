using getone.Domains;
using getone.Storages;
using Microsoft.AspNetCore.Mvc;

namespace getone.Controllers
{
    [ApiController]
    [Route("/Technician")]
    public class TechnicianController : ControllerBase
    {

        [HttpPost("Websiteimprovement")]
        public string Websiteimprovement(string str)
        {
            return str; // Доработка сайта на основе отзывов
        }
        [HttpPost("Sitesupport")]
        public string Sitesupport(string str)
        {
            return str;// Поддержка функционирования сайта
        }
        [HttpPost("Debuggingsystem")]
        public string Debuggingsystem(string str)
        {
            return str;// Отладка системы по обработке заявок
        }
        [HttpPost]
        public Techician Create(Techician technician)
        {
            Storage.TechiciansStorage.Create(technician);
            return technician;
        }

        [HttpGet]
        public Techician Read(int workerId)
        {
            return Storage.TechiciansStorage.Read(workerId);
        }

        [HttpPut]
        public Techician Update(int workerId, Techician newTechnician)
        {
            return Storage.TechiciansStorage.Update(workerId, newTechnician);
        }

        [HttpDelete]
        public bool Delete(int workerId)
        {
            return Storage.TechiciansStorage.Delete(workerId);
        }
    }
}