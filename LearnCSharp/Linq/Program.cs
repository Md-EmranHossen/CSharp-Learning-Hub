using System.Collections;

int[] numbers = [2, 3, 4, 5, 6];

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 1)
        sum += numbers[i];
}

//Using Linq
IEnumerable<int> r = from number in numbers
                     where number % 2 == 1
                     orderby number descending
                     select number;


var r2 = numbers.Where(x => x % 2 == 1)
    .OrderByDescending(x => x)
    .Select(x => x);


var m = from c in r
        where c > 5
        select c;