//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Assignment: Project 01 - Factory Method and Abstract Factory
//Description: This class will format the output in HTML

using System.Collections.Generic;

namespace Factory
{
    public class TheHTMLFormatter : IFormatterFactoryMethod
    {
        public void TheFormatter(List<FoodItemData> theFood, string restaurant)
        {
            switch(restaurant)
            {
                case "D":
                    IOrderOfMenu diner = new DinerHtmlMenu();
                    diner.CreateMenu(theFood);
                    break;
                case "E":
                    IOrderOfMenu evening = new EveningHtmlMenu();
                    evening.CreateMenu(theFood);
                    break;
                case "A":
                    IOrderOfMenu allDay = new AllDayHtmlMenu();
                    allDay.CreateMenu(theFood);
                    break;

            }

        }
    }
}