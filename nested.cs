using System;
using System.Threading;
 
public class NestedLoops
{
    static public void Main () 
    {
        for(int j = 0; j <= 2; j++)
        {
            for(int i = 0; i <= 2; i++)
            {
                for(int k = 0; k <= 2; k++)
                {
                    Console.WriteLine("J is {0}, I is {1}, K is {2}", j, i, k);
                }
            }
        }
    }
}