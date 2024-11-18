using System;
public class Employee
{
    //public Employee()

    //{
    //    Console.WriteLine("Constructors Invoked");
    //}
    //~Employee()
    //{
    //    Console.WriteLine($"Destructor Invoked");
    //}
    //public int id;
    //public String name;
    //public float salary;
    //public Employee(int id, String name, float salary)

    //{
    //    this.id = id;
    //    this.name = name;
    //    this.salary = salary;
    //}
    //public void display()
    //{
    //    Console.WriteLine(id + " " + name + " " + salary);
    //}
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}
class TestEmployee
{
    public static void Mains(string[] args)
    {
        //Employee e1 = new Employee();
        ////Employee e2 = new Employee();
        //Employee e1 = new Employee(101, "Sonoo", 890000f);
        //Employee e2 = new Employee(102, "Mahesh", 490000f);
        //e1.display();
        //e2.display();

        Employee e1 = new Employee();
        e1.Name = "Sonoo Jaiswal";
        Console.WriteLine("Employee Name: " + e1.Name);
    }
}