using System;
 
public class GuessGame
{
    static public void Main () 
    {
    	Random rand = new Random();
        int number = rand.Next(1, 101);
        int guess;

    	Console.Clear();
    	Console.WriteLine("What number am I thinking of?");
    	guess = Convert.ToInt32(Console.ReadLine());

    	while(guess != number)
    	{		
    		Console.WriteLine("Sorry, that's wrong. Try again.");
            if(guess < number)
            {
                Console.WriteLine("Too low.");
            }
            else 
            {
               Console.WriteLine("Too high."); 
            }
            guess = Convert.ToInt32(Console.ReadLine());
    	}

        Console.WriteLine("Congratulations");

    }
}