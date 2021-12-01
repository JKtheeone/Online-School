using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Controllers
{
    [ApiController]
    [Route("/Schedule")]
    public class ScheduleController : ControllerBase
    {
        [HttpPost]
        public Schedule Create(Schedule schedule)
        {
            Storage.ScheduleStorage.Create(schedule)
            return schedule;
        }

        [HttpGet]
        public Schedule Read(int scheduleId)
        {
            return Storage.ScheduleStorage.Read(scheduleId);
        }

        [HttpPut]
        public Schedule Update(int scheduleId, Schedule newSchedule)
        {
            return Storage.ScheduleStorage.Update(scheduleId, newSchedule);
        }

        [HttpDelete]
        public bool Delete(int scheduleId)
        {
            return Storage.ScheduleStorage.Delete(scheduleId);
        }
    }
}