using Class_Example;

Pen redPen = new Pen("red", "smart", 100);
Pen bluePen = new Pen("blue", "smart", 200);

bluePen.Write("Hello world");
redPen.Write("Hello world Again");

Console.WriteLine(redPen.InkAmount);

redPen.InkAmount = 9;