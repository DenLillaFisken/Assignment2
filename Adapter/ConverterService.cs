using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class ConverterService : IConverterService
    {
        public ReturningStrings ReturningStrings { get; set; }
        public PrintingInts PrintingInts { get; set; }

        public ConverterService()
        {
            ReturningStrings = new ReturningStrings();
            PrintingInts = new PrintingInts();
        }

        public int ConvertStringToInt()
        {
            //Använder ReturningStrings-modellen, hämtar ut stringen
            string value = ReturningStrings.ReturnString();
            //Konverterar stringen till en int
            int intValue = Convert.ToInt32(value);
            //returnerar det nya int-värdet
            return intValue;
        }

        public void Print()
        {
            //Skrickar in det konverterade stringvärdet till den befintliga metoden i PrintingInts
            PrintingInts.Print(ConvertStringToInt());
        }
    }
}
