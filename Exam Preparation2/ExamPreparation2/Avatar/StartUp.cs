using System;
using System.Collections.Generic;
using Avatar.Models;

namespace Avatar
{
    public class StartUp
    {
        static void Main()
        {
            var nationsBuilder = new NationsBuilder();
            
            string inputline = string.Empty;
            while ((inputline = Console.ReadLine()) != "Quit")
            {
                var tokens = inputline.Split(' ');
                var cmd = tokens[0];
                switch (cmd)
                {
                    case "Bender":
                    {
                        var benderArgs = new List<string>();
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            benderArgs.Add(tokens[i]);
                        }
                        nationsBuilder.AssignBender(benderArgs);
                    }
                        break;
                    case "Monument":
                    {
                        var monumentArgs = new List<string>();
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            monumentArgs.Add(tokens[i]);
                        }
                        nationsBuilder.AssignMonument(monumentArgs);
                    }
                        break;
                    case "Status":
                    {
                        var nationsType = tokens[1];
                        Console.WriteLine(nationsBuilder.GetStatus(nationsType));
                    }
                        break;
                    case "War":
                    {
                        var nationsType = tokens[1];
                        nationsBuilder.IssueWar(nationsType);
                    }
                        break;
                }
            }
            Console.WriteLine(nationsBuilder.GetWarsRecord());
        }
    }
}