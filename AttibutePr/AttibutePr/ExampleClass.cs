using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttibutePr
{
    class ExampleClass
    {
        [ValidateInt32(10,2,true)]
        public int Test1;

        [ValidateInt32(20,0,false)]
        public int Test2;

        public string Test3;

    }
}
