
namespace TaskDomain;
//This class represents a recurring task so different from the actual interface
public class RecurringTask : ITaskable
{
    private bool Iscomplete { get; set; }
    private string Title { get; }
    private string? Description { get; set; }
    private string? GetFrequency { get; }

    public RecurringTask(string title, string? description = null, string? frequency = null)
    {
        Title = title;
        Description = description;
        GetFrequency = frequency;
    }

    public string GetTitle()
    {
        return Title;
    }

    public string GetDescription()
    {
        if (Description is string)
        {
            return Description;
        }
        return string.Empty;
    }

    public bool IsComplete()
    {
        return Iscomplete;
    }

    public bool MarkComplete()
    {
        Iscomplete = true;
        return Iscomplete;
    }
}
