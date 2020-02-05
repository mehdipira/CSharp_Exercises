using System;
 
public class ErrorInput
{
    static public void Main () 
    {
        int number;

        Console.Clear();
        Console.WriteLine("Type in an integer:");
        number = Convert.ToInt32(Console.ReadLine());
    }
}