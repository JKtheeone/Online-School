using getone.Domains;
using getone.Storages;
using Microsoft.AspNetCore.Mvc;

namespace getone.Controllers
{
    [ApiController]
    [Route("/ApplicationJournal")]
    public class ApplicationJournalController : ControllerBase
    {
        [HttpPost]
        public ApplicationJournal Create(ApplicationJournal applicationJournal)
        {
            Storage.ApplicationJournalStorage.Create(applicationJournal);
            return applicationJournal;
        }

        [HttpGet]
        public ApplicationJournal Read(int reqId)
        {
            return Storage.ApplicationJournalStorage.Read(reqId);
        }

        [HttpPut]
        public ApplicationJournal Update(int reqId, ApplicationJournal newApplicationJournal)
        {
            return Storage.ApplicationJournalStorage.Update(reqId,newApplicationJournal);
        }

        [HttpDelete]
        public bool Delete(int reqId)
        {
            return Storage.ApplicationJournalStorage.Delete(reqId);
        }
    }
}


