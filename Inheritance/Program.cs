using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal                                              done
            // give this class 4 members that all Animals have in common          done


            // Create a class Bird                                                done
            // give this class 4 members that are specific to Bird                done
            // Set this class to inherit from your Animal Class                   done

            // Create a class Reptile                                             done
            // give this class 4 members that are specific to Reptile             done
            // Set this class to inherit from your Animal Class                   done




            /*Create an object of your Bird class                                   
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird phoenix = new Bird()
            {
                FamilyName = "Phoenix",
                BasicColor = "brown and burnt orange",
                LivingEnvironment = "aerial",
                WingSpan = 11.50,
                NestSize = 20.40,
                EggSize = 2,
                Legs = 2,
                Age = 350,
            };

            Console.WriteLine($"Welcome to Jadeia where we have the {phoenix.Age} year old {phoenix.FamilyName}.  The {phoenix.FamilyName} is most commonly {phoenix.BasicColor} " +
                $"and is considered an {phoenix.LivingEnvironment} bird. These creatures have a huge wingspan of {phoenix.WingSpan} feet long.  If they ever need to land they use " +
                $"their {phoenix.Legs} legs to gently touch down, but only for brief moments.  These amazing {phoenix.FamilyName} have a nest size of {phoenix.NestSize} feet.  " +
                $"The nests are this size because they usually have three to four eggs that can be as big as {phoenix.EggSize} feet.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile dragon = new Reptile()
            {
                RegionLive = "Western",
                BasicColor = "shades of green",
                LivingEnvironment = "forest",
                Length = 20.5,
                PoisonousStatus = false,
                HideType = "jewel scales",
                Legs = 4,
                Age = 273,
                
            };
            Console.WriteLine($"Our next animal is the formidable {dragon.RegionLive} dragon.  These reptiles can grow to be {dragon.Length} feet from tail to head.  They tend to " +
                $"hide in a {dragon.LivingEnvironment}.  Their {dragon.BasicColor} {dragon.HideType} is best suited for this type of living environment. The particular " +
                $"{dragon.RegionLive} dragon we have is {dragon.Age} years young, many live to be three times that old.  You may ask, is this {dragon.Legs} legged reptile poisonous? " +
                $"The answer is {dragon.PoisonousStatus}.  This type of dragon is not poisonous - but they do breathe fire" );

        }
    } 
}
