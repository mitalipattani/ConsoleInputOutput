using System;

namespace _1.FormattedOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            double someVar = 1.234; // 01.234000
            Console.WriteLine("{0:00.000000}", someVar);
            float pi = 3.14519206f; // 3.15 :F4 F means Fixed upto 4 digit
            Console.WriteLine("{0:F3}", pi);
            //Hexadecimal : X
            Console.WriteLine("{0:X}", 250);
            //string formatting with left align or right align
            double colaPrice = 1.2034;
            string cola = "Coca cola";
            double fantaPrice = 1.203;
            string fanta = "FANTA DIZZY";
            double pepsiPrice = 1.502;
            string pepsi = "PEPSI";

            Console.WriteLine("-------------------");
            //-sign means left align + means right aligned
            //number like 15 means total space is 15
            Console.WriteLine("{0,-15} | {1,15:F2}", cola, colaPrice);
            Console.WriteLine("{0,-15} | {1,10:F2}", fanta, fantaPrice);
            Console.Read();

        }
    }
}
