namespace OOP.Lists.Exercise04.Models;

public class Contact
{
    public string Name { get; private set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public Contact(string name, string phone, string email)
    {
        this.Name = name;
        this.Phone = phone;
        this.Email = email;
    }
}
