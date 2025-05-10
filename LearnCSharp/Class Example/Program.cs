using Devskill.CharpExamples.ClassExamples;
using Class_Example;
Pen redPen = new Pen("red", "smart", 100);
Pen bluePen = new Pen("blue", "smart", 200);

bluePen.Write("Hello world");
redPen.Write("Hello world Again");

Console.WriteLine(redPen.InkAmount);

redPen.InkAmount = 9;

Product product1 = new Product();
Product product2 = new Product();


product1.Price = 2000;
double discount = product1.GetDiscount();
