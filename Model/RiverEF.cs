using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFRelations.Model
{
    public class RiverEF
    {
        public int Id { get; set; }
        public List<RiverNameEF> Names { get; set; } = new();
        public string? Mouth {  get; set; }
        public string? Source { get; set; }
        public int? Length { get; set; }
        public List<CountryEF> Countries { get; set; } = new();
        public List<CountryRiverEF> CountryRivers { get; set; } = new();
    }
}
