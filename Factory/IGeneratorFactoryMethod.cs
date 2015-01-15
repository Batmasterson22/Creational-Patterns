//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Assignment: Project 01 - Factory Method and Abstract Factory
//Description: This is the Factory Method for the generator and 
//has a Diner, Evening Only, and All Day generators

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface IGeneratorFactoryMethod
    {
        List<FoodItemData> TheGenerator(List<FoodItemData> theFood);
    }
}
