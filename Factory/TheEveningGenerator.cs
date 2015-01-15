//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Assignment: Project 01 - Factory Method and Abstract Factory
//Description: This is one of the factories from the Generator
//Factory Method specfically it generates the Evening Only menu

using System.Collections.Generic;

namespace Factory
{
    public class TheEveningGenerator : IGeneratorFactoryMethod
    {
        public List<FoodItemData> TheGenerator(List<FoodItemData> theFood)
        {
            List<FoodItemData> tempFood = new List<FoodItemData>();

            //Loop through all the objects in the FoodItemData List
            foreach (var food in theFood)
            {
                //Makes a new list of FoodItemDatas for the Evening Only menu
                if (food.category.ToString().Equals("Dinner") || food.category.ToString().Equals("Side Dish")
                    || food.category.ToString().Equals("Appetizer") || food.category.ToString().Equals("Dessert"))
                {
                    tempFood.Add(food);
                }

            }

            return tempFood;
        }


    }
}