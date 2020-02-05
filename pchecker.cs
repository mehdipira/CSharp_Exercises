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
        Console.WriteLine("Password Checking Completed.");
    }

    static void CheckPassword(string pwd)
    {
        foreach(char p in pwd)
        {
            if(p < 'A' || p > 'Z')
            {
                Console.WriteLine("Invalid Character {0}",p);
            }
        }

    }
}

