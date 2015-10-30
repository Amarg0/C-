using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributePr
{
    class ValidateInt32Attribute
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int ZeroEnabled { get; set; }
    }
}
