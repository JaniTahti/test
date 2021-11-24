using System;

namespace imiN
{
    class Program
    {
        static void Main(string[] args)
        {
            string nimi;
            Console.WriteLine("Anna sana");
            nimi = Console.ReadLine();
            string Alku = nimi.Substring(0, 1);


            string loppu = nimi.Substring(nimi.Length -1);
            string vastaus = loppu + nimi.Substring(1, nimi.Length -2) + Alku;
            Console.WriteLine("vastaus on; " + vastaus);
        }
    }
}
