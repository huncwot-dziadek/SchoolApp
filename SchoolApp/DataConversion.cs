using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class DataConversion
    {
        public static float gradeConvert;

        public DataConversion()
        {
        }

        public void RangeCheck(float grade)
        {
            DataConversion.gradeConvert = grade;
           
            //AddSubjectGrade(grade);
        }

        public void ExchangeInput(string input)
        {
            if (input.Length == 1)
            {
                int grade = 0;
                int badNumber1 = 0;

                if (input[0] >= 49 && input[0] <= 54)
                {
                    switch (input[0])
                    {
                        case '6':
                            grade += 95;
                            break;
                        case '5':
                            grade += 80;
                            break;
                        case '4':
                            grade += 60;
                            break;
                        case '3':
                            grade += 40;
                            break;
                        case '2':
                            grade += 20;
                            break;
                        case '1':
                            grade += 5;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    badNumber1++;
                }
                try
                {
                    if (badNumber1 == 0)
                    {
                        this.RangeCheck(grade);
                    }
                    else
                    {
                        Program.j--;
                        gradeConvert = -1.0f;
                        throw new Exception(message: "Incorrect input, try again");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception catched: {e.Message}");
                }
            }

            if (input.Length == 2)
            {
                int[] grade = new int[2] { 0, 0 };
                int badNumber2 = 0;

                int i = 0;

                if ((input[i] >= 49 && input[i] <= 54) && (input[i + 1] == 43 || input[i + 1] == 45))     //
                {
                    switch (input[i])
                    {
                        case '6':
                            grade[i] += 95;
                            break;
                        case '5':
                            grade[i] += 80;
                            break;
                        case '4':
                            grade[i] += 60;
                            break;
                        case '3':
                            grade[i] += 40;
                            break;
                        case '2':
                            grade[i] += 20;
                            break;
                        case '1':
                            grade[i] += 5;
                            break;
                    }
                    switch (input[i + 1])
                    {
                        case '+':
                            grade[i + 1] += 5;
                            break;
                        case '-':
                            grade[i + 1] += -5;
                            break;
                    }
                }
                else
                {
                    badNumber2++;
                }

                try
                {
                    if (badNumber2 == 0)
                    {
                        var gradeTab = (grade[0] + grade[1]);
                        var gradeTabConvert = (float)gradeTab;
                        this.RangeCheck(gradeTabConvert);
                    }

                    else
                    {
                        Program.j--;
                        gradeConvert = -1.0f;
                        throw new Exception(message: "Incorrect input, try again");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception catched: {e.Message}");
                }
            }
        }
    }
}
