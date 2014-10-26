using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Liczbik
    {
        private int licznik;

        public static int TotalLicznik { get; set; }

        public void ZwiekszLicznik()
        {
            licznik++;
            TotalLicznik++;
        }
    }
}
