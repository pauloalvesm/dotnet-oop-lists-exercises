using OOP.Lists.Exercise05.Business;
using OOP.Lists.Exercise05.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Job Manager *****");

        JobManager manager = new JobManager();

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1 - Add Job");
            Console.WriteLine("2 - List Jobs for Today");
            Console.WriteLine("3 - List All Jobs");
            Console.WriteLine("4 - Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            Console.WriteLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter the job description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter the due date (example: 2023-10-26): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
                    {
                        manager.AddJob(description, dueDate);
                        Console.WriteLine("Job added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid date. The job was not added.");
                    }
                    break;
                case "2":
                    List<Job> jobsToday = manager.JobsForToday();
                    Console.WriteLine("Jobs for today:");
                    foreach (Job job in jobsToday)
                    {
                        Console.WriteLine($"{job.Description} - {job.DueDate.ToShortDateString()}");
                    }
                    break;
                case "3":
                    List<Job> allJobs = manager.ListJobs();
                    Console.WriteLine("All jobs:");
                    foreach (Job job in allJobs)
                    {
                        Console.WriteLine($"{job.Description} - {job.DueDate.ToShortDateString()}");
                    }
                    break;
                case "4":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}