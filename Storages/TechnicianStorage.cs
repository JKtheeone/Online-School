using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{
        public class TechnicianStorage
        {
            private Dictionary<int, Techician> Technicians { get; } = new Dictionary<int, Techician>();


            public void Create(Techician technician)
            {
            Technicians.Add(technician.WorkerId, technician);
            }

            public Techician Read(int workerId)
            {
                return Technicians[workerId];
            }

            public Techician Update(int workerId, Techician newTechnician)
            {
                Technicians[workerId] = newTechnician;
                return Technicians[workerId];
            }

            public bool Delete(int workerId)
            {
                return Technicians.Remove(workerId);
            }
        }
    
}