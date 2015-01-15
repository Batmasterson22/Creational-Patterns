//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: Concrete Factory for GB All Day Menu in HTML

using System.Collections.Generic;

namespace Factory
{
    public class GBAllDayHtml : IAbstractFactory
    {
        public List<FoodItemData> CreateReader()
        {
            List<FoodItemData> theFood = new List<FoodItemData>();
            CountryFilter countryFilter = new CountryFilter();
            IReader read = new XMLReader();

            theFood = read.MenuReader();
            theFood = countryFilter.FilterByCountry(theFood, "GB");

            return theFood;
        }

        public List<FoodItemData> CreateMenuCreator(List<FoodItemData> theFood)
        {
            IMenuGenerator generate = new AllDayGenerator();
            theFood = generate.MenuGenerator(theFood);

            return theFood;
        }

        public void CreateMenuFormatter(List<FoodItemData> theFood)
        {
            IMenuFormatter format = new HTMLFormatter();
            format.MenuFormatter(theFood, "A");

        }



    }
}