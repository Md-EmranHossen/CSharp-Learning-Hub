
using Records;

Person person = new Person("Emran Hossen", 25);

Person person2 = person;

person2.Name = "Shakib";

Console.WriteLine(person.Name);
Console.WriteLine(person2.Name);


Person person3 = new Person("hasan", 30);
Person person4 = new Person("hasan", 30);

if (person3 == person4)
{
    Console.WriteLine("Same");
}
 
else
{
    Console.WriteLine("Not same");
}
