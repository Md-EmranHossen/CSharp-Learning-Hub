/*
string name = "Emran";
Type t2 = name.GetType();
*/


using System.Reflection;

Type t = typeof(Math);

MethodInfo[] methods = t.GetMethods();
int x = 0;
foreach (var method in methods)
{
    ParameterInfo[] parameters = method.GetParameters();
    Type returntype = method.ReturnType;

    Console.Write(returntype.Name.ToLower());
    Console.Write(" ");
    Console.WriteLine(method.Name);

    Console.Write("(");
    if(parameters.Length > 0)
    {
        foreach(var parameter in parameters)
        {
            Console.Write(parameter.ParameterType.Name);
            Console.Write(' ');
            Console.Write(parameter.Name);

            if (parameters[parameters.Length - 1].Name != parameter.Name)
            {
                Console.Write(",");
            }
        }
    }
    Console.WriteLine(")");
    Console.WriteLine();
}