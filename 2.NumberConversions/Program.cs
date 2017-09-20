using System;

namespace _2.NumberConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int numValue = 0;
            Console.WriteLine("enter a number between -2,17,483,684 to +2,147,483,647");
            string input = Console.ReadLine();
            try
            {
                numValue = Convert.ToInt32(input);
            }catch(FormatException e)
            {
                Console.WriteLine("INPUT STRING IS NOT A SEQUENCE OF DIGITS"
                    + e.Message);
            }catch(OverflowException e)
            {
                Console.WriteLine("THE NUMBER CANNOT FIT IN INT32 " +
                    e.Message);
            }
            finally
            {
                Console.WriteLine("num value {0} ", numValue);
                if(numValue < Int32.MaxValue)
                {
                    Console.WriteLine("your new value is {0}", numValue + 1);
                }
                else
                {
                    Console.WriteLine("numVal cannot be incremented beyond its current value");
                }
            }
            Console.Read();
     
        }
    }
}
