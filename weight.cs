using System;
 
public class WeightCalc
{
    static public void Main () 
    {
    	float kgs;
    	float bmi;

    	Console.Clear();
		Console.WriteLine("What is your weight?");
		kgs = Convert.ToSingle(Console.ReadLine());
		Console.WriteLine("What is your bmi?");
		bmi = Convert.ToSingle(Console.ReadLine());

		if(kgs > 92 && bmi > 30)
		{
			Console.WriteLine("Obese");
		}
		else if(kgs < 56 && bmi < 18.5)
		{
			Console.WriteLine("Underweight");
		}

    }
}

