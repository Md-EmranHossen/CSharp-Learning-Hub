// Basic Switch Case (Previous Syntax) 
using SwitchCaseAdvanced;

var option = 5;
int x = 0;

switch (option) // Option Must be primitive type.
{
    case 0:
        x += 5;
        break;
    case 1:
        x = 5;
        break;
    case 2:
        x += 3;
        break;
    case 3:
        x = 0;
        break;
    case 4:
        x += 4;
        break;
    case 5:
        x -= 5;
        break;
    default:
        x = 1;
        break;
}


// New syntax of Switch Case (From .NET 5)
x = option switch
{
    0 => x + 5,
    1 => 5,
    2 => 5 / 2,
    3 => 5,
    _ => 1
};


// Option become object Type
var person = new Person { Name = "Emran", Age = 42 };

x = person switch
{
    { Age: 40, Name: "Sajib" } => 5,
    { Age: 25, Name: "Rakib" } => 8,
    { Age: _, Name: _ } => 0
};
