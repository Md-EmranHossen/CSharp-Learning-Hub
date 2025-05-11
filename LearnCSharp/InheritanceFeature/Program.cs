using InheritanceFeature;

Electronics camera = new Electronics
{
    Name = "Camera",
    Price = 200
};
Console.WriteLine(camera.CalculateDiscountedPrice(20));
Console.WriteLine(camera.Barcode);


Product product = new Electronics { Name = "Laptop", Price = 200,Barcode = "#334df" };

Console.WriteLine(product.CalculateDiscountedPrice(20));
//Console.WriteLine(product.Barcode); No Access


