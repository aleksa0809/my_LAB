using System;

namespace username
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" your name  : ");
            string name = Console.ReadLine();

            Console.WriteLine(" your age  : ");
            double age = Convert.ToDouble(Console.ReadLine());
            double days = age*365;
            Console.WriteLine( "you have lived  "  + days  + " days");
        }
    }
}
