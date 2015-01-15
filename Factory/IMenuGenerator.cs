//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This class contains the Factory method for the generator and returns
//a new TheDinerGenerator, TheEveningGenerator, or TheAllDayGenerator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class IMenuGenerator
    {
        //When this variable is set it returns the factory method GetMenu()
        protected IGeneratorFactoryMethod GeneratorService { get { return (GetMenu()); } }

        //This is the Factory Method that creates a GeneratorAbstractFactory object
        protected abstract IGeneratorFactoryMethod GetMenu();

        public List<FoodItemData> MenuGenerator(List<FoodItemData> theFood)
        {
            return GeneratorService.TheGenerator(theFood);
        }

    }
}
