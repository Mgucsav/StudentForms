using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForms
{
    class Student
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public DateTime BirthDate { get; set; }

        public string Gender { get; set; }
        public List<Lesson> Lessons { get; set; }
        public Student(string name, string number, DateTime birthDate, string gender)
        {
            this.Name = name;
            this.Number = number;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.Lessons = new List<Lesson>();
        }
        public void addLesson(Lesson less)
        {
            this.Lessons.Add(less);
        }

    }
}
