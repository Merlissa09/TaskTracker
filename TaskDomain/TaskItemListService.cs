namespace TaskDomain;

public class TaskItemListService
{
    // instance variable - this belongs to a specific instance/object of this class
    // this is a todo list
    List<ITaskable> taskItems = [];

    public TaskItemListService()
    {
        PopulateInitialTaskItems();
    }

    /// <summary>
    /// Overloaded constructor which allows for a List of <see cref="ITaskable"/>
    /// to be passed in upon instantiation. Using the interface type allows the
    /// service to accept a heterogeneous collection (TaskItem, DeadlineTask,
    /// RecurringTask, etc.) without depending on concrete types.
    /// </summary>
    /// <param name="taskItems"> the passed in list of items implementing <see cref="ITaskable"/></param>
    /// <param name="append"> Optional. Defaults to true. Will first populate with
    /// items from PopulateInitialTaskItems and then append incoming taskItems to the end </param>
    public TaskItemListService(List<ITaskable> taskItems, bool append = true)
    {
        if (append)
        {
            // create a initial list of task items (these are concrete TaskItem instances)
            PopulateInitialTaskItems();
            // add our incoming task items (might be different implementations of ITaskable)
            // to the end of the existing list
            this.taskItems.AddRange(taskItems);
        }
        else
            // replace the existing taskItems with the incoming taskItems
            // Note: we store the incoming collection typed as List<ITaskable> so callers
            // can pass mixed concrete types without modification.
            this.taskItems = taskItems;
    }

    private void PopulateInitialTaskItems()
    {
        // We construct concrete TaskItem instances here but store them in a
        // List<ITaskable>. This demonstrates how the service uses the
        // interface abstraction so it doesn't care about the concrete type.
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
        return taskItems.RemoveAll(taskItem => taskItem.GetId() == id);

    }

    public List<ITaskable> GetAllTasks()
    {
        // returns the full internal list of task items
        return [.. taskItems.AsReadOnly()];
    }
    public List<ITaskable> GetPendingTasks()
    {
        // returns only tasks where IsComplete() is false
        List<ITaskable> pendingTasks = [];

        foreach (var item in taskItems)
        {
            if (!item.IsComplete())
            {
                pendingTasks.Add(item);
            }
        }

        return [.. pendingTasks.AsReadOnly()];
    }

    public List<ITaskable> GetCompletedTasks()
    {
        // returns only tasks where IsComplete() is false
        List<ITaskable> completedTasks = [];

        foreach (var item in taskItems)
        {
            if (item.IsComplete())
            {
                completedTasks.Add(item);
            }
        }

        return [.. completedTasks.AsReadOnly()];
    }
}