using System;
namespace Presentation
{
    class StudentDetails
    {
        Student st = new Student("John", "Anylast", 3.9f);
        Student st2 = new Student(13, "George", "Glastname", 4.2f);
        public void displayOutput()
        {
            Console.WriteLine("{0} {1}'s GPA is {2:F2}", st.FirstName, st.LastName, st.GPA);
            Console.WriteLine("Student ID is {0}. {1}'s GPA is {2:F2}", st2.StudentId,st2.FirstName, st2.LastName, st2.GPA);

        }
    }

    
}
