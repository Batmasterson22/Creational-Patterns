//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This class is used to write all the FoodItemData objects for
// a specific category (i.e. breakfast, dinner, lunch...) to a plain text file

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ThePlainTextWriter
    {
        public StreamWriter WriteThePlainText(List<FoodItemData> theFood, StreamWriter writer, string menuType)
        {
            string currency = "";

            //Loops through each object in the FoodItemData list
            foreach (var food in theFood)
            {
                if (food.category.Equals(menuType))
                {
                    //This conditional statement is used to set the curreny output by the country
                    if (food.country.Equals("GB"))
                        currency = "GBP";
                    else
                        currency = "$";

                    //This conditional statement is used output the only the FoodItems from the 
                    //passed food category
                    writer.WriteLine("{0}{1}{2:N2}", food.name.PadRight(70), currency, food.price);
                    writer.WriteLine("{0}\n", food.description);

                }

            }

            return writer;
        }

    }
}
