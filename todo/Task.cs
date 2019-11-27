using System;


namespace todo
{
   public  class  Task

    { 
        public bool archived = false;
        public bool completed = false;
        public string task;
        

        public Task()
        {
            Console.WriteLine(" Please enter the  task");
            this.task = Console.ReadLine();

        }

        public void edit(){
            Console.WriteLine("Is the task completed? ");
            string answer = Console.ReadLine();
            if (answer.ToUpper() == "Y" ){
                this.completed = true;
            }
            Console.WriteLine("Is the task archived? ");
             answer  = Console.ReadLine();
            if (answer.ToUpper() == "Y" ){
                this.archived = true;
            }
        }

       

        public override String ToString(){
            string suffix = " (";
            if (this.completed){
                suffix += " completed ";
            }
            if (this.archived){
                suffix += " archived ";
            }
            suffix += ")";
            string answer = this.task;
            if (this.completed || this.archived ){
                answer += suffix;
                
            } 
            return answer;
        }
    }
}
