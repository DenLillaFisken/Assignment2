using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    public class WordFacade
    {

        List<char> one = new();
        List<char> two = new();
        List<char> three = new();
        List<char> four = new();
        List<char> five = new();

        public void SaveWord()
        {
            Console.WriteLine("Enter word with EXACTLY 5 charaters: ");

            string input = Console.ReadLine();
            //om fel input
            if (input.Length != 5)
            {
                Console.WriteLine("Exiting program - Error - The string needs to be EXACTLY 5 characters long");
                Console.ReadKey(true);
            }
            //Sparar ned ordet 
            else
            {
                one.Add(input[0]);
                two.Add(input[1]);
                three.Add(input[2]);
                four.Add(input[3]);
                five.Add(input[4]);
            }            
        }

        public void LoadWord()
        {
            // Load Word
            if (one.Count > 0)
            {
                char[] word = { one.Last(), two.Last(), three.Last(), four.Last(), five.Last() };
                Console.WriteLine(word);
            }
        }

    }
}

