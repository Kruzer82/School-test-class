using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarekDerkowski
{
    public class TeacherRepository : ITeacherRepository
    {
        private Teacher teacher = null;
        public void Add(Teacher item)
        {
            teacher = item;
        }

        public void AddLesson(Lesson lesson)
        {
            teacher.Lessons.Add(lesson);
        }

        public Teacher Get()
        {
            return teacher;
        }

        public void Remove(Teacher item)
        {
            teacher = null;
        }

        public void RemoveLesson(Lesson lesson)
        {
            teacher.Lessons.Remove(lesson);
        }

        public void Update(Teacher item)
        {
            teacher = item;
        }


    }
}
