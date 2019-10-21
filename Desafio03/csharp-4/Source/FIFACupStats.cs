using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using Desafio03.csharp_4.Source;
using System.Reflection;

namespace Codenation.Challenge
{

    public class FIFACupStats
    {


        public string CSVFilePath { get; set; } = "data.csv";

        public Encoding CSVEncoding { get; set; } = Encoding.UTF8;

        private static List<Player> data = new List<Player>();

        public FIFACupStats()
        {

            using (StreamReader reader = new StreamReader(CSVFilePath))
            {
                string firsLine = reader.ReadLine();
                string[] header = firsLine.Split(",");

                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    object[] registry = line.Split(",");

                    Player player = new Player();

                    for(int i = 0; i < registry.Length; i++)
                    {
                        player.AddProperty(player, header[i], registry[i]);
                    }

                    data.Add(player);
                }
            }
        }

        public int NationalityDistinctCount()
        {
            return 0;
        }

        public int ClubDistinctCount()
        {
            throw new NotImplementedException();
        }

        public List<string> First20Players()
        {
            throw new NotImplementedException();
        }

        public List<string> Top10PlayersByReleaseClause()
        {
            throw new NotImplementedException();
        }

        public List<string> Top10PlayersByAge()
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, int> AgeCountMap()
        {
            throw new NotImplementedException();
        }
    }
}
