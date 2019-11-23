using System.Collections.Generic;
using System.Linq;
using Codenation.Challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace Codenation.Challenge.Services
{
    public class SubmissionService : ISubmissionService
    {
        private CodenationContext context;
        public SubmissionService(CodenationContext context)
        {
            this.context = context;
        }

        public IList<Submission> FindByChallengeIdAndAccelerationId(int challengeId, int accelerationId)
        {
            return context.Candidates.
                Where(x => x.AccelerationId == accelerationId).
                Select(x => x.User).
                SelectMany(x => x.Submissions).
                Where(x => x.Challenge.Id == challengeId).
                Distinct().
                ToList();
        }

        public decimal FindHigherScoreByChallengeId(int challengeId)
        {
            return context.Challenges.Where(x => x.Id == challengeId).
                SelectMany(x => x.Submissions).
                Select(x => x.Score).
                OrderByDescending(x => x).
                First();
        }

        public Submission Save(Submission submission)
        {
            var sub = context.Submissions.Find(submission.ChallengeId, submission.UserId);

            if (sub == null)
                context.Submissions.Add(submission);
            else
                sub.Score = submission.Score;

            context.SaveChanges();
            return submission;
        }
    }
}
