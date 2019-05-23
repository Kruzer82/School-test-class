using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarekDerkowski
{

    public class Classes
    {
        public int teacherQty { get; set; }
        public List<Student> students { get; set; }
        public string className { get; set; }

        public Classes(int teacherQty, List<Student> students, string className)
        {
            this.teacherQty = teacherQty;
            this.students = students;
            this.className = className;
        }

        public bool AddStudentToClass(int studentId, string name)
        {
            foreach (Student item in students)
            {
                if (item.StudentId == studentId)
                {
                    return false;
                }
            }
            students.Add(new Student(studentId,name));
            return true;
        }

        public bool AddStudentToClass(Student student)
        {
            foreach (Student item in students)
            {
                if (item.StudentId == student.StudentId)
                {
                    return false;
                }
            }
            students.Add(new Student(student.StudentId, student.Name));
            return true;
        }
    }
}
