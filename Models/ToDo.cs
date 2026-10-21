namespace todos
{
    public class ToDo
    {
        public string? Task { get; set; }

       public int? Priority { get; set; }

       public bool? Done { get; set; }

       public string? Category { get; set; }

      /* public string? Task;

       public int? Priority;

       public bool? Done;

       public string? Category;

    //Konstruerare 
       public ToDo(string task, int priority, bool done, string category)
        {
            Task = task;
            Priority = priority;
            Done = done;
            Category = category;
        }

        public string WriteToDo()
        {
            Console.WriteLine($"Task: {Task} Priority: {Priority} Done: {Done} Category: {Category}");
            if(Task == null) return "tomt värde";
            else
            {
              return $"task: {Task} priority {Priority} Done: {Done} Category {Category}";  
            }
            
        }*/
        
    }

    
}