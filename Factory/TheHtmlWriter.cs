//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Assignment: Project 01 - Factory Method and Abstract Factory
//Description: This class is used to write the food items to HTML in the required format

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class TheHtmlWriter
    {
        public StreamWriter WriteTheHtml(List<FoodItemData> theFood, StreamWriter writer, string menuType)
        {
            string currency = "";

            writer.WriteLine("\t<UL>");

            //Loops through each object in the FoodItemData list
            foreach (var food in theFood)
            {
                //This conditional statement is used to set the curreny output by the country
                if (food.country.Equals("GB"))
                    currency = "GBP";
                else
                    currency = "$";

                //This conditional statement is used output the only the FoodItems from the 
                //passed food category
                if (food.category.Equals(menuType))
                {
                    writer.WriteLine("\t\t<LI>");
                    writer.WriteLine("\t\t\t" + food.name.ToString() + "<BR>");
                    writer.WriteLine("\t\t\t<I>" + food.description.ToString() + "</I>");
                    writer.WriteLine("\t\t\t<BR>{0}{1:N2}", currency, food.price);
                    writer.WriteLine("\t\t</LI>");

                }

            }

            writer.WriteLine("\t</UL>");

            return writer;
        }


    }
}
