using System;

namespace greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first name ");
            string first_name = Console.ReadLine();
            Console.WriteLine("enter your second  name ");
            string second_name = Console.ReadLine();

            Console.WriteLine(" Hello " + first_name + " " + second_name + ".");
        }
    }
}
