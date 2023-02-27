using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class DataConversion
    {
        //public event GradeConvertDelegate GradeConvert;
        //private int[] inputTab = new int[2];

        public static float gradeConvert;

        public DataConversion()
        {
        }

        public void ConversionGrade(float grade)
        {
            RangeCheck(grade);
        }
        public void ConversionGrade(double grade)
        {
            var gradeMadeOfDouble = (float)grade;
            RangeCheck(gradeMadeOfDouble);
        }
        public void ConversionGrade(int grade)
        {
            var gradeMadeOfInt = (float)grade;
            RangeCheck(gradeMadeOfInt);
        }
        public void ConversionGrade(string grade)
        {
            float.Parse(grade);

            if (float.TryParse(grade, out float resultFloat))
            {
                RangeCheck(resultFloat);
            }

            else
            {
                throw new Exception("String is not float");
            }

        }

        public void RangeCheck(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                var gradeConvert = grade;
            }
            else
            {
                throw new Exception("Grade out of range");
            }
        }

        public void ExchangeInput(string input)

        {
            if (input.Length == 1)
            {
                if (input[0] >= 1 && input[0] <= 6)    //if (!string.IsNullOrEmpty(input)) { }
                {
                    switch (input)
                    {
                        case "6":
                            gradeConvert = 100;
                            break;
                        case "5":
                            gradeConvert = 80;
                            break;
                        case "4":
                            gradeConvert = 60;
                            break;
                        case "3":
                            gradeConvert = 40;
                            break;
                        case "2":
                            gradeConvert = 20;
                            break;
                        case "1":
                            gradeConvert = 0;
                            break;
                        default:
                            break;
                    }
                    this.RangeCheck(gradeConvert);  //else
                }//{
                //    throw new Exception("Grade out of range 6");
                //}
            }

            if (input.Length == 2)
            {
                int[] grade = new int[2];

                for (int i = 0; i <= 1; i++)
                {
                    switch (input[i])
                    {
                        case '6':
                            grade[i] = 100;
                            break;
                        case '5':
                            grade[i] = 80;
                            break;
                        case '4':
                            grade[i] = 60;
                            break;
                        case '3':
                            grade[i] = 40;
                            break;
                        case '2':
                            grade[i] = 20;
                            break;
                        case '1':
                            grade[i] = 0;
                            break;
                        case '+':
                            grade[i] = 5;
                            break;
                        case '-':
                            grade[i] = -5;
                            break;

                    }

                }
                var gradeTab = (grade[0] + grade[1]);
                gradeConvert = (float)gradeTab;

                //Student.AddSubjectGrade(gradeConvert);


            }
            //else
            //{
            //    throw new Exception("Incorrect input");
            //}
        }
    }
}





//if (input.Length == 1)
//        {
//            switch (input)
//            {
//                case "6":
//                    gradeConvert = 100;
//                    break;
//                case "5":
//                    gradeConvert = 80;
//                    break;
//                case "4":
//                    gradeConvert = 60;
//                    break;
//                case "3":
//                    gradeConvert = 40;
//                    break;
//                case "2":
//                    gradeConvert = 20;
//                    break;
//                case "1":
//                    gradeConvert = 0;
//                    break;
//            }
//        }

//        else if (input.Length == 2)
//        {
//            int[] grade = new int[2];


//            for (int i = 0; i <= 1; i++)
//            {
//                switch (input[i])
//                {
//                    case '6':
//                        grade[i] = 100;
//                        break;
//                    case '5':
//                        grade[i] = 80;
//                        break;
//                    case '4':
//                        grade[i] = 60;
//                        break;
//                    case '3':
//                        grade[i] = 40;
//                        break;
//                    case '2':
//                        grade[i] = 20;
//                        break;
//                    case '1':
//                        grade[i] = 0;
//                        break;
//                    case '+':
//                        grade[i] = 5;
//                        break;
//                    case '-':
//                        grade[i] = -5;
//                        break;

//                }

//            }
//            gradeConvert = (grade[0] + grade[1]);
//        }
//        else
//        {
//throw new Exception("Incorrect input");
//        }
//    }


//public void ConversionGrade(char grade)
//{
//    switch (grade)
//    {
//        case 'A':
//        case 'a':
//            gradeConvert = 100;
//            break;
//        case 'B':
//        case 'b':
//            gradeConvert = 75;
//            break;
//        case 'C':
//        case 'c':
//            gradeConvert = 50;
//            break;
//        case 'D':
//        case 'd':
//            gradeConvert = 25;
//            break;
//        case 'E':
//        case 'e':
//            gradeConvert = 0;
//            break;

//    }
//}