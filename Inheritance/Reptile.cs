using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {

        public double Length { get; set; }

        public bool PoisonousStatus { get; set; }

        public string RegionLive { get; set; }

        public string HideType { get; set; }

        public Reptile()
        {

        }

        public Reptile(double length, bool poisonousStatus, string regionLive, string hideType, string basicColor, int legs, int age, string livingEnvironment)
        {
            Length = length;
            PoisonousStatus = poisonousStatus;
            RegionLive = regionLive;
            HideType = hideType;
            BasicColor = basicColor;
            LivingEnvironment = livingEnvironment;
            Legs = legs;
            Age = age;
        }
    }
}
