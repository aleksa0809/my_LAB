using System;
namespace Pipes1
{
    public class Candies
    {

        public double  Mass { get; set; }
        public string Taste { get; set; }

        public Candies()
        {
        }
        public void input_data()
        {
            Console.WriteLine("enter the number of kg: ");
            Mass = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the taste: ");
            Taste = Console.ReadLine();


        }

        public void print_data()
        {
            Console.WriteLine("candies taste: " + Taste);


            Console.WriteLine("candies number of kg : " + Mass.ToString());

        }
    }
}
