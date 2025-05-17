using Company;

Department department = new Department()
{
    DepartmentId = 1,
    Name = "IT"
};

Employee employee1 = new Employee()
{
    EmployeeID = 1,
    EmployeeName = "Emran",
    Email = "emranhossen3075@gmal.com",
    dpt = department
};



Employee employee2 = new Employee()
{
    EmployeeID = 2,
    EmployeeName = "Rakib",
    Email = "rakib@gmal.com",
    dpt = department

};



Employee employee3 = new Employee()
{
    EmployeeID = 3,
    EmployeeName = "Sajib",
    Email = "sajib@gmal.com",
    dpt = department
};

Console.WriteLine("First Employee");
Console.WriteLine("Employee ID : " + employee1.EmployeeID);
Console.WriteLine("Employee Name : " + employee1.EmployeeName);
Console.WriteLine("Email : " + employee1.Email);
Console.WriteLine("Department ID:" + employee1.dpt.DepartmentId);
Console.WriteLine("Department Name:" + employee1.dpt.Name);



Console.WriteLine("\nSecond Employee");
Console.WriteLine("Employee ID : " + employee2.EmployeeID);
Console.WriteLine("Employee Name : " + employee2.EmployeeName);
Console.WriteLine("Email : " + employee2.Email);
Console.WriteLine("Department ID:" + employee2.dpt.DepartmentId);
Console.WriteLine("Department Name:" + employee2.dpt.Name);

