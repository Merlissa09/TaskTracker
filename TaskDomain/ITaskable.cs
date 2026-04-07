/// <summary>
/// This interface is designed to provide a shared contract for all task items.
/// This allows us to work with any kind of task item's shared functionality.
/// Distinct functionality will need to be handled by the implementing TaskItem itself.
/// </summary>
public interface ITaskable
{
    /// <summary>
    /// Retrieves the title of a task
    /// </summary>
    /// <returns>The title of the task</returns>
    string GetTitle();
    /// <summary>
    /// Retrieves the task description
    /// </summary>
    /// <returns>The description of the task</returns>
    string GetDescription();
    /// <summary>
    /// Gets whether a task is complete or not
    /// </summary>
    /// <returns> The status of the tasks completion</returns>
    bool IsComplete();
    /// <summary>
    /// Marks a task as complete.
    /// </summary>
    /// <returns>Whether the task was completed or not</returns>
    bool MarkComplete();
}