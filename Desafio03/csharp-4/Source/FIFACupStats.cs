using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Reflection;

namespace Codenation.Challenge
{

    public class FIFACupStats
    {


        public string CSVFilePath { get; set; } = "data.csv";

        public Encoding CSVEncoding { get; set; } = Encoding.UTF8;

        private static List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();

        string[] header;

        public FIFACupStats()
        {

            using (StreamReader reader = new StreamReader(CSVFilePath))
            {
                string firsLine = reader.ReadLine();
                string[] header = firsLine.Split(",");

                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    Dictionary<string, object> dado = new Dictionary<string, object>();
                    object[] registry = line.Split(",");

                    for(int i = 0; i < registry.Length; i++)
                    {
                        dado.Add(header[i], registry[i]);
                    }

                    data.Add(dado);
                }
            }
        }

        public int NationalityDistinctCount()
        {
            data.Where(i => i.Keys.Equals(header.g))
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
