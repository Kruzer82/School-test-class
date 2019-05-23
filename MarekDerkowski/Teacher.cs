using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarekDerkowski
{
    public class Teacher
    {
        public string Name { get; set; }
        public List<Lesson> Lessons { get; set; }

        public Teacher(string name, List<Lesson> lessons)
        {
            Name = name;
            Lessons = lessons;
        }
    }
}
