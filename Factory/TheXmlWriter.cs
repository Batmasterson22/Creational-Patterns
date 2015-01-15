//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This class is used to write all the FoodItemData objects for
// a specific category (i.e. breakfast, dinner, lunch...) to a XML file

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Factory
{
    class TheXmlWriter
    {
        public XmlWriter WriteTheXml(List<FoodItemData> theFood, XmlWriter writer, string menuType)
        {
            string currency = "";

            //Loops through each object in the FoodItemData list
            foreach (var food in theFood)
            {
                //This conditional statement is used to set the curreny output by the country
                if (food.country.Equals("GB"))
                    currency = "GBP";
                else
                    currency = "USD";

                //This conditional statement is used output the only the FoodItems from the 
                //passed food category
                if (food.category.Equals(menuType))
                {
                    writer.WriteStartElement("MenuItem");
                    writer.WriteElementString("Name", food.name);
                    writer.WriteStartElement("Price");
                    writer.WriteElementString("CurrencyCode", currency);
                    writer.WriteElementString("Amount", food.price.ToString());
                    writer.WriteEndElement();
                    writer.WriteElementString("Description", food.description);
                    writer.WriteEndElement();

                }

            }

            return writer;
        }
    }
}
