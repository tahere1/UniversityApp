using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    public class StudentList
    {
        public static List<Student> student_list = new List<Student>() 
        { 
            new Student(){
                Id = 5 ,
                FirstName= "Ali" ,
                LastName="Jalali" ,
                MobileNumber=091197651,
                NationalCode= 12545389 ,
                IdStudent = 96743 ,
                Grade = 15.34
            },
            new Student(){
                Id = 6 ,
                FirstName= "Sara" ,
                LastName="Hosseini" ,
                MobileNumber=09118778516,
                NationalCode= 12545389 ,
                IdStudent = 76743 ,
                Grade = 16.04
            },
            new Student(){
                Id = 8 ,
                FirstName= "Shabnam" ,
                LastName="Alavi" ,
                MobileNumber=09656438516,
                NationalCode= 12543229 ,
                IdStudent = 61543 ,
                Grade = 16.95
            }
        };
    }
}
