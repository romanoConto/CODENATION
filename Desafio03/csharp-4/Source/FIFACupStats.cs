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

        private readonly string[] header;

        public FIFACupStats()
        {

            using (StreamReader reader = new StreamReader(CSVFilePath))
            {
                string firsLine = reader.ReadLine();
                string[] header = firsLine.Split(',');

                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    Dictionary<string, object> dado = new Dictionary<string, object>();
                    object[] registry = line.Split(',');

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
            .Select(k => k.Value).FirstOrDefault()).Distinct().Count();
        }

        public int ClubDistinctCount()
        {
            var clubs = data.Select(i => i.Where(j => j.Key.Equals("club") && j.Value != null && !j.Value.Equals(""))
            .Select(k => k.Value).FirstOrDefault()).ToList();

            return clubs.Distinct().Where(x => x != null).Count();
        }

        public List<string> First20Players()
        {
            return GetFullName(data).Distinct().ToList().GetRange(0, 20);
        }

        public List<string> Top10PlayersByReleaseClause()
        {
            decimal outAux;

            return GetFullName(data.OrderByDescending(i => i.Where(j => j.Key.Equals("eur_release_clause"))
                .Select(k => decimal.TryParse(k.Value.ToString().Replace(".", ","), out outAux) ? outAux : (decimal?)0).FirstOrDefault())
                .ToList())
                .Distinct().ToList().GetRange(0, 10);
        }

        public List<string> Top10PlayersByAge()
        {
            return GetFullName(data.OrderBy((i => i.Where(j => j.Key.Equals("birth_date"))
            .Select(k => k.Value).FirstOrDefault()))
                .ThenByDescending(i => i.Where(j => j.Key.Equals("eur_wage"))
                .Select(k => k.Value).FirstOrDefault())
                .Distinct().ToList().GetRange(0, 10));
        }

        public Dictionary<int, int> AgeCountMap()
        {
            return data.OrderBy(i => i.Where(j => j.Key.Equals("age")).Select(k => k.Value).FirstOrDefault()).Distinct()
                .GroupBy(i => i.Where(j => j.Key.Equals("age"))
                .Select(k => k.Value).FirstOrDefault())
                .ToDictionary(d => int.Parse(d.Key.ToString()), d => d.Count() / 6);
        }

        private List<string> GetFullName(List<Dictionary<string, object>> list)
        {
            return list.Select(i => i.Where(j => j.Key.Equals("full_name"))
           .Select(k => k.Value.ToString()).FirstOrDefault()).ToList();
        }
    }
}
