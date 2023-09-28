using System;
namespace Uppgift_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur långt Elin hopade ?");
            string längdhop = Console.ReadLine();
            int längdhopp = int.Parse(längdhop);

            Console.WriteLine("Hur långt Alma Hoppade?");
            string längdhop2 = Console.ReadLine();
            int längdhopp2 = int.Parse(längdhop2);

            int skillnaden = längdhopp - längdhopp2;

            Console.WriteLine("Elin hoppade " + skillnaden + " meter längre än Alma");
            Console.ReadKey();
        }
    }
}