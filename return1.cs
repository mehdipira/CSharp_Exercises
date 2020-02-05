using System;
 
public class PasswordChecker
{
    static public void Main () 
    {
    	string password;
        Console.Clear();
        Console.Write("Enter password: ");
        password = Console.ReadLine();
        CheckPassword(password);
    }

    void CheckPassword(string pwd)
    {
        foreach(char c in pwd)
        {
            if(p < 'A' && p > 'Z')
            {
                Console.WriteLine("Invalid Character {0}",c);
            }
        }

    }
}

