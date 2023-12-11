namespace GA_StudentAdmin.ConsoleApp;

    //Egenskaper: Navn, Alder, Studieprogram, StudentID.
    //Metode: SkrivUtInfo() som skriver ut informasjon om studenten.

public class Student
{
    public string StudentName { get; set; }
    public int StudentAge { get; set; }
    public int StudentId { get; set;}
    public string StudyProgram { get; set; }

    List<Student> StudentList { get; set; } = new List<Student>();

    public Student(string studentName, int studentAge, int studentID, string studyProgram)
    {
        StudentName = studentName;
        StudentAge = studentAge;
        StudentId = studentID;
        StudyProgram = studyProgram;
    }

    public void ShowInfo()
    {
        foreach (var student in StudentList)
        {
            Console.WriteLine($"{student}");
        }
    }
}