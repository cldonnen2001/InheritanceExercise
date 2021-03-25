using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animal
    {
        public string BasicColor { get; set; }

        public string LivingEnvironment { get; set; }

        public int Legs { get; set; }

        public int Age { get; set; }

        public Animal()
        {

        }

        public Animal(string basicColor, string livingEnvironment, int legs, int age)
        {
            BasicColor = basicColor;
            LivingEnvironment = livingEnvironment;
            Legs = legs;
            Age = age;
        }
    }
       
}
