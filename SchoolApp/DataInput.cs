using SchoolApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolApp
{
    public class DataInput
    {
        public void DataIn(string number)
        {
            var dataConversion = new DataConversion();
            //var student = new Student(name, surname);

            while (true)
            {
                Console.WriteLine("Give a rating:");
                //var number = Console.ReadLine();

                if (number == "q" || number == "Q")
                {
                    break;
                }

                if (number.Length == 1 || number.Length == 2)
                {
                    dataConversion.ExchangeInput(number);
                }

                else
                {
                    try
                    {
                        float.TryParse(number, out var value);

                        if (value != 0)
                        {
                            dataConversion.ConversionGrade(value);
                        }
                        else
                        {
                            throw new Exception(message: "Grade is not float");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Exception catched: {e.Message}");
                    }
                }

                //if (DataConversion.gradeConvert >= 0)
                //{
                //    student.AddSubjectGrade(DataConversion.gradeConvert);
                //}

            }
        }
    }
}
