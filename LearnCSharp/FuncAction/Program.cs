Print(2, 3, (int a, int b) => (a + b));
Print(2, 3, (int a, int b) => (a * b));


// If there is a return type => Func<>
// If thre is no return type Action<>

void Print(int a, int b, Func<int, int, int> logic)
{
    Console.WriteLine(logic(a, b));
}