namespace MyHashSet;

public class SPSStudent(string name, int yeargroup, string tutorInitials = "")
{
    private string Name { get; } = name;
    private int YearGroup { get; } = yeargroup;
    private string TutorInitials { get; } = tutorInitials;

    public override string ToString() => $"{Name}: Y{YearGroup}, {TutorInitials}";
    
    public override int GetHashCode() => HashCode.Combine(Name, YearGroup, TutorInitials);
}