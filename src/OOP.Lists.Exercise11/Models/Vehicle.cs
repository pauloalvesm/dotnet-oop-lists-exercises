namespace OOP.Lists.Exercise11.Models;

public abstract class Vehicle
{
    public string Model { get; }
    public int Year { get; }
    public int Speed { get; private set; }

    public Vehicle(string model, int year, int initialSpeed = 0)
    {
        Model = model;
        Year = year;
        Speed = initialSpeed;
    }

    public abstract void Accelerate(int increment);
    public abstract void Brake(int decrement);

    protected void UpdateSpeed(int newSpeed)
    {
        Speed = Math.Max(0, newSpeed);
    }

    public override string ToString()
    {
        return $"[Vehicle] Model: {Model}, Year: {Year}, Current Speed: {Speed} km/h";
    }
}
