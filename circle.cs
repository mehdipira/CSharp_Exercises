using System;

public class CircleCalcs
{
	static void Main () 
    {
        string input;
        int radius;
        double c;
        double a;

        Console.Clear();
        Console.Write("Enter the radius: ");
        input = Console.ReadLine();  

        if(int.TryParse(input,out radius))
        {
            if(circle(radius, out c, out a))
            {
                Console.WriteLine("A circle with radius {0} has a circumference of {1:0.00} and area of {2:0.000}.", radius, c, a);
            }
            else
            {
                Console.WriteLine("Radius was zero!");
            }
        }
        else
        {
            Console.WriteLine("Incorrect Input");
        }
   
    }

    static bool circle(int radius, out double circumference, out double area) 
    {
        circumference = 0;
        area = 0;
        if(radius == 0) return false;
        circumference = 2 * Math.PI * radius;
        area = Math.PI * Math.Pow(radius,2);
        return true;
    } 
 
}