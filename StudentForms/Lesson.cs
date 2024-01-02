using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForms
{
    class Lesson
    {
        public string Name { get; set; }
        public int AKTS { get; set; }
        public int Hour { get; set; }

        public Lesson(string name, int AKTS, int hour)
        {
            this.Name = name;
            this.AKTS = AKTS;
            this.Hour = hour;
        }
    }
}
