using static SchoolApp.StudentBase;

namespace SchoolApp
{
    public interface IStudent
    {
        //event GradeConvertDelegate GradeConvert;

        string Name { get; }

        string Surname { get; }

        void AddSubjectGrade(float grade);
      
        Statistics GetStatistics();
    }
}
