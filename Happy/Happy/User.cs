using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Xml.Serialization;

namespace Happy
{
    //[Serializable]
    public class User
    {
        //[System.Xml.Serialization.XmlElementAttribute("Login")]
        public string Login { get; set; }
        //[System.Xml.Serialization.XmlElementAttribute("Password")]
        public string Password { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public User()
        {
            
        }
    }
}
