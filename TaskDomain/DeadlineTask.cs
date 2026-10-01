namespace TaskDomain;

/// <summary>
/// DeadlineTask represents a task that includes a due date.
/// Unlike TaskItem, it stores additional deadline information
/// while still supporting the shared task behavior defined in ITaskable.
/// </summary>

/// <summary>
/// DeadlineTask represents a task that includes a due date.
/// It implements <see cref="ITaskable"/> so it can be mixed with other
/// task implementations in collections typed as <see cref="ITaskable"/>.
/// Operating on the interface rather than concrete types keeps the service
/// and UI code decoupled from specific implementations.
/// </summary>
public class DeadlineTask : TaskId, ITaskable
{
    private string _title;
    private string _description;
    private bool _complete;
    private string _dueDate;

    /// <summary>
    /// Creates a new <see cref="DeadlineTask"/> and assigns a unique id via
    /// the base <see cref="TaskId"/> constructor. The <c>: base()</c> call
    /// ensures the `Id` property is set using the shared, thread-safe counter.
    /// </summary>
    public DeadlineTask(string title, string description, string dueDate) : base()
    {
        _title = title;
        _description = description;
        _dueDate = dueDate;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public bool IsComplete()
    {
        return _complete;
    }

    public bool MarkComplete()
    {
        if (_complete)
        {
            return false;
        }

        _complete = true;
        return true;
    }

    public string GetDueDate()
    {
        return _dueDate;
    }

    public string GetSummary()
    {
        return $"[Deadline] {_title} — due {_dueDate}";
    }

    public string PrintDeadlineTask()
    {
        return $"Title: {_title}{Environment.NewLine}" +
               $"Description: {_description}{Environment.NewLine}" +
               $"Due Date: {_dueDate}{Environment.NewLine}" +
               $"Is Complete: {_complete}";
    }

}