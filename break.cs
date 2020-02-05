using System;
using System.Net;
 
public class BreakStatement
{
    static public void Main () 
    {
        string word;
        string url;
        Console.WriteLine("Search Word:");
        word = Console.ReadLine();
        Console.WriteLine("URL");
        url = Console.ReadLine();

        WebClient wc = new WebClient();
        
        string webText = wc.DownloadString(url);

        string[] words = webText.Split(' ');
        foreach(string w in words)
        {
            if(w.ToUpper() == word.ToUpper())
            {
                Console.WriteLine("{0} found.", word);
                break;
            }
        }
    

    }
}