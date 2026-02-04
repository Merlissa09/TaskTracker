var shouldContinue = true;
do
{
    Console.WriteLine("Welcome to TaskTracker!");
    Console.WriteLine("1. List Tasks");
    Console.WriteLine("2. About");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");

    int.TryParse(Console.ReadLine(), null, out int input);


    switch (input)
    {
        case 1:
            // list the tasks
            break;
        case 2:

            break;
        case 3:
            shouldContinue = false;
            break;
        default:
            shouldContinue = false;
            break;
    }
    // make it so that the pro
} while (shouldContinue);

void AboutMeInformation()
{
    Console.WriteLine("My name is Melissa Hegney");
    Console.WriteLine("My GitHub name is Merlissa09");
    Console.WriteLine();
}