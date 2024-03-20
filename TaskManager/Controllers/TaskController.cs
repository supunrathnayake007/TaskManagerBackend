using Microsoft.AspNetCore.Mvc;
using TaskManager.Contracts.Task;
using TaskManager.Models;
using TaskManager.Services.Tasks;

namespace TaskManager.Controllers;
[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }
    [HttpPost]
    public IActionResult CreateTask(CreateTaskRequest request)
    {
        var task = new Models.Task(
            Guid.NewGuid(),
            request.Title,
            request.Note,
            request.CreatedDateTime,
            DateTime.UtcNow,
            request.IsComplete,
            request.CompleteDateTime
        );
        //TODO: Save Task to dataBase

        var response = new TaskResponse(
            task.Id,
            task.Title,
            task.Note,
            task.CreatedDateTime,
            task.LastModifiedDateTime,
            task.IsComplete,
            task.CompleteDateTime
        );

        return CreatedAtAction(
            actionName: nameof(GetTask),
            routeValues: new { id = task.Id },
            value: response);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetTask(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertTask(Guid id, UpsertTaskRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteTask(Guid id)
    {
        return Ok(id);
    }
}
