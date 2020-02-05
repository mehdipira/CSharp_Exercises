using System;
 
public class GradeCalculator
{
    static public void Main () 
    {
    	int result;

    	Console.Clear();
    	Console.WriteLine("What is the final result?");
    	result = Convert.ToInt32(Console.ReadLine());

    	if(result >= 95)
    	{
    		Console.WriteLine("A");
    	}
    	
    	
    	Console.WriteLine("Calculation Over.");

    }
}