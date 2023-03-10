using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class TeamTheBestStudents
    {
        public static string fileNameList = "list of qualified students.txt";

        public static List<string> students = new List<string>();

        public TeamTheBestStudents(string surname, string name)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddStudent(string surname, string name)
        {
            var surnameName = $"{this.Surname} {this.Name}";
            students.Add(surnameName);
        }

        public static void ReadInFile()
        {
            if (File.Exists(fileNameList))
            {
                using (var reader = File.OpenText(fileNameList))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        students.Add(line);
                        line = reader.ReadLine();
                    }
                }
                File.Delete(fileNameList);
            }
        }

















        //public void WriteStudents(string surname, string name)
        //{
        //    foreach (var student in students)
        //    {
        //        using (var writer = File.AppendText(fileNameList))
        //        {
        //            writer.WriteLine(student);
        //        }
        //    }
        //}

    }
}

