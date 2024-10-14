using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Subject
    {
        public string Title { get; }
        public int Hours { get; }
        public List<string> Tasks { get; set; }
        public Subject(string title, int hours)
        {
            Title = title;
            Hours = hours;
            Tasks = new List<string>();
        }
        public void AddTask(string taskTitle)
        {
            if(!Tasks.Contains(taskTitle))
            {
                throw new ArgumentException("такое задание уже есть в предмете");
            }
            else
                Tasks.Add(taskTitle);
        }
    }
}