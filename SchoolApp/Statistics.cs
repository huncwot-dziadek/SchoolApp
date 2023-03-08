using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Statistics
    {
        public float Max { get; private set; }
        public float Min { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }
        public void AddSubjectGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Max = Math.Max(this.Max, grade);
            this.Min = Math.Min(this.Min, grade);
        }
    }
}



