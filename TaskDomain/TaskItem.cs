namespace TaskTracker.TaskDomain;

/// <summary>
/// This class is a template/blueprint for our todo items
/// </summary>
public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsComplete { get; set; }
}