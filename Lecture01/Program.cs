using System;

namespace Lecture01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsLeapYear(int year){
            bool leapyear = false;
            if(year%4 == 0 && year%100 != 0){
                leapyear = true;
            }
            if(year%400 == 0){
                leapyear = true;
            }
            Console.WriteLine(leapyear);
            return leapyear;
        }
    }
}
