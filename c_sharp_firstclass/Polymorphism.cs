using System;
//public class Cal
//{
//    public static int add(int a, int b)
//    {
//        return a + b;
//    }
//    public static float add(int a, int b, float c)
//    {
//        return a + b + c;
//    }
//}
//public class TestMemberOverloading
//{
//    public static void Main()
//    {
//        Console.WriteLine(Cal.add(12, 23));
//        Console.WriteLine(Cal.add(12, 23, 25.3f));
//    }
//}

//Method Overriding
//public class Animal
//{

//    public virtual void eat()
//    {
//        Console.WriteLine("Eating...");
//    }
//}
//public class Dog : Animal
//{
//    public override void eat()
//    {
//        Console.WriteLine("Eating bread...");
//    }
//}
//public class TestOverriding
//{
//    public static void Main()

//    {
//        Dog d = new Dog();
//        d.eat();
//    }
//}

//Base
public class Animal{  
    public string color = "white";  
}  
public class Dog: Animal  
{  
    string color = "black";  
    public void showColor()  
    {  
        Console.WriteLine(base.color);  //base keyword to access the variable,method .
        Console.WriteLine(color);  
    }  
      
}  
public class TestBase  
{  
    public static void Mains()  
    {  
        Dog d = new Dog();  
        d.showColor();  
    }  
}  