using System;

class Math: Assignment {
    private string _textBookSection;
    private string _problems;

    public Math(string name, string topic, string section, string problem): base(name, topic) {
        _textBookSection = section;
        _problems = problem;
    }
    public string GetHomework() {
        string homework = $"{_textBookSection} {_problems}";
        return homework;
    }
}