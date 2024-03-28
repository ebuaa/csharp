using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals1
{
    public class Eagle : Bird
    {
        public Eagle(string Name, string Rarity)
        {
            this.Name = Name;
            this.Rarity = Rarity;
        }

        public Eagle(string Name)
        {
            this.Name = Name;
        }

        public override void Fly()
        {
            Console.WriteLine(this.Name + " Fly comme un Eagle");
        }
    }
}
