using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------------------------------------");
        Address address = new Address("Rexburg", "Idaho", "STC - 367", "USA");
        Lecture lecture = new Lecture("How to be a nice person", "To be a nice person you need to do nice things", "2:00 pm", "April 1st 2023", address , "Brother Moseley", 30);
        lecture.DisplayLecture();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------");
        Address address1 = new Address("New York", "New York", "Met Museum", "USA");
        Reception reception = new Reception("Met gala", "Red carpet with worldwide super stars", "6:00 pm", "May 2nd", address1, "Welcome to the Met Gala we are happy to have you here", "Yes");
        reception.DisplayReception();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------");
        Address address2 = new Address("London", "London", "Hampstead Heath", "United Kingdom");
        Outdoor outdoor = new Outdoor("Adele concert", "The singer adele will be performing live", "3:00 pm", "July 6th 2023", address2,"Sunshine");
        outdoor.DisplayOutdoor();
    }
}

class Address {
    private string _city;
    private string _state;
    private string _location;
    private string _country;

    public Address(string city, string state, string location, string country) {
        _city = city;
        _state = state;
        _location = location;
        _country = country;
    }

    public string DisplayAddress() {
        return $"Event address\nCity: {_city} State: {_state} Country: {_country} Location: {_location}";
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
        _address = address;
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
        Console.WriteLine($"Short Description - Lecture Title: {_title}\n> {_description}\n> Date: {_date} Time: {_time}\n> Address: {_address.DisplayAddress()}");
        Console.WriteLine($"\nFull Description - Lecture by {_speaker} titled {_title}\n{_description}\n> Date: {_date} Time: {_time}\n> Location Capacity: {_capacity}\n> Address: {_address.DisplayAddress()}");
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
        Console.WriteLine($"Short Description - Reception Title: {_title}\n> {_description}\n> Date: {_date} Time: {_time}\n> Address {_address.DisplayAddress()}");
        Console.WriteLine($"\nFull Description - Reception titled {_title}\n{_description}\n> Registration: {_register}\n> Date: {_date} Time: {_time}\n> Address: {_address.DisplayAddress()}\n>RSVP: {_rsvp}");
    }

}


class Outdoor:Event {
    private string _weather;

    public Outdoor(string title, string description, string time, string date, Address address, string weather):base (title, description, time, date, address) {
        _weather = weather;
    }

    public void DisplayOutdoor(){
        Console.WriteLine($"Short Description - Outdoor Title: {_title}\n> {_description}\n> Date: {_date} Time: {_time}\n> Address {_address.DisplayAddress()}");
        Console.WriteLine($"\nFull Description - Outdoor event titled {_title}\n{_description}\n> Date: {_date} Time: {_time}\n> Address: {_address.DisplayAddress()}\n>Weather: {_weather}");
    }

}