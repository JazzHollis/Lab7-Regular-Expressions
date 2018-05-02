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

            Console.WriteLine("Please enter a valid Name:");
            string nameInput = Console.ReadLine();
            ValidateNames(nameInput);

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

            if (Regex.IsMatch(nameInput, @"^[A-Z][a-zA-Z\\s]+$" ))
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


            if (Regex.IsMatch(emailInput, @"^[A-Za-z0-9._%+-]{5,30}@[a-zA-Z0-9.-]{2,15}\.[a-zA-Z]{2,}$"))
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


            {
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


            {
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










