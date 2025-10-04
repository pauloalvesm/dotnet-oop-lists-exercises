using OOP.Lists.Exercise12.Models;

namespace OOP.Lists.Exercise12.Business;

public class Agenda
{
    private List<Person> _personList;

    public Agenda()
    {
        _personList = new List<Person>();
    }

    public void StorePerson(string name, int age, float height)
    {
        Person person = new Person(name, age, height);
        _personList.Add(person);
    }

    public void RemovePerson(string name)
    {
        Person person = SearchPerson(name);

        if (person != null)
        {
            _personList.Remove(person);
        }
        else
        {
            Console.WriteLine("Person not found in the agenda.");
        }
    }

    public Person SearchPerson(string name)
    {
        return _personList.Find(p => p.Name == name);
    }

    public void PrintAgenda()
    {
        Console.WriteLine("Agenda:");

        foreach (var person in _personList)
        {
            Console.WriteLine(person.ToString());
        }
    }
}
