using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarekDerkowski
{
    public class Student
    {

        public int StudentId { get; set; }
        public string Name { get; set; }

        public Student(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }
    }
}
