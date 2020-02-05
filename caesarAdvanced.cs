using System;
 
public class CaesarCipherAdvanced
{
    static public void Main () 
    {
        string plaintext;
        int shift;
        Console.Clear();
        Console.WriteLine("How many letters would you like to shift by?");
        shift = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your text:");
        plaintext = Console.ReadLine();

        foreach(char c in plaintext)
        {
            if(c == ' ')
            {
                Console.Write(" ");
            }
            else
            {
                char letter = c;
                if(letter >= ('Z'-shift) && letter <= 'Z') 
                {
                    letter = (char)(letter-26);
                }
                else if(letter >= ('z'-shift) && letter <= 'z') 
                {
                    letter = (char)(letter-26);
                }

                Console.Write("{0}",(char)(letter+shift));
            }
        }
        Console.Write("\n");
    }
}