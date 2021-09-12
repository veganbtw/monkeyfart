using System;

namespace Lecture01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Good day, human! Please write a year and hit 'Enter' in order to check if it is a leap year.");
            try {
                int value = int.Parse(Console.ReadLine());
                if(value < 1582){
                    throw new IndexOutOfRangeException(": There were no leap years before 1582");
                } else {
                    bool key = IsLeapYear(value);
                    if(key){
                        Console.WriteLine("yay");
                    } else if (!key) {
                        Console.WriteLine("nay");
                    }
                }
            } catch (Exception e){
                Console.WriteLine(e+": Input has to be an integer. 'Pancake' is not a year.");
            }
        }

        public static bool IsLeapYear(int year){
            bool LeapYear = false;
            if(year >= 1582){
                if(year%4 == 0 && year%100 != 0){
                    LeapYear = true;
                }
                if(year%400 == 0){
                    LeapYear = true;
                }
            }
        return LeapYear;
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
