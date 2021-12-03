using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Machine
{
    public class MachineClass : IMachineState, IMachine
    {
        public IMachineState MachineState { get; set; }
        public List<MachineCommand> Queue { get; set; }

        public MachineClass()
        {
            MachineState = new MachineOffState();
            Queue = new List<MachineCommand>();
        }

        //stänger av eller startar maskinen beroende på vad den har för nuvarande state
        public void PowerSwitch()
        {
            MachineState.PowerSwitch();
            if (MachineState is MachineOffState)
            {
                MachineState = new MachineOnState();
            }
            else
            {
                MachineState = new MachineOffState();
            }
        }
        //skriver ut input
        public void Print(string input)
        {
            Console.WriteLine("\nPrinting:");
            Console.WriteLine($"{input}");
        }

        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this, Queue);
        }
    }
}
