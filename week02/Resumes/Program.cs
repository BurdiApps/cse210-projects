using System;
// A code template for the Program class

// I was first putting public in front of class
// Is it necessary? 
class Program
{
    //public (same here)
     static void Main(string[] args)
    {
        // test job  class
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2019";
        job1._endYear = "2022";

        //add second job
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = "2022";
        job2._endYear = "2023";

        // This was the first way I did it to make
        // it work
        // |
        // v
        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        // create new instance of the Resume class
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobDetails();
    }

}