using SchoolApp;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace SchoolApp

; public class Program
{
    static string fileName;
    public static int j = 0;

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
        Console.WriteLine("Welcome to the program WHAT STUDENT");
        Console.WriteLine("                       =============");
        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Enter student details:");
            Console.Write("Name:                  ");
            var name = Console.ReadLine();

            Console.Write("Surname:               ");
            var surname = Console.ReadLine();
            var student = new Student(name, surname);
            var dataConversion = new DataConversion();

            fileName = $"{student.Name} {student.Surname}.txt";

            Console.WriteLine();
            Console.WriteLine("Start entering data or exit the program by pressing key Q:");
            Console.WriteLine("Your grade should be in the range: 1-, 1, 1+, 2-, 2, 2+, 3-, 3, 3+ ........ 5, 5+, 6-, 6, (6+ = perfect)");
            Console.WriteLine();
            Console.WriteLine("Give a ratings:");
            while (true)
            {
                if (j <= 4)
                {
                    Console.Write($"{(subject)j}");                    
                    j++;
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
                    j--;
                    Console.WriteLine("Incorrect input, try again");
                }

                //if (DataConversion.gradeConvert >= 0)
                //{
                //    student.AddSubjectGrade(DataConversion.gradeConvert);
                //}
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

            if (decision == "y" || decision == "Y")
            {
                if (statistics.Average >= 80)
                {
                    fileName = $"{student.Name} {student.Surname} is qualified.txt";
                    var teamTheBestStudents = new TeamTheBestStudents(student.Surname, student.Name);
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
            j = 0;

        }
    }
}



