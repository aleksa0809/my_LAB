using System;
namespace Pipes1
{
    public class Pipe 

    {
        public string Diametre { get; set; }
        public string Length { get; set; }
       
        public Pipe()
        {
        }
        public  void  input_data()
        {
            Console.WriteLine("enter the pipe diameter: ");
            Diametre = Console.ReadLine();

            Console.WriteLine("enter the pipe length: ");
            Length = Console.ReadLine();
        }

            public void print_data()
            {

                Console.WriteLine("pipe diameter: " + Diametre.ToString());

                Console.WriteLine("pipe length: " + Length.ToString());
            }
        }
    }

    
