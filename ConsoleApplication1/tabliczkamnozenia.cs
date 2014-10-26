using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek ulamek1 = new Ulamek(1, 2);
            Ulamek ulamek2 = new Ulamek(1, 4);
            Ulamek wynik = Ulamek.Mnozenie(ulamek1, ulamek2);
        }
    }
}
        