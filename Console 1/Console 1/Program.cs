using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Objekti Peruna = new Objekti();
            Peruna.nimi = "joo";
            Peruna.GetName();
            Peruna.GetPosition();
            Console.WriteLine("sadölkjf");
            Console.ReadKey();
            
        }
        class Objekti
        {
            public string nimi;
            public position Pos = new position(1,2);


            public void GetName()
            {
                Console.WriteLine("My Name is "+ nimi);
            }
            public void GetPosition()
            {
                Console.WriteLine(Pos.x + ";" + Pos.y);

            }

        }
        class position
        {
            public int x;
            public int y;
            public position(int xx, int yy)
            {
                x = xx;
                y = yy;

            }
        }
    }
}
