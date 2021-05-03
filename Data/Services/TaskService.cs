using System.Collections.Generic;
using System.Linq;

namespace Tasks.Data
{
    public class TaskService : ITaskService
    {
        public void AddTask(Task task)
        {
            SeedData.Tasks.Add(task);
        }

        public void DeleteTask(int taskId)
        {
            var task = SeedData.Tasks.FirstOrDefault(n => n.Id == taskId);
            if (task != null)
            {
                SeedData.Tasks.Remove(task);
            }
        }

        public List<Task> GetAllTasks() => SeedData.Tasks.ToList();

        public Task GetTaskById(int taskId) => SeedData.Tasks.FirstOrDefault(n => n.Id == taskId);

        public void UpdateTask(int taskId, Task task)
        {
            var oldTask = SeedData.Tasks.FirstOrDefault(nameof => nameof.Id == taskId);
            if(oldTask != null)
            {
                oldTask.Name = task.Name;
                oldTask.Description = task.Description;
                oldTask.DateStarted = task.DateStarted;
                oldTask.DateCompleted = task.DateCompleted;
            }

        }
    }
}