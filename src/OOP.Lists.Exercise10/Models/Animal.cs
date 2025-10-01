namespace OOP.Lists.Exercise10.Models;

public class Animal
{
    protected string _name;
    protected string _species;
    protected int _age;

    public Animal(string name, string species, int age)
    {
        _name = name;
        _species = species;
        _age = age;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Species
    {
        get { return _species; }
        set { _species = value; }
    }

    public int Age 
    {
        get { return _age; }
        set { _age = value; }
    }

    public virtual void MakeSound(string animalSound)
    {
        Console.WriteLine(animalSound);
    }
}
