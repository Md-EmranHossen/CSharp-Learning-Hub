using System.Text;

string name = "Emran Hossen";
name = "Md" + name;
// There are three space needed here in the memorhy


// string Builder is memory efficeint
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append(name);

for (int i = 0; i < stringBuilder.Length; i++)
{
    Console.WriteLine(stringBuilder[i]);
}

// But stringBuilder is not return a string.so you have to convert  to sring after modification.
string result = stringBuilder.ToString();
Console.WriteLine(result);