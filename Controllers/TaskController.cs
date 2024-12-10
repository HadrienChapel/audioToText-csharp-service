using Microsoft.AspNetCore.Mvc;
using todo_api.Models;

namespace todo_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private static List<TodoTask> tasks = new List<TodoTask>
    {
        new TodoTask { Id = 1, Title = "Learn C#", Completed = false },
        new TodoTask { Id = 2, Title = "Build an API", Completed = true },
    };

    [HttpGet]
    public IActionResult GetTasks() => Ok(tasks);

    [HttpPost]
    public IActionResult AddTask([FromBody] TodoTask task)
    {
        task.Id = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;
        tasks.Add(task);
        return CreatedAtAction(nameof(GetTasks), new { id = task.Id }, task);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateTask(int id, [FromBody] TodoTask updatedTask)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task == null) return NotFound();

        task.Title = updatedTask.Title;
        task.Completed = updatedTask.Completed;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTask(int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task == null) return NotFound();

        tasks.Remove(task);
        return NoContent();
    }
}
