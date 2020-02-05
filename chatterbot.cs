using System;
using System.Collections.Generic;
using System.IO;

public class ChatBot
{
	static Dictionary<string,List<string>> kb;
    static Dictionary<string,List<string>> tp;
    static string[] randomFacts;
    static void Main () 
    {
    	string input = "";
        randomFacts = File.ReadAllLines("randomfacts.txt");
        LoadKnowledgeFiles(out kb, "knowledge.txt");
        LoadKnowledgeFiles(out tp, "transpos.txt");

        Console.Clear();
        Console.WriteLine("Hello I am Eliza.");
    	while(input.ToLower() != "bye")
    	{
    		input = Console.ReadLine().ToLower();
            Console.WriteLine("Eliza > " + CalculateResponse(input));
        }
    }

    static string CalculateResponse(string input)
    {
        Random r = new Random();
        int chance = r.Next(0,100);
 
        if(chance < 10)
        {
            Random rand = new Random();
            return("Did you know " + randomFacts[rand.Next(0,randomFacts.Length)] + "?");
        }

        List<string> responses = new List<string>();
        
        if(chance < 40)
        {
            string[] words = input.Split(' ');
            string response = "";

            bool transposed = false;
            foreach(string w in words)
            {
                if(tp.TryGetValue(w, out responses))
                {
                    Random rand = new Random();
                    response += responses[rand.Next(0, responses.Count)] + " ";
                    transposed = true;
                }
                else
                {
                    response += w + " ";
                }
            }
            if(transposed) return(response);
        }

        if(kb.TryGetValue(input, out responses))
        {
            Random rand = new Random();
            return(responses[rand.Next(0, responses.Count)]);
        }
        
        return("I'm sorry. I don't understand.");
    }

    static void LoadKnowledgeFiles(out Dictionary<string,List<string>> d, string filename)
    {
        d = new Dictionary<string,List<string>>();
        string[] lines = File.ReadAllLines(filename);
        foreach(string line in lines)
        {
            string[] rule = line.Split('|');
            List<string> responses = new List<string>();
            string key = rule[0].ToLower();
            if(d.TryGetValue(key, out responses))
            {
                responses = d[key];
                responses.Add(rule[1]);
                d[rule[0]] = responses;
            }
            else
            {
                responses = new List<string>();
                responses.Add(rule[1]);
                d.Add(key,responses);
            }
        }
    }

}