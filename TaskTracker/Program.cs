using TaskDomain;
using TaskTracker;

// TODO: if time later in the course discuss DI (dependency injection)

var shouldContinue = true;

// this is a object representing our to do list
TaskItemListService taskItemListService = new();

do
{
    Console.WriteLine("Welcome to TaskTracker!");

    foreach (var item in Enum.GetValues<MainMenu>())
    {
        Console.WriteLine($"{(int)item}. {item}");
    }

    Console.Write("Choose an option: ");

    int.TryParse(Console.ReadLine(), null, out int input);


    switch (input)
    {
        case (int)MainMenu.ListTasks:
            UiDisplay.DisplayTaskItems(taskItemListService.GetAllTasks());
            break;
        case (int)MainMenu.AddTask:

            Console.WriteLine("What is the name of the task to add?");
            var userInput = Console.ReadLine();
            if (userInput != null)
            {
                // add logic to add a task
                taskItemListService.AddTask(userInput);
            }
            break;
        case (int)MainMenu.DeleteTask:
            Console.WriteLine("What is the ID of the task you'd like to delete?");
            var success = int.TryParse(Console.ReadLine(), out int idToDelete);
            if (success)
                taskItemListService.DeleteTask(idToDelete);
            else
                Console.WriteLine("Your answer wasn't valid, please enter a different ID number");
            break;
        case (int)MainMenu.UpdateTask:
            break;
        default:
            shouldContinue = false;
            break;
    }
    // make it so that the pro
} while (shouldContinue);