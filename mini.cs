using System;
 
public class CheapestPrice
{
    static public void Main () 
    {
    	float[] breadPrices = {3.45f,3.10f,2.56f,2.05f,3.95f};
        float[] milkPrices = {1.50f,2.50f,1.75f,2.05f,1.25f,2.35f,3.05f};
        float[] eggPrices = {4.50f,3.65f,2.90f,4.10f};

        Console.Clear();
        float minBread = MaxCalc(breadPrices) - MinCalc(breadPrices);

        Console.WriteLine("{0}", minBread);
    }

    static public float MinCalc(float[] numbers)
    {
        float minimum = numbers[0];
        for(int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i] < minimum)
                minimum = numbers[i];
        }
        return minimum;
    }

    static public float MaxCalc(float[] numbers)
    {
        float maximum = numbers[0];
        for(int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i] > maximum)
                maximum = numbers[i];
        }
        return maximum;
    }

}

