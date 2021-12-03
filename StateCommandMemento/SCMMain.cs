using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.Machine;
using Assignment2.StateCommandMemento.Memento;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {
            MachineClass printer = new();
            var commandManager = new CommandManager(printer);
            MachineMemento machineMemento = printer.CreateMemento();

            // Draw Menu

            Console.WriteLine("---------------------");
            Console.WriteLine("      Printer    ");
            Console.WriteLine("---------------------");
            Console.WriteLine("A: PowerSwitch");
            Console.WriteLine("B: Enter text to print");
            Console.WriteLine("C: Reset and turn off");
            Console.WriteLine("X: Quit Program\n");

            while (true)
            {
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                        //ändrar staten på maskinen
                        printer.PowerSwitch();
                        //Skriver ut kön som bildats när maskinen varit avslagen
                        foreach (var text in printer.Queue)
                        {
                            commandManager.Execute(text.Input);
                        }
                        //rensar kön efter den skrivit ut allting
                        printer.Queue.Clear();
                        break;

                    case 'b' or 'B':
                        //Ber användaren skriva text som ska printas ut
                        Console.WriteLine("Enter string:");
                        var Userinput = Console.ReadLine();
                        //skickas in i en metod för att skriva ut den eller lägga i kön beroende på om maskinen är av eller på.
                        commandManager.Execute(Userinput);
                        break;

                    case 'c' or 'C':
                        Console.WriteLine("Reset and turn off");
                        //Rensar kön för maskinen och sätter state till off
                        machineMemento.Restore();
                        break;

                    case 'x' or 'X':
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("That is not a valid choice");
                        break;
                }
            }

        }
    }
}