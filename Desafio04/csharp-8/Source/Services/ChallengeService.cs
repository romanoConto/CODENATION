using System.Collections.Generic;
using System.Linq;
using Codenation.Challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace Codenation.Challenge.Services
{
    public class ChallengeService : IChallengeService
    {
        private CodenationContext context;
        public ChallengeService(CodenationContext context)
        {
            this.context = context;
        }

        public IList<Models.Challenge> FindByAccelerationIdAndUserId(int accelerationId, int userId)
        {
            return context.Candidates.Where(x => x.AccelerationId == accelerationId && x.UserId == userId).
                Select(x => x.Acceleration).
                Select(x => x.Challenge).
                Distinct().
                ToList();
        }

        public Models.Challenge Save(Models.Challenge challenge)
        {
            var status = challenge.Id == 0 ? EntityState.Added : EntityState.Modified;
            context.Entry(challenge).State = status;
            context.SaveChanges();
            return challenge;
        }
    }
}