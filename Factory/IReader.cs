//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This class contains the Factory method for the reader and returns
//a new TheJSONReader or TheXMLReader

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class IReader
    {
        //When this variable is set it returns the factory method GetReader()
        protected IReaderFactoryMethod ReaderService { get { return (GetReader()); } }
        //This is the Factory Method that creates a ReaderFactoryMethod object
        protected abstract IReaderFactoryMethod GetReader();

        public List<FoodItemData> MenuReader()
        {
            return ReaderService.TheReader();
        }
    }
}
