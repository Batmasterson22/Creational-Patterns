//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Assignment: Project 01 - Factory Method and Abstract Factory
//Description: This is the Factory Method for the reader and it 
//contains a JSON reader and XML reader

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface IReaderFactoryMethod
    {
        List<FoodItemData> TheReader();
    }
}
