using ECommerce;

List<Product> products = new List<Product>();

string choice;

do
{
    Console.WriteLine("Enter Product ID");
    int pid = int.Parse(Console.ReadLine());


    Console.WriteLine("Enter Product Name");
    string pname = (Console.ReadLine());


    Console.WriteLine("Enter Price");
    double unitPrice = double.Parse(Console.ReadLine());


    Console.WriteLine("Enter Date of Manufacture (yyy-MM-dd)");
    DateTime dom = DateTime.Parse(Console.ReadLine());


    Product product = new Product()
    {
        ProductId = pid,
        ProductName = pname,
        Price = unitPrice,
        DateOfManufacture = dom
    };
    products.Add(product);


    Console.WriteLine("Product Added.\n");
    Console.WriteLine("Do you want to continue to next product?(Yes/No");
    choice = Console.ReadLine();
} while (choice != "no" && choice != "NO");

Console.WriteLine("\nProducts");
foreach (Product item in products)
{
    Console.WriteLine(item.ProductId + "," + item.ProductName + "," + item.Price + "," + item.DateOfManufacture.ToShortDateString());
}