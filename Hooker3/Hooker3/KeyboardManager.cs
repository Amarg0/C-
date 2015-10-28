using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hooker3
{
    public class KeyboardManager
    {
        public event FiveHandler FivePressed;
        public event ThreeHandler ThreePressed;
        public event DigitHandler DigitPressed;
        public event AnyHandler AnyPressed;

        public void OnFive()
        {
            if (FivePressed != null)
                FivePressed();
        }

        public void OnThree()
        {
            if (ThreePressed != null)
                FivePressed();
        }

        public void OnDigit()
        {
            if (DigitPressed!= null)
                DigitPressed();
        }

        public void OnAny(ConsoleKeyInfo cki)
        {
            if (AnyPressed != null)
                AnyPressed(cki);
        }
        

    }
}
