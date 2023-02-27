using static SchoolApp.StudentBase;

namespace SchoolApp
{
    public abstract class StudentBase : IStudent
    {
        //public abstract event GradeConvertDelegate GradeConvert;

        public StudentBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }


        public abstract void AddSubjectGrade(float grade);

        //public abstract void AddSubjectGrade(double grade);

        //public abstract void AddSubjectGrade(int grade);

        //public abstract void AddSubjectGrade(char grade);

        //public abstract void AddSubjectGrade(string grade);

        //public abstract void AddTestGrade(int grade);

        public abstract Statistics GetStatistics();
        
    }
}
