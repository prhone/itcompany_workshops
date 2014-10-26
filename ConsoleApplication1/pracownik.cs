using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int rokRozpoczeciaPracy { get; set; }

        public int StazPracy
        {
            get
            {
                return DateTime.Now.Year - rokRozpoczeciaPracy;
            }
        }
        public pracownik(int rokRozpoczeciaPracy)
        {
            this.rokRozpoczeciaPracy = rokRozpoczeciaPracy;
        }

    }
}
