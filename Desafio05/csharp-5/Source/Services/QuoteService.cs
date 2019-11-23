using System;
using System.Linq;
using Codenation.Challenge.Models;

namespace Codenation.Challenge.Services
{
    public class QuoteService : IQuoteService
    {
        private ScriptsContext _context;
        private IRandomService _randomService;

        public QuoteService(ScriptsContext context, IRandomService randomService)
        {
            this._context = context;
            this._randomService = randomService;
        }

        public Quote GetAnyQuote()
        {
            int count = _randomService.RandomInteger(_context.Quotes.Count());

            return _context.Quotes.OrderBy(x => x.Id)
                .Skip(count)
                .FirstOrDefault();
        }

        public Quote GetAnyQuote(string actor)
        {
            return _context.Quotes.Where(x => x.Actor.Equals(actor))
                .FirstOrDefault();
        }
    }
}