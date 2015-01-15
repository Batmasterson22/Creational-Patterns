//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Assignment: Project 01 - Factory Method and Abstract Factory
//Description: This is one of the factories from the Reader Factory Method specfically it is 
//used to read from a JSON file. Currently it only accepts JSON for the US menu. It can be extened
//by removing the error statement and adding an appropriate concrete factory extended from IAbstractFactory

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Factory
{
    public class TheJSONReader : IReaderFactoryMethod
    {
        public List<FoodItemData> TheReader()
        {
            //Create a list of FoodItemData objects filled with data read from a file
            List<FoodItemData> theFood = new List<FoodItemData>();
            //Create a list of strings to parse the JSON file
            List<string> stringList = new List<string>();

            //This regular expression is used to determine if the entered file path is a JSON file
            Regex rgx = new Regex(@"([a-zA-Z]:(\\w+)*\\[a-zA-Z0_9]+)?.json");

            string toTest = "";

            while (true)
            {
                Console.WriteLine("\nWhat is the path to the JSON file including the file name and extension?");
                toTest = Console.ReadLine();
                //toTest = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FoodItemData.json");

                if (File.Exists(toTest))
                {
                    if (rgx.IsMatch(toTest))
                        break;
                    else
                        Console.WriteLine("That file format is not supported for the US menus at this time.");
                }
                else
                    Console.WriteLine("\nFile Not Found! Please check the file path and try again.\n");

            }
            

            string aCoun = "", aID = "", aName = "", aDesc = "", aCate = "", aPric = "";

            //Create a JsonTextReader with a StringReader that has the whole json file text passed to it
            JsonTextReader reader = new JsonTextReader(new StringReader(File.ReadAllText(toTest)));

            //This loop is used to parse all the words from a json file
            while (reader.Read())
            {
                //This condition will only add the words after the listed keywords
                if (reader.Value != null && (reader.Value.Equals("-country") || reader.Value.Equals("id")
                                             || reader.Value.Equals("name") || reader.Value.Equals("description")
                                             || reader.Value.Equals("category") || reader.Value.Equals("price")))
                {
                    reader.Read();
                    stringList.Add((string)reader.Value);
                }

            }

            //This loop iternates through each element of the string list, sets them to a variable,
            //then adds a new FoodItem to the FoodItemData list
            for (int i = 0; i < stringList.Count; )
            {
                aCoun = stringList[i];
                i++;
                aID = stringList[i];
                i++;
                aName = stringList[i];
                i++;
                aDesc = stringList[i];
                i++;
                aCate = stringList[i];
                i++;
                aPric = stringList[i];
                i++;

                theFood.Add(new FoodItemData(aCoun, Convert.ToInt32(aID), aName, aDesc, aCate, Convert.ToDouble(aPric)));

            }

            return theFood;
        }

    }
}