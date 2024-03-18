namespace TaskManager.Contracts.Task;
public record UpsertTaskRequest(
    string Title,
    string Note,
    DateTime CreatedDateTime,
    bool IsComplete,
    DateTime CompleteDateTime
);