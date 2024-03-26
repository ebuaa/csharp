﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        public string Name { get; set; }

        public void Moove()
        {
            Console.WriteLine($"{Name} is mooving\n");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping zzZzZZZZZzzZZzZZ\n");

        }

        public Animal(string newName)
        {
            this.Name = newName;
        }
        
        public Animal()
        {

        }
    }
}
