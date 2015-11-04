using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttibutePr
{

    class Program
    {
        static void Main(string[] args)
        {
            var exampleClass = new ExampleClass(10,5);

            Int32Validate.Validate(exampleClass);

        }
    }
}
