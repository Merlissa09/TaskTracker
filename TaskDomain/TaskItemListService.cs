namespace TaskDomain;

public class TaskItemListService
{
    // instance variable - this belongs to a specific instance/object of this class
    // this is a todo list
    List<TaskItem> taskItems = [];

    public TaskItemListService()
    {
        PopulateInitialTaskItems();
    }

    /// <summary>
    /// Overloaded constructor which allows for a List of TaskItem to be passed in
    /// upon instantiation
    /// </summary>
    /// <param name="taskItems"> the passed in list of task item</param>
    /// <param name="append"> Optional. Defaults to true. Will first populate with
    /// items from PopulateInitialTaskItems and then append incoming taskItems to the end </param>
    public TaskItemListService(List<TaskItem> taskItems, bool append = true)
    {
        if (append)
        {
            // create a initial list of task items
            PopulateInitialTaskItems();
            // add our incoming task items to the end of the existing list
            this.taskItems.AddRange(taskItems);
        }
        else
            // replace the existing taskItems with the incoming taskItems
            this.taskItems = taskItems;
    }

    private void PopulateInitialTaskItems()
    {
        TaskItem taskOne = new("Clean the chicken coop");
        TaskItem taskTwo = new("Finish convert px to rem");
        TaskItem taskThree = new("Grade Week 3 Labs");


        taskItems.Add(taskOne);
        taskItems.Add(taskTwo);
        taskItems.Add(taskThree);

    }

    public void AddTask(string title)
    {
        TaskItem taskItem = new TaskItem(title);
        taskItems.Add(taskItem);
    }

    /// <summary>
    /// Deletes any taskitems with a matching Id
    /// </summary>
    /// <param name="id">the int id that should be deleted</param>
    /// <returns>the number of matches deleted</returns>
    public int DeleteTask(int id)
    {
        // what is the task we want to delete
        // can identify by name, id
        // going to use id since it is guaranteed to be unique

        // find the index of the id
        // delete the index
        // for a better ux should consider confirming the taskItem with the user before deleting
        return taskItems.RemoveAll(taskItem => taskItem.Id == id);

    }

    // TODO: Move this into the UI layer - this is not the responsibility of the business logic layer
    public void DisplayTaskItems()
    {
        foreach (var item in taskItems)
        {
            Console.WriteLine($"{item.Id}: {item.Title}");
        }
    }

    public void GetAllTasks()
    {
        //returns the full internal list of task items
        foreach (var item in taskitems)
        {
            Console.WriteLine($"{item.ID}, {item.Title}");
        }
    }
    public void GetPendingTasks()
    {
        //returns only tasks where isComplete() is false, 
        //using a loop or stream
        foreach (var item in taskItems)
        {
            if (!item.IsComplete())
            {
                Console.WriteLine($"{item.Id}: {item.Title}");
            }
        }
    }
    public void GetCompletedTasks()
    {
        //returns only tasks where isComplete() is true, using a loop or stream
        foreach (var item in taskItems)
        {
            if (item.IsComplete())
            {
                Console.WriteLine($"{item.Id}: {item.Title}");
            }
        }
    }
}