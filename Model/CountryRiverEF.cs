using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFRelations.Model
{
    public class CountryRiverEF
    {
        public int LengthInCountry { get; set; }
        public int CountryId { get; set; }
        public CountryEF Country { get; set; }
        public int RiverId { get; set; }
        public RiverEF River { get; set; }
    }
}
