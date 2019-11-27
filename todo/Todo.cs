using System;
using System.Collections.Generic;

namespace todo
{
    class Todo
    {
        private List <Task> tasks = new List<Task>();
        

        public void  Print()
        {
           foreach(Task task in tasks){
               Console.WriteLine(task);
           }

        }
        public void Add(Task task){
            tasks.Add(task);
        }
        public List<Task> GetTasks() => tasks;
    }
}
