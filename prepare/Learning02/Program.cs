using System;

class Program
{
    static void Main(string[] args)
    {
        // Person person01 = new Person();
        // person01._firstName = "Luke";
        // person01._lastName = "Skywalker"

        // Person person02 = new Person();
        // person02._firstName = "Darth";
        // person02._lastName = "Vader";

        // person01.printName();
        // person02.printName();

        Resume person01 = new Resume();
        Resume person02 = new Resume();
        Job job01 = new Job();
        Job job02 = new Job();

        person01._name = "Vinnicius Castro";
        job01._company = "Microsoft";
        job01._jobTitle = "CEO";
        job01._startYear = 2026;
        job01._endYear = 2030;

        
        job02._company = "Google";
        job02._jobTitle = "Software Engineer";
        job02._startYear = 2020;
        job02._endYear = 2023;

        person01._job.Add(job01);
        person01._job.Add(job02);





        // person01.displayResume();
        // job01.displayJobs();
        
        // person02.displayResume();
        // job02.displayJobs();

        person01.displayResume();
    }
}

class Person {
    //property or attributes 
    public string _firstName;
    public string _lastName;

    public void printName() {
        Console.WriteLine($"{_firstName} {_lastName}");
    }

}

class Resume {
    public string _name;
    public List<Job> _job = new List<Job> {};

    public void displayResume() {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _job) {
            job.displayJobs();
        }

     
    }

}

class Job {
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear; 

    public void displayJobs() {
        
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}