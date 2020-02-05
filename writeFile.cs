using System;
using System.IO;

class FileWriting
{
	static void Main()
	{
		string filename = "cars.txt";
		File.Delete(filename);
		CarDetails c1 = new CarDetails("Honda","Civic",2006,"red","345RGT");
		Console.Clear();
		c1.PrintDetails(filename);
	}
}