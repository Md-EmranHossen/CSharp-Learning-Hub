string name = "Emran Hossen";
int age = 43;

var o = new { Name = "Emran hossen", Age = 43 };


dynamic Get2RandomNumbers()  // Use Dynamic keyword
{
    Random random = new(DateTime.Now.Microsecond);
    int n1 = random.Next(1, 500);
    int n2 = random.Next(1, 500);
    return new { n1 = n1, n2 = n2 };
}

(int, int n2) result = Get2RandomNumbers();

int x = result.Item1;

Console.WriteLine(x);