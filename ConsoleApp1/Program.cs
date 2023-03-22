using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("LINQ Count");
            // Loome kollektsiooni, mida soovime analüüsida
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            // Kasutame funktsiooni Count, et leida kollektsioonis olevate elementide arv
            int count = numbers.Count();
            Console.WriteLine("Kollektsioonis on {0} elementi", count);
  
            // Kasutame funktsiooni ToLookup, et grupeerida kollektsiooni elemendid nende jäägiklasside järgi
            var lookup = numbers.ToLookup(x => x % 3);
            Console.WriteLine("Kollektsiooni elemendid, grupeerituna jäägiklasside järgi:");

            // Käime läbi iga jäägiklassi rühma ja väljastame nende elemendid
            foreach (var group in lookup)
            {
                Console.WriteLine("Jäägiklass {0}:", group.Key);
                foreach (var number in group)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
