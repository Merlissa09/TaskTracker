namespace TaskDomain;


public abstract class TaskSorter
{
    //Takes a list of Task Items and sorts them
    public abstract List<TaskItem> Sort(List<TaskItem> tasks);
}
public class AlphabeticalTaskSorter : TaskSorter
{                   //this grabs the task and sorts them then returns a sorted list of tasks
    public override List<TaskItem> Sort(List<TaskItem> tasks)
    {   //This sorts the list of task by A-Z
        return tasks.OrderBy(task => task.GetTitle()).ToList();
    }
}
public class CompletionSorter : TaskSorter
{                   //This sorts the list of task by completion status
    public override List<TaskItem> Sort(List<TaskItem> tasks)
    {   //if task is incomplete it will be first/ if complete it will be last 
        return tasks.OrderBy(task => task.IsComplete()).ToList();
    }
} 