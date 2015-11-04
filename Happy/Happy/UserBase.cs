using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Happy
{
    public class UserBase
    {
        //public List<User> Users = new List<User>();
        public User[] Users = new User[1000];

        public void Serialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof (User[]));
            using (FileStream file = new FileStream("users.xml", FileMode.Create))
            {
                serializer.Serialize(file, Users);
            }
        }

        public void Deserialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof (User[]));
            using (FileStream fileStream = new FileStream("users.xml", FileMode.OpenOrCreate))
            {
                Users = (User[]) serializer.Deserialize(fileStream);
            }
        }

        public bool FileCheck()
        {
            return File.Exists("users.xml");
        }
    }
}
