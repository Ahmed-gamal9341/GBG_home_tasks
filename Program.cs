class Student
{
    public string Name { get; set; }
    public List<int> Scores { get; set; }

    public int GetAverageScore(List<int> Scores)
    {
        if (Scores == null || Scores.Count == 0)
            return 0;

        int total = 0;
        foreach (var score in Scores)
        {
            total += score;
        }
        return total / Scores.Count;
    }

    public string GetLetterGrade()
    {
        int averageScore = GetAverageScore(Scores);
        if (averageScore >= 90)
            return "A";
        else if (averageScore >= 80)
            return "B";
        else if (averageScore >= 70)
            return "C";
        else if (averageScore >= 60)
            return "D";
        else
            return "F";
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Average Score: {GetAverageScore(Scores)}");
        Console.WriteLine($"Letter Grade: {GetLetterGrade()}");
    }

    public static void Main(string[] args)
    {
        Student student = new Student
        {
            Name = "Ahmed Gamal",
            Scores = new List<int> { 85, 92, 78, 90 }
        };

        student.PrintStudentInfo();
    }
}
