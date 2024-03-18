namespace TaskManager.Contracts.Task;
public record TaskResponse(
    Guid Id,
    string Title,
    string Note,
    DateTime CreatedDateTime,
    DateTime LastModified,
    bool IsComplete,
    DateTime CompleteDateTime
);