using System;

class Library
{
	static void Main()
	{
		Book b1 = new Book("Brave New World", "Aldous Huxley");
		Book b2 = new Book("War of the Worlds", "HG Wells");
		
		Book.title = "Brave New World";

		Console.Clear();
		b1.Print();
		b2.Print();
	}


}