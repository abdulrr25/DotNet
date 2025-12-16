using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Day_Inheritance1
{
    internal class Animals
    {
        public String color;
        public string name;
        public int limbs;
    }

    internal class Cats : Animals
    {
        public int age;
    }

}
