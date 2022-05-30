using UniversityApp;
using UniversityApp.CRUD;


List <Professor> MyProfessorList = ProfessorList.professor_list;
List<Student> MyStudentList = StudentList.student_list;
List<SpecializedLesson> MySpecialistLesson = LessonList.lesson_list_specialized;
List<NonSpecialistLesson> MyNonSpecialistLesson = LessonList.lesson_list_nonspecialized;
//---------------------------------------------------------------------------------------------
//-------------------------------------- ADD --------------------------------------------------

Console.WriteLine("--------------------- Professor List ------------------------");
AddClass.Add(MyProfessorList, 4,"Nahal","Nazari", 123445, 1312423, "Physics",34332);
PrintClass.Prints(MyProfessorList);

Console.WriteLine("--------------------- Student List --------------------------");
try {
    Console.WriteLine(" Enter Mobile number for student Iman Golpour:");
    long Mobile_Number = Convert.ToInt64(Console.ReadLine());
    AddClass.Add(MyStudentList, IdS: 10, "Iman", "Golpour", Mobile: Mobile_Number, 123456789, Idstudent: 23613, grade: 15.24);
}
catch (FormatException ex) 
{
    Console.WriteLine(" ERROR : " + ex.Message.ToString());
}

AddClass.Add(MyStudentList, IdS: 11, "Shadi", "Azimi", Mobile: 0945644551, 987456789, Idstudent: 47613, grade: 14.05);
PrintClass.Prints(MyStudentList);

Console.WriteLine("---------------------- Lesson List --------------------------");
Dictionary<string, int> d = ClassDictionary.Course;
AddClass.Add(d, MySpecialistLesson, 41, "Computer", "Hadi Saedi", "Soheil Khanpour", "1/1/2022", "1/3/2022", Coefficient: 3, Score: 70);
AddClass.Add(d, MySpecialistLesson, 42, "Computer", "Hadi Saedi", "Shadi Azimi", "1/1/2022", "1/3/2022", Coefficient: 3, Score: 70);
AddClass.Add(d, MyNonSpecialistLesson, 39, "Literature", "Arash Ghorbani", "Shadi Azimi", "7/1/2022", "25/3/2022", CreditPercentage: 40);
Console.WriteLine("--------------------Specialist Lesson List-----------------------------");
PrintClass.Prints(MySpecialistLesson);
Console.WriteLine("--------------------NonSpecialist Lesson List-----------------------------");
PrintClass.Prints(MyNonSpecialistLesson);
PrintClass.Prints(d);

//---------------------------------------------------------------------------------------------
//----------------------------------------- Edit -----------------------------------------------

Console.WriteLine("----------------------- Edit Professor -----------------------------------------");
EditClass.Edit(MyProfessorList, ID: 2, FirstName: "Sajad" , MobileNumber:94444444444);
PrintClass.Prints(MyProfessorList);
Console.WriteLine("----------------------- Edit Student -----------------------------------------");
EditClass.Edit(MyStudentList, ID: 47613, FirstName: "Zahra", Grade: 18);
PrintClass.Prints(MyStudentList);
Console.WriteLine("----------------------- Edit NonSpecialist Lesson -----------------------------------------");
EditClass.Edit(MyNonSpecialistLesson, ID: 39, StudentFullName: "Zahra Azimi", CreditPercentage: 45);
PrintClass.Prints(MyNonSpecialistLesson);
Console.WriteLine("----------------------- Edit NonSpecialist Lesson -----------------------------------------");
EditClass.Edit(MySpecialistLesson, ID: 42, StudentFullName: "Zahra Azimi", Coefficient: 3, Score: 90);
PrintClass.Prints(MyNonSpecialistLesson);

//---------------------------------------------------------------------------------------------
//----------------------------------------- Delete ---------------------------------------------

DeleteClass.Delete(MyProfessorList , 1);
DeleteClass.Delete(MyStudentList , 23613);
DeleteClass.Delete(MySpecialistLesson, 41);
DeleteClass.Delete(MyNonSpecialistLesson, 39);
Console.WriteLine("-------------------- Professor List After Delete-------------------------------");
PrintClass.Prints(MyProfessorList);
Console.WriteLine("-------------------- Student List After Delete---------------------------------");
PrintClass.Prints(MyStudentList);
Console.WriteLine("-------------------- Specialist Lesson List After Delete------------------------");
PrintClass.Prints(MySpecialistLesson);
Console.WriteLine("-------------------- NonSpecialist Lesson List After Delete---------------------");
PrintClass.Prints(MyNonSpecialistLesson);


//---------------------------------------------------------------------------------------------
//------------------------------------------ Linq Query----------------------------------------

Console.WriteLine("------------------------ Linq Query ---------------------------");
LinqCode.MyLinqCode(MySpecialistLesson , MyNonSpecialistLesson);


Console.ReadKey();