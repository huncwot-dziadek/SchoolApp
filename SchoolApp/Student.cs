using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolApp.StudentBase;

namespace SchoolApp
{
    public class Student : StudentBase
    {            
        private List<float> grades = new List<float>();
        public Student(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddSubjectGrade(float gradeConvert)
        {
            grades.Add(gradeConvert);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddSubjectGrade(grade);
            }

            return statistics;
        }

    }
}


