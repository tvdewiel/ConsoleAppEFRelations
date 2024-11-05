using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFRelations.Model
{
    public class CountryNameEF : GeoNameEF
    {
        public CountryNameEF(string name, string languageCode) : base(name, languageCode)
        {
        }
    }
}
