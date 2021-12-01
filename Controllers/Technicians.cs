using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        public Technician Create(Technician technician)
        {
            Storage.TechnicianStorage.Create(technician)
            return technician;
        }

        [HttpGet]
        public Technician Read(int workerId)
        {
            return Storage.TechnicianStorage.Read(workerId);
        }

        [HttpPut]
        public Technician Update(int workerId, Technician newTechnician)
        {
            return Storage.TechnicianStorage.Update(workerId, newTechnician);
        }

        [HttpDelete]
        public bool Delete(int workerId)
        {
            return Storage.TechnicianStorage.Delete(workerId);
        }
    }
}