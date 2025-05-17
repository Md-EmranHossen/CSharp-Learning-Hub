using College;


Student student = new Student()
{
    RolNo = 1,
    StudentName = "Emran",
    Email = "emranhossen3075@gmail.com",
    branch = new Branch()
    {
        BranchName = "Computer Science",
        NoOfSemesters = 8
    }
};

Console.WriteLine(student.RolNo);
Console.WriteLine(student.StudentName);
Console.WriteLine(student.Email);
Console.WriteLine(student.branch.BranchName);
Console.WriteLine(student.branch.NoOfSemesters);

