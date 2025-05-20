
using LinqMinAndMax;



List<Employee> employees = new List<Employee>()
{
    new Employee
    {
        EmpId = 101,Name = "Emran", Job = "Programmer", Salary = 20000
    },

    new Employee
    {
        EmpId = 102, Name = "Sajib", Job = "Developer", Salary = 10000
    },

    new Employee
    {
        EmpId = 103, Name = "Rakib", Job = "Student", Salary = 30000
    },

    new Employee
    {
        EmpId = 104, Name = "Ridwan", Job = "Desiner", Salary = 25000
    },
    new Employee
    {
        EmpId = 105, Name = "Anik", Job = "Developer", Salary = 17000
    }
};


double MinSalary = employees.Min(emp => emp.Salary);

double MaxSalary = employees.Max(emp => emp.Salary);

double Sum = employees.Sum(emp => emp.Salary);

double AverageSalary = employees.Average(emp => emp.Salary);

int Count = employees.Count();










