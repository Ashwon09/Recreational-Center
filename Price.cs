using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Price
    {
        public string Group { get; set; }
        public string Duration { get; set; }
        public int childWeekDays { get; set; }
        public int childWeekEnds { get; set; }
        public int adultWeekDays { get; set; }
        public int adultWeekEnds { get; set; }
        public int oldWeekDays { get; set; }
        public int oldWeekEnds { get; set; }
    }
}
