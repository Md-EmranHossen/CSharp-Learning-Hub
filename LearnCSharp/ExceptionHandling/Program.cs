try
{
    int x = 100;
    int y = 5;

    while (x > 0)
    {
        x /= 2;
        x /= y;
    }
}
catch(DivideByZeroException dex)
{
    Console.WriteLine(dex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message); 
}