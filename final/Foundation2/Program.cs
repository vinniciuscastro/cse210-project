using System;

class Program
{
    static void Main(string[] args)
    {
        Order orders = new Order();
        orders.Display();
    }
}


class Product {
    private string _product;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string product, int id, double price, int quantity) {
        _product = product;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string DisplayProduct() {
        return $"{_id} - {_product}: QT {_quantity} price: ${_price}";
    } 

}

class Address {
    private string _city;
    private string _state;
    private string _province;
    private string _country;
    private double _shipping; 

    public Address(string city, string state, string province, string country) {
        _city = city;
        _state = state;
        _province = province;
        _country = country;
    
    }

    public string DisplayAddress() {
        if (_country == "United States") {
            _shipping = 5.00;
        }
        else {
            _shipping = 35.00;
        }
        return $"City: {_city} State: {_state} Province: {_province} Country: {_country}\nShipping price: ${_shipping}";
    }

}

class Customer {
    private string _name;

    public Customer(string name){
        _name = name; 
    }

    public string DisplayCustomer() {
        return $"Customer name: {_name}";
    }
}
class Order {
    Product p = new Product("apple", 0021, 3.43, 5);
    Customer c = new Customer("Vinnicius Castro");
    Address a = new Address("Sao Paulo","SP","None", "Brazil");
    Product p1 = new Product("honey", 0011, 2.21, 7);
    Customer c1 = new Customer("Olivia Rodrigo");
    Address a1 = new Address("Murrieta","CA","French Valley", "United States");
    Product p2 = new Product("bread", 0011, 1.99, 9);
    Customer c2 = new Customer("Billie Eilish");
    Address a2 = new Address("Los Angeles","CA","Santa Monica", "United States");
    Product p3 = new Product("Strawberry", 0011, 1.99, 2);
    Customer c3 = new Customer("Tais Araujo");
    Address a3 = new Address("Rio de Janeiro","RJ","None", "Brazil");


    public void Display(){
        Console.WriteLine("Customer:");
        Console.WriteLine($"{c.DisplayCustomer()}\n{a.DisplayAddress()}");
        Console.WriteLine();
        Console.WriteLine($"Order:\n{p.DisplayProduct()}");
        Console.WriteLine();
        Console.WriteLine("Customer:");
        Console.WriteLine($"{c1.DisplayCustomer()}\n{a1.DisplayAddress()}");
        Console.WriteLine();
        Console.WriteLine($"Order:\n{p1.DisplayProduct()}");
        Console.WriteLine();
        Console.WriteLine("Customer:");
        Console.WriteLine($"{c2.DisplayCustomer()}\n{a2.DisplayAddress()}");
        Console.WriteLine();
        Console.WriteLine($"Order:\n{p2.DisplayProduct()}");
        Console.WriteLine();
        Console.WriteLine("Customer:");
        Console.WriteLine($"{c3.DisplayCustomer()}\n{a3.DisplayAddress()}");
        Console.WriteLine();
        Console.WriteLine($"Order:\n{p3.DisplayProduct()}");
    }


}