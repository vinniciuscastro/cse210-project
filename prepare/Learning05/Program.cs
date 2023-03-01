using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        string color = "Yellow";
        
        
        var squ = new Square(color, 8.32);
        var rec = new Rectangle("yelloww", 2.32, 1.02);
        var cir = new Circle("yellowish", 3.14);
        shapes.Add(squ);
        shapes.Add(rec);
        shapes.Add(cir);

        foreach (Shape s in shapes) {
            string c = s.getColor();
            double area = s.GetArea();

            Console.WriteLine($"The {c} has an area of {area}");
        }
        
    }
}
class Shape {
    protected string _color = "yellow";

    public Shape(string color) {
        _color = color;
    }
    public string getColor() {
        return _color;
    }

    public void setColor(string color) {
        _color = color;
    }

    virtual public double GetArea() {
        return  0;
    }
}

class Square: Shape {
    private double _side = 8.02;

    public Square(string color, double side): base(color) {
        _side = side;
    }

    public override double GetArea() {
        return _side;
    }
 
}

class Rectangle:Shape {

    private double _length = 2.82; 
    private double _width = 2.87;

    public Rectangle(string color, double length, double width): base(color){
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}

class Circle: Shape {
    private double _radius = 3.14;

    public Circle(string color, double radius): base(color) {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius;
    }
}