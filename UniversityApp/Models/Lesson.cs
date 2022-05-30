using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    public abstract class Lesson
    {
        public int IdLesson { get; set; }
        public string LessonName { get; set; }
        public string ProfessorName { get; set; }
        public string StudentFullName { get; set; }
        public string Start { get; init; }
        public string End { get; set; }
    }
}
