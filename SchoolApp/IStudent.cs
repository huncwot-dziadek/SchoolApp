using static SchoolApp.StudentBase;

namespace SchoolApp
{
    public interface IStudent
    {
        //event GradeConvertDelegate GradeConvert;

        string Name { get; }

        string Surname { get; }

        void AddSubjectGrade(float grade);

        //void AddSubjectGrade(double grade);

        //void AddSubjectGrade(int grade);

        //void AddSubjectGrade(char grade);

        //void AddSubjectGrade(string grade);

        //void AddTestGrade(int grade);

        Statistics GetStatistics();
    }
}
