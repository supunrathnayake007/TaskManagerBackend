using System.Reflection.Metadata;

namespace TaskManager.Models;
public class Task
{
    public Guid Id { get; }
    public string Title { get; }
    public string Note { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime LastModifiedDateTime { get; }
    public bool IsComplete { get; }
    public DateTime CompleteDateTime { get; }

    public Task(
        Guid id,
        string title,
        string note,
        DateTime createdDateTime,
        DateTime lastModifiedDateTime,
        bool isComplete,
        DateTime completeDateTime)
    {
        Id = id;
        Title = title;
        Note = note;
        CreatedDateTime = createdDateTime;
        LastModifiedDateTime = lastModifiedDateTime;
        IsComplete = isComplete;
        CompleteDateTime = completeDateTime;
    }
}
