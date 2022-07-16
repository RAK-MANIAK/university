using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    public class Applicant: People
    {
        public int math;
        public int ukr;
        public int angl;
        public int avg;
        public string zaklad;

        public Applicant()
        {
            math = 182;
            ukr = 189;
            angl = 145;
            avg = 9;
            zaklad = "Ліцей №24";
        }

        public Applicant(int math, int ukr, int angl, int avg, string zaklad)
        {
            this.math = math;
            this.ukr = ukr;
            this.angl = angl;
            this.avg = avg;
            this.zaklad = zaklad;
        }
        public Applicant(Applicant prev)
        {
            math = prev.math;
            ukr = prev.ukr;
            angl = prev.angl;
            avg = prev.avg;
            zaklad = prev.zaklad;
        }
        public int Math
        {
            get { return math; }
            set { math = value; }
        }
        public int Ukr
        {
            get { return ukr; }
            set { ukr = value; }
        }
        public int Angl
        {
            get { return angl; }
            set { angl = value; }
        }
        public int Avg
        {
            get { return avg; }
            set { avg = value; }
        }
        public string Zaklad
        {
            get { return zaklad; }
            set { zaklad = value; }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"---Студент---\nІм'я:{name}\tПрізвище:{surname}\tДата.нар:{date}");
            Console.WriteLine($"Математика:{math}\tУкр.мова:{ukr}\tАнгл.мова:{angl}\tБал атестата:{avg}\tЗаклад:{zaklad}");
        }
    }
}
