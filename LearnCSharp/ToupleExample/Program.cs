string name = "Emran Hossen";
int age = 43;


(int n1, int n2) Get2RandomNumbers()
{
    Random random = new(DateTime.Now.Microsecond);
    int n1 = random.Next(1, 500);
    int n2 = random.Next(1, 500);
    return (n1, n2);
}

(int, int n2) result = Get2RandomNumbers();


Console.WriteLine(result.Item1);
Console.WriteLine(result.n2);


(string n, double f)[] things = new (string n, double)[20];

void Test((string x, DateTime y) items)
{

}