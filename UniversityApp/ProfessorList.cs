using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    public class ProfessorList
    {
        public static List<Professor> professor_list = new List<Professor>()
        {
            new Professor()
            {
                Id = 1 ,
                FirstName= "Hadi" ,
                LastName="Saedi" ,
                MobileNumber=0911111111,
                NationalCode= 123456789 ,
                Field="Computer" ,
                TeachingCode=4569
            },
            new Professor()
            {
                Id = 2 ,
                FirstName= "Sanaz" ,
                LastName="Mahdavi" ,
                MobileNumber=0911125411,
                NationalCode= 65826789 ,
                Field="Math" ,
                TeachingCode=7893
            },
            new Professor()
            {
                Id = 3 ,
                FirstName= "Arash" ,
                LastName="Ghorbani" ,
                MobileNumber=0911125411,
                NationalCode= 65826789 ,
                Field="Literature" ,
                TeachingCode=7893
            },

        };
    }
}
