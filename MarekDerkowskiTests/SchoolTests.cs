using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarekDerkowski;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarekDerkowski.Tests
{
    [TestClass()]
    public class SchoolTests
    {
        [TestMethod()]
        public void AddOneStudentToClassTest()
        {
            Student student1 = new Student(1,"Student 1");
            List<Student> students = new List<Student>();
            students.Add(student1);
            Classes classes = new Classes(1, students, "Klasa 1");
            Assert.AreEqual(classes.students[0].Name, "Student 1", "", "Student 1 is Correct" );
        }

        [TestMethod()]
        public void AddManyStudentToClassTest()
        {
            Student student1 = new Student(1,"Student 1");
            Student student2 = new Student(2,"Student 2");
            Student student3 = new Student(3,"Student 3");
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            Classes classes = new Classes(1, students, "Klasa 1");
            Assert.AreEqual(classes.students[0].Name, "Student 1", "", "Student 1 is Correct");
            Assert.AreEqual(classes.students[1].Name, "Student 2", "", "Student 2 is Correct");
            Assert.AreEqual(classes.students[2].Name, "Student 3", "", "Student 3 is Correct");
        }

        [TestMethod()]
        public void DeleteStudentFromClassTest()
        {
            Student student1 = new Student(1,"Student 1");
            Student student2 = new Student(2,"Student 2");
            Student student3 = new Student(3,"Student 3");
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            Classes classes = new Classes(1, students, "Klasa 1");
            classes.students.RemoveAll(x => x.Name == "Student 2");
            Assert.AreEqual(classes.students[0], student1, "", "Student 1 is Correct");
            Assert.AreEqual(classes.students[1], student3, "", "Student 3 is Correct");
        }

        [TestMethod()]
        public void SetTeacherQtyTest()
        {
            List<Student> students = new List<Student>();
            Classes classes = new Classes(1, students, "Klasa 1");
            Assert.AreEqual(classes.teacherQty, 1, "", "TeacherQty is Correct");
            classes.teacherQty = 4;
            Assert.AreEqual(classes.teacherQty, 4, "", "TeacherQty is Correct after change");
        }

        [TestMethod()]
        public void SetClassesNameTest()
        {
            List<Student> students = new List<Student>();
            Classes classes = new Classes(1, students, "Klasa 1");
            Assert.AreEqual(classes.className, "Klasa 1", "", "ClassName is Correct");
            classes.className = "Klasa 4";
            Assert.AreEqual(classes.className, "Klasa 4", "", "ClassName is Correct after change");
        }

        [TestMethod()]
        public void CheckDuplicateClassNameTest()
        {
            List<Student> students = new List<Student>();
            Classes classes1 = new Classes(1, students, "Klasa 1");
            Classes classes2 = new Classes(1, students, "Klasa 1");
            Classes classes3 = new Classes(1, students, "Klasa 2");
            School school = new School();
            Assert.IsTrue(school.AddClassToSchool(classes1));
            Assert.IsFalse(school.AddClassToSchool(classes2));
            Assert.IsTrue(school.AddClassToSchool(classes3));
        }

        [TestMethod()]
        public void AddStudentToSchoolTest()
        {
            School school = new School();
            Student student1 = new Student(1, "Student 1");
            Student student2 = new Student(1, "Student 2");
            Student student3 = new Student(3, "Student 3");

            Assert.IsTrue(school.AddStudentToSchool(student1));
            Assert.IsFalse(school.AddStudentToSchool(student2));
            Assert.IsTrue(school.AddStudentToSchool(student3));
        }

        [TestMethod()]
        public void AddTeacherTest()
        {
            Lesson lesson1 = new Lesson("Lekcja 1", 1, 1);
            Lesson lesson2 = new Lesson("Lekcja 2", 2, 2);
            List<Lesson> lessons = new List<Lesson>();
            lessons.Add(lesson1);
            lessons.Add(lesson2);
            Teacher teacher = new Teacher("Nauczyciel", lessons);
            Assert.AreEqual(teacher.Name, "Nauczyciel");
            Assert.AreEqual(teacher.Lessons[0].Name, "Lekcja 1");
            Assert.AreEqual(teacher.Lessons[0].HourLesson, 1);
            Assert.AreEqual(teacher.Lessons[0].TaskQty, 1);
            Assert.AreEqual(teacher.Lessons[1].Name, "Lekcja 2");
            Assert.AreEqual(teacher.Lessons[1].HourLesson, 2);
            Assert.AreEqual(teacher.Lessons[1].TaskQty, 2);
        }
    }
}