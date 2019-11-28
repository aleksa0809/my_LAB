using System;
using System.Collections.Generic;

namespace Pipes1
{
    class MainClass
       
    {
     
      public static void Main(string[] args)

        {
            List<Car> car = new List<Car>();
            List<Porridge> porridge = new List<Porridge>();
            List<Pipe> pipe = new List<Pipe>();
            List<Candies> candies = new List<Candies>();
            bool cycle = true;
            while (cycle)
            {

      
            Console.WriteLine("Choose the products:");
            Console.WriteLine("1-cars");
            Console.WriteLine("2-pipes");
            Console.WriteLine("3-candies");
            Console.WriteLine("4-porridge");
            Console.WriteLine("5 - print list");
            Console.WriteLine("6 - exit ");
            String k = Console.ReadLine();
            switch (k )
            {
                case "1":
                        Car c = new Car();
                        c.input_data();
                        car.Add(c);
                    break;

                case "2":
                        Pipe p2 = new Pipe();
                        p2.input_data();
                        pipe.Add(p2);
                     break;

                case "3":
                        Candies ca = new Candies();
                        ca.input_data();
                        candies.Add(ca);
                     break;

                case "4":
                        Porridge p = new Porridge();
                        p.input_data();
                        porridge.Add(p);
                    break;

                case "5":
                        foreach (Car c1 in car)
                            c1.print_data();
                       

                        foreach (Pipe pi1 in pipe)
                            pi1.print_data();

                        foreach (Candies cand in candies)
                            cand.print_data();


                        foreach (Porridge po in porridge)
                            po.print_data();




                        break;

                case "6":
                        cycle = false;
                        break;

                default:
                    
                    break;

            }
            }


        }

    }
}
