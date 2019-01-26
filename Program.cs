using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassingInformatiom
{
    class Page_3_12_by_30_Calculation_Function
    {
        static void Main(string[] args)
        {
            //Simply passing information to method Feet_To_Inches
            Console.Write("\n{0}",FeetToInches(30));
            Console.Write("\n{0}\n", FeetToInches(100));
        }

        // Recieving a call from the calling method
        // and this method is returing a call
        public static int FeetToInches(int x)
        {
            //declaration
            int feet, recieved, calculation;
            //initializing the decalaration
            feet = 12;
            recieved = x;
            //Calculation of the variables
            calculation = feet * recieved;
            // Returning the calculation to the calling method
            return calculation;
        }
    }
}
