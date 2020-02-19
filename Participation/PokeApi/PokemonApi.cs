using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi
{
    class PokemonApi
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<resultObject> results { get; set; }
        public List<pokemonObject> pokemon { get; set; }
    }

    public class resultObject
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class pokemonObject
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string name { get; set; }
        public Sprite sprite { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return $"({id}) {name} \n     height: {height} \n     weight: {weight}";
        }
    }
    public class Sprite
    {
        public string backDefault {get;set;}
        public string frontDefault {get;set;}
    }
}
