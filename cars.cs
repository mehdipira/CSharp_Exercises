using System;

class Car
{
	string make;
	string model;
	int year;
	string colour;

	public Car(string m, string mod, int y, string c)
	{
		make = m;
		model = mod;
		year = y;
		colour = c;
	}

	public void PrintDetails()
	{
		Console.WriteLine("Make: " + make);
		Console.WriteLine("Model: " + model);
		Console.WriteLine("Year: " + year);
		Console.WriteLine("Colour: " + colour);
		Console.WriteLine("=========================");
	}

}