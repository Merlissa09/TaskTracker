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

    public void PrintDeadlineTask()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Due Date: {_dueDate}");
        Console.WriteLine($"Is Complete: {_complete}");
        
    }
    
}