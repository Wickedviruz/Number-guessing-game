using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Gissa ett nummer emellan 0 till 100 \n");
                string a = Console.ReadLine();

                int i = int.Parse(a);

                if (i > winNum)
                {
                    Console.WriteLine("För högt, gissa lägre");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("För lågt, gissa högre");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("Rätt gissat!");
                    win = true;
                }
                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Tack för att du spelade");
            Console.Write("Tryck ENTER för att avsluta");
            Console.ReadKey(true);
        }
    }
}
