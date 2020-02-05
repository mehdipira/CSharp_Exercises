using System;
 
public class Hangman
{
    static public void Main () 
    {
        Console.Clear();
        PrintHangman(10);
    }

    static void PrintHangman(int wrongTimes)
    {
        if(wrongTimes > 3)
            Console.WriteLine("__________ ");
        if(wrongTimes > 4)
            Console.WriteLine(" |/      | ");
        else if(wrongTimes > 2)
            Console.WriteLine(" |/      ");
        
        if(wrongTimes > 8)
        {
            Console.WriteLine(" |      (_) ");
            Console.WriteLine(" |      \\|/ ");
            Console.WriteLine(" |       |  ");
            Console.WriteLine(" |      / \\ ");
        }
        else if(wrongTimes > 7)
        {
            Console.WriteLine(" |      (_) ");
            Console.WriteLine(" |      \\|/ ");
            Console.WriteLine(" |       |  ");
            Console.WriteLine(" | ");
        }
        else if(wrongTimes > 6)
        {
            Console.WriteLine(" |      (_) ");
            Console.WriteLine(" |      \\|/ ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
        }
        else if(wrongTimes > 5)
        {
            Console.WriteLine(" |      (_) ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
        }
        else if(wrongTimes > 1)
        {
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
        }
        if(wrongTimes > 0)
            Console.WriteLine("_|___");
    }
}