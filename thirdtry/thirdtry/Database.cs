using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace thirdtry
{
    class Database
    {
        public toy[] toys = new toy[100];

        public void Serialize()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(toy[]));
            using (FileStream fs = new FileStream("toys.xml", FileMode.Create))
            {
                formatter.Serialize(fs, toys);
            }
        }

        public void Deserialize()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(toy[]));

            using (FileStream fs = new FileStream("toys.xml", FileMode.OpenOrCreate))
            {
                toys = (toy[])formatter.Deserialize(fs);
            }
        }
        
        public bool FileCheck()
        {
            return File.Exists("toys.xml");
        }
    }
}
