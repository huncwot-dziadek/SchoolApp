using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class TeamTheBestStudents
    {
        private const string fileNameList = "list of qualified students.txt";

        private List<string> students = new List<string>();
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
            using (var writer = File.AppendText(fileNameList))
            {
                writer.WriteLine(surnameName);
            }
        }
    }
}

