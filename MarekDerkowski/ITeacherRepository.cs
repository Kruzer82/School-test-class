using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarekDerkowski
{
    interface ITeacherRepository: IRepository<Teacher>
    {
        void AddLesson(Lesson lesson);
        void RemoveLesson(Lesson lesson);
    }
}
