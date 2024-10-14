using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Student : User
    {
        static int idCount = 0;
        public Dictionary<Subject, Dictionary<string, int>> Marks { get; }
        public Student(string login, string password)
        {
            Marks = new Dictionary<Subject, Dictionary<string, int>>();
            Login = login;
            Password = password;
            _id = idCount++;
        }
        public void AddMark(Subject subj, string task, int mark)
        {
            if (Marks.ContainsKey(subj)) 
            {
                if (!Marks[subj].ContainsKey(task))
                {
                    Marks[subj][task] = mark;
                }
                else
                {
                    Marks[subj].Add(task, mark);
                }
            }
            else
            {
                Marks.Add(subj, new Dictionary<string, int>());
                Marks[subj].Add(task, mark);    
            }
        }

        public double GetTotalMarks()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Login}";
        }
    }
}