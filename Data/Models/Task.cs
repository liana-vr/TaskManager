using System;

namespace Tasks.Data
{
    public class Task
    {      
         public int Id { get; set; }
         public string Name { get; set; }
         public string Description { get; set; }
         public DateTime DateStarted { get; set; }
         public DateTime? DateCompleted { get; set; }
    }
}