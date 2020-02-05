using System;

public class Person
{
   string name = "";
   string address = "";
   string phone = "";
   float height = 0;
    
   public Person(string n, string a, string p, float h)
   {
      name = n;
      address = a;
      phone = p;
      height = h;
   }

   public void PrintDetails()
   {
      Console.WriteLine("Name: " + name + "\n" + 
                        "Address: " + address + "\n" + 
                        "Phone: " + phone + "\n" +
                        "Height: " + + height);
   }
}