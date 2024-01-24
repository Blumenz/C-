internal class Program
{
    private static void Main(string[] args)
    {
        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";

        int course1Grade = 4;
        int course2Grade = 3;
        int course3Grade = 3;
        int course4Grade = 3;
        int course5Grade = 4;

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        int gradeA = 4;
        int gradeB = 3;

        double finalGPA = (((double) course1Grade * (double)course1Credit) + ((double)course2Grade * (double)course2Credit) + ((double)course3Grade * (double)course3Credit) + ((double)course4Grade * (double)course4Credit) + ((double)course5Grade * (double)course5Credit)) / (course1Credit + course2Credit + course3Credit + course4Credit + course5Credit);

      
        Console.WriteLine("Student: " + studentName);
        Console.WriteLine("\nCourse\t\t    Grade\tCredit Hours");
        Console.WriteLine($"{course1Name} \t\t{course1Grade}\t    {course1Credit}\n{course2Name}\t\t{course2Grade}\t    {course2Credit}\n{course3Name}\t\t{course3Grade}\t    {course3Credit}\n{course4Name}\t{course4Grade}\t    {course4Credit}\n{course5Name}\t\t{course5Grade}\t    {course5Credit}\nFinal GPA:\t\t{Math.Round(finalGPA, 2)}");
        
       
    }
}