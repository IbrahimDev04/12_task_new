using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp28.Models
{
    internal class Group
    {
        static Group[] Groups = new Group[0];
        static int GroupCount = 1;
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public Student[] Students = new Student[0];

        public Group(string groupName)
        {
            GroupName = groupName;
            GroupId = GroupCount;
            GroupCount += 1;
            
        }


        public static void AddGroup(Group groups)
        {
            Array.Resize(ref Groups, Groups.Length+1);
            Groups[^1] = groups;
        }

        public static void RemoveGroup(int id)
        {
            var NewArr = new Group[Groups.Length-1];
            int j = 0;
            for (int i=0 ; i<Groups.Length; i++)
            {
                if (Groups[i].GroupId != id)
                {
                    NewArr[j] = Groups[i];
                    j++;
                }
            }
            Groups = NewArr;
        }

        public static Group GetGroup(int id)
        {
            foreach( Group group in Groups)
            {
                if (group.GroupId == id)
                {
                    return group;
                }
            }
            return null;
        }


        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length+1);
            Students[^1] = student;
        }

        public void GetGroupInfo()
        {
            Console.WriteLine($"{this.GroupId}. {this.GroupName}");
            foreach (Student student in this.Students)
            {
                Console.WriteLine($"{student.Id}.{student.Name} {student.Surname}");
            }
        }

        public void GetStudent(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    Console.WriteLine($"{student.Id}.{student.Name} {student.Surname}");
                }
            }
        }

        public void Search(string name)
        {
            foreach (Student student in Students)
            {
                if (student.Name == name || student.Surname == name)
                {
                    Console.WriteLine($"{student.Id}.{student.Name} {student.Surname}");
                }
            }
        }

        public void ShowStudents()
        {
            foreach (Group group in Groups)
            {
                if (this == group)
                {
                    foreach (var item in group.Students)
                    {
                        Console.WriteLine($"{item.Id} - {item.Name} {item.Surname}");
                    }
                }

            }
        }

        public virtual void ToString()
        {
            foreach (Group group in Groups)
            {
                if (this == group)
                {
                    Console.WriteLine($"{group.GroupId} {group.GroupName} - {group.Students.Length} telebe var.");
                }
            }
        }
    }
}
