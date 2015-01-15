//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Assignment: Project 01 - Factory Method and Abstract Factory
//Description: This is one of the factories from the Reader Factory Method specfically it is 
//used to read from a XMl file. Currently it only accepts XML for British menu. It can be extened
//by removing the error statement and adding an appropriate concrete factory extended from IAbstractFactory

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.XPath;

namespace Factory
{
    public class TheXMLReader : IReaderFactoryMethod
    {
        public List<FoodItemData> TheReader()
        {
            string toTest = "";

            //This regular expression is used to determine if the entered file path is a XML file
            Regex rgx = new Regex(@"([a-zA-Z]:(\\w+)*\\[a-zA-Z0_9]+)?.xml");
            
            while (true)
            {
                Console.WriteLine("\nWhat is the path to the XML file including the file name and extension?");
                toTest = Console.ReadLine();
                //toTest = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FoodItemData.xml");

                if (File.Exists(toTest))
                {
                    if (rgx.IsMatch(toTest))
                        break;
                    else
                        Console.WriteLine("That file format is not supported for the British menus at this time.");
                }
                else
                    Console.WriteLine("\nFile Not Found! Please check the file path and try again.\n");

            }
            
           
            //Create a list of FoodItemData objects filled with data read from a file
            List<FoodItemData> theFood = new List<FoodItemData>();

            string aCoun = "", aName = "", aDesc = "", aCate = "";
            int aID = 0;
            double aPric = 0.0D;

            //The XPath class is used to parse a XML file
            XPathDocument xdoc = new XPathDocument(toTest);
            XPathNavigator xpdoc = xdoc.CreateNavigator();
            XPathNodeIterator xset = xpdoc.Select("/FoodItemData/FoodItem");

            //This loop iterates through each FoodItem in a XML file, sets them to a variable,
            //then adds a new FoodItem to the FoodItemData list
            while (xset.MoveNext())
            {
                aCoun = xset.Current.GetAttribute("country", "");

                XPathNodeIterator xnode = xset.Current.Select("id");
                xnode.MoveNext();
                aID = xnode.Current.ValueAsInt;

                xnode = xset.Current.Select("name");
                xnode.MoveNext();
                aName = xnode.Current.Value;

                xnode = xset.Current.Select("description");
                xnode.MoveNext();
                aDesc = xnode.Current.Value;

                xnode = xset.Current.Select("category");
                xnode.MoveNext();
                aCate = xnode.Current.Value;

                xnode = xset.Current.Select("price");
                xnode.MoveNext();
                aPric = xnode.Current.ValueAsDouble;

                theFood.Add(new FoodItemData(aCoun, aID, aName, aDesc, aCate, aPric));

            }

            return theFood;
        }

    }
}