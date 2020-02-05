using System;
using System.IO;

class CarDetails
{
	string make;
	string model;
	int year;
	string colour;
	string rego;

	public CarDetails(string m, string mod, int y, string c, string r)
	{
		make = m;
		model = mod;
		year = y;
		colour = c;
		rego = r;
	}

	public void PrintDetails()
	{
		Console.WriteLine("Make: " + make);
		Console.WriteLine("Model: " + model);
		Console.WriteLine("Year: " + year);
		Console.WriteLine("Colour: " + colour);
		Console.WriteLine("Registration: " + rego);
		Console.WriteLine("=========================");
	}

	public void PrintDetails(string filename)
	{
		File.AppendAllText(filename, "Make: " + make + "\n");
		File.AppendAllText(filename, "Model: " + model + "\n");
		File.AppendAllText(filename, "Year: " + year + "\n");
		File.AppendAllText(filename, "Colour: " + colour + "\n");
		File.AppendAllText(filename, "Registration: " + rego + "\n");
		File.AppendAllText(filename, "=========================\n");
	}

}