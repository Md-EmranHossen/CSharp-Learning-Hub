using ParamiterModifier;

Console.WriteLine("Hello World"); // Here [Hello world] is called argument
Test.Method1(2,3,3,4,5);


int y = 5;

Test.Methood2(ref y);
Console.WriteLine(y);

Test.Methood3(in y);
Console.WriteLine(y);


Test.Methood4(out y);
Console.WriteLine(y);