namespace OOP.Lists.Exercise10.Models;

public class Dog : Animal
{
    public Dog(string name, int age) : base(name, "Dog", age) {}

    public override void MakeSound(string animalSound = "Woof! Woof!")
    {
        Console.Write($"The dog says: ");
        base.MakeSound(animalSound);
    }
}
