namespace OOP.Lists.Exercise10.Models;

public class Cat : Animal
{
    public Cat(string name, int age) : base(name, "Cat", age) {}

    public override void MakeSound(string animalSound = "Meow!")
    {
        Console.Write($"The cat says: ");
        base.MakeSound(animalSound);
    }
}
