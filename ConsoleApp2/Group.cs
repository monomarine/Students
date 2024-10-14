using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Group
    {
        public string Title { get; }
        public List<Student> Students { get; }
        public Group(string title)
        {
            Title = title;
            Students = new List<Student>(); 
        }
        public void AddStudent(Student strudent)
        {
            if (!Students.Contains(strudent))
                Students.Add(strudent);
            else
                throw new ArgumentException("студент уже зачислен в группу");
        }

        public bool ExpelStudent(int stidentId)
        {
            foreach (Student student in Students)
            {
                if(student.ID == stidentId)
                {
                    Students.Remove(student);
                    return true;    
                }
            }
            return false;
        }

        public override string ToString()
        {
            string result = $"список студентов группы {Title}\n";
            int i = 1;
            foreach (Student student in Students)
            {
                result += $"{i}: {student}\n";
                i++;
            }
            return result ;
        }
    }
}