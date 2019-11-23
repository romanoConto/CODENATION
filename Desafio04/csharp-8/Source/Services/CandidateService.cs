using System.Collections.Generic;
using System.Linq;
using Codenation.Challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace Codenation.Challenge.Services
{
    public class CandidateService : ICandidateService
    {
        private CodenationContext context;
        public CandidateService(CodenationContext context)
        {
            this.context = context;
        }

        public IList<Candidate> FindByAccelerationId(int accelerationId)
        {
            return context.Accelerations.Where(x => x.Id == accelerationId).
                SelectMany(x => x.Candidates).
                Distinct().
                ToList();
        }

        public IList<Candidate> FindByCompanyId(int companyId)
        {
            return context.Companies.Where(x => x.Id == companyId).
                SelectMany(x => x.Candidates).
                Distinct().
                ToList();
        }

        public Candidate FindById(int userId, int accelerationId, int companyId)
        {
            return context.Candidates.Where(x => x.UserId == userId && x.AccelerationId == accelerationId && x.CompanyId == companyId).
                FirstOrDefault();
        }

        public Candidate Save(Candidate candidate)
        {
            var sub = context.Candidates.Find(candidate.CompanyId, candidate.AccelerationId, candidate.UserId);

            if (sub == null)
                context.Candidates.Add(candidate);
            else
                sub.Status = candidate.Status;

            context.SaveChanges();

            return candidate;
        }
    }
}
