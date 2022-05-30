using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.CRUD
{
    public class AddClass
    {
        //Add Professor --------------------------------------------------------------------------
        public static void Add(List<Professor> MyList, int Id, string FName, string LName
           , long Mobile, int NCode, string field, int TCode)
        {
            try
            {
                MyList.Add(new Professor()
                {
                    Id = Id,
                    FirstName = FName,
                    LastName = LName,
                    MobileNumber = Mobile,
                    NationalCode = NCode,
                    Field = field,
                    TeachingCode = TCode
                }
                );
            }
            catch (FormatException ex)
            {
                Console.WriteLine(" ERROR : " + ex.Message.ToString());

            }
        }

        //Add Student -----------------------------------------------------------------------------
        public static void Add(List<Student> MyList, int IdS, string FName, string LName
           , long Mobile, int NCode, int Idstudent, double grade)
        {
            try
            {
                MyList.Add(new Student()
                {
                    Id = IdS,
                    FirstName = FName,
                    LastName = LName,
                    MobileNumber = Mobile,
                    NationalCode = NCode,
                    IdStudent = Idstudent,
                    Grade = grade
                }
            );
            }
            catch (FormatException ex) 
            {
                Console.WriteLine(" ERROR : " + ex.Message.ToString());
            }

            
        }

        //Add Lesson ------------------------------------------------------------------------------
        public static void Add(Dictionary<string, int> myDictionary, List<SpecializedLesson> MyList, int IdLesson,
            string LessonName, string ProfessorName, string StudentFullName,
            string Start, string End, int Coefficient, int Score)
        {
            MyList.Add(new SpecializedLesson()
            {
                IdLesson = IdLesson,
                LessonName = LessonName,
                ProfessorName = ProfessorName,
                StudentFullName = StudentFullName,
                Start = Start,
                End = End,
                Coefficient = Coefficient,
                Score = Score
            });

            int x = MyList.Where(c => c.LessonName == LessonName).Count();
            if (myDictionary.ContainsKey(LessonName) == false)
            {
                myDictionary.Add(LessonName, x);
            }
            else 
            {
                myDictionary[LessonName] = x;
            }
            
        }

        public static void Add(Dictionary<string, int> myDictionary, List<NonSpecialistLesson> MyList,
            int IdLesson, string LessonName, string ProfessorName,
            string StudentFullName, string Start, string End, int CreditPercentage)
        {
            MyList.Add(new NonSpecialistLesson()
            {
                IdLesson = IdLesson,
                LessonName = LessonName,
                ProfessorName = ProfessorName,
                StudentFullName = StudentFullName,
                Start = Start,
                End = End,
                CreditPercentage = CreditPercentage
            });

            int x = MyList.Where(c => c.LessonName == LessonName).Count();
            if (myDictionary.ContainsKey(LessonName) == false)
            {
                myDictionary.Add(LessonName, x);
            }
            else
            {
                myDictionary[LessonName] = x;
            }
        }

    }
}
