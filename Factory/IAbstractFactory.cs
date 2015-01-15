//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This is the Abstract Factory interface that implements three
//methods CreateReader, CreateMenuCreator, and CreateMenuFormatter.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface IAbstractFactory
    {
        //This method creates the reader from the user's inputed file path and 
        //returns a List of FoodItemData objects
        List<FoodItemData> CreateReader();

        //This method modifies the List of FoodItemData objects to the 
        //specific restaurant category (ie Diner, Evening, and All Day)
        List<FoodItemData> CreateMenuCreator(List<FoodItemData> theFood);

        //This creates a file in either HMTL, Plain Text, or XML
        void CreateMenuFormatter(List<FoodItemData> theFood);
        
    }
}
