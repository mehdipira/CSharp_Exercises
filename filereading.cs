using System;
using System.IO;

class FileTester
{
	static void Main()
	{
		string text = File.ReadAllText("limerick.txt");

		string[] words = text.Split(' ');

		Console.Clear();

		foreach(string w in words)
		{
			Console.WriteLine(w);	
		}

	}
}