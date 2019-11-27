using System;


namespace todo
{
    public class TaskWithDate: Task
    {
    public string date;

   public  TaskWithDate () : base() {
              Console.WriteLine(" Please enter the  date");
        this.date = Console.ReadLine();
        

    
    
       


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
            string answer = this.task + " " + this.date;
            if (this.completed || this.archived ){
                answer += suffix;
                
            } 
            return answer;
        }
}
}
