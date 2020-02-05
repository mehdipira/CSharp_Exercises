using System;
 
public class PriceAverager
{
    static public void Main () 
    {
    	float[] breadPrices = {3.45f,3.10f,2.56f,2.00f,3.95f};
        float[] milkPrices = {1.50f,2.50f,1.75f,2.05f,1.25f,2.35f,3.05f};
        float[] eggPrices = {4.50f,3.65f,2.90f,4.10f};

        //calculate the minimum bread price
        float minumum = breadPrices[0];
        foreach(int i = 1; i < breadPrices.Length; i++)
        {
            if(breadPrices[i] < minimum)
                minimum = breadPrices[i];
        }
        Console.WriteLine("Lowest price is {0}", minimum);
    }
}

