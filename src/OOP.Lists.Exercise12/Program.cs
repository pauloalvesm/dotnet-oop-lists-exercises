using OOP.Lists.Exercise12.Business;
using OOP.Lists.Exercise12.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Contact Agenda *****");

        Agenda agenda = new Agenda();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Person");
            Console.WriteLine("2. Remove Person");
            Console.WriteLine("3. Search Person");
            Console.WriteLine("4. Print Agenda");
            Console.WriteLine("5. Exit");

            Console.Write("\nOption: ");

            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("Invalid option, please try again!");
                continue;
            }

            switch (option)
            {
                case 1:
                    Console.WriteLine("\nEnter the person's data: ");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Age: ");
                    if (!int.TryParse(Console.ReadLine(), out int age))
                    {
                        Console.WriteLine("Invalid Age format. Returning to main menu.");
                        break;
                    }

                    Console.Write("Height: ");
                    if (!float.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out float height))
                    {
                        Console.WriteLine("Invalid Height format. Returning to main menu.");
                        break;
                    }

                    agenda.StorePerson(name, age, height);
                    break;

                case 2:
                    Console.Write("Name of the person to be removed: ");
                    string nameForRemoval = Console.ReadLine();
                    agenda.RemovePerson(nameForRemoval);
                    break;

                case 3:
                    Console.Write("Name of the person you want to search: ");
                    string nameForSearch = Console.ReadLine();
                    Person person = agenda.SearchPerson(nameForSearch);

                    if (person != null)
                    {
                        Console.WriteLine($"Person found - {person}");
                    }
                    else
                    {
                        Console.WriteLine("Person not found in the agenda!");
                    }
                    break;

                case 4:
                    agenda.PrintAgenda();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option, please try again!");
                    break;
            }
        }
    }
}