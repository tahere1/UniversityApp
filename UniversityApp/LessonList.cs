using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    public class LessonList
    {
        public static List<SpecializedLesson> lesson_list_specialized = new List<SpecializedLesson>() 
        {
            new SpecializedLesson() 
            {
                IdLesson = 46 ,
                LessonName = "Computer",
                ProfessorName  = "Hadi Saedi", 
                StudentFullName  = "Ali Jalali",
                Start = "1/1/2022",
                End = "1/3/2022" ,
                Coefficient =  3,
                Score = 70
            },
            new SpecializedLesson()
            {
                IdLesson = 47 ,
                LessonName = "Computer",
                ProfessorName  = "Hadi Saedi",
                StudentFullName  = "Sara Hosseini",
                Start = "1/1/2022",
                End = "1/3/2022" ,
                Coefficient =  3,
                Score = 70
            }
        };

        public static List<NonSpecialistLesson> lesson_list_nonspecialized = new List<NonSpecialistLesson>() 
        {
            new NonSpecialistLesson()
            {
                IdLesson = 36 ,
                LessonName= "Literature",
                ProfessorName  = "Arash Ghorbani",
                StudentFullName  = "Sara Hosseini",
                Start = "7/1/2022",
                End = "25/3/2022" ,
                CreditPercentage = 40
            },
            new NonSpecialistLesson()
            {
                IdLesson = 37 ,
                LessonName= "Literature",
                ProfessorName  = "Arash Ghorbani",
                StudentFullName  = "Shabnam Alavi",
                Start = "7/1/2022",
                End = "25/3/2022" ,
                CreditPercentage = 40
            },
            new NonSpecialistLesson()
            {
                IdLesson = 38 ,
                LessonName= "Literature",
                ProfessorName  = "Arash Ghorbani",
                StudentFullName  = "Ali Jalali",
                Start = "7/1/2022",
                End = "25/3/2022" ,
                CreditPercentage = 40
            }
        };

    }
}
