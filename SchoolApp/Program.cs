using SchoolApp;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace SchoolApp

; public class Program
{
    static string fileName;
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program WHAT STUDENT");
        Console.WriteLine("                       =============");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Enter student details:");
        Console.Write("Name:                  ");
        var name = Console.ReadLine();

        Console.Write("Surname:               ");
        var surname = Console.ReadLine();
        var student = new Student(name, surname);
        var dataInput = new DataInput();
        var dataConversion = new DataConversion();


        fileName = $"{student.Name} {student.Surname}";

        Console.WriteLine();
        Console.WriteLine("Start entering data or exit the program by pressing key Q:");
        Console.WriteLine("Your grade should be in the range: 1-, 1, 1+, 2-, 2, 2+, 3-, 3, 3+ ........ 5, 5+, 6-, 6, (6+ = perfect)");

        while (true)
        {
            Console.WriteLine("Give a rating:");
            var nextInput = Console.ReadLine();
           
            if (nextInput == "q" || nextInput == "Q")
            {
                break;
            }

            if (nextInput.Length == 1 || nextInput.Length == 2)
            {
                dataConversion.ExchangeInput(nextInput);
            }

            else
            {
                try
                {
                    float.TryParse(nextInput, out var value);

                    if (value != 0)
                    {
                        dataConversion.ConversionGrade(value);
                    }
                    else
                    {
                        throw new Exception(message: "Grade is not float");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception catched: {e.Message}");
                }
            }

            if (DataConversion.gradeConvert >= 0)
            {
                student.AddSubjectGrade(DataConversion.gradeConvert);
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

        if (decision == "y" || decision == "Y")
        {
            using (var writer = File.AppendText(Program.fileName))
            {
                DateTime thisDay = DateTime.Today;
                writer.WriteLine(thisDay.ToString("d"));
                writer.WriteLine($"Ocena minimalna:   {statistics.Min}");
                writer.WriteLine($"Ocena maksymalna:   {statistics.Max}");
                writer.WriteLine($"Srednia ocen:   {statistics.Average:N2}");

            }
        }
    }
}



