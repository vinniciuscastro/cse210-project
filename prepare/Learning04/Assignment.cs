using System;

class Assignment {
    protected string _name;
    protected string _topic;

    public Assignment(string n, string t) {
        _name = n;
        _topic = t;


    }
    public string GetSummary(){
        string summary = $"{_name} - {_topic}";
        return summary;
    }
}