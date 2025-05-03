using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Switch
    {
        private bool _isOn = false;
        public delegate void Activatoin(bool onOrOff);

        public event Activatoin OnPress;


        public void Press()
        {
            _isOn = !_isOn;
            OnPress.Invoke(_isOn);
        }
    }
}
