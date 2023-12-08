namespace GA_StudentAdmin.ConsoleApp;

//  Egenskaper: Fagkode, Fagnavn, AntallStudiepoeng.
//  Metode: SkrivUtInfo() som skriver ut informasjon om faget.

public class Subject
{
    public List<Subject> Subjects { get; set; }
    public string SubjectName;
    public string SubjectCode;
    public int SubjectPoints;

    public Subject(string subjectName, string subjectCode, int subjectPoints)
    {
        Subjects = new List<Subject>();
        SubjectName = subjectName;
        SubjectCode = subjectCode;
        SubjectPoints = subjectPoints;
    }

    public void ShowSubjectInfo()
    {
        foreach (var subject in Subjects)
        {
            Console.WriteLine($"{subject}");
        }
    }
}