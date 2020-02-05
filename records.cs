using System;

public class MyContacts
{
	static public void Main () 
    {
    	Person friend = new Person("Jim Wilson","34 Bay Road","1234567",175);
    	Person friend2 = new Person("Bill Todds","15 Mills Crescent","0987654",135);
    	Person friend3 = new Person("Jo Holiday","3/87 Highgate Road","5748374",167);
    	Person friend4 = new Person("Pam Smith","90 Redhill Fields Close","1872634",183);

    	Console.Clear();
    	friend.PrintDetails();
    	friend2.PrintDetails();
    	friend3.PrintDetails();
    	friend4.PrintDetails();
    }
}