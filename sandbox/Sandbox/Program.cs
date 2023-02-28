using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World! This is Vinni");
//         Console.WriteLine(AddNUmbers(2,2));
//     }

//     static int AddNUmbers(int num1, int num2) {
//         return num1 + num2;
//     }
// }
// class Program {
//     static void Main(string[] args) {
        
//         var divider =  new IntegerDivision();
//         divider.SetLhs(10);
//         divider.SetRhs(1);
//         divider.DisplayResult();

//         divider.SetLhs(0);
//         divider.SetRhs(100);
//         divider.DisplayResult();

//         divider.SetLhs(5);
//         divider.SetRhs(0);
//         divider.DisplayResult();

//         divider.SetLhs(25);
//         divider.SetRhs(5);
//         divider.DisplayResult();
//     }
// }

// class IntegerDivision {
//     private int _lhs = 1;
//     private int _rhs = 1;

//     public IntegerDivision() {
//         _lhs = 1;
//         _rhs = 1;
//     }
//     public IntegerDivision(int wholeNumber) {
//         _lhs = wholeNumber;
//         _rhs = 1;
//     }


//     public int Result() {
//         return _lhs / _rhs;
//     }

//     public int GetLhs() {
//         return _lhs;
//     }
//     public void SetLhs(int lhs) {
//         _lhs = lhs;
//     }

//     public int GetRhs() {
//         return _rhs;
//     }

//     public void SetRhs(int rhs) {
//         if (rhs == 0) {
//             Console.WriteLine("You can't divide by 0");
//         } else {
//             _rhs = rhs;
//         }
        
//     }
    

//     public void DisplayResult() {
//         var result = Result();
//         Console.WriteLine($"{_lhs} divided by {_rhs} is {result}");
//     }
// }

// class Program {
//         static void Main(string[] args) {
//             var person = new Person();
//             var student = new Student();

//             Console.WriteLine(person.GetName());
//             Console.WriteLine(student.GetName());

//         }
// }

// // parent class, super class, base class 
// class Person {
//     public string GetName() {
//         return "Vinnicius";
//     }
// }

// // child class or sub class
// class Student: Person {

// }
// Method Overriding 
// When I child class provides its own implementation of a method
// class Program
// {
//     static void Main(string[] args)
//     {
//         var employees = new List<Employee>();
//         var salary = new Employee();
//         var hourly = new HourlyEmployee();
//         var exec = new Executive();

//         employees.Add(salary);
//         employees.Add(hourly);
//         employees.Add(exec);
//         foreach (var e in employees) {
//             Console.WriteLine(e.CalculateYearPlay());
//         }
//         Console.WriteLine(salary.CalculateYearPlay());
//         Console.WriteLine(hourly.CalculateYearPlay());
//     }
// }
// class Employee {
//     protected int Salary = 100000;

//     virtual public int CalculateYearPlay() {
//         return Salary;
//     }
// }
// class Executive: Employee {
//     private int bonus= 1000000;

//     public override int CalculateYearPlay()
//     {
//         return Salary + bonus; 
//     }
// }
// class HourlyEmployee: Employee {
//     private int HourlyWage = 25;
//     private int HoursPerYear = 2000;

//     public override int CalculateYearPlay()
//     {
//         return HourlyWage * HoursPerYear;
//     }
// }


class Program
{
    static void Main(string[] args)
    {
       
    }
}

abstract class Person {
    abstract public string Speak(); 
}

class NicePerson: Person {
    public override string Speak()
    {
        return "Hello! How are you today?";
    }
}
class MeanPerson: Person {
    public override string Speak()
    {
        return "Your code is the worst.";
    }
}
