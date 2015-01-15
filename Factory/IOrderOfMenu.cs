//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This interface is used to write a HTML file accroding to the 
//restraunt category (i.e. Diner, Evening Only, All Day)

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Factory
{
    interface IOrderOfMenu
    {
        void CreateMenu(List<FoodItemData> theFood);
    }

    //Description: This class is used to write the Diner Menu to a HTML file
    public class DinerHtmlMenu : IOrderOfMenu
    {
        public void CreateMenu(List<FoodItemData> theFood)
        {
            TheHtmlWriter toWrite = new TheHtmlWriter();
            string outPut = "";

            //This conditional statement is used to name the output file
            if (theFood[0].country.Equals("GB"))
                outPut = "GB-Menu-Diner.html";
            else
                outPut = "US-Menu-Diner.html";

            string outputLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outPut);

            StreamWriter writer = new StreamWriter(outPut);

            //The order in which the foods will be written is Breakfast, Snack, Appetizer
            //Lunch, Dessert

            writer.WriteLine("<HTML>");
            writer.WriteLine("<HEAD>\n<TITLE>Menu</TITLE>\n</HEAD>");
            writer.WriteLine("<BODY>");
            writer.WriteLine("\t<CENTER>Menu</CENTER>");

            writer.WriteLine("\t<H1>BREAKFAST</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Breakfast");

            writer.WriteLine("\t<H1>SNACK</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Snack");

            writer.WriteLine("\t<H1>APPETIZER</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Appetizer");

            writer.WriteLine("\t<H1>LUNCH</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Lunch");

            writer.WriteLine("\t<H1>DESSERT</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Dessert");


            writer.WriteLine("</BODY>");
            writer.WriteLine("</HTML>");

            writer.Close();
            Console.WriteLine("The Diner Menu file can be found at:\n{0}", outputLocation);

        }


    }

    //Description: This class is used to write the Evening Only Menu to a HTML file
    public class EveningHtmlMenu : IOrderOfMenu
    {
        public void CreateMenu(List<FoodItemData> theFood)
        {
            TheHtmlWriter toWrite = new TheHtmlWriter();
            string outPut = "";

            //This conditional statement is used to name the output file
            if (theFood[0].country.Equals("GB"))
                outPut = "GB-Menu-Evening.html";
            else
                outPut = "US-Menu-Evening.html";

            string outputLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outPut);

            StreamWriter writer = new StreamWriter(outPut);

            //The order in which the foods will be written is, Appetizer, Dinner
            //Dessert, Side Dish

            writer.WriteLine("<HTML>");
            writer.WriteLine("<HEAD>\n<TITLE>Menu</TITLE>\n</HEAD>");
            writer.WriteLine("<BODY>");
            writer.WriteLine("\t<CENTER>Menu</CENTER>");

            writer.WriteLine("\t<H1>APPETIZER</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Appetizer");

            writer.WriteLine("\t<H1>DINNER</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Dinner");

            writer.WriteLine("\t<H1>DESSERT</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Dessert");

            writer.WriteLine("\t<H1>SIDE_DISH</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Side Dish");

            writer.WriteLine("</BODY>");
            writer.WriteLine("</HTML>");

            writer.Close();

            Console.WriteLine("The Evening Only Menu file can be found at:\n{0}", outputLocation);

        }


    }

    //Description: This class is used to write the All Day Menu to a HTML file
    public class AllDayHtmlMenu : IOrderOfMenu
    {
        public void CreateMenu(List<FoodItemData> theFood)
        {
            TheHtmlWriter toWrite = new TheHtmlWriter();
            string outPut = "";

            //This conditional statement is used to name the output file
            if (theFood[0].country.Equals("GB"))
                outPut = "GB-Menu-AllDay.html";
            else
                outPut = "US-Menu-AllDay.html";

            string outputLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outPut);

            StreamWriter writer = new StreamWriter(outPut);

            //The order in which the foods will be written is, Breakfast, Snack, 
            //Appetizer, Lunch, Dinner, Dessert, Side Dish

            writer.WriteLine("<HTML>");
            writer.WriteLine("<HEAD>\n<TITLE>Menu</TITLE>\n</HEAD>");
            writer.WriteLine("<BODY>");
            writer.WriteLine("\t<CENTER>Menu</CENTER>");

            writer.WriteLine("\t<H1>BREAKFAST</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Breakfast");

            writer.WriteLine("\t<H1>SNACK</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Snack");

            writer.WriteLine("\t<H1>APPETIZER</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Appetizer");

            writer.WriteLine("\t<H1>LUNCH</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Lunch");

            writer.WriteLine("\t<H1>DINNER</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Dinner");

            writer.WriteLine("\t<H1>DESSERT</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Dessert");

            writer.WriteLine("\t<H1>SIDE_DISH</H1>");
            toWrite.WriteTheHtml(theFood, writer, "Side Dish");

            writer.WriteLine("</BODY>");
            writer.WriteLine("</HTML>");

            writer.Close();

            Console.WriteLine("The All Day Menu file can be found at:\n{0}", outputLocation);

        }


    }

    //Description: This class is used to write the Diner Menu to a Plain Text file
    public class DinerPlainMenu : IOrderOfMenu
    {
        public void CreateMenu(List<FoodItemData> theFood)
        {
            string outPut = "";

            //This conditional statement is used to name the output file
            if (theFood[0].country.Equals("GB"))
                outPut = "GB-Menu-Diner.txt";
            else
                outPut = "US-Menu-Diner.txt";

            string outputLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outPut);

            StreamWriter writer = new StreamWriter(outPut);
            ThePlainTextWriter toWrite = new ThePlainTextWriter();

            //The order in which the foods will be written is Breakfast, Snack, Appetizer
            //Lunch, Dessert

            writer.WriteLine("Menu\n");

            writer.WriteLine("BREAKFAST\n");
            toWrite.WriteThePlainText(theFood, writer, "Breakfast");

            writer.WriteLine("SNACK\n");
            toWrite.WriteThePlainText(theFood, writer, "Snack");

            writer.WriteLine("APPETIZER\n");
            toWrite.WriteThePlainText(theFood, writer, "Appetizer");

            writer.WriteLine("LUNCH\n");
            toWrite.WriteThePlainText(theFood, writer, "Lunch");

            writer.WriteLine("DESSERT\n");
            toWrite.WriteThePlainText(theFood, writer, "Dessert");

            writer.Close();

            Console.WriteLine("The Diner Menu file can be found at:\n{0}", outputLocation);

        }


    }

    //Description: This class is used to write the Evening Only Menu to a Plain Text file
    public class EveningPlainMenu : IOrderOfMenu
    {
        public void CreateMenu(List<FoodItemData> theFood)
        {
            string outPut = "";

            //This conditional statement is used to name the output file
            if (theFood[0].country.Equals("GB"))
                outPut = "GB-Menu-Evening.txt";
            else
                outPut = "US-Menu-Evening.txt";

            string outputLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outPut);

            StreamWriter writer = new StreamWriter(outPut);
            ThePlainTextWriter toWrite = new ThePlainTextWriter();

            //The order in which the foods will be written is, Appetizer, Dinner
            //Dessert, Side Dish

            writer.WriteLine("Menu\n");

            writer.WriteLine("APPETIZER\n");
            toWrite.WriteThePlainText(theFood, writer, "Appetizer");

            writer.WriteLine("DINNER\n");
            toWrite.WriteThePlainText(theFood, writer, "Dinner");

            writer.WriteLine("DESSERT\n");
            toWrite.WriteThePlainText(theFood, writer, "Dessert");

            writer.WriteLine("SIDE_DISH\n");
            toWrite.WriteThePlainText(theFood, writer, "Side Dish");

            writer.Close();

            Console.WriteLine("The Evening Only Menu file can be found at:\n{0}", outputLocation);

        }


    }

    //Description: This class is used to write the All Day Menu to a Plain Text file
    public class AllDayPlainMenu : IOrderOfMenu
    {
        public void CreateMenu(List<FoodItemData> theFood)
        {
            string outPut = "";

            //This conditional statement is used to name the output file
            if (theFood[0].country.Equals("GB"))
                outPut = "GB-Menu-AllDay.txt";
            else
                outPut = "US-Menu-AllDay.txt";

            string outputLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outPut);

            StreamWriter writer = new StreamWriter(outPut);
            ThePlainTextWriter toWrite = new ThePlainTextWriter();

            //The order in which the foods will be written is, Breakfast, Snack, 
            //Appetizer, Lunch, Dinner, Dessert, Side Dish

            writer.WriteLine("Menu\n");

            writer.WriteLine("BREAKFAST\n");
            toWrite.WriteThePlainText(theFood, writer, "Breakfast");

            writer.WriteLine("SNACK\n");
            toWrite.WriteThePlainText(theFood, writer, "Snack");

            writer.WriteLine("APPETIZER\n");
            toWrite.WriteThePlainText(theFood, writer, "Appetizer");

            writer.WriteLine("LUNCH\n");
            toWrite.WriteThePlainText(theFood, writer, "Lunch");

            writer.WriteLine("DINNER\n");
            toWrite.WriteThePlainText(theFood, writer, "Dinner");

            writer.WriteLine("DESSERT\n");
            toWrite.WriteThePlainText(theFood, writer, "Dessert");

            writer.WriteLine("SIDE_DISH\n");
            toWrite.WriteThePlainText(theFood, writer, "Side Dish");

            writer.Close();

            Console.WriteLine("Your All Day Menu file can be found at:\n{0}", outputLocation);

        }


    }

    //Description: This class is used to write the Diner Menu to a XML file
    public class DinerXmlMenu : IOrderOfMenu
    {
        public void CreateMenu(List<FoodItemData> theFood)
        {
            string outPut = "";

            //This conditional statement is used to name the output file
            if (theFood[0].country.Equals("GB"))
                outPut = "GB-Menu-Diner.xml";
            else
                outPut = "US-Menu-Diner.xml";

            string outputLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outPut);

            Encoding UTF8 = new UTF8Encoding(false);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = UTF8;
            settings.Indent = true;

            TheXmlWriter xmlWriter = new TheXmlWriter();
            XmlWriter writer = XmlWriter.Create(outPut, settings);

            //The order in which the foods will be written is Breakfast, Snack, Appetizer
            //Lunch, Dessert

            writer.WriteStartElement("MenuItems");

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "BREAKFAST");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Breakfast");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "SNACK");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Snack");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "APPETIZER");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Appetizer");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "LUNCH");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Lunch");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "DESSERT");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Dessert");
            writer.WriteEndElement();

            writer.WriteFullEndElement();
            writer.Close();

            Console.WriteLine("The Diner Menu file can be found at:\n{0}", outputLocation);

        }


    }

    //Description: This class is used to write the Evening Only Menu to a XML file
    public class EveningXmlMenu : IOrderOfMenu
    {
        public void CreateMenu(List<FoodItemData> theFood)
        {
            string outPut = "";

            //This conditional statement is used to name the output file
            if (theFood[0].country.Equals("GB"))
                outPut = "GB-Menu-Evening.xml";
            else
                outPut = "US-Menu-Evening.xml";

            string outputLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outPut);

            Encoding UTF8 = new UTF8Encoding(false);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = UTF8;
            settings.Indent = true;
            TheXmlWriter xmlWriter = new TheXmlWriter();
            XmlWriter writer = XmlWriter.Create(outPut, settings);

            //The order in which the foods will be written is, Appetizer, Dinner
            //Dessert, Side Dish

            writer.WriteStartElement("MenuItems");

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "APPETIZER");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Appetizer");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "DINNER");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Dinner");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "DESSERT");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Dessert");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "SIDE_DISH");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Side Dish");
            writer.WriteEndElement();

            writer.WriteFullEndElement();
            writer.Close();

            Console.WriteLine("The Evening Only Menu file can be found at:\n{0}", outputLocation);

        }


    }

    //Description: This class is used to write the All Day Menu to a XML file
    public class AllDayXmlMenu : IOrderOfMenu
    {
        public void CreateMenu(List<FoodItemData> theFood)
        {
            string outPut = "";

            //This conditional statement is used to name the output file
            if (theFood[0].country.Equals("GB"))
                outPut = "GB-Menu-AllDay.xml";
            else
                outPut = "US-Menu-AllDay.xml";

            string outputLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outPut);

            Encoding UTF8 = new UTF8Encoding(false);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = UTF8;
            settings.Indent = true;
            TheXmlWriter xmlWriter = new TheXmlWriter();
            XmlWriter writer = XmlWriter.Create(outPut, settings);

            //The order in which the foods will be written is, Breakfast, Snack, 
            //Appetizer, Lunch, Dinner, Dessert, Side Dish

            writer.WriteStartElement("MenuItems");

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "BREAKFAST");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Breakfast");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "SNACK");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Snack");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "APPETIZER");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Appetizer");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "LUNCH");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Lunch");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "DINNER");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Dinner");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "DESSERT");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Dessert");
            writer.WriteEndElement();

            writer.WriteStartElement("MenuCategory");
            writer.WriteAttributeString("category", "SIDE_DISH");
            writer = xmlWriter.WriteTheXml(theFood, writer, "Side Dish");
            writer.WriteEndElement();

            writer.WriteFullEndElement();
            writer.Close();

            Console.WriteLine("The All Day Menu file can be found at:\n{0}", outputLocation);

        }


    }



}
