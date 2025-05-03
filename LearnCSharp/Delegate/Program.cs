using static Delegate.MathExample;
Calculate sum = Sum;


/*int Sum(int a, int b)
{
    return a + b;
}

int Multiply(int a, int b)
{
    return a * b;
}*/


// Delegate using Lamda methood
/*int Sum(int a, int b) => (a + b);

int Multiply(int a, int b) => (a * b);



Print(2, 3, Sum);
Print(2, 3, Multiply);

void Print(int a, int b, Calculate logic)
{
    Console.WriteLine(logic(a, b));
}*/




Print(2, 3, (int a, int b) => (a + b));
Print(2, 3, (int a, int b) => (a * b));

void Print(int a, int b, Calculate logic)
{
    Console.WriteLine(logic(a, b));
}