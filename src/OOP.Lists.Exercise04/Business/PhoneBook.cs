using OOP.Lists.Exercise04.Models;

namespace OOP.Lists.Exercise04.Business;

public class PhoneBook
{
    private List<Contact> contactList;

    public PhoneBook()
    {
        contactList = new List<Contact>();
    }

    public void AddContact(Contact contact)
    {
        contactList.Add(contact);
    }

    public void RemoveContact(Contact contact)
    {
        contactList.Remove(contact);
    }

    public Contact FindContact(string name)
    {
        return contactList.Find(c => c.Name == name);
    }

    public void DisplaySortedContacts()
    {
        var sortedList = new List<Contact>(contactList);
        sortedList.Sort((contact1, contact2) => 
        string.Compare(contact1.Name, contact2.Name, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("---------- Contacts in Alphabetical Order ----------");
        if (sortedList.Count == 0)
        {
            Console.WriteLine("No contacts in the phone book.");
        }
        else
        {
            foreach (var contact in sortedList)
            {
                Console.WriteLine($"Name: {contact.Name} | Phone: {contact.Phone} | Email: {contact.Email}");
            }
        }
        Console.WriteLine("-------------------------------------");
    }
}
