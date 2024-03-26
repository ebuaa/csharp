using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Animals1;

namespace Animals1
{
    internal class Chien
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Rarity { get; set; }


        public Chien(string name, int iD, string rarity)
        {
            Name = name;
            ID = iD;
            Rarity = rarity;
        }

        public Chien()
        {
        }
    }
}

