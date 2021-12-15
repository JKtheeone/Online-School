using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{
        public class FeedbackJournalStorage
        {
            private Dictionary<int, FeedbackJournal> FeedbackJournals { get; } = new Dictionary<int, FeedbackJournal>();

            public void Create(FeedbackJournal feedbackJournal)
            {
                FeedbackJournals.Add(feedbackJournal.RevId, feedbackJournal);
            }

            public FeedbackJournal Read(int revId)
            {
                return FeedbackJournals[revId];
            }

            public FeedbackJournal Update(int revId, FeedbackJournal newFeedbackJournal)
            {
                FeedbackJournals[revId] = newFeedbackJournal;
                return FeedbackJournals[revId];
            }

            public bool Delete(int revId)
            {
                return FeedbackJournals.Remove(revId);
            }
        }
    
}