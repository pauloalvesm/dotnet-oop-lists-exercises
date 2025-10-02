namespace OOP.Lists.Exercise11.Models;

public class Motorcycle : Vehicle
{
    public Motorcycle(string model, int year) : base(model, year) {}

    public override void Accelerate(int increment)
    {
        UpdateSpeed(Speed + increment);
        Console.WriteLine($"Motorcycle ({Model}) accelerates by {increment} km/h. New Speed: {Speed} km/h.");
    }

    public override void Brake(int decrement)
    {
        UpdateSpeed(Speed - decrement);
        Console.WriteLine($"Motorcycle ({Model}) brakes by {decrement} km/h. New Speed: {Speed} km/h.");
    }

    public override string ToString()
    {
        return $"[Motorcycle] Model: {Model}, Year: {Year}, Current Speed: {Speed} km/h";
    }
}
