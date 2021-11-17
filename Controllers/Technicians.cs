using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Controllers
{
    [ApiController]
    [Route("/Technicians")]
    public class TechniciansController : ControllerBase
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
        public string Create(string str)
        {
            return str;
        }
        [HttpGet]
        public string Read(string str)
        {
            return str;
        }
        [HttpPut]
        public string Update(string str)
        {
            return str;
        }
        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }
    }
}