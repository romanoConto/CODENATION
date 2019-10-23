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

                    for (int i = 0; i < registry.Length; i++)
                    {
                        dado.Add(header[i], registry[i]);
                    }

                    data.Add(dado);
                }
            }
        }

        public int NationalityDistinctCount()
        {
            return data.Select(i => i.Where(j => j.Key.Equals("nationality") && !j.Value.Equals(""))
           .Select(k => k.Value).FirstOrDefault())
                .Distinct().Count();
        }

        public int ClubDistinctCount()
        {
            return data.Select(i => i.Where(j => j.Key.Equals("club") && !j.Value.Equals(""))
           .Select(k => k.Value).FirstOrDefault())
                .Distinct().Count();
        }

        public List<string> First20Players()
        {
            return GetFullName(data.GetRange(0, 20));
        }

        public List<string> Top10PlayersByReleaseClause()
        {
            return GetFullName(data.OrderByDescending(dict => dict.ContainsKey("eur_release_clause")).ToList().GetRange(0, 10));
        }

        public List<string> Top10PlayersByAge()
        {
            return GetFullName(data.OrderByDescending(i => i.ContainsKey("birth_date"))
                .ThenByDescending(i => i.ContainsKey("eur_wage")).ToList().GetRange(0, 10));
        }

        public Dictionary<int, int> AgeCountMap()
        {
            return data.GroupBy(i => i.Where(j => j.Key.Equals("age"))
            .Select(k => k.Value).FirstOrDefault())
                .ToDictionary(d => int.Parse(d.Key.ToString()), d => d.Count());
        }

        private List<string> GetFullName(List<Dictionary<string, object>> list)
        {
            return list.Select(i => i.Where(j => j.Key.Equals("full_name"))
           .Select(k => k.Value.ToString()).FirstOrDefault()).ToList();
        }

    }
}
