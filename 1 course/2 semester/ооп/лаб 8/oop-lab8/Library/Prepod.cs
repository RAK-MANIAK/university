using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    public class Prepod:People
    {
        public string posada;
        public string kafedra;
        public string vvnz;

        public Prepod()
        {
            posada = "викладач програмування";
            kafedra = "компютерні науки";
            vvnz = "Житомирська політехніка";
        }
        public Prepod(string posada, string kafedra, string vvnz)
        {
            this.posada = posada;
            this.kafedra = kafedra;
            this.vvnz = vvnz;
        }
        public Prepod(Prepod prev)
        {
            posada = prev.posada;
            kafedra = prev.kafedra;
            vvnz = prev.vvnz;
        }
        public string Posada
        {
            get { return posada; }
            set { posada = value; }
        }
        public string Kafedra
        {
            get { return kafedra; }
            set { kafedra = value; }
        }
        public string Vvnz
        {
            get { return vvnz; }
            set { vvnz = value; }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"---Викладач---\nІм'я:{name}\tПрізвище:{surname}\tДата.нар:{date}");
            Console.WriteLine($"Посада:{posada}\tКафедра:{kafedra}\tВНЗ:{vvnz}");
        }
    }
}
