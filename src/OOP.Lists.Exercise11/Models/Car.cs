namespace OOP.Lists.Exercise11.Models;

public class Car : Vehicle
{
    public Car(string model, int year) : base(model, year) {}

    public override void Accelerate(int increment)
    {
        UpdateSpeed(Speed + increment);
        Console.WriteLine($"Car ({Model}) accelerates by {increment} km/h. New Speed: {Speed} km/h.");
    }

    public override void Brake(int decrement)
    {
        UpdateSpeed(Speed - decrement);
        Console.WriteLine($"Car ({Model}) brakes by {decrement} km/h. New Speed: {Speed} km/h.");
    }

    public override string ToString()
    {
        return $"[Car] Model: {Model}, Year: {Year}, Current Speed: {Speed} km/h";
    }
}
