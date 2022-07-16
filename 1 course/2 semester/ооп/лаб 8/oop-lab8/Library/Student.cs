using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    public class Student:Applicant
    {
        public int course;
        public string group;
        public string faculty;
        public string vnz;

        public Student()
        {
            course = 1;
            group = "ВТ";
            faculty = "ФІКТ";
            vnz = "Житомирська політехніка";
        }
        public Student(int course, string group, string faculty, string vnz)
        {
            this.course = course;
            this.group = group;
            this.faculty = faculty;
            this.vnz = vnz;
        }
        public Student(Student prev)
        {
            course = prev.course;
            group = prev.group;
            faculty = prev.faculty;
            vnz = prev.vnz;
        }
        public int Course
        {
            get { return course; }
            set { course = value; }
        }
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        public string Vnz
        {
            get { return vnz; }
            set { vnz = value; }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"---Студент---\nІм'я:{name}\tПрізвище:{surname}\tДата.нар:{date}");
            Console.WriteLine($"Курс:{course}\tГрупа:{group}\tФакультет:{faculty}\tВНЗ:{vnz}");
            Console.WriteLine($"Математика:{math}\tУкр.мова:{ukr}\tАнгл.мова:{angl}\tБал атестата:{avg}\tЗаклад:{zaklad}");
        }
    }
}
