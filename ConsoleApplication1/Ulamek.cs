using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ulamek
    {
        //1
        int licznik;

        public int Licznik
        {
            get { return licznik; }
            set { licznik = value; }
        }

        //1 to to samo co to niżej
        public int Mianownik { get; set; }

        public Ulamek(int licz, int mian)
        {
            //TO JEST KONSTRUKTOR!
            Licznik = licz;
            Mianownik = mian;
        }

        public Ulamek()
        {
        }

        public override string ToString()
        {
            return Licznik + "/" + Mianownik;
        }

        public static Ulamek Mnozenie(Ulamek ulamek1, Ulamek ulamek2)
        {
            Ulamek wynik = new Ulamek();
            wynik.Licznik = ulamek1.Licznik * ulamek2.Licznik;
            wynik.Mianownik = ulamek1.Licznik * ulamek2.Licznik;
            return wynik;
        }

        public static Ulamek operator +(Ulamek ul1, Ulamek ul2)
        {
            return new Ulamek() { Licznik = ul1.Licznik * ul2.Mianownik + ul2.Licznik * ul1.Mianownik, Mianownik = ul1.Mianownik * ul2.Mianownik };
        }

        //throw now Exception("NIE DZIEL PRZEZ ZERO!!!!")
    }
}