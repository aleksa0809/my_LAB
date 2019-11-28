using System;
using System.Collections.Generic;


namespace todo
{
    public class Menu
    {
        //process user's answer(add, edit items,print lists, exit programm)
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
                  string answer = Console.ReadLine();
                  int position = GetPosition(answer, current);
                  if(position ==-1){
                      Console.WriteLine("Incorrect position, mistake");
                      break;
                  }
                  current[position].edit();
                    break;
                case "R":
                    foreach (Task task in current)
                    {
                        if (!task.archived) continue;
                        archived.Add(task);
                    }
                    foreach (Task task in archived)
                    {
                        //remove archived tasks from current todo list
                        if (task.archived) current.Remove(task);
                    }
                    break;
                case "P":
                    printList(current);
                    break;
                case "V":
                    printList(archived);
                    break;
                    case "Z":
                    Console.WriteLine("unittest");
                    break;
                case "Q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("I  do not understand");
                    break;
                    
            }
        }
        //
        void printList(List<Task> list)
        {
            if (list.Count == 0)//if list is empty, we return back
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            int count = 1;//print the numbers of item of list

            foreach (Task task in list)//print all the tasks with positions
            {

                Console.Write(count + ") ");
                Console.WriteLine(task);
                count++;
            }
        }
        public int  GetPosition(string answer, List<Task> list)
        {
            int pos =-1;//default return value
            try
            {
                pos = Int32.Parse(answer);//convert from string for  number
                pos--;//count is from zero
                if (pos < 0 || pos > list.Count - 1)
                    return -1;
            }
            catch (FormatException e)
            {
                return -1;
            }
            return pos;
        }

    }

}












