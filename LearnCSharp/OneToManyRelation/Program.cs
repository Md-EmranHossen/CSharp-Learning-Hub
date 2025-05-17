
using College;

Student student = new Student()
{
    RolNo = 1,
    StudentName = "Emran",
    Email = "emranhossen3075@gmail.com",
    examinations = new List<Examination>()
    {
        new Examination
        {
            ExaminationName = "Module Test 1",
            Month = 5,
            Year = 2024,
            MaxMarks = 100,
            SequreMarks = 86
        },

         new Examination
        {
            ExaminationName = "Module Test 2",
            Month = 6,
            Year = 2024,
            MaxMarks = 100,
            SequreMarks = 75
        },

          new Examination
        {
            ExaminationName = "Module Test 3",
            Month = 7,
            Year = 2024,
            MaxMarks = 90,
            SequreMarks = 68
        }
    }
};

Console.WriteLine("Roll No: " + student.RolNo);
Console.WriteLine("Name: " + student.StudentName);
Console.WriteLine("Email : " + student.Email);
Console.WriteLine("Examination Info");
foreach (var item in student.examinations)
{
    Console.WriteLine(item.ExaminationName + "," + item.Year + "," + item.Month + "," + item.SequreMarks + "/" + item.MaxMarks);
}