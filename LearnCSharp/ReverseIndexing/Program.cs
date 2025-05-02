int[] ages = [32, 42, 99];

// Reverse indexing is 1 based

ages[^1] = 7;  
ages[^2] = 9;
ages[^3] = 23;


foreach(var age in ages)
{
    Console.WriteLine(age);
}