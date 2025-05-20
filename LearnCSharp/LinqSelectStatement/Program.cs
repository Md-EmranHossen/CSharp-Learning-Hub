
using LinqSelectStatement;

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


IEnumerable<Person> result = employees.Select(emp => new Person()
{
    PersonName = emp.Name
});

foreach (var item in result)
{
    Console.WriteLine(item.PersonName);
}