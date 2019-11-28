using System;
using System.Collections.Generic;

namespace todo
{
    class Program
    {

        static List<Task> archived = new List<Task>();
        static List<Task> current = new List<Task>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please, choose an action: ");
                Console.WriteLine("A : add a new task ");
                Console.WriteLine("T : add a new task with date ");
                Console.WriteLine("E : edit task  ");
                Console.WriteLine("P : print current tasks ");
                Console.WriteLine("V : print archived  tasks ");
                Console.WriteLine("R : move tasks from  current to archived ");
                Console.WriteLine("Q : exit from app ");
                string answer = Console.ReadLine();
                new Menu(answer, current, archived);
            }
        }
    }
}
