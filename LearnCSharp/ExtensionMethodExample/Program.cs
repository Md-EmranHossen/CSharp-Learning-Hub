using ClassLibraryForExtensionMethod;
using ExtensionMethodExample;

Product product1 = new Product() { ProductCost = 33.2, DiscountPercentage = 10 };

double result = product1.GetDiscount();