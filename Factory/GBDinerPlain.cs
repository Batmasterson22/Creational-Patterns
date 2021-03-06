//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: Concrete Factory for GB Diner Menu in Plain text

using System.Collections.Generic;

namespace Factory
{
    public class GBDinerPlain : IAbstractFactory
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
            IMenuGenerator generate = new DinerGenerator();
            theFood = generate.MenuGenerator(theFood);

            return theFood;
        }

        public void CreateMenuFormatter(List<FoodItemData> theFood)
        {
            IMenuFormatter format = new PlainFormatter();
            format.MenuFormatter(theFood, "D");

        }



    }
}