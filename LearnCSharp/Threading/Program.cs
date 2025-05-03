void PrintEvenNumbers()
{
    for(int i = 0; i < 100; i+=2)
    {
        Console.WriteLine(i);
    }
}


void PrintOddNumbers()
{
    for (int i = 1; i < 100; i+=2)
    {
        Console.WriteLine(i);
    }
}

// Threading Execute parallaly
Thread t1 = new Thread(() => PrintEvenNumbers());
Thread t2 = new Thread(() => PrintOddNumbers());

t1.Start();
t2.Start();