using System;

namespace round
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" double : ");
            double n = Convert.ToDouble(Console.ReadLine());
            int  i  = (int)Math.Round(n);

            Console.Write("round: ");
            Console.WriteLine(i);
        }
    }
}
