namespace TaskDomain;

/// <summary>
/// DeadlineTask represents a task that includes a due date.
/// Unlike TaskItem, it stores additional deadline information
/// while still supporting the shared task behavior defined in ITaskable.
/// </summary>

public class DeadlineTask : ITaskable
{
    private string _title;
    private string _description;
    private bool _complete;
    private string _dueDate;

    public DeadlineTask(string title, string description, string dueDate)
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