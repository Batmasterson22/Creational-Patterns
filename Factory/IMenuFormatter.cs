//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This class contains the Factory method for the formatter and returns
//a new TheHTMLFormatter, ThePlainFormatter, or TheXMLFormatter

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class IMenuFormatter
    {
        //When this variable is set it returns the factory method GenerateMenu()
        protected IFormatterFactoryMethod FormatterService { get { return (GenerateMenu()); } }
        //This is the Factory Method that creates a FormatterAbstractFactory object
        protected abstract IFormatterFactoryMethod GenerateMenu();

        public void MenuFormatter(List<FoodItemData> theFood, string restaurant)
        {
            FormatterService.TheFormatter(theFood, restaurant);
        }

    }
}
