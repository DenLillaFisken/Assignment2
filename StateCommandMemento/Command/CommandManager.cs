using Assignment2.StateCommandMemento.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    public class CommandManager
    {
        public MachineClass Printer { get; set; }
        public CommandManager(MachineClass printer)
        {
            Printer = printer;
        }

        public void Execute(string userInput) 
        {
            var newCommand = new MachineCommand(Printer, userInput);

            //Om maskinen är avstängd, skicka meddelande till kö
            if (Printer.MachineState is MachineOffState)
            {
                Printer.Queue.Add(newCommand);
                Console.WriteLine("\nPrinter is off. Adding to queue.");
            }
            //Anssars skriv ut meddelandet direkts
            else
            {
                newCommand.Execute();
            }
        }
    }
}
