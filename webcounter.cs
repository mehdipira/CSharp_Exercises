using System;
using System.Net;

public class WebCounter
{
    static public void Main () 
    {
    	int count = 0;

		WebClient wc = new WebClient();
		string webData = (wc.DownloadString("https://en.wikipedia.org/wiki/Dog").ToUpper());

		string searchWord;
		Console.Write("Enter Search Word: ");
		searchWord = Console.ReadLine().ToUpper();

		string[] words = webData.Split(' ');
		foreach(string w in words)
		{
			if(w.Contains(searchWord))
				count++;
		}

		Console.WriteLine("{0} occurs {1}", searchWord, count);
	}
}