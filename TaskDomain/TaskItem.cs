namespace TaskDomain;

/// <summary>
/// This class is a template/blueprint for our todo items.
/// It implements <see cref="ITaskable"/> so it can be treated
/// polymorphically alongside other task types (e.g., <see cref="DeadlineTask"/>,
/// <see cref="RecurringTask"/>). The service layer operates on the
/// <see cref="ITaskable"/> abstraction rather than concrete <see cref="TaskItem"/>
/// allowing a mix of task types in a single collection.
/// </summary>
public class TaskItem : TaskId, ITaskable
{

    // Constructor builds/constructs the object/instance.
    // The `: base()` call invokes the base class constructor on `TaskId`,
    // which atomically assigns a globally-unique `Id` to this instance.
    // Calling the base constructor ensures every TaskItem gets an Id
    // according to the shared id-generation policy.
    public TaskItem(string title) : base()
    {
        _title = title;
    }

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