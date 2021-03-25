using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {

        public string FamilyName { get; set; }
        public double WingSpan { get; set; }

        public double NestSize { get; set; }

        public double EggSize { get; set; }
        
        public Bird()
        {

        }

        public Bird(string familyName, double wingSpan, double nestSize, double eggSize, string basicColor, int legs, int age, string livingEnvironment)
        {
            FamilyName = familyName;
            WingSpan = wingSpan;
            NestSize = nestSize;
            EggSize = eggSize;
            BasicColor = basicColor;
            LivingEnvironment = livingEnvironment;
            Legs = legs;
            Age = age;
        }

    }
}
