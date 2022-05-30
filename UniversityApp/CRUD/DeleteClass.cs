using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.CRUD
{
    public class DeleteClass
    {
        public static void Delete(List<Professor> p, int ID)
        {
            for (int i=0; i<p.Count; i++) 
            { 
                if(p[i].Id == ID)
                    p.RemoveAt(i);
            }
        }
        public static void Delete(List<Student> s, int ID)
        {
            for (int i = 0; i < s.Count; i++)
            {
                if (s[i].IdStudent == ID)
                    s.RemoveAt(i);
            }
        }

        public static void Delete(List<SpecializedLesson> ls, int ID)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].IdLesson == ID)
                    ls.RemoveAt(i);
            }
        }
        public static void Delete(List<NonSpecialistLesson> ln, int ID)
        {
            for (int i = 0; i < ln.Count; i++)
            {
                if (ln[i].IdLesson == ID)
                    ln.RemoveAt(i);
            }
        }
    }
}
