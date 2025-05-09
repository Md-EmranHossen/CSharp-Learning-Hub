int x = 5;
int y = 6;
int z = x + y - 3 / 4;

// Increment and Decrement
x++;
++x;

y--;
--y;
Console.WriteLine(x);
Console.WriteLine(y);


float price = 3.4f;
double amount = 4.64d;
decimal Bigamount = 444.34324324m;

bool logic1 = true;
bool logic2 = true;
bool result = logic1 && logic2;
bool result2 = x > 3;
bool result3 = x != 3;


int a = 12;

Console.WriteLine(Convert.ToString(a, toBase: 2));
Console.WriteLine(Convert.ToString(a, toBase: 16));


// How to write binary number format and Hexadecimal number
int a2 = 0b111;
int a3 = 0xA;
Console.WriteLine(a2);
Console.WriteLine(a3);