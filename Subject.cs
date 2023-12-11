namespace GA_StudentAdmin.ConsoleApp;

//  Egenskaper: Fagkode, Fagnavn, AntallStudiepoeng.
//  Metode: SkrivUtInfo() som skriver ut informasjon om faget.

public class Subject
{
    public string SubjectName { get; set; }
    public string SubjectCode { get; set; }
    public int SubjectPoints { get; set; }

    public List<Subject> SubjectList {  get; set; } = new List<Subject>();

    public Subject()
    {
     
    }
    public void Initialize(string subjectName, string subjectCode, int subjectPoints)
    {
        SubjectName = subjectName;
        SubjectCode = subjectCode;
        SubjectPoints = subjectPoints;
    }

    public void AddSubject(Subject subject)
    {
        {
            SubjectList.Add(new Subject { SubjectName = "Databaser", SubjectCode = "DRI104", SubjectPoints = 6 });
            SubjectList.Add(new Subject { SubjectName = "Datakommunikasjon og Infrastruktur", SubjectCode = "DRI103", SubjectPoints = 6});
        };
    }

    public void ShowSubjectInfo()
    {
        foreach (var subject in SubjectList)
        {
            Console.WriteLine($"{subject.SubjectName}");
        }
    }
}