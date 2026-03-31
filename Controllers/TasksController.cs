using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    static List<TaskItem> tasks = new List<TaskItem>();

    [HttpGet]
    public IActionResult Get() => Ok(tasks);

    [HttpPost]
    public IActionResult Post(TaskItem task)
    {
        task.Id = tasks.Count + 1;
        tasks.Add(task);
        return Ok(task);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, TaskItem updated)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task == null) return NotFound();

        task.Title = updated.Title;
        task.Completed = updated.Completed;

        return Ok(task);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        tasks.RemoveAll(t => t.Id == id);
        return Ok();
    }
}

public class TaskItem
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public bool Completed { get; set; }
}