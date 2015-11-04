using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy
{
    class BussinessLayer
    {
        public void CreateUser(UserBase userBase, string login, string password)
        {
            if (userBase.FileCheck())
            {
                userBase.Deserialize();
            }
            for (int i=0; i < 1000; i++)
            {
                if (userBase.Users[i] == null)
                {
                    userBase.Users[i] = new User(login, password);
                    break;
                }
            }

            userBase.Serialize();
        }

        public bool Enter(UserBase userBase, string login, string password)
        {
            if (userBase.FileCheck())
            {
                userBase.Deserialize();
            }

            for (int i = 0; i < 100; i++)
            {
                if (userBase.Users[i]==null)
                    break;
                if (userBase.Users[i].Login == login && userBase.Users[i].Password == password)
                    return true;

            }
            throw new Exception("Не удалось выполнить вход");
        }
    }
}
