using ConsoleApp28.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28.Models
{
    internal class Student
    {
        static int Count = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
            Name = name.Capitalize();
            Surname = surname.Capitalize();
            Id = Count;
            Count++;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Id}. {Name} {Surname}");
        }

    }
}
