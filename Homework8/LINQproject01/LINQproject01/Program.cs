using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LINQproject01
{
    class Program
    {
        public static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {


            InitializeStudent();
            WriteXML();
            ReadXML();
            OutXML();

            static void WriteXML()
            {

                System.Xml.Serialization.XmlSerializer writer =
                    new System.Xml.Serialization.XmlSerializer(typeof(List<Student>));

                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Documents/Sophomore/CS_GAU/Homework8/LINQproject01/LINQproject01/students.xml";
                System.IO.FileStream file = System.IO.File.Create(path);

                writer.Serialize(file, students);
                file.Close();
            }

            static void ReadXML(){

                System.Xml.Serialization.XmlSerializer reader =
        new System.Xml.Serialization.XmlSerializer(typeof(List<Student>));
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Documents/Sophomore/CS_GAU/Homework8/LINQproject01/LINQproject01/students.xml";

                System.IO.StreamReader file = new System.IO.StreamReader(path);
                List<Student> students = (List<Student>)reader.Deserialize(file);
                foreach (Student student in students)
                {
                    Console.WriteLine($"Studnet: {student.Name} {student.LastName}, Major: {student.Major}");
                }
                file.Close();
            }
            static void OutXML()
            {

                var filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Documents/Sophomore/CS_GAU/Homework8/LINQproject01/LINQproject01/students.xml";
                var studentData = XElement.Load(filePath);




                //List<Student> mystudentData = studentData.Descendants("Student").Where(st => (int)st.Element("StudentID") == 2);

                //List<Student> mystudentData = from stud in studentData.Descendants("Student")
                //                              select stud.Element("Name").Value;




                //foreach (Student student in students)
                //{
                //    Console.WriteLine($"Studnet: {student.Name} {student.LastName}, Major: {student.Major}");
                //}

            }
                static void InitializeStudent()
            {
                students.Add(new Student
                {
                    StudentID = 1,
                    Name = "Nino",
                    LastName = "Ninidze",
                    Major = "Computer Science"
                });

                students.Add(new Student
                {
                    StudentID = 2,
                    Name = "Neli",
                    LastName = "Chelidze",
                    Major = "Computer Engineering"
                });

                students.Add(new Student
                {
                    StudentID = 3,
                    Name = "Giorgi",
                    LastName = "Giorgadze",
                    Major = "English Literature"
                });

            }

         }
    }
}
