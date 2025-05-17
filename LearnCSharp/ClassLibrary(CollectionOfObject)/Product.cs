namespace ECommerce
{
    /// <summary>
    /// Represents a Product in ECommerce application
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime DateOfManufacture { get; set; }
    }
}
