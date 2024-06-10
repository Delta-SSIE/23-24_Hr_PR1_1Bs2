// See https://aka.ms/new-console-template for more information
using vaicova_projekt;

Calendar instalation = new Calendar();

while (true)
{
    int volba = VypisMenu();

    WriteTask(volba, instalation);

}

static int VypisMenu()
{
    int volba;

    while (true)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Create a task");
        Console.WriteLine("2. Show all tasks");
        Console.WriteLine("3. Delet a task");
        Console.WriteLine("4. Delet all to-do list");
        Console.WriteLine("5. Exit");

        if (int.TryParse(Console.ReadLine(), out volba) && volba >= 1 && volba <= 5)
        {
            break;
        }

    }
    return volba;
}

void WriteTask(int volba, Calendar i)
{
    switch (volba)
    {
        case 1:
            Console.WriteLine("Write a name of the task:");
            string task = Console.ReadLine();
            Console.WriteLine("Write a day of the task:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a month of the task:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a notes for the task");
            string notes = Console.ReadLine();

            Part newTask = new Part(task, day, month, notes);

            i.AddTasks(newTask);
            Console.WriteLine("Task was succesfully created");
            break;

        case 2:
            Console.WriteLine("All the tasks:");
            i.ShowAllTasks();
            break;

        case 3:
            Console.WriteLine("Write a name of the task that you want to delete:");
            string delete = Console.ReadLine();
            i.DeleteTask(delete);
            Console.WriteLine("Task was succesfully deleted");
            break;

        case 4:
            i.DeleteAllTasks();
            Console.WriteLine("All tasks were succedfully deleted");
            break;

        case 5:
            Environment.Exit(0);
            break;
    }
}
