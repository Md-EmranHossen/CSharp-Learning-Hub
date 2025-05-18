using LinqOrderBy;

List<Employee> employees = new List<Employee>()
{
    new Employee
    {
        EmpId = 101,Name = "Emran", Job = "Programmer", City = "Dhaka"
    },

    new Employee
    {
        EmpId = 102, Name = "Sajib", Job = "Developer", City = "Mymenshing"
    },

    new Employee
    {
        EmpId = 103, Name = "Rakib", Job = "Student", City = "Khulna"
    },

    new Employee
    {
        EmpId = 104, Name = "Ridwan", Job = "Desiner", City = "Cumilla"
    },
    new Employee
    {
        EmpId = 105, Name = "Anik", Job = "Developer", City = "Barishal"
    }
};

IEnumerable<Employee> result = employees.OrderBy(emp => emp.Job).ThenBy(emp => emp.City);
IEnumerable<Employee> result2 = employees.OrderByDescending(emp => emp.Name).ThenBy(emp => emp.EmpId);


foreach (var it in result)
{
    Console.WriteLine(it.Name);
}

Console.WriteLine();

foreach (var it in result2)
{
    Console.WriteLine(it.Name);
}