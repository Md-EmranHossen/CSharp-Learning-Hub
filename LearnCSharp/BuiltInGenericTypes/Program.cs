#region List Examples
using System.Collections;

List<string> names = new List<string>();

names.Add("Eman Hossen");
names.Add("Rakib Hossain");
names.Remove("Eman Hossen");


List<int> Ages = new List<int>();
Ages.Add(29);
Ages.Add(22);
Ages.Add(34);

Console.WriteLine(names[1]);
Console.WriteLine(Ages[9]);
Console.WriteLine(names.Count);

names[1] = "Shakib";
Ages[0] = 34;

#endregion

#region Dictionary Examples

Dictionary<string, int> persons = new Dictionary<string, int>();
persons.Add("Emran", 24);
persons.Add("Rakib", 25);

persons["Emran"] = 25;

Dictionary<string, Dictionary<int, double>> items = new Dictionary<string, Dictionary<int, double>>();
List<Dictionary<string, string>> things = new List<Dictionary<string, string>>();

#endregion

#region Hashset Example like set

HashSet<string> codes = new HashSet<string>();
codes.Add("Emran Hossen");
codes.Add("Sajib");
codes.Add("Emran Hossen");

Console.WriteLine(codes.Count);
// output: 2 Because there are no duplicate value allowed
codes.Remove("Emran Hossen");
#endregion

#region SortedList Example

SortedList<int, string> grades = new SortedList<int, string>();
grades.Add(93, "Emran");
grades.Add(88, "Tareq");
grades.Add(96, "Rakib");


foreach (var grade in grades)
{
    Console.WriteLine($"Name:{grade.Value}, Grade: {grade.Key}");
}

#endregion 

#region LinkedList
LinkedList<int> list = new LinkedList<int>();
list.AddLast(5);
list.AddFirst(6);
#endregion

#region Stack Example

Stack<int> stack = new Stack<int>();
stack.Push(4);
stack.Push(6);

int item = stack.Peek();

int last = stack.Pop();
Console.WriteLine("Last Item: " + last);
#endregion

#region Queue Example

Queue<int> queue = new Queue<int>();
queue.Enqueue(3);
queue.Enqueue(5);

var first = queue.Dequeue();

Console.WriteLine("Frist item: " + first);
#endregion

//Non Generics Example (For mixed items(object type))
#region ArrayListExample

ArrayList arrayList = new ArrayList();
arrayList.Add(3);
arrayList.Add("Emran Hossen");
arrayList.Add(true);
object item1 = arrayList[1];
#endregion

#region HashTable
Hashtable hastable = new Hashtable();
hastable.Add("Emran", 99);
hastable.Add("Rakib", 93);
#endregion

#region Stack
Stack stack2 = new Stack();
stack.Push(3);
var item3 = stack2.Pop();

#endregion

#region Queue
Queue queue2 = new Queue();
queue2.Enqueue(3);
queue2.Enqueue(5);
var item4 = queue2.Dequeue();
#endregion


// Default Key word
Console.WriteLine(default(int));
Console.WriteLine(default(double));
Console.WriteLine(default(bool));
Console.WriteLine(default(List<int>));

if (default(List<int>) is null)
    Console.WriteLine("null");




