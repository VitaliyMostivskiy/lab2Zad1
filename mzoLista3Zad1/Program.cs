using System.Collections.Generic;
using System.IO;

namespace mzoLista3Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = GetStudents("zad1.csv");

            foreach (var student in students)
            {
                student.Print();
            }
        }

        private static List<Student> GetStudents(string path)
        {
            List<Student> students = new List<Student>();

            using (var file = new StreamReader(path))
            {
                string line = "";
                while ((line = file.ReadLine()) != null)
                {
                    var parts = line.Split("><".ToCharArray());
                    students.Add(new Student { Name = parts[1], Surname = parts[3] });
                }
            }

            return students;
        }
    }
}
