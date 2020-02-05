using System;
 
public class ContinueStatement
{
    static public void Main () 
    {
        string fileContents = Console.In.ReadToEnd();
        Console.Clear();
        
        string[] lines = fileContents.Split('\n');

        foreach(string l in lines)
        {
            if(l.IndexOf("NULL") >= 0 || l == lines[0])
            {
                continue;
            }
            string[] fields = l.Split(',');
            float lat = Convert.ToSingle(fields[2]);
            if(lat > -30 && lat < 30)
            {
                Console.WriteLine("{0}", fields[1]);
            }
        }
    
    }
}