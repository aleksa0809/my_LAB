using System;
namespace Pipes1
{
    public class Porridge
    {
        public double Fat_amount { get; set; }

        public double Litres { get; set; }

        public Porridge()
        {
        }

        public void input_data()
        {
            Console.WriteLine("enter fat percentage: ");
            Fat_amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the number of litres: ");
            Litres = Convert.ToDouble(Console.ReadLine());

        }

        public void print_data()
        {
            Console.WriteLine("porridge Fat amount: " + Fat_amount.ToString());

            Console.WriteLine("porridge Litres: " + Litres.ToString());




        }

    }
}
	