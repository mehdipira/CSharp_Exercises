using System;
 
public class TheForLoop
{
    static public void Main () 
    {
    	int total = 0;
    	float numberOfStudents;

    	Console.Clear();
    	Console.WriteLine("Please enter number of students:");
    	numberOfStudents = Convert.ToSingle(Console.ReadLine());
    	Console.WriteLine("Please enter values:");


    	for(int i = 1; i <= numberOfStudents; i++)
    	{
    		Console.WriteLine("Enter value {0}: ", i);
    		total = total + Convert.ToInt32(Console.ReadLine());
    	}

    	float avg = total/numberOfStudents;
    	Console.WriteLine("The Average is {0}.", avg);
    }
}

