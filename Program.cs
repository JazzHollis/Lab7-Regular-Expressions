using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompts user to input requested information
            Console.WriteLine("Please enter a valid Name:");
            string nameInput = Console.ReadLine();
            ValidateNames(nameInput);//Calls method and parameters

            Console.WriteLine("Please enter a valid email: ");
            string emailInput = Console.ReadLine();
            ValidateEmail(emailInput);

            Console.WriteLine("Please enter a valid phone number: 313-555-6666");
            string phoneInput = Console.ReadLine();
            ValidatePhone(phoneInput);

            Console.WriteLine("Please enter a valid date:(DD/MM/YYYY)");
            string dateInput = Console.ReadLine();
            ValidateDate(dateInput);

        }

        public static void ValidateNames(string nameInput)
        {
            //Validates that the correct format of name is entered with first letter being capitalized and up to 30 characters
            if (Regex.IsMatch(nameInput, @"^[A-Z][a-zA-Z]{2,30}+$"))
            {
                Console.WriteLine("Your name has been received!");
            }

            else
            {
                Console.WriteLine("Name is not valid! Please try again!");
            }


        }
        
        public static void ValidateEmail(string emailInput)
        {

            //Validates that the correct format of email is entered
            if (Regex.IsMatch(emailInput, @"^[A-Za-z0-9._%+-]{5,30}@[a-zA-Z0-9.-]{5,10}\.[a-zA-Z]{2,}$"))
            {
                Console.WriteLine("Email received!");
            }

            else
            {
                Console.WriteLine("Email is not valid! Please try again.");
            }

        }

        public static void ValidatePhone(string phoneInput)
        {


            {   //Validates that the correct format of phone number is entered
                if (Regex.IsMatch(phoneInput, @"^\d{3}-\d{3}-\d{4}$"))

                {
                    Console.WriteLine("Phone number received!");


                }

                else
                {
                    Console.WriteLine("Sorry, number is not valid! Please try again");
                }

            }
        }
        public static void ValidateDate(string dateInput)
        {


            {   //Validates that the correct date format is entered 
                if (Regex.IsMatch(dateInput, @"^\d{2}/\d{2}/\d{4}$"))
                {
                    Console.WriteLine("Date received! ");
                }

                else
                {
                    Console.WriteLine("Sorry, date entered is not valid! Please try again! ");

                }

            }
                

        }





        
    }

}











