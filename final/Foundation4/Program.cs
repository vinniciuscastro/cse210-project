using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> activities = new List<Exercise>();

        Running running = new Running("March 31st 2023",30, 4.8);
        Bicycles cycling = new Bicycles("July 27th 2023", 30, 9.6);
        Swimming swimming = new Swimming("April 6th 2023", 400, 500);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        Console.WriteLine("Summary of activities:");
        Console.WriteLine();
        foreach (Exercise e in activities){
            Console.WriteLine(e.GetSummary());
        }
    }
}

class Exercise {
    protected string _date;
    protected int _minutes;

    public Exercise(string date, int minutes) {
        _minutes = minutes;
        _date = date;
    }

    virtual public double GetDistance() {
        return 0;
    } 
    virtual public double GetSpeed() {
        return 0;
    } 
    virtual public double GetPace() {
        return 0;
    } 
    virtual public string GetSummary() {
        return "";
    } 



}

class Running:Exercise {
    private double _distance;

    public Running(string date, int minutes, double distance): base(date,minutes) {
        _distance = distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }
    public override double GetPace()
    {
        return _minutes / _distance;
    }


    public override string GetSummary()
    {
        return $"  > {_date} Running ({_minutes} min): Distance {Math.Round(_distance,1)} km, Speed {Math.Round(GetSpeed(),1)} kph, Pace {Math.Round(GetPace(),1)} per km";
    }

}

class Bicycles:Exercise {
    private double _speed;

    public Bicycles(string date, int minutes, double speed):base (date, minutes) {
        _speed = speed;
    }

    public override double GetPace()
    {
        return 60/ _speed;
    }
    public override double GetDistance()
    {
        return _speed * _minutes / 60;
    }



    public override string GetSummary()
    {
        return $"  > {_date} Cycling ({_minutes} min): Distance {Math.Round(GetDistance(),1)} km, Speed {Math.Round(_speed,1)} kph, Pace {Math.Round(GetPace(),1)} per km";
    }

}

class Swimming:Exercise {
    private int _laps;

    public Swimming(string date, int minutes, int laps):base (date, minutes) {
        _laps = laps;
    }

    public override double GetDistance() {
        return _laps * 50 /1000;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public override string GetSummary()
    {
        return $"  > {_date} Swimming ({_minutes} min): Distance {Math.Round(GetDistance(),1)} km, Speed {Math.Round(GetSpeed(),1)} kph, Pace {Math.Round(GetPace(),1)} per km";
    }
    
}