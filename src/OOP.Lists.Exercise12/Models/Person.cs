namespace OOP.Lists.Exercise12.Models
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }

        public Person(string name, int age, float height)
        {
            Name = name;
            Age = age;
            Height = height;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Height: {Height}";
        }
    }
}
