using System;

using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> newplanetList = new List<string>(){"Neptune", "Uranus"};
            planetList.AddRange(newplanetList);
            planetList.Insert(1,"Venus");
            planetList.Insert(2,"Earth");
            planetList.Add("Pluto");
            List<string> rockyPlanets = new List<string>(){};
            rockyPlanets = planetList.GetRange(0,4);
            planetList.Remove("Pluto");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }
            foreach (string rockyplanet in rockyPlanets)
            {
                Console.WriteLine(rockyplanet);
            }
            
        }
    }
}
