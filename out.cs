using System;

public class OutExample
{
	static void Main () 
    {
        string input;
        int number;

        Console.Clear();
        Console.Write("Enter a number: ");
        input = Console.ReadLine();
        
        if(int.TryParse(input,out number))
        {
            Console.WriteLine("Thank-you");
        }
        else
        {
            Console.WriteLine("Incorrect Input");
        }



    }   
}