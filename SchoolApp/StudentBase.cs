using static SchoolApp.StudentBase;

namespace SchoolApp
{
    public abstract class StudentBase : IStudent
    {
        public StudentBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public abstract void AddSubjectGrade(float grade);

        public abstract Statistics GetStatistics();

    }
}
