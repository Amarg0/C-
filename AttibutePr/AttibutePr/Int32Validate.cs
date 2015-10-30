using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;

namespace AttibutePr
{
    static class Int32Validate
    {
        public static void Validate(Object obj)
        {
            //ExampleClass exc = (ExampleClass)obj;
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(int);

            foreach (System.Attribute attr in attrs)
            {
                Console.WriteLine("Вошёл");
                if (attr is ValidateInt32Attribute)
                {
                    ValidateInt32Attribute vi = (ValidateInt32Attribute)attr;
                    Console.WriteLine("{0} - {1} - {2}",vi.MaxValue, vi.MinValue, vi.ZeroEnabled);

                }
            }
        }
    }
}
