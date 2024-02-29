namespace CSharp_Basics
{
    partial class Interstellar(int id, double fuel, char shipClass, bool operational, string name) 
        : Spaceship(id, fuel, shipClass, operational, name)
    {
        //class functions
        public
        //over loaded gun function is unique to this class with override
        override void firePlasmaCanons() => Console.WriteLine("Firing plasma cannons: fire long range plasma canons pew pew pew!");
    }
}