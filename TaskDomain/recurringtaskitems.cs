
namespace TaskDomain;

// This class represents a recurring task and implements ITaskable so it can
// be stored in collections of the abstraction type (List<ITaskable>).
// Using the interface instead of concrete types allows the list service and
// UI to operate on different task implementations uniformly.
public class RecurringTask : TaskId, ITaskable
{
    private bool _isComplete;
    private string Title { get; }
    private string? Description { get; set; }
    public string? Frequency { get; }

    /// <summary>
    /// Constructs a new <see cref="RecurringTask"/>.
    /// The `: base()` call invokes <see cref="TaskId"/>'s constructor to assign
    /// the unique identifier for this task. Subclasses should call the base
    /// constructor to ensure id generation is consistent across types.
    /// </summary>
    public RecurringTask(string title, string? description = null, string? frequency = null) : base()
    {
        Title = title;
        Description = description;
        Frequency = frequency;
    }

    public string GetTitle()
    {
        return Title;
    }

    public string GetDescription()
    {
        return Description ?? string.Empty;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public bool MarkComplete()
    {
        if (_isComplete)
        {
            return false;
        }

        _isComplete = true;
        return true;
    }

    public string GetSummary()
    {
        return $"[Recurring] {Title} — {Frequency}";
    }
}
