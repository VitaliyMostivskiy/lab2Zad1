using System;

namespace mzoLista3Zad1
{
    public class Student
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public void Print()
        {
            Console.WriteLine("Name: {0}\nSurname: {1}", Name, Surname);
        }
    }
}

