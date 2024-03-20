using TaskManager.Contracts.Task;

namespace TaskManager.Services.Tasks;

public interface ITaskService
{
    void CreateTask(Models.Task task);
}