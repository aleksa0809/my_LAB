using System;

namespace Pipes1
{
    public class Car
        

    {
        
        public string Number { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }

        public Car()
         {

        }
        public void input_data()
        {
            Console.WriteLine("enter the car name: ");
            Name = Console.ReadLine();

            Console.WriteLine("enter the car colour: ");
            Color = Console.ReadLine();

            Console.WriteLine("enter the car number: ");
            Number = Console.ReadLine();

        }

        public void print_data()
        {
            Console.WriteLine("car name: " + Name);

            Console.WriteLine("car color: " + Color);

            Console.WriteLine("car number: " + Number);






        }
    }
}
