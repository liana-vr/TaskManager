using System.Collections.Generic;

namespace Tasks.Data
{
    public interface ITaskService
    {
        List<Task> GetAllTasks();
        Task GetTaskById(int taskId);
        void UpdateTask(int taskId, Task task);
        void DeleteTask(int taskId);
        void AddTask(Task task);
    }
}