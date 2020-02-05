using System;
 
public class ConcatenateStrings
{
    static public void Main () 
    {
    	string string1 = "Hello ";
    	string string2 = "There";

    	Console.WriteLine(string.Concat(string1,string2));
    }
}