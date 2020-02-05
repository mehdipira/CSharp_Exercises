using System;
using System.IO;

class FileTotal
{
	static void Main()
	{
		if(!File.Exists("prices.txt")) return;

		float total = 0;
		foreach(string p in File.ReadLines("prices.txt"))
		{
			float price;
			if(float.TryParse(p, out price))
			{
				total += price;
			}
		}
		Console.Clear();
		Console.WriteLine("Total of values in file is: " + total);
	}
}