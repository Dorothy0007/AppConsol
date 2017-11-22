using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poruka");
            Console.WriteLine("Message");
            Console.WriteLine("Werbung");

            Console.WriteLine("Upiši neki broj za koji želiš kvadratni korijen.");
            string unos = Console.ReadLine();
            try
            {
                double broj = double.Parse(unos);
                double rezultat = KvadratniKorijen(broj);
                Console.WriteLine($"Kvadrani korijen od {broj} je {rezultat}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }

        public static double KvadratniKorijen(double broj)
        {
            return Math.Sqrt(broj);

        }
    }
}
