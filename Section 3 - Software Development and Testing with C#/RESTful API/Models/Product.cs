namespace RESTful_API.Models
{
    public class Product
    {
        //Defines the structure for the Product entity and it's properties

        public int ID { get; set; }
        public required string Name { get; set; }
        public double Price { get; set; }
    }
}