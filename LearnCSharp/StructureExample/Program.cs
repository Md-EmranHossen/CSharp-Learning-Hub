using StructureExample;

Product product1 = new Product();
product1.Name = "Camera";
product1.Price = 3000;
var discount1 = product1.GetDiscountedPrice(20);


Product product2 = product1;
product2.Name = "Laptop";


Console.WriteLine($"Product1 Name : {product1.Name}, Product1 Price: {product1.Price}");
Console.WriteLine($"Product2 Name : {product2.Name}, Product2 Price: {product2.Price}");

// Value Type
int x = 5;
int y = x;
y = 3;