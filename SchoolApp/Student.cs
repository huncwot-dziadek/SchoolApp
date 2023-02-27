using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolApp.StudentBase;

namespace SchoolApp
{
    internal class Student : StudentBase
    {

        //public override event GradeConvertDelegate GradeConvert;

        private List<float> grades = new List<float>();
        public Student(string name, string surname)
            : base(name, surname)
        {
        }


        public override void AddSubjectGrade(float gradeConvert)
        {
            grades.Add(gradeConvert);
        }


                //public override void AddSubjectGrade(float grade)
        //{
        //    if (grade >= 0 && grade <= 100)
        //    {

        //        //if (GradeConvert != null)
        //        //{
        //        //    this.grades.Add(DataConversion.gradeConvert);
        //        //}

        //        this.grades.Add(grade);

        //        //if (GradeAdded != null)
        //        //{
        //        //    GradeAdded(this, new EventArgs());
        //        //}
        //    }
        //    else
        //    {
        //        throw new Exception("Grade out of range");
        //    }
        //}

        //public override void AddSubjectGrade(double grade)
        //{
        //    var gradeMadeOfDouble = (float)grade;
        //    this.AddSubjectGrade(gradeMadeOfDouble);
        //}

        //public override void AddSubjectGrade(int grade)
        //{
        //    var gradeMadeOfInt = (float)grade;
        //    this.AddSubjectGrade(gradeMadeOfInt);
        //}

        //public override void AddSubjectGrade(string grade)
        //{
        //    float.Parse(grade);

        //    if (float.TryParse(grade, out float resultFloat))
        //    {
        //        this.AddSubjectGrade(resultFloat);

        //        //if (GradeAdded != null)
        //        //{
        //        //    GradeAdded(this, new EventArgs());
        //        //}
        //    }

        //    else
        //    {
        //        throw new Exception("String is not float");
        //    }

        //}
        //public override void AddSubjectGrade(char grade)
        //{
        //    switch (grade)
        //    {
        //        case 'A':
        //        case 'a':
        //            this.AddSubjectGrade(100);
        //            break;
        //        case 'B':
        //        case 'b':
        //            this.AddSubjectGrade(75);
        //            break;
        //        case 'C':
        //        case 'c':
        //            this.AddSubjectGrade(50);
        //            break;
        //        case 'D':
        //        case 'd':
        //            this.AddSubjectGrade(25);
        //            break;
        //        case 'E':
        //        case 'e':
        //            this.AddSubjectGrade(0);
        //            break;

        //    }
        //}

        public override Statistics GetStatistics()                        //bylo:  public override 
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


