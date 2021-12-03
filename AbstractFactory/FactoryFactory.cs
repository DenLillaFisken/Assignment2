using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    internal class FactoryFactory
    {
        public FactoryFactory()
        {

        }

        internal IFactory GetFactory(string typeOfFactory)
        {
            if (typeOfFactory == "dog")
            {
                return new DogFactory();
            }
            else if (typeOfFactory == "cat")
            {
                return new CatFactory();
            }
            return null;
        }
    }
}
