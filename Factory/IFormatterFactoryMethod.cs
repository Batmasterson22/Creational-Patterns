//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Assignment: Project 01 - Factory Method and Abstract Factory
//Description: This is the Factory Method for the formatter and it
//will write a HTML, Plain Text, or XML for either Diner, Evening
//Only, or All Day Menus

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface IFormatterFactoryMethod
    {
        void TheFormatter(List<FoodItemData> theFood, string restaurant);
    }
}
