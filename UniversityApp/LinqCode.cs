using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    public class LinqCode
    {
        public static void MyLinqCode(List<SpecializedLesson> Ls, List<NonSpecialistLesson> Ln)
        {
            var AllLesson = Ls.Select(b => new {
                IdLesson = b.IdLesson,
                LessonName = b.LessonName,
                ProfessorName = b.ProfessorName,
                StudentFullName = b.StudentFullName,
                Start = b.Start,
                End = b.End,
            }).ToList();

            AllLesson.AddRange(Ln.Select(b => new
            {
                IdLesson = b.IdLesson,
                LessonName = b.LessonName,
                ProfessorName = b.ProfessorName,
                StudentFullName = b.StudentFullName,
                Start = b.Start,
                End = b.End,
            }).ToList());

            var result = from a in AllLesson
                         group a by a.ProfessorName into g
                         select new { ProfessorName = g.Key , count = g.Count()  };
            
            foreach (var item in result)
            {
                Console.WriteLine($"\t ProfessorName :  {item.ProfessorName} \t count : {item.count} ");
            }

            
        }


    }
    
}
