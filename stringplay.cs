using System;

class StringPlay
{
	static void Main()
	{
		string word1 = "elephant";
		string word2 = "elephant";

		word1 = word1.ToUpper();
		word2 = word2.ToUpper();

		Console.Clear();
		if(String.Compare(word1,word2) == 0)
		{
			Console.WriteLine("Words are the same.");
		}
		else
		{
			Console.WriteLine("Words are different.");
		}
	}
}