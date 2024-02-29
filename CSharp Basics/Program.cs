namespace CSharp_Basics
{
    using System;

    class Program
    {

        static void Main()
        {

            try
            {
                
                // Example usage of the Spaceship classes with potential error
                ShortRange shortRangeSpaceship = new ShortRange(1, 100.0, 'S', true, "StarGazer S-395");
                Interstellar interstellarSpaceship = new Interstellar(2, 2000.0, 'I', false, "StarFocker I-639");

                // Display information about spaceships
                DisplaySpaceshipInfo(shortRangeSpaceship);
                DisplaySpaceshipInfo(interstellarSpaceship);

                //starfleet company destination landing ports 
                List<string> starPorts = new List<string>();

                starPorts.Add("Falcon 8");
                starPorts.Add("Xlorpine 66");
                starPorts.Add("AllianceBase-AC5");

                Console.WriteLine($"Number of Starports: {starPorts.Count}");

                Console.WriteLine("List of Starports:");
                foreach (string starPort in starPorts)
                {
                    Console.WriteLine(starPort);
                }

                Console.WriteLine();

                shortRangeSpaceship.firePlasmaCanons();
                Console.WriteLine();
                interstellarSpaceship.firePlasmaCanons();
                Console.WriteLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        static void DisplaySpaceshipInfo(Spaceship spaceship)
        {
            Console.WriteLine($"Spaceship ID: {spaceship.SpaceshipID}");
            Console.WriteLine($"Fuel Range: {spaceship.FuelRange}");
            Console.WriteLine($"Spaceship Class: {spaceship.SpaceshipClass}");
            Console.WriteLine($"Is Operational: {spaceship.IsOperational}");
            Console.WriteLine($"Spaceship Name: {spaceship.SpaceshipName}");
            Console.WriteLine();
        }

        abstract class Vehicle
        {
            // Abstract class for vehicle
            public bool hasEngine { get; set; }
            
        }

        class Interstellar(int id, double fuel, char shipClass, bool operational, string name) : Spaceship(id, fuel, shipClass, operational, name)
        {
            //class functions
            public
            //over loaded gun function is unique to this class with override
            override void firePlasmaCanons() => Console.WriteLine("Firing plasma cannons: fire long range plasma canons pew pew pew!");
        }
    }
}