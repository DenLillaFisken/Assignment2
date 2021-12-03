using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på en sträng parameter
        
        public void Run()
        {
            var factoryFactory = new FactoryFactory();
            string typeOfAnimal = "dog";
            var animalFactory = factoryFactory.GetFactory(typeOfAnimal);

            if (typeOfAnimal == "dog")
            {
                var hund = animalFactory.CreateAnimal("Bruno");
                Console.WriteLine("Hundens namn är " + hund.Name);
                Console.WriteLine("Favoritleksak: " + hund.FavoriteToy);
            }
            else if(typeOfAnimal == "cat")
            {
                var cat = animalFactory.CreateAnimal("Misse");
                Console.WriteLine("Kattens namn är " + cat.Name);
                Console.WriteLine("Favoritleksak: " + cat.FavoriteToy);
            }
            else
            {
                Console.WriteLine("That is not a valid type of animal");
            }
        }
    }
}
