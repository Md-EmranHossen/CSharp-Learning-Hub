using Generics;

Coordiate<Person, double> coordiate = new Coordiate<Person, double>();
coordiate.X = new Person();
coordiate.Y = 4.8;


Coordiate<Person, double> coordiate2 = new Coordiate<Person, double>();
coordiate2.X = new Person();
coordiate2.Y = 9.5;


Coordiate<Person, int> coordiate3 = new Coordiate<Person, int>();
coordiate3.Test(new Person(), 3);


