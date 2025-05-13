using EnumExample;

Student student = new Student();

student.Name = "Emran";
student.Result = ResultOptions.Pass;

Console.WriteLine((int)student.Result);