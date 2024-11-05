using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFRelations.Model
{
    public class GeoNameEF
    {
        public GeoNameEF(string name, string languageCode)
        {
            Name = name;
            LanguageCode = languageCode;
        }

        public GeoNameEF(int id, string name, string languageCode)
        {
            Id = id;
            Name = name;
            LanguageCode = languageCode;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LanguageCode { get; set; }
    }
}
