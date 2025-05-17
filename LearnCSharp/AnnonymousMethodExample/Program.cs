
using AnnonymousMethodExample;

//Subscriber subscriber = new Subscriber();

Publisher publisher = new Publisher();

publisher.myevEvent += delegate (int a, int b)
{
    int c = a + b;
    Console.WriteLine(c);
};

// Invoke the event
publisher.RaiseEvent(10, 20);
publisher.RaiseEvent(9, 32);

Console.ReadKey();