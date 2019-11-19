using System;

namespace story
{/*
Напишите программу, которая позволяет пользователю вводить как имена, так и фамилии двух людей. Сохраните их в соответствующих переменных. Затем программа напечатает рассказ, в котором эти два человека являются главными героями.
*/
    class Person
    {
        public string first_name;
        public string second_name;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person pers1 = new Person();
            Person pers2 = new Person();

            Console.WriteLine("enter the first name of the first person ");
            pers1.first_name = Console.ReadLine();

            Console.WriteLine("enter the second  name of the first person ");
            pers1.second_name = Console.ReadLine();

            Console.WriteLine("enter the first name of the second person ");
            pers2.first_name = Console.ReadLine();

            Console.WriteLine("enter the second  name of the second person ");
            pers2.second_name = Console.ReadLine();

            Console.WriteLine("Once upon a time "
             + pers1.first_name + " "
             + pers1.second_name + " "
             + " have met " 
             + pers2.first_name + " "
             + pers2.second_name + "."
          );
        }
    }
}
