using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Happy
{
    internal class UserBase
    {
        public List<Problem> Problems = new List<Problem>();

        public void Serialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof (List<Problem>));
            using (FileStream file = new FileStream("users.xml", FileMode.Create))
            {
                serializer.Serialize(file, Problems);
            }
        }

        public void Deserialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof (List<Problem>));
            using (FileStream fileStream = new FileStream("users.xml", FileMode.OpenOrCreate))
            {
                Problems = (List<Problem>) serializer.Deserialize(fileStream);
            }
        }
    }
}
