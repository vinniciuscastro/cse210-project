using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
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

    public override double GetDistance()
    {
        return GetPace() * 50 / 1000;
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
        return GetPace() * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
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
}