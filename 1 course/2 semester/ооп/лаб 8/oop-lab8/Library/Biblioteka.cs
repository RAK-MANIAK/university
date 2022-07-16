using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    public class Biblioteka: Student
    {
        public int id;
        public string data;
        public int rozmir;

        public Biblioteka()
        {
            id = 5;
            data = "09.06.2022";
            rozmir = 50;
        }
        public Biblioteka(int id, string data, int rozmir)
        {
            this.id = id;
            this.data = data;
            this.rozmir = rozmir;
        }

        public Biblioteka(Biblioteka prev)
        {
            id = prev.id;
            data = prev.data;
            rozmir = prev.rozmir;
            name = prev.name;
            surname = prev.surname;
            date = prev.data;
            course = prev.course;
            group = prev.group;
            faculty = prev.faculty;
            vnz = prev.vnz;
            math = prev.math;
            ukr = prev.ukr;
            angl = prev.angl;
            avg = prev.avg;
            zaklad = prev.zaklad;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public int Rozmir
        {
            get { return rozmir; }
            set { rozmir = value; }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"---Користувач бібліотеки---\nІм'я:{name}\tПрізвище:{surname}\tДата.нар:{date}");
            Console.WriteLine($"Курс:{course}\tГрупа:{group}\tФакультет:{faculty}\tВНЗ:{vnz}");
            Console.WriteLine($"Математика:{math}\tУкр.Мова:{ukr}\tАнгл.Мова:{angl}\tБал атестата:{avg}\tШкола:{zaklad}");
            Console.WriteLine($"Номер:{id}\tДата видачі:{data}\tВнесок:{rozmir}");

        }
    }

}
