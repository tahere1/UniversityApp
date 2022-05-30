using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.CRUD
{
    public class PrintClass
    {
        public static void Prints(List<Professor> MyList) 
        {
            foreach (Professor L in MyList)
            {
                Console.WriteLine($" ID: {L.Id} \t FullName: {L.FirstName} {L.LastName} \t" +
                    $" NationalCode : {L.NationalCode} \t TeachingCode: {L.TeachingCode} \t " +
                    $"Field: {L.Field} \t MobileNumber: {L.MobileNumber}");
            }
        }
        public static void Prints(List<Student> MyList)
        {
            foreach (Student L in MyList)
            {
                Console.WriteLine($" Student ID: {L.IdStudent} \t FullName: {L.FirstName} {L.LastName} \t" +
                    $" Student Grade: {L.Grade} \t MobileNumber: {L.MobileNumber} ");
            }
        }

        public static void Prints(List<SpecializedLesson> MyList)
        {
            foreach (SpecializedLesson L in MyList)
            {
                Console.WriteLine($" SpecializedLesson ID: {L.IdLesson} \t Lesson: {L.LessonName}  \t ProfessorName: {L.ProfessorName} \t  " +
                    $"StudentFullName: {L.StudentFullName} \t Start: {L.Start} \t End: {L.End} \t" +
                    $"Coefficient: {L.Coefficient} \t Score: {L.Score} ");
            }
        }
        public static void Prints(List<NonSpecialistLesson> MyList)
        {
            foreach (NonSpecialistLesson L in MyList)
            {
                Console.WriteLine($" NonSpecialistLesson: {L.IdLesson} \t Lesson: {L.LessonName} \t  ProfessorName: {L.ProfessorName} \t  " +
                    $"StudentFullName: {L.StudentFullName} \t Start: {L.Start} \t End: {L.End} \t" +
                    $"Coefficient: {L.CreditPercentage}");
            }
        }
        public static void Prints(Dictionary<string , int> d) 
        {
            Console.WriteLine("---------------- Course Dictionary ------------------ ");
            foreach (KeyValuePair<string, int> i in d)
            {
                Console.WriteLine($"\t {i.Key}  \t {i.Value} students");
            }
            
        }
    }
}
