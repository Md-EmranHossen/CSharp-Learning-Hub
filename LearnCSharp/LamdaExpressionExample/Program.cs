
using LamdaExpressionExample;

Publisher publisher = new Publisher();

publisher.myevEvent += (a,b) =>
{
    int c = a + b;
    Console.WriteLine(c);
};

// Invoke the event
publisher.RaiseEvent(10, 20);
publisher.RaiseEvent(9, 32);

Console.ReadKey();