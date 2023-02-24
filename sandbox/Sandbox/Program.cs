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
