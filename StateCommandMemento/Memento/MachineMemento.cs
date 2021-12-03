using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Memento
{
    public class MachineMemento
    {
        public MachineClass Printer { get; set; }
        public List<MachineCommand> StringList { get; set; }

        public MachineMemento(MachineClass printer, List<MachineCommand> stringlist)
        {
            Printer = printer;
            StringList = stringlist;
        }

        public void Restore()
        {
            //rensar kön och sätter state till av
            Console.WriteLine("Reseting queue and turning off...");
            Printer.Queue.Clear();
            Printer.MachineState = new MachineOffState();

        }
    }
}
