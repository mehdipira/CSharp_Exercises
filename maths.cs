using System;
 
public class Maths
{
    static public void Main ()
    {
    	//F=C * 9/5 + 32
        float f;
        float c = 24;
        f = c * 9/5 + 32;
        
        Console.WriteLine ("{1} Celsius is equal to {0} Fahrenheit", f, c);
    }
}