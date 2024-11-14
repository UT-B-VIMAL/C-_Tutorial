using c_sharp_firstclass;
using System;

public class Arrays
{
    public void printArrays(int[] arr)  //array to function
    {
        //int[] arr = new int[5] { 10, 20, 30, 40, 50 };
        //int[] arr = new int[] { 10, 20, 30, 40, 50 };
        //int[] arr = { 10, 20, 30, 40, 50 };

        //traversing array  
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}
        Console.WriteLine("Printing array values");
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
    public void array()
    {
        //int[] arr1 = { 25, 10, 20, 15, 40, 50 };
        //int[] arr2 = { 12, 23, 44, 11, 54 };
        //printArrays(arr1);//passing array to function  
        //printArrays(arr2);
        //multiarray();
        //jaggedArray();
        //Params();
        ArrayClass();
    }

    //Multidimensional array
    public void multiarray()
    { 
        //int[,,] arr = new int[3, 3, 3];//declaration of 3D array  
        int[,] arr = new int[3, 3];//declaration of 2D array  
        arr[0, 1] = 10;//initialization  
        arr[1, 2] = 20;
        arr[2, 0] = 30;

        //traversal  
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {

                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();//new line at each row  
        }
    }
    //Multidimensional array

    //Jagged array
    public void jaggedArray()
    {
        int[][] arr = new int[2][];// Declare the array  


        arr[0] = new int[] { 11, 21, 56, 78 };// Initialize the array          
        arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };

        // Traverse array elements  
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                System.Console.Write(arr[i][j] + " ");
            }
            System.Console.WriteLine();
        }
    }
    //Jagged array

    //Params
    public void Show(params int[] val) // Params Paramater  
    {
        for (int i = 0; i < val.Length; i++)
        {
            Console.WriteLine(val[i]);
        }
    }
    // Main function, execution entry point of the program  
    static void Params()
    {
        Arrays program = new Arrays(); // Creating Object  
        program.Show(2, 4, 6, 8, 10, 12, 14); // Passing arguments of variable length  
    }

    //Params

    //Array Class
    public void ArrayClass()
    {
        // Creating an array  
        int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
        // Creating an empty array  
        int[] arr2 = new int[6];
        // Displaying length of array  
        Console.WriteLine("length of first array: " + arr.Length);
        // Sorting array  
        Array.Sort(arr);
        Console.Write("First array elements: ");
        // Displaying sorted array  
        PrintArray(arr);
        // Finding index of an array element  
        Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(arr, 25));
        // Coping first array to empty array  
        Array.Copy(arr, arr2, arr.Length);
        Console.Write("Second array elements: ");
        // Displaying second array  
        PrintArray(arr2);
        Array.Reverse(arr);
    }
    public void PrintArray(int[] arr)
    {
        foreach (int elem in arr)
        {
            Console.Write(elem + " ");
        }
    }
    //Array Class



}
