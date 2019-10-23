using Codenation.Challenge;
using System;
using System.Collections.Generic;
using System.IO;

namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FIFACupStats f = new FIFACupStats();

            int nationality = f.NationalityDistinctCount();
            int club = f.ClubDistinctCount();
            List<string> players = f.First20Players();
            List<string> playersAge = f.Top10PlayersByAge();
            List<string> playersRelease = f.Top10PlayersByReleaseClause();
            Dictionary<int, int> ageCount = f.AgeCountMap();
        }

    }
}
