// class for Resume

using System;
// create resume class
public class Resume
{
    public string _name;

    // create member variable names, datatype: List<Job>
    // initialize the list
    public List<Job> _jobs = new List<Job>();

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}