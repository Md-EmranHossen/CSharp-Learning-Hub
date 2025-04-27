using System.Linq.Expressions;

Func<int, int, double> div = (a, b) => a / b*1.0;
double r = div(3, 4);

Console.WriteLine(r);

//Expression  
Expression<Func<int,int,double>> e = (a, b) => a / b*1.0;
var f = e.Compile();
f(5, 2);
Console.WriteLine(f); 