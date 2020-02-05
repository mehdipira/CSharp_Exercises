using System;
 
public class SimpleCalculator
{
    static public void Main () 
    {
    	float number1;
    	float number2;
    	int op;

    	Console.Clear();
    	Console.WriteLine("Enter Number 1");
    	number1 = Convert.ToSingle(Console.ReadLine());
    	Console.WriteLine("Enter Number 2");
    	number2 = Convert.ToSingle(Console.ReadLine());
    	Console.WriteLine("Enter Operator");
    	op = Convert.ToInt32(Console.ReadLine());

    	switch(op)
    	{
    		case 1:
    			Console.WriteLine("{0}", number1*number2);
    			break;
    		case 2:
    			Console.WriteLine("{0}", number1/number2);
    			break;
    		case 3:
    			Console.WriteLine("{0}", number1+number2);
    			break;
    		case 4:
    			Console.WriteLine("{0}", number1-number2);
    			break;
    		default:
    		    Console.WriteLine("Cannot do calculation");
    		    break;
    	}


    }
}