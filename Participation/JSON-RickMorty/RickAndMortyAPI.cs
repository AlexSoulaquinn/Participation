using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_RickMorty
{
    class RickAndMortyAPI
    {
        public InfoObject info { get; set; }
        public List<ResultObject> results { get; set; }
    }

    public class ResultObject
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string gender { get; set; }
        public string img { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return $"({id}) {name}";
        }
    }

    public class InfoObject
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
    }
}
