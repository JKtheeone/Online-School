using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{
    public class Technician
    {
        public class TechnicianStorage
        {
            private Dictionary<int, Technician> Technicians { get; } = new Dictionary<int, Technician>();


            public void Create(Technician technician)
            {
                Technicians.Add(technician.WorkerId, technician)
            }

            public Technician Read(int workerId)
            {
                return Technicians[workerId];
            }

            public Technician Update(int workerId, Technician newTechnician)
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
}