using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Klient
    {
        public string DaneAdresowe { get; set; }
    }

        class Klient : KlientFirmowy
            {
                public string Nazwa { get; set; }
                public string NIP { get; set; }
                public int RokZalozenia { get; set; }       
            }
        
        class Klient : KlientIndywidualny
        {
            public string Imie { get; set; }

}
