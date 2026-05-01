using TaskDomain;

namespace TaskTracker;

public static class UiDisplay
{
    /// <summary>
    /// Contains logic to display the Projects ownership information to the Console
    /// </summary>
    public static void AboutMeInformation()
    {
        Console.WriteLine("My name is Melissa Hegney");
        Console.WriteLine("My GitHub name is Merlissa09");
        Console.WriteLine();
    }

    /// <summary>
    /// <summary>
    /// Displays all passed-in tasks to the console.
    /// Accepts a <see cref="List{ITaskable}"/> so callers can pass in a
    /// heterogeneous list of task implementations (e.g., `TaskItem`,
    /// `DeadlineTask`, `RecurringTask`). The UI relies only on the
    /// `ITaskable` contract (GetId/GetTitle) and remains decoupled from
    /// concrete types.
    /// </summary>
    /// <param name="taskItems">the tasks which should be displayed</param>
    public static void DisplayTaskItems(List<ITaskable> taskItems)
    {
        foreach (var item in taskItems)
        {
            Console.WriteLine($"{item.GetId()}: {item.GetTitle()}");
        }
    }
}