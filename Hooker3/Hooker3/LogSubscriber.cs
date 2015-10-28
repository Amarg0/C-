using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hooker3
{
    class LogSubscriber
    {
        public static void AnyOn(ConsoleKeyInfo cki)
        {
            Console.WriteLine("Нажата клавиша " + cki.Key);
            string file_adress = "c:\\Users\\Amargo\\Desktop\\Log.txt";
            FileStream logfile = new FileStream(file_adress, FileMode.Create);
            StreamWriter writer = new StreamWriter(logfile);
            writer.Write("Была нажата клавиша: "+cki.Key);
            writer.Close();
        }
    }
}
