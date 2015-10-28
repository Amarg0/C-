using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace thirdtry
{
    public class toy
    {
        public int Key { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Censure { get; set; }

        public toy()
        { }

        public toy(string name = null, int price = 0, int censure=0, int key = 0)
        {
            Name = name;
            Price = price;
            Censure = censure;
            Key = key;
        }
    }
}
