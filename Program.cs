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

            List<string> morePlanetsList = new List<string>(){"Uranus", "Neptune"};

            planetList.AddRange(morePlanetsList);
                    foreach( string planet in planetList )
        {
            Console.WriteLine(planet);
        }

Console.WriteLine();

        planetList.Insert(1, "Venus");
        planetList.Insert(2, "Earth");

                    foreach( string planet in planetList )
        {
            Console.WriteLine(planet);
        }

Console.WriteLine();
        planetList.Add("Pluto");

                    foreach( string planet in planetList )
        {
            Console.WriteLine(planet);
        }
            List<string> rockyPlanets = planetList.GetRange(0, 4);
        
        Console.WriteLine();
        foreach( string rockyPlanet in rockyPlanets)
        {
            Console.WriteLine(rockyPlanet);
        }

        planetList.RemoveAt(8);
        Console.WriteLine();
        foreach( string planet in planetList)
        {
            Console.WriteLine(planet);
        }


        }
    }
}
