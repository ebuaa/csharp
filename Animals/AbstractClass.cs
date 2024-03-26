using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;

namespace AbstractClass
{
    abstract class Animals
    {
        public abstract void Sleeping();
    }

    class Dog : Animals
    {
        public override void Sleeping()
        {
            Console.WriteLine("Dinosaure is sleeping");
        }
    }
}
