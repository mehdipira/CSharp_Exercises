using System;
 
public class GuessMyNumber
{
    static public void Main () 
    {
    	string myName = "Merlin";
    	string guess;

    	Console.Clear();
    	Console.WriteLine("What is my name?");
    	guess = Console.ReadLine();

    	if(guess == myName)
    	{
    		Console.WriteLine("Congratulations");
    	}
    	else 
    	{
    		Console.WriteLine("Sorry, that's wrong.");
    	}

    }
}