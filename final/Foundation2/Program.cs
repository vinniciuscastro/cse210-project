using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
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

}

class Address {
    private string _city;
    private string _state;
    private string _province;
    private string _country;
    private int _shipping; 

}

class Customer {
    private string _name;
    Address address = new Address();
}
class Order {
    Product p = new Product("apple", 0021, 3.43, 5);
    Customer c = new Customer();

}