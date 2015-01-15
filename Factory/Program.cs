//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Assignment: Project 01 - Factory Method and Abstract Factory
//Description: This is the main driver for the menu creating program. It uses
//the class GetUserInput to handle the user interaction then creates a 
//concrete class for the appropriate input

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {   
            //This list is used to hold the food data from a file
            var theFood = new List<FoodItemData>();
            string theCase = "";

            //This class is used to handle the user interface
            var theInput = new GetUserInput();
            string[] theCaseArray = theInput.TheUserInput();

            theCase = theCaseArray[0] + theCaseArray[1] + theCaseArray[2];
            
            //This switch statement is used to call a specific concrete factory from the
            //IAbstractFactory class that is entered by the user
            switch(theCase)
            {
                case "GDH":
                    IAbstractFactory theFact1 = new GBDinerHtml();
                    theFood = theFact1.CreateReader();
                    theFood = theFact1.CreateMenuCreator(theFood);
                    theFact1.CreateMenuFormatter(theFood);
                    break;

                case "GEH":
                    IAbstractFactory theFact2 = new GBEveningHtml();
                    theFood = theFact2.CreateReader();
                    theFood = theFact2.CreateMenuCreator(theFood);
                    theFact2.CreateMenuFormatter(theFood);
                    break;

                case "GAH":
                    IAbstractFactory theFact3 = new GBAllDayHtml();
                    theFood = theFact3.CreateReader();
                    theFood = theFact3.CreateMenuCreator(theFood);
                    theFact3.CreateMenuFormatter(theFood);
                    break;

                case "GDP":
                    IAbstractFactory theFact4 = new GBDinerPlain();
                    theFood = theFact4.CreateReader();
                    theFood = theFact4.CreateMenuCreator(theFood);
                    theFact4.CreateMenuFormatter(theFood);
                    break;

                case "GEP":
                    IAbstractFactory theFact5 = new GBEveningPlain();
                    theFood = theFact5.CreateReader();
                    theFood = theFact5.CreateMenuCreator(theFood);
                    theFact5.CreateMenuFormatter(theFood);
                    break;

                case "GAP":
                    IAbstractFactory theFact6 = new GBAllDayPlain();
                    theFood = theFact6.CreateReader();
                    theFood = theFact6.CreateMenuCreator(theFood);
                    theFact6.CreateMenuFormatter(theFood);
                    break;

                case "GDX":
                    IAbstractFactory theFact7 = new GBDinerXml();
                    theFood = theFact7.CreateReader();
                    theFood = theFact7.CreateMenuCreator(theFood);
                    theFact7.CreateMenuFormatter(theFood);
                    break;

                case "GEX":
                    IAbstractFactory theFact8 = new GBEveningXml();
                    theFood = theFact8.CreateReader();
                    theFood = theFact8.CreateMenuCreator(theFood);
                    theFact8.CreateMenuFormatter(theFood);
                    break;

                case "GAX":
                    IAbstractFactory theFact9 = new GBAllDayXml();
                    theFood = theFact9.CreateReader();
                    theFood = theFact9.CreateMenuCreator(theFood);
                    theFact9.CreateMenuFormatter(theFood);
                    break;

                case "UDH":
                    IAbstractFactory theFact10 = new USDinerHtml();
                    theFood = theFact10.CreateReader();
                    theFood = theFact10.CreateMenuCreator(theFood);
                    theFact10.CreateMenuFormatter(theFood);
                    break;

                case "UEH":
                    IAbstractFactory theFact11 = new USEveningHtml();
                    theFood = theFact11.CreateReader();
                    theFood = theFact11.CreateMenuCreator(theFood);
                    theFact11.CreateMenuFormatter(theFood);
                    break;

                case "UAH":
                    IAbstractFactory theFact12 = new USAllDayHtml();
                    theFood = theFact12.CreateReader();
                    theFood = theFact12.CreateMenuCreator(theFood);
                    theFact12.CreateMenuFormatter(theFood);
                    break;

                case "UDP":
                    IAbstractFactory theFact13 = new USDinerPlain();
                    theFood = theFact13.CreateReader();
                    theFood = theFact13.CreateMenuCreator(theFood);
                    theFact13.CreateMenuFormatter(theFood);
                    break;

                case "UEP":
                    IAbstractFactory theFact14 = new USEveningPlain();
                    theFood = theFact14.CreateReader();
                    theFood = theFact14.CreateMenuCreator(theFood);
                    theFact14.CreateMenuFormatter(theFood);
                    break;

                case "UAP":
                    IAbstractFactory theFact15 = new USAllDayPlain();
                    theFood = theFact15.CreateReader();
                    theFood = theFact15.CreateMenuCreator(theFood);
                    theFact15.CreateMenuFormatter(theFood);
                    break;

                case "UDX":
                    IAbstractFactory theFact16 = new USDinerXml();
                    theFood = theFact16.CreateReader();
                    theFood = theFact16.CreateMenuCreator(theFood);
                    theFact16.CreateMenuFormatter(theFood);
                    break;

                case "UEX":
                    IAbstractFactory theFact17 = new USEveningXml();
                    theFood = theFact17.CreateReader();
                    theFood = theFact17.CreateMenuCreator(theFood);
                    theFact17.CreateMenuFormatter(theFood);
                    break;

                case "UAX":
                    IAbstractFactory theFact18 = new USAllDayXml();
                    theFood = theFact18.CreateReader();
                    theFood = theFact18.CreateMenuCreator(theFood);
                    theFact18.CreateMenuFormatter(theFood);
                    break;


            }

            Console.WriteLine("\nPress enter to exit the program.");
            Console.ReadLine();
            
        }
    }
}
