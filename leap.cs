using System;
 
public class LeapYear
{
    static public void Main () 
    {
    	//A leap year is a year divisible by 4
    	//BUT a year divisible by 100 is not a leap year unless
    	//it is also divisible by 400

    	int year, test1, test2, test3;

    	Console.Clear();
    	Console.WriteLine("Please Enter a Year:");
    	year = Convert.ToInt32(Console.ReadLine());

    	test1 = year % 4;
    	test2 = year % 100;
    	test3 = year % 400;

    	if( (test1 == 0 && test2 != 0) || test3 == 0 )
    	{
    		Console.WriteLine("This is a Leap Year.");
    	}
    	else
    	{
    		Console.WriteLine("Not a Leap Year");
    	}

    }
}

