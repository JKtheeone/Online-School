using getone.Domains;
using getone.Storages;
using Microsoft.AspNetCore.Mvc;

namespace getone.Controllers
{
    [ApiController]
    [Route("/FeedbackJournal")]
    public class FeedbackJournalController : ControllerBase
    {
        [HttpPost]
        public FeedbackJournal Create(FeedbackJournal feedbackJournal)
        {
            Storage.FeedbackJournalStorage.Create(feedbackJournal);
            return feedbackJournal;
        }

        [HttpGet]
        public FeedbackJournal Read(int revId)
        {
            return Storage.FeedbackJournalStorage.Read(revId);
        }

        [HttpPut]
        public FeedbackJournal Update(int revId, FeedbackJournal newFeedbackJournal)
        {
            return Storage.FeedbackJournalStorage.Update(revId, newFeedbackJournal);
        }

        [HttpDelete]
        public bool Delete(int revId)
        {
            return Storage.FeedbackJournalStorage.Delete(revId);
        }
    }
}