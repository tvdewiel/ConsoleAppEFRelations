using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFRelations.Model
{
    public class CityNameEF : GeoNameEF
    {
        public CityNameEF(string name, string languageCode) : base(name, languageCode)
        {
        }
    }
}
