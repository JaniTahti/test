using System;

namespace HeiNImi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hei käyttäjä mikä on sinun nimesi");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ai hei" + x + " minulla ei ole nimeä :(");
        }
    }
}
