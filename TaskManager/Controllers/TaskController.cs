using Microsoft.AspNetCore.Mvc;
using TaskManager.Contracts.Task;

namespace TaskManager.Controllers;
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost("/task")]
    public IActionResult CreateTask(CreateTaskRequest request)
    {
        return Ok(request);
    }

    [HttpGet("/task/{id:guid}")]
    public IActionResult GetTask(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("/task/{id:guid}")]
    public IActionResult UpsertTask(Guid id, UpsertTaskRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("/task/{id:guid}")]
    public IActionResult DeleteTask(Guid id)
    {
        return Ok(id);
    }
}
