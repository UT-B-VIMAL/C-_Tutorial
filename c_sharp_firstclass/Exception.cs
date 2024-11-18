using System;
//public class ExExample
//{
//    public static void Main(string[] args)
//    {
//        try
//        {
//            int a = 10;
//            int b = 0;
//            int x = a / b;
//        }
//        //catch (Exception e) { Console.WriteLine(e.Message); }
//        catch (NullReferenceException e) { Console.WriteLine(e); }
//        finally { Console.WriteLine("Finally block is executed"); }

//        Console.WriteLine("Rest of the code");
//    }


//}

//user-defined exception
public class InvalidAgeException : Exception
{
    public InvalidAgeException(String message)
        : base(message)
    {

    }

}
public class TestUserDefinedException
{
    static void validate(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Sorry, Age must be greater than 18");
        }
    }
    public static void Main(string[] args)
    {
        try
        {
            validate(17);
        }
        catch (InvalidAgeException e) { Console.WriteLine(e.Message); }
        Console.WriteLine("Rest of the code");
    }
}