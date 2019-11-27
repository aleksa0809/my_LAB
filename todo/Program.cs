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
                switch (answer.ToUpper())
                {
                    case "A":
                        current.Add(new Task());
                        break;
                    case "T":
                        current.Add(new TaskWithDate());
                        break;
                    case "E":
                        bool isEmpty = current.Count == 0;
                        if (isEmpty)
                        {
                            Console.WriteLine("The list is empty");
                            break;
                        }
                        printList(current);
                        Console.WriteLine("Please, enter the  number of  task ");
                        try{
                        int position = Int32.Parse(Console.ReadLine());
                        position--;//count is from zero
                        if(position < 0  || position > current.Count -1){
                            Console.WriteLine("Incorrect position");
                            break;
                        }

                        // Console.WriteLine(position);
                        current[position - 1].edit();
                             }
                             catch (FormatException e){
                                 Console.WriteLine("Incorrect number");
                             }
                        break;
                    case "R":
                        foreach (Task task in current)
                        {
                            if (task.archived) continue;
                            current.Remove(task);
                            archived.Add(task);
                        }
                        break;
                    case "P":
                        printList(current);
                        break;
                    case "V":
                        printList(archived);
                        break;
                    case "Q":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("I  do not understand");
                        break;
                }
            }
        }

        private static int ParsetoInt(string v)
        {
            throw new NotImplementedException();
        }

        static void editTask()
        {

        }
        static void printList(List<Task> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            int count = 1;
            foreach (Task task in list)
            {

                Console.Write(count + ") ");
                Console.WriteLine(task);
                count++;

            }
           
        }

    }
}
