using System;

namespace CSharp_Basics
{
    class Spaceship : Vehicle
    {
        //example of the operators example req
        public int a = 10, b = 3;
        private int sum, difference, product, quotient, remainder;
        // Fields for spaceship that inherit Vehicle
        public int SpaceshipID { get; set; }
        public double FuelRange { get; set; }
        public char SpaceshipClass { get; set; }
        public bool IsOperational { get; set; }
        public string SpaceshipName { get; set; }

        // Constructor to initialize spaceship properties
        public Spaceship(int id, double fuel, char shipClass, bool operational, string name)
        {
            // Constructor fields for the spaceship
            SpaceshipID = id;
            FuelRange = fuel;
            SpaceshipClass = shipClass;
            IsOperational = operational;
            SpaceshipName = name;

            // Initialization inside a constructor example doesnt do anything with spaceships
            // example of operators
            sum = a + b;           // 13
            difference = a - b;    // 7
            product = a * b;       // 30
            quotient = a / b;      // 3
            remainder = a % b;     // 1
        }

        //member functions
        public virtual void firePlasmaCanons()
        {
            //base spaceship gun function. all child classes will have guns
            Console.WriteLine("Firing plasma cannons: generic spaceship pew pew pew!");
        }
    }
}