using System;
 
public class ScoreProcessing
{
    static public void Main () 
    {
        int[] scores;

        int numScores;
        Console.WriteLine("How many scores?");
        numScores = Convert.ToInt32(Console.ReadLine());

        scores = new int[numScores];

        foreach(int box in scores)
        {
             box = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Processing Here =========");
        foreach(int box in scores)
        {
            Console.WriteLine("{0}", box/25.0f * 100);
        }

    }
}