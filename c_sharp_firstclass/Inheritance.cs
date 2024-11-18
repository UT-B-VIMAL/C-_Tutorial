using System;


//Single Level Inheritance
//public class Employees
//{
//    public float salary = 40;
//}
//public class Programmer : Employees
//{
//    public float bonus = 1000;
//}
//class TestInheritance
//{
//    public static void Main(string[] args)
//    {
//        Programmer p1 = new Programmer();

//        Console.WriteLine("Salary: " + p1.salary);
//        Console.WriteLine("Bonus: " + p1.bonus);

//    }
//}

//Multi Level Inheriatnce
//public class Animal
//{
//    public void eat() { Console.WriteLine("Eating..."); }
//}
//public class Dog : Animal
//{
//    public void bark() { Console.WriteLine("Barking..."); }
//}
//public class BabyDog : Dog
//{
//    public void weep() { Console.WriteLine("Weeping..."); }
//}
//class TestInheritance2
//{
//    public static void Main(string[] args)

//    {
//        BabyDog d1 = new BabyDog();
//        d1.eat();
//        d1.bark();
//        d1.weep();
//    }
//}

//Aggregation
public class Address
{
    public string addressLine, city, state;
    public Address(string addressLine, string city, string state)
    {

        this.addressLine = addressLine;
        this.city = city;
        this.state = state;
    }
}
public class Employees
{
    public int id;
    public string name;
    public Address address;//Employee HAS-A Address  
    public Employees(int id, string name, Address address)
    {
        this.id = id;
        this.name = name;

        this.address = address;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " +
          address.addressLine + " " + address.city + " " + address.state);
    }
}
public class TestAggregation
{
    public static void Mains(string[] args)
    {
        Address a1 = new Address("G-13, Sec-3", "Noida", "UP");
        Employees e1 = new Employees(1, "Sonoo", a1);
        e1.display();
    }
}