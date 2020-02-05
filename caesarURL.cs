using System;
using System.Net;
 
public class CaesarCipher
{
    static public void Main () 
    {
        Console.Clear();
        Console.WriteLine("Enter the url to encrypt:");
        string url = Console.ReadLine();
        WebClient wc = new WebClient();  
        string plaintext = wc.DownloadString(url);

        foreach(char c in plaintext)
        {
            if(c == ' ')
            {
                Console.Write(" ");
            }
            else
            {
                char letter = c;
                if(letter >= 'V' && letter <= 'Z') 
                {
                    letter = (char)(letter-26);
                }
                else if(letter >= 'v' && letter <= 'z') 
                {
                    letter = (char)(letter-26);
                }

                Console.Write("{0}",(char)(letter+5));
            }
        }
        Console.Write("\n");
    }
}