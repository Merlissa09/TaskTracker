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
    /// Contains logic to display all passed in TaskItems to the Console
    /// </summary>
    /// <param name="taskItems">the taskItems which should be displayed </param>
    public static void DisplayTaskItems(List<TaskItem> taskItems)
    {
        foreach (var item in taskItems)
        {
            Console.WriteLine($"{item.Id}: {item.Title}");
        }
    }
}