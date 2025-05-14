// null means no value is initiilized (nothing here)
int? x = null;
if (x.HasValue)
{
    Console.WriteLine(x.Value);
}
// Another representation
Nullable<int> m = null;

string? name = null;
Console.WriteLine(name);


string empty = "";
empty = string.Empty; //Recomended
