//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Assignment: Project 01 - Factory Method and Abstract Factory
//Description: This class handles the user interface

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class GetUserInput
    {
        public string[] TheUserInput()
        {
            string country = "";
            string restaurant = "";
            string fileType = "";
            string[] toReturn = new string[3];

            while (true)
            {
                Console.WriteLine("Choose a country to generate a menu:");
                Console.WriteLine("Enter G for Great Britain. \nEnter U for United States");
                country = Console.ReadLine().ToUpper();

                if (country.Equals("G") || country.Equals("U"))
                {
                    break;
                }

                Console.WriteLine("Invalid Input! Please try again\n");

            }

            while (true)
            {
                Console.WriteLine("Enter D for the diner menu");
                Console.WriteLine("Enter E for the evening only menu");
                Console.WriteLine("Enter A for the all day menu");
                restaurant = Console.ReadLine().ToUpper();

                if (restaurant.Equals("D") || restaurant.Equals("E") || restaurant.Equals("A"))
                {
                    break;
                }

                Console.WriteLine("Invalid Input! Please try again\n");

            }

            while (true)
            {
                Console.WriteLine("Enter P for Plain Text Menu");
                Console.WriteLine("Enter X for XML Menu");
                Console.WriteLine("Enter H for HTML Menu");
                fileType = Console.ReadLine().ToUpper();

                if (fileType.Equals("P") || fileType.Equals("X") || fileType.Equals("H"))
                {
                    break;
                }

                Console.WriteLine("Invalid Input! Please try again\n");

            }

            toReturn[0] = country;
            toReturn[1] = restaurant;
            toReturn[2] = fileType;

            return toReturn;
        }


    }
}
