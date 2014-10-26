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
            Console.WriteLine("Podaj pierwszą liczbę");
            int pierwszaliczba= int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int drugaliczba= int.Parse(Console.ReadLine());
            Console.WriteLine(dodaj(pierwszaliczba, drugaliczba));
            Console.ReadKey();
        }

            static int dodaj(int a, int b)
            {
                return a+b;
            }
            

        }
    }
