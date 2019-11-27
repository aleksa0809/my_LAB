using System;
using System.Collections.Generic;


namespace todo
{
    public class Menu
    {
        public Menu(string command, List<Task> current, List<Task> archived)
        {

            switch (command.ToUpper())
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
                    try
                    {
                        int position = Int32.Parse(Console.ReadLine());
                        position--;//count is from zero
                        if (position < 0 || position > current.Count - 1)
                        {
                            Console.WriteLine("Incorrect position");
                            break;
                        }

                        // Console.WriteLine(position);
                        current[position - 1].edit();
                    }
                    catch (FormatException e)
                    {
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
        void printList(List<Task> list)
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











