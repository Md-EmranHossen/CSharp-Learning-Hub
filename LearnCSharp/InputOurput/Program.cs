// Provide alwayes outpur as a string
Console.WriteLine(5);
string x = Console.ReadLine();
Console.WriteLine(x);


int num = Console.Read(); // Take ascii value
Console.WriteLine(num);


char k = (char)Console.Read();
Console.WriteLine(k);


// Another Way
char ch = Convert.ToChar(Console.Read());
Console.WriteLine(ch);


// Take input withour clicking Enter key
ConsoleKeyInfo key = Console.ReadKey();


// How to print a value of a variable with string 
int number = 14;
Console.WriteLine($"The number is {number}");


// Currency Formatting
decimal value = 123.423m;
Console.WriteLine(value.ToString("c2"));


// Method
int[] array = { 2, 3, 4, 3, 5, 8, 8 };
void printArray(int[] array)
{
    foreach (var num in array)
    {
        Console.WriteLine(num);
    }
}
printArray(array);


//How to take input separately given string line

Console.WriteLine("Enter the numbers with commas");

string numLine = Console.ReadLine();

string[] nums = numLine.Split(',');

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = nums[i].Trim();
}

int[] number1 = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
    number1[i] = int.Parse(nums[i]) + 1;
}


foreach (var ch1 in number1)
{
    Console.WriteLine(ch1);
}
Console.WriteLine();



// If want to take inputs are line by line
int sum = 0;
while (true)
{
    string wholeline = Console.ReadLine();
    if (string.IsNullOrEmpty(wholeline))
    {
        break;
    }
    sum += int.Parse(wholeline);
}
Console.WriteLine(sum);