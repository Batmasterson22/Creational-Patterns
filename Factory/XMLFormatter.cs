﻿//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This class is used to override the factory method and returns a XML formatter

namespace Factory
{
    class XMLFormatter : IMenuFormatter
    {
        protected override IFormatterFactoryMethod GenerateMenu()
        {
            return new TheXMLFormatter();
        }
    }
}