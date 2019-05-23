using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarekDerkowski
{
    public class Lesson
    {
        public string Name { get; set; }
        public int HourLesson { get; set; }
        public int TaskQty { get; set; }

        public Lesson(string name, int hourLesson, int taskQty)
        {
            Name = name;
            HourLesson = hourLesson;
            TaskQty = taskQty;
        }

    }

}
