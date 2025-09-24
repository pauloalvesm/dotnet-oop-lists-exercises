namespace OOP.Lists.Exercise05.Models;

public class Job
{
    public string Description { get; private set; }
    public DateTime DueDate { get; private set; }

    public Job(string description, DateTime dueDate)
    {
        Description = description;
        DueDate = dueDate;
    }

    public bool ShouldBeExecutedToday()
    {
        return DueDate.Date == DateTime.Today;
    }
}
