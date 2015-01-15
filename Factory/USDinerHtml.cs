//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: Concrete Factory for US Diner Menu in HTML

using System.Collections.Generic;

namespace Factory
{
    public class USDinerHtml : IAbstractFactory
    {
        public List<FoodItemData> CreateReader()
        {
            List<FoodItemData> theFood = new List<FoodItemData>();
            CountryFilter countryFilter = new CountryFilter();
            IReader read = new JSONReader();

            theFood = read.MenuReader();
            theFood = countryFilter.FilterByCountry(theFood, "US");

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
            IMenuFormatter format = new HTMLFormatter();
            format.MenuFormatter(theFood, "D");

        }



    }
}