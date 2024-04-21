namespace test.Model
{
    public class BaseModel
    {
      public List<Product> Products { get; set; }
      public List<Discount>? Discounts { get; set; }

    }
    public class Product
    {
        public string name { get; set; }
        public double value { get; set; }

    }
    public class Discount
    {
        public string name { get; set; }
        public int total { get; set; }
    }
    public class DiscountMain
    {
        public string name { get; set; }
        public string type { get; set; }
    }
}
