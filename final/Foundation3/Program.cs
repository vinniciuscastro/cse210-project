using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
    }
}

class Address {
    private string _city;
    private string _state;
    private string _province;
    private string _country;

    public Address() {
        
    
    }

    public string DisplayAddress() {
        return $"Event address\nCity: {_city} State: {_state} Province: {_province} Country: {_country}";
    }

}
class Event {
    protected string _title;
    protected string _description;
    protected string _time;
    protected string _date;
    protected Address _address;


    public Event(string title, string description, string time, string date, Address address) {
        _title = title;
        _description = description;
        _time = time; 
    }

}

class Lecture:Event {
    private string _speaker;
    private int _capacity;
    

    public Lecture(string title, string description, string time, string date, Address address, string speaker, int capacity):base (title, description, time, date, address) {
        _speaker = speaker;
        _capacity = capacity;
    }
    public void DisplayLecture() {
        Console.WriteLine($"Lecture Title: {_title}");
    }
}

class Reception:Event{
    private string _rsvp;
    private string _register; 
    
    public Reception(string title, string description, string time,string date, Address address, string rsvp, string register): base (title, description, register, date, address){
        _rsvp = rsvp;
        _register = register;
    }
    public void DisplayReception(){

    }

}


class Outdoor:Event {
    private string _weather;

    public Outdoor(string title, string description, string time, string date, Address address, string weather):base (title, description, time, date, address) {
        _weather = weather;
    }

    public void DisplayOutdoor(){

    }

}