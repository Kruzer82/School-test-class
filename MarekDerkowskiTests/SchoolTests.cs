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
        public void AddOneStudentToClassByConstructorTest()
        {
            Student student1 = new Student(1,"Student 1");
            List<Student> students = new List<Student>();
            students.Add(student1);
            Classes classes = new Classes(1, students, "Klasa 1");
            Assert.AreEqual(classes.students.ElementAt(0).StudentId, 1);
            Assert.AreEqual(classes.students.ElementAt(0).Name, "Student 1");
        }

        [TestMethod()]
        public void AddManyStudentToClassByConstructorTest()
        {
            Student student1 = new Student(1, "Student 1");
            Student student2 = new Student(2, "Student 2");
            Student student3 = new Student(3, "Student 3");
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            Classes classes = new Classes(1, students, "Klasa 1");
            Assert.AreEqual(classes.students.ElementAt(0).StudentId, 1);
            Assert.AreEqual(classes.students.ElementAt(1).StudentId, 2);
            Assert.AreEqual(classes.students.ElementAt(2).StudentId, 3);
            Assert.AreEqual(classes.students.ElementAt(0).Name, "Student 1");
            Assert.AreEqual(classes.students.ElementAt(1).Name, "Student 2");
            Assert.AreEqual(classes.students.ElementAt(2).Name, "Student 3");
        }

        [TestMethod()]
        public void AddManyStudentToClassByFunctionTest()
        {
            Student student1 = new Student(1, "Student 1");
            Student student2 = new Student(2, "Student 2");
            Student student3 = new Student(3, "Student 3");
            List<Student> students = new List<Student>();
            Classes classes = new Classes(1, students, "Klasa 1");
            classes.AddStudentToClass(student1);
            classes.AddStudentToClass(student2);
            classes.AddStudentToClass(student3);
            Assert.AreEqual(classes.students.ElementAt(0).Name, "Student 1");
            Assert.AreEqual(classes.students.ElementAt(0).StudentId, 1);
            Assert.AreEqual(classes.students.ElementAt(1).Name, "Student 2");
            Assert.AreEqual(classes.students.ElementAt(1).StudentId, 2);
            Assert.AreEqual(classes.students.ElementAt(2).Name, "Student 3");
            Assert.AreEqual(classes.students.ElementAt(2).StudentId, 3);
        }


        [TestMethod()]
        public void AddManyStudentToClassByFunction2Test()
        {

            List<Student> students = new List<Student>();
            Classes classes = new Classes(1, students, "Klasa 1");
            classes.AddStudentToClass(1, "Student 1");
            classes.AddStudentToClass(2, "Student 2");
            classes.AddStudentToClass(3, "Student 3");
            Assert.AreEqual(classes.students.ElementAt(0).Name, "Student 1");
            Assert.AreEqual(classes.students.ElementAt(0).StudentId, 1);
            Assert.AreEqual(classes.students.ElementAt(1).Name, "Student 2");
            Assert.AreEqual(classes.students.ElementAt(1).StudentId, 2);
            Assert.AreEqual(classes.students.ElementAt(2).Name, "Student 3");
            Assert.AreEqual(classes.students.ElementAt(2).StudentId, 3);
        }
        [TestMethod()]
        public void AddDuplicateStudentToClassByFunctionTest()
        {
            Student student1 = new Student(1, "Student 1");
            Student student2 = new Student(1, "Student 1");
            Student student3 = new Student(3, "Student 3");
            List<Student> students = new List<Student>();
            Classes classes = new Classes(1, students, "Klasa 1");
            Assert.IsTrue(classes.AddStudentToClass(student1));
            Assert.IsFalse(classes.AddStudentToClass(student2));
            Assert.IsTrue(classes.AddStudentToClass(student3));
            Assert.AreEqual(classes.students.ElementAt(0).Name, "Student 1");
            Assert.AreEqual(classes.students.ElementAt(0).StudentId, 1);
            Assert.AreEqual(classes.students.ElementAt(1).Name, "Student 3");
            Assert.AreEqual(classes.students.ElementAt(1).StudentId, 3);
        }

        [TestMethod()]
        public void AddStudentListAndClassesListToSchool()
        {
            Student student1 = new Student(1, "Student 1");
            Student student2 = new Student(2, "Student 2");
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            Classes classes1 = new Classes(1, students, "Klasa 1");
            Classes classes2 = new Classes(2, students, "Klasa 2");
            List<Classes> classes = new List<Classes>();
            School school = new School(classes, students);
            Assert.AreEqual(school.classes, classes);
            Assert.AreEqual(school.student, students);
        }

        [TestMethod()]
        public void DeleteStudentFromClassTest()
        {
            Student student1 = new Student(1, "Student 1");
            Student student2 = new Student(2, "Student 2");
            Student student3 = new Student(3, "Student 3");
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            Classes classes = new Classes(1, students, "Klasa 1");
            classes.students.RemoveAll(x => x.Name == "Student 2");
            Assert.AreEqual(classes.students[0], student1);
            Assert.AreEqual(classes.students[1], student3);
        }

        [TestMethod()]
        public void SetTeacherQtyTest()
        {
            List<Student> students = new List<Student>();
            Classes classes = new Classes(1, students, "Klasa 1");
            Assert.AreEqual(classes.teacherQty, 1, "");
            classes.teacherQty = 4;
            Assert.AreEqual(classes.teacherQty, 4, "");
        }

        [TestMethod()]
        public void SetClassesNameTest()
        {
            List<Student> students = new List<Student>();
            Classes classes = new Classes(1, students, "Klasa 1");
            Assert.AreEqual(classes.className, "Klasa 1");
            classes.className = "Klasa 4";
            Assert.AreEqual(classes.className, "Klasa 4");
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