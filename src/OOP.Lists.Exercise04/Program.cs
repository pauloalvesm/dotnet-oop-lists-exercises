using OOP.Lists.Exercise04.Business;
using OOP.Lists.Exercise04.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Phone Book *****");

        PhoneBook phoneBook = new PhoneBook();

        while (true)
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1. Add a contact");
            Console.WriteLine("2. Find a contact");
            Console.WriteLine("3. Remove a contact");
            Console.WriteLine("4. Display all contacts (sorted)");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Contact's name: ");
                    string name = Console.ReadLine();
                    Console.Write("Contact's phone number: ");
                    string phone = Console.ReadLine();
                    Console.Write("Contact's email: ");
                    string email = Console.ReadLine();
                    Contact newContact = new Contact(name, phone, email);
                    phoneBook.AddContact(newContact);
                    break;
                case 2:
                    Console.Write("Name of the contact to find: ");
                    string nameToFind = Console.ReadLine();
                    Contact foundContact = phoneBook.FindContact(nameToFind);
                    if (foundContact != null)
                    {
                        Console.WriteLine($"Contact found: {foundContact.Name}, {foundContact.Phone}, {foundContact.Email}");
                    }
                    else
                    {
                        Console.WriteLine("Contact not found.");
                    }
                    break;
                case 3:
                    Console.Write("Name of the contact to remove: ");
                    string nameToRemove = Console.ReadLine();
                    Contact contactToRemove = phoneBook.FindContact(nameToRemove);
                    if (contactToRemove != null)
                    {
                        phoneBook.RemoveContact(contactToRemove);
                        Console.WriteLine("Contact removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Contact not found.");
                    }
                    break;
                case 4:
                    phoneBook.DisplaySortedContacts();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}