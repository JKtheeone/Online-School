using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{
    public class Schedule
    {
        public class ScheduleStorage
        {
            private Dictionary<int, Schedule> Schedules { get; } = new Dictionary<int, Schedule>();

            public void Create(Schedule schedule)
            {
                Schedules.Add(schedule.ScheduleId, schedule)
            }

            public Schedule Read(int scheduleId)
            {
                return Schedules[scheduleId];
            }

            public Schedule Update(int scheduleId, Schedule newSchedule)
            {
                Schedules[scheduleId] = newSchedule;
                return Schedules[scheduleId];
            }

            public bool Delete(int scheduleId)
            {
                return Schedules.Remove(scheduleId);
            }
        }
    }
}