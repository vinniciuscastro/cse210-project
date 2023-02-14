using System;

class Writing: Assignment{
    private string _title;
  

    public Writing(string name, string topic, string title):base(name,topic){
        _title = title;

    }

    public string GetWritingInfo() {
        string info = $"{_title}";
        return info;
    }

}