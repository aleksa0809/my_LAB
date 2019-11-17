using System;

namespace weather
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine(" is the weather nice today?  ");
                string answer = Console.ReadLine();

                if (answer.ToLower() != "y" && answer.ToLower() != "n")

                {

                    Console.WriteLine("I do not understand you. ");
                    continue;

                }

                if (answer.ToLower() == "y")
                {
                    Console.WriteLine("Go to picknik");
                    break;
                }
                else
                {
                    Console.WriteLine("Read a book. ");
                    break;
                }



            }
        }
    }
}
