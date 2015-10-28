using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace thirdtry
{
    class BussinessLayer
    {
        public void Create(Database database, string name, int price, int censure)
        {
            if (database.FileCheck() == true)
                database.Deserialize();
            int i;
            for (i=0;i<100;i++)
                if (database.toys[i]==null)
                {
                    database.toys[i] = new toy();
                    database.toys[i].Name = name;
                    database.toys[i].Price = price;
                    database.toys[i].Censure = censure;
                    database.toys[i].Key = i;
                    break;
                }
            database.Serialize();
        }

        public Database Readall(Database database)
        {
            if (database.FileCheck() == true)
                database.Deserialize();
            return database;
            
        }

        public toy Find (Database database, int key)
        {
            if (database.FileCheck() == true)
                database.Deserialize();
            return database.toys[key];
        }

        public bool delete(Database database, int key, bool fl)
        {
            if (database.FileCheck() == true)
                database.Deserialize();
            for (int i = 0; i < 100; i++)
                if (i == key & database.toys[i]!=null)
                {
                    database.toys[i] = null;
                    fl = true;
                    break;
                }
            database.Serialize();
            return fl;

        }

        public bool Check(Database database, int key, bool fl)
        {
            if (database.FileCheck() == true)
                database.Deserialize();
            for (int i = 0; i < 100; i++)
                if (i == key &&  database.toys[i]!=null)
                {
                    fl = true;
                    break;
                }
            return fl;
        }

        public void Change(Database database, int key, string name, int price, int censure)
        {
            if (database.FileCheck() == true)
                database.Deserialize();
            database.toys[key].Name = name;
            database.toys[key].Price = price;
            database.toys[key].Censure = censure;
            database.Serialize();

        }

        public Database choose(Database database, int price, int censure)
        {
            if (database.FileCheck() == true)
                database.Deserialize();
            for (int i = 0; i < 100; i++)
                if (database.toys[i]!=null)
                    if (database.toys[i].Price > price)
                        database.toys[i] = null;
            return database;
        }
    }
}
