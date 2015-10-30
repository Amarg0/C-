using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttibutePr
{
    public class ExampleClass
    {
        [ValidateInt32(10, 2, true)]
        public Int32 Test1 {get;set;}

        [ValidateInt32(10, 2, true)]
        public Int32 Test2;

        public ExampleClass(int test1, int test2)
        {
            Test1 = test1;
            Test2 = test2;
        }
    }
}
