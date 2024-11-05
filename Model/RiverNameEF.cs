using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFRelations.Model
{
    public class RiverNameEF : GeoNameEF
    {
        public RiverNameEF(string name, string languageCode) : base(name, languageCode)
        {
        }
    }
}
