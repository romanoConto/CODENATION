using Codenation.Challenge;
using Desafio03.csharp_6.Source;
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

            //csharp-4
            FIFACupStats f = new FIFACupStats();

            int nationality = f.NationalityDistinctCount();
            int club = f.ClubDistinctCount();
            List<string> players = f.First20Players();
            List<string> playersAge = f.Top10PlayersByAge();
            List<string> playersRelease = f.Top10PlayersByReleaseClause();
            Dictionary<int, int> ageCount = f.AgeCountMap();

            //csharp-6
            Carteira carteira = new Carteira();
            carteira.Salary = new decimal(-20);
            carteira.Shop = new decimal(-10);
            carteira.Dsr = new decimal(-10);
            carteira.Study = new decimal(0);

            FieldCalculator fc = new FieldCalculator();

            decimal soma = fc.Addition(carteira);
            decimal subtraction = fc.Subtraction(carteira);
            decimal total = fc.Total(carteira);
        }

    }
}
