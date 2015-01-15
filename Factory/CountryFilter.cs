//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This class is used to filter the list of FoodItems by there respective country

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class CountryFilter
    {
        public List<FoodItemData> FilterByCountry(List<FoodItemData> theFood, String country)
        {
            List<FoodItemData> tempFood = new List<FoodItemData>();

            //Loops through all the items in the FoodItemData list
            foreach (var food in theFood)
            {
                //This conditional statement is used to create a new list of 
                //FoodDataItems for a specific country
                if (food.country.ToString().Equals(country))
                {
                    tempFood.Add(food);
                }

            }

            return tempFood;
        }
    }
}
