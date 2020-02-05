using System;
 
public class LocalVariables
{
    static int counterValue;
    static public void Main () 
    {
        Console.Clear();
        Counter();

        Console.WriteLine(counterValue);
    }

    static void Counter()
    {
        counterValue = 5;
    }
}

