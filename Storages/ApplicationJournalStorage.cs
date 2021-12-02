using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{
    public class ApplicationJournalStorage
    {
          private Dictionary<int, ApplicationJournal>ApplicationJournals { get; } = new();


        public void Create(ApplicationJournal applicationJournal)
        {
            ApplicationJournals.Add(applicationJournal.ReqId, applicationJournal);
        }

        public ApplicationJournal Read(int reqId)
        {
            return ApplicationJournals[reqId];
        }

        public ApplicationJournal Update(int reqId, ApplicationJournal newApplicationJournal)
        {
                ApplicationJournals[reqId] = newApplicationJournal;
                return ApplicationJournals[reqId];
        }

        public bool Delete(int reqId)
        {
            return ApplicationJournals.Remove(reqId);
        }
    }
}


