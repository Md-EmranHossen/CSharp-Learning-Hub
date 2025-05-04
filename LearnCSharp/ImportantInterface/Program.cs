
using ImportantInterface;

People people = new People();

foreach(var person in people)
{
    Console.WriteLine(person.Name);
}

List<Person> list = new List<Person>(people);