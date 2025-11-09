using System;
public class Job
{
    // create member variables in the class for each element
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    // create method (member function) to display the job details
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }

}