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
        Title = title;
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
    private string Title = string.Empty;
    private string Description = string.Empty;
    private bool Complete = false;

    // TODO: Consider achievement system

    public string GetTitle()
    {
        return Title;
    }

    public string GetDescription()
    {
        return Description;
    }

    public bool IsComplete()
    {
        return Complete;
    }

    public bool MarkComplete()
    {
        return Complete = true;
    }

}