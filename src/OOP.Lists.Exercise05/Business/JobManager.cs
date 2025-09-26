using OOP.Lists.Exercise05.Models;

namespace OOP.Lists.Exercise05.Business;

public class JobManager
{
    private List<Job> jobList;

    public JobManager()
    {
        jobList = new List<Job>();
    }

    public void AddJob(string description, DateTime dueDate)
    {
        Job newJob = new Job(description, dueDate);
        jobList.Add(newJob);
    }

    public void RemoveJob(string informedDescription)
    {
        Job jobToRemove = jobList.Find(j => j.Description == informedDescription);
        if (jobToRemove != null)
        {
            jobList.Remove(jobToRemove);
        }
    }

    public List<Job> ListJobs()
    {
        return jobList;
    }

    public List<Job> JobsForToday()
    {
        return jobList.FindAll(jobs => jobs.ShouldBeExecutedToday());
    }
}
