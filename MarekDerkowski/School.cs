using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace MarekDerkowski
{
    public class School
    {
        List<Classes> classes;
        List<Student> student;

        public School()
        {
            this.classes = new List<Classes>();
            this.student = new List<Student>();
        }

        public School(List<Classes> classes, List<Student> student)
        {
            this.classes = classes;
            this.student = student;
        }

        public bool AddClassToSchool(Classes classesToAdd)
        {
            foreach (Classes item in classes)
            {
                if (item.className.Equals(classesToAdd.className))
                {
                    return false;
                }
            }
            classes.Add(classesToAdd);
            return true;
        }

        public bool AddStudentToSchool(Student studentToAdd)
        {
            foreach (Student item in student)
            {
                if (item.StudentId == studentToAdd.StudentId)
                {
                    return false;
                }
            }
            student.Add(studentToAdd);
            return true;
        }
    }
}
