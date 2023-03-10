using SchoolApp;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace SchoolApp

; public class Program
{
    static string fileName;
    public static int numberOfSubjects = 0;

    enum subject
    {
        combinatorics______,
        algebra____________,
        persistence________,
        teamwork_ability___,
        communicativeness__
    }

    private static void Main(string[] args)

    {
        Console.WriteLine("Welcome to the program WHICH STUDENT WILL ADVANCE");
        Console.WriteLine("                       ==========================");
        Console.WriteLine();
        Console.WriteLine("This is the first huncwot program");
        Console.WriteLine();
        Console.WriteLine("Here we go");
        Console.WriteLine();
        Console.Write("How many students do you want to grades?   ");

        var number = Console.ReadLine();
        var numberOfStudents = int.Parse(number);

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("Enter student details:");
            Console.Write("Name:                  ");
            var name = Console.ReadLine();

            Console.Write("Surname:               ");
            var surname = Console.ReadLine();
            var student = new Student(name, surname);
            var dataConversion = new DataConversion();
            var teamTheBestStudents = new TeamTheBestStudents(surname, name);

            fileName = $"{student.Name} {student.Surname}.txt";

            Console.WriteLine();
            Console.WriteLine("Start entering data or exit the program by pressing key Q:");
            Console.WriteLine("Your grade should be in the range: 1-, 1, 1+, 2-, 2, 2+, 3-, 3, 3+ ........ 5, 5+, 6-, 6, (6+ = perfect)");
            Console.WriteLine();
            Console.WriteLine("Give a ratings:");
            while (true)
            {
                if (numberOfSubjects <= 4)
                {
                    Console.Write($"{(subject)numberOfSubjects}");
                    numberOfSubjects++;
                }
                else
                {
                    break;
                }

                var nextInput = Console.ReadLine();

                if (nextInput == "q" || nextInput == "Q")
                {
                    break;
                }

                if (nextInput.Length == 1 || nextInput.Length == 2)
                {
                    dataConversion.ExchangeInput(nextInput);

                    if (DataConversion.gradeConvert >= 0)
                    {
                        student.AddSubjectGrade(DataConversion.gradeConvert);
                    }
                }

                else
                {
                    numberOfSubjects--;
                    Console.WriteLine("Incorrect input, try again");
                }
            }

            var statistics = student.GetStatistics();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{student.Name} {student.Surname} received {statistics.Count} ratings");
            Console.WriteLine($"Rating max:  {statistics.Max}");
            Console.WriteLine($"Rating min:  {statistics.Min}");
            Console.WriteLine($"Average ratings:  {statistics.Average:N2}");
            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.WriteLine("Save the student's results?  Y/N");
            var decision = Console.ReadLine();

            TeamTheBestStudents.ReadInFile();

            if (decision == "y" || decision == "Y")
            {
                if (statistics.Average >= 80)
                {
                    fileName = $"{student.Name} {student.Surname} is qualified.txt";
                    teamTheBestStudents.AddStudent(student.Surname, student.Name);
                }

                using (var writer = File.AppendText(Program.fileName))
                {
                    DateTime thisDay = DateTime.Today;
                    writer.WriteLine(thisDay.ToString("d"));
                    writer.WriteLine($"Ocena minimalna:    {statistics.Min}");
                    writer.WriteLine($"Ocena maksymalna:   {statistics.Max}");
                    writer.WriteLine($"Srednia ocen:       {statistics.Average:N2}");
                }
            }
            numberOfSubjects = 0;
        }

        TeamTheBestStudents.students.Sort();

        foreach (var student in TeamTheBestStudents.students)
        {
            using (var writer = File.AppendText(TeamTheBestStudents.fileNameList))
            {
                writer.WriteLine(student);
            }
        }
    }
}



