using System;

public class ThrowingExample
{
	
	static void Main () 
    {
    	int i = 0;
        Console.WriteLine("Enter an integer: ");

        try
        {
            i = GetInteger();
        }
        catch(Exception e)
        {
            Console.WriteLine("The input was incorrect.");
        }
    }

    static int GetInteger()
    {
        string input = Console.ReadLine();
        int val;
        if(!int.TryParse(input, out val))
        {
            throw new Exception();
        }
        return val;
    }
   
}