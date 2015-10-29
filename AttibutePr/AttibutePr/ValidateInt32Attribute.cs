using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttibutePr
{
    [AttributeUsage(AttributeTargets.Field|AttributeTargets.Property,AllowMultiple = true)]
    public sealed class ValidateInt32Attribute:Attribute
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public bool ZeroEnabled { get; set; }

        public ValidateInt32Attribute(int minValue, int maxValue, bool zeroEnabled)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            ZeroEnabled = zeroEnabled;
        }

        public ValidateInt32Attribute() { }



    }
}
