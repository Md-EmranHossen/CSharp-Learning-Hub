// Array
using Indexers;

int[] ages = [22, 25];
ages[0] = 21;

// List ( List a normal class)
List<string> names = new List<string> { "Emran Hossen", "Rakib Hossain" };
names[0] = "Narmi";

// How to access our custom class like List (using indexers)
ShoppingCart cart = new ShoppingCart();
cart[0] = new Product();
cart["4"] = new Product();
cart[3, 4.5] = new Product();