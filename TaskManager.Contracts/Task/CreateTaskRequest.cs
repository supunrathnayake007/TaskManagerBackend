namespace TaskManager.Contracts.Task;
public record CreateTaskRequest(
    string Title,
    string Note,
    DateTime CreatedDateTime,
    bool IsComplete,
    DateTime CompleteDateTime
);