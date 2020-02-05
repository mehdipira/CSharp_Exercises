using System;

class CarCollection
{
	static void Main()
	{
		Car c1 = new Car("Ford", "GT", 2015, "red");
		Car c2 = new Car("Honda", "Civic", 2006, "blue");
		Car c3 = new Car("Honda", "Integra", 1998, "black");

		Console.Clear();
		c1.PrintDetails();
		c2.PrintDetails();
		c3.PrintDetails();
	}


}