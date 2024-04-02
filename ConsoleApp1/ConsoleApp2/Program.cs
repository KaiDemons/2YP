using System;

class Student
{
    public string Surname { get; set; }
    public string DateOfBirth { get; set; }
    public string GroupNumber { get; set; }
    public int[] Grades { get; set; }

    public void ChangeLastName(string newLastName)
    {
        Surname = newLastName;
    }

    public void ChangeBirthDate(string newBirthDate)
    {
        DateOfBirth = newBirthDate;
    }

    public void ChangeGroupNumber(string newGroupNumber)
    {
        GroupNumber = newGroupNumber;
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Student: {Surname}");
        Console.WriteLine($"Date of Birth: {DateOfBirth}");
        Console.WriteLine($"Group Number: {GroupNumber}");
        Console.WriteLine("Grades:");
        for (int i = 0; i < Grades.Length; i++)
        {
            Console.WriteLine($"Subject {i + 1}: {Grades[i]}");
        }
    }

    static void Main()
    {
        int[] grades = { 5, 4, 3, 5, 4 };
        
        Student student1 = new Student
        {
            Surname = "Aleksandr",
            DateOfBirth = "24.12.2005",
            GroupNumber = "Gr624",
            Grades = grades
        };
        
        student1.PrintStudentInfo();
        
        student1.ChangeLastName("Ilya");
        student1.ChangeBirthDate("20.05.2006");
        student1.ChangeGroupNumber("Gr613");
        
        student1.PrintStudentInfo();
    }
}