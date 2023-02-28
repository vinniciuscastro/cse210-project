using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
    }
}
class Shape {
    protected string _color;


    public string getColor() {
        return _color;
    }

    public void setColor(string color) {
        _color = color;
    }

    // public double GetArea() {
    //     return  
    // }
}

class Square: Shape {
    private double _side;

    // public double GetArea() {
    //     return  
    // }
}

class Rectangle:Shape {
    private double _length; 
    private double _width; 

    // public double GetArea() {
    //     return  
    // }
}

class Circle: Shape {
    private double _radius; 

    // public double GetArea() {
    //     return  
    // }
}