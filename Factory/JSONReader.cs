//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This class is used to override the reader factory method and returns a JSON reader

namespace Factory
{
    class JSONReader : IReader
    {
        protected override IReaderFactoryMethod GetReader()
        {
            return new TheJSONReader();
        }
    }
}