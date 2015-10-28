using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdtry
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            Start start = new Start();
            start.Starter(database);
        }
    }
}
