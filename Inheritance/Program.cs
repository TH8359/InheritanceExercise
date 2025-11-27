using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal [COMPLETE]
            // give this class 4 members that all Animals have in common [COMPLETE]


            // Create a class Bird [COMPLETE]
            // give this class 4 members that are specific to Bird [COMPLETE]
            // Set this class to inherit from your Animal Class [COMPLETE]

            // Create a class Reptile [COMPLETE]
            // give this class 4 members that are specific to Reptile [COMPLETE]
            // Set this class to inherit from your Animal Class [COMPLETE]




            /*Create an object of your Bird class [COMPLETE]
             *  give values to your members using the object of your Bird class [COMPLETE]
             *  
             * Creatively display the class member values [COMPLETE]
             */

            Bird baldEagle = new Bird();

            baldEagle.ApproximateLifespanInYears = 30;
            baldEagle.ApproximateAverageWeightInPounds = 14;
            baldEagle.Habitat = "Rivers";
            baldEagle.Sustenance = "Fish";
            baldEagle.TypeOfBird = "Bald Eagle";
            baldEagle.WingspanInFeet = 7.7;
            baldEagle.DaysForEggToHatch = 35;
            baldEagle.ColorationOfBird = "Black, White, Yellow";
            
            Console.WriteLine("BIRD INFO:");
            Console.WriteLine($"Name: {baldEagle.TypeOfBird}");
            Console.WriteLine($"Lifespan: {baldEagle.ApproximateLifespanInYears} Years");
            Console.WriteLine($"Average Weight: {baldEagle.ApproximateAverageWeightInPounds} Pounds");
            Console.WriteLine($"Habitat: {baldEagle.Habitat}");
            Console.WriteLine($"Sustenance: {baldEagle.Sustenance}");
            Console.WriteLine($"Wingspan: {baldEagle.WingspanInFeet} Feet");
            Console.WriteLine($"Hatch Time: {baldEagle.DaysForEggToHatch} Days");
            Console.WriteLine($"Coloration: {baldEagle.ColorationOfBird}");

            /*Create an object of your Reptile class [COMPLETE]
             *  give values to your members using the object of your Reptile class [COMPLETE]
             *
             * Creatively display the class member values [COMPLETE]
             */
            
            Reptile beardedDragon = new Reptile();
            
            beardedDragon.TypeOfReptile = "Bearded Dragon";
            beardedDragon.VenomousOrNot = "Venomous";
            beardedDragon.ColorationOfReptile = "Brown, Red, White, Orange, Black";
            beardedDragon.DaysBetweenSkinShedding = 90;
            beardedDragon.ApproximateLifespanInYears = 15;
            beardedDragon.ApproximateAverageWeightInPounds = 1.5;
            beardedDragon.Habitat = "Desert";
            beardedDragon.Sustenance = "Insects";

            Console.WriteLine("REPTILE INFO:");
            Console.WriteLine($"Name: {beardedDragon.TypeOfReptile}");
            Console.WriteLine($"Venomous?: {beardedDragon.VenomousOrNot}");
            Console.WriteLine($"Coloration: {beardedDragon.ColorationOfReptile}");
            Console.WriteLine($"Shedding Frequency: {beardedDragon.DaysBetweenSkinShedding} Days");
            Console.WriteLine($"Lifespan: {beardedDragon.ApproximateLifespanInYears} Years");
            Console.WriteLine($"Average Weight: {beardedDragon.ApproximateAverageWeightInPounds} Pounds");
            Console.WriteLine($"Habitat: {beardedDragon.Habitat}");
            Console.WriteLine($"Sustenance: {beardedDragon.Sustenance}");
        }
    }
}
