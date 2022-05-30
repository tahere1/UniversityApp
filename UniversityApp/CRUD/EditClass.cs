using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.CRUD
{
    public class EditClass
    {
        public static void Edit(List<Professor> MyList, int ID, string FirstName = "",
            string LastName = "", string Field = "", long MobileNumber = -2) 
        {
            for (int i = 0; i < MyList.Count; i++)
            {
                if (MyList[i].Id == ID)
                {
                    if (FirstName != "") { MyList[i].FirstName = FirstName; }
                    if (LastName != "") { MyList[i].LastName = LastName; }
                    if (Field != "") { MyList[i].Field = Field; }
                    if (MobileNumber != -2) { MyList[i].MobileNumber = MobileNumber; }
                }
            }
        }
        public static void Edit(List<Student> MyList, int ID,string FirstName ="",
            string LastName="", Double Grade = -2 , long MobileNumber = -2)
        {
            for (int i = 0; i < MyList.Count; i++)
            {
                if (MyList[i].IdStudent == ID)
                {
                    if (FirstName != "") { MyList[i].FirstName = FirstName; }
                    if (LastName != "") { MyList[i].LastName = LastName; }
                    if (Grade != -2) { MyList[i].Grade = Grade; }
                    if (MobileNumber != -2) { MyList[i].MobileNumber = MobileNumber; }
                }
            }
        }
        public static void Edit(List<NonSpecialistLesson> MyList, int ID, string ProfessorName="" ,
             string StudentFullName ="" , string LessonName="" , int CreditPercentage = -1)
        {
            for (int i = 0; i < MyList.Count; i++)
            {
                if (MyList[i].IdLesson == ID)
                {
                    if (ProfessorName != "") { MyList[i].ProfessorName = ProfessorName; }
                    if (StudentFullName != "") { MyList[i].StudentFullName = StudentFullName; }
                    if (LessonName != "") { MyList[i].LessonName = LessonName;}
                    if (CreditPercentage != -1) { MyList[i].CreditPercentage = CreditPercentage; }
                }

            }
        }

        public static void Edit(List<SpecializedLesson> MyList, int ID, string ProfessorName = ""
            , string StudentFullName = "", string LessonName = "", int Coefficient = -2 , int Score = -2)
        {
            for (int i = 0; i < MyList.Count; i++)
            {
                if (MyList[i].IdLesson == ID)
                {
                    if (ProfessorName != "") { MyList[i].ProfessorName = ProfessorName; }
                    if (StudentFullName != "") { MyList[i].StudentFullName = StudentFullName; }
                    if (LessonName != "") { MyList[i].LessonName = LessonName; }
                    if (Coefficient != -2) { MyList[i].Coefficient = Coefficient; }
                    if (Score != -2) { MyList[i].Score = Score; }

                }

            }
        }
    }
}
