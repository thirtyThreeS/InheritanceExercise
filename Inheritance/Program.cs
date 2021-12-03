using System;

namespace Inheritance
{
    class Animal
    {
        public int armsAndLegs { get; set; }
        public int tailLength { get; set; }
        public string color { get; set; }
        public int speedMPH { get; set; }
    }

    class Bird : Animal
    {
        public string type { get; set; }
        public string from { get; set; }
        public string eats { get; set; }
        public int sizeInches { get; set; }

    }

    class Reptile : Animal
    {
        public int sizeFeet { get; set; }
        public string habitat { get; set; }
        public bool albino { get; set; }
        public string type { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird = new Bird();
            bird.armsAndLegs = 2;
            bird.tailLength = 2;
            bird.color = "red";
            bird.speedMPH = 25;
            bird.type = "Northern Cardinal";
            bird.from = "Eastern USA and Mexico";
            bird.sizeInches = 9;
            bird.eats = "seeds";

            Console.WriteLine($"The {bird.type} lives mostly within the {bird.from}. Its main diet are {bird.eats} and it grows " +
                $"to be about {bird.sizeInches} inches. With its beautiful color of {bird.color} it can reach up to about {bird.speedMPH} mph.." +
                $" more characteristics of this bird include {bird.armsAndLegs} legs and {bird.armsAndLegs} wings with about" +
                $" a {bird.tailLength} inch tail.");

            Console.ReadLine();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile reptile = new Reptile();
            reptile.type = "Alligator";
            reptile.color = "white";
            reptile.habitat = "Florida Zoo";
            reptile.sizeFeet = 10;
            reptile.tailLength = 8;
            reptile.armsAndLegs = 4;
            reptile.speedMPH = 35;
            reptile.albino = true;

            Console.WriteLine($"At the {reptile.habitat} there is a {reptile.albino} {reptile.color} {reptile.type} that " +
                $"is about {reptile.sizeFeet} feet in size with a huge {reptile.tailLength} foot tail! This beast " +
                $"has a massive {reptile.armsAndLegs} legs and can reach speeds of up to {reptile.speedMPH} mph! Don't" +
                $" get caught in front of this guy!");

            Console.ReadLine();

        }
    }
}
