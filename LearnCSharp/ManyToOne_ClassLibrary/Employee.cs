namespace Company
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }

        public Department dpt { get; set; }
    }
}
