using c_sharp_firstclass;
using System;

public class Function
{

    //call by value
    //public void Show(int val)
    //{
    //    val *= val; // Manipulating value  
    //    Console.WriteLine("Value inside the show function " + val);
    //    // No return statement  
    //}
    //public void Run()
    //{
    //    int val = 50;
    //    Function program = new Function(); // Creating Object  
    //    Console.WriteLine("Value before calling the function " + val);
    //    program.Show(val); // Calling Function by passing value            
    //    Console.WriteLine("Value after calling the function " + val);
    //}

    //call by value

    //call by reference
    //public void Show(ref int val)
    //{
    //    val *= val; // Manipulating value  
    //    Console.WriteLine("Value inside the show function " + val);
    //    // No return statement  
    //}
    //// Main function, execution entry point of the program  
    //public void Run()
    //{
    //    int val = 50;
    //    Function program = new Function(); // Creating Object  
    //    Console.WriteLine("Value before calling the function " + val);
    //    program.Show(ref val); // Calling Function by passing reference            
    //    Console.WriteLine("Value after calling the function " + val);
    //}

    //call by reference

    //out parameter
    public void Show(out int a, out int b) // Out parameter  
    {
        int square = 5;
        a = square;
        b = square;
        // Manipulating value  
        a *= a;
        b *= b;
    }
    // Main function, execution entry point of the program  
    public void Run()
    {
        int val1 = 50, val2 = 100;
        Function program = new Function(); // Creating Object  
        Console.WriteLine("Value before passing \n val1 = " + val1 + " \n val2 = " + val2);
        program.Show(out val1, out val2); // Passing out argument  
        Console.WriteLine("Value after passing \n val1 = " + val1 + " \n val2 = " + val2);
    }
    //out parameter


}
