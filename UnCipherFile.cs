using System;
using System.IO;
 
public class UnFileCipher
{
    static public void Main () 
    {
        string filename;
        string plaintext;
        Console.Clear();
        Console.Write("Enter the filename:");
        filename = Console.ReadLine();
        plaintext = File.ReadAllText(filename);

        string filetext = "";

        foreach(char c in plaintext)
        {
            if(!char.IsLetter(c))
            {
                filetext += c;
            }
            else
            {
                char letter = c;
                if(letter >= 'A' && letter <= 'C') 
                {
                    letter = (char)(letter+26);
                }
                else if(letter >= 'a' && letter <= 'c') 
                {
                    letter = (char)(letter+26);
                }

                filetext += (char)(letter-3);
            }
        }
        Console.Write("\n");
        File.WriteAllText(filename + "un", filetext);
    }
}