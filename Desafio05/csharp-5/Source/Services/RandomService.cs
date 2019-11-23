using System;

namespace Codenation.Challenge.Services
{
    public class RandomService: IRandomService
    {
        internal static object _context;

        public int RandomInteger(int max)
        {
            Random r = new Random();
            return r.Next(0, max);
        }
    }
}