//Name:  Jason Hodges - jrhodge1@asu.edu
//Class: CSE 460 - MW 6:00-7:15
//Description: This is the FoodItemData object that contains the variables 
//different meals that are read in from either a JSON or XML file

namespace Factory
{
    public class FoodItemData
    {
        public FoodItemData(string country, int id, string name, string description, string category, double price)
        {
            this.country = country;
            this.id = id;
            this.name = name;
            this.description = description;
            this.category = category;
            this.price = price;

        }

        public string country { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public double price { get; set; }

    }



}