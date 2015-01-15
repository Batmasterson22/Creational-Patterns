//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This class is used to override the reader factory method and returns a XML reader

namespace Factory
{
    class XMLReader : IReader
    {
        protected override IReaderFactoryMethod GetReader()
        {
            return new TheXMLReader();
        }
    }
}