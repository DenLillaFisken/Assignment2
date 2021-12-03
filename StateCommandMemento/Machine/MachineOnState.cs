using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Machine
{
    class MachineOnState : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning Machine Off");
        }
    }
}
