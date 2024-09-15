using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        //Creating an enum for the days of the week.
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {

            //Prompting the user to enter the current day of the week.
            
            Console.WriteLine("Enter the current day of the week: ");

            //Capturing the user input.

            string currentDay = Console.ReadLine();

            //Assigning the value to a variable of the enum data type created above and wrapping the above statement
            //in a try/catch block and having it print "Please enter an actual day of the week.” to the console
            //if an error occurs.         

            try
            {
                //Parsing the string value into an Enum.
                //This method directly parses the string representation of the name or numeric value of enum member into
                //enumType object. If the string representation of the name is not found, then it will give the exception.
                
                Enum.Parse(typeof(WeekDays), currentDay);

                Console.WriteLine("Today is: " + currentDay);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week."); //String representation not found.
                Console.ReadLine();
            }
            
            
            




            


            //DaysOfTheWeek day = Console.ReadLine(DaysOfTheWeek.)

            //string input = Console.ReadLine(); //string representation of the enum object as obtained from the user



            ////int day = (int)Enum.Parse(typeof(DaysOfTheWeek), input);

            //Console.ReadLine();
        }
    }    
}
