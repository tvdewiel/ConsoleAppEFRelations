using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFRelations.Model
{
    public class CountryEF
    {
        public int Id { get; set; }
        public int Population {  get; set; }
        public int Surface { get; set; }
        public List<ContinentEF> Continents { get; set; } = new();
        public List<CountryNameEF> Names { get; set; } = new();
        public List<CityEF> Cities { get; set; } = new();
        //public List<CityEF> Capitals { get; set; } = new();
        public List<CapitalEF> Capitals { get; set; } = new();
        public List<RiverEF> Rivers { get; set; } = new();
    }
}
