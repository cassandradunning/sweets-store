namespace Products
{
    public class Product
    {

        public double? Price { get; set; }
        public double? Weight { get; set; }

        public string? Name { get; set; }

        // public Product(string Name)
        // // If you add ^^ everything that derives from product will have to have a 
        // // unique constructor bc of the signature (string Name)

        // {

        // }
    }
}