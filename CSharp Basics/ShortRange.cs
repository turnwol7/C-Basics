// ShortRange.cs
using System;
using System.Xml.Linq;

namespace CSharp_Basics
{
        partial class ShortRange(int id, double fuel, char shipClass, bool operational, string name)
            : Spaceship(id, fuel, shipClass, operational, name)
        {
            // Constructor code if needed

            // Overridden method unique to this class
        public override void firePlasmaCanons() => Console.WriteLine("Firing plasma cannons: fire shortrange gatlin guns pew pew pew!");
        }
}