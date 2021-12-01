using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Controllers
{
    [ApiController]
    [Route("/ApplicationJournal")]
    public class ApplicationJournalController : ControllerBase
    {
        [HttpPost]
        public ApplicationJournal Create(ApplicationJournal applicationJournal)
        {
            Storage.ApplicationJournalStorage.Create(applicationJournal)
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


