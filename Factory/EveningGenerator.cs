//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This class is used to override the factory method and returns a Evening Only generator

namespace Factory
{
    class EveningGenerator : IMenuGenerator
    {
        protected override IGeneratorFactoryMethod GetMenu()
        {
            return new TheEveningGenerator();
        }
    }
}