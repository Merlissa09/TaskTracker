namespace TaskDomain;

/// <summary>
/// This class is a template/blueprint for our todo items
/// </summary>
public class TaskItem : ITaskable
{

    // constructor builds/constructs the object/instance
    public TaskItem(string title)
    {
        Id = ++_totalCount;
        _title = title;
    }

    // static property
    // static properties belong to the class itself - they are shared between objects
    private static int _totalCount = 0;

    public static int TotalCount
    {
        get => _totalCount;
    }

    // Instance properties
    // Instance properties belong to the object
    public int Id { get; }
    private readonly string _title = string.Empty;
    private string _description = string.Empty;
    private bool _complete = false;

    // TODO: Consider achievement system

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
    
    public string GetSummary()
    {
    return $"[Task] {_title}";
    }

}