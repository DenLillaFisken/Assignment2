using Assignment2.StateCommandMemento.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    public class MachineCommand : ICommand
    {
        public IMachine Machine { get; set; }
        public string Input { get; set; }
        public MachineCommand(IMachine machine, string input)
        {
            Machine = machine;
            Input = input;
        }
        public void Execute()
        {
            Machine.Print(Input);
        }
    }
}
