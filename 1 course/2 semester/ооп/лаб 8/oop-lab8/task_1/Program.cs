namespace lab_8
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int fl;
            Applicant appl = new Applicant();
            Student stud = new Student();
            Biblioteka bibl = new Biblioteka();
            Prepod prep = new Prepod();

            Console.WriteLine("---Абітурієнт---\n[1]По замовчуванню\n[2]Ввести дані");
            while (!int.TryParse(Console.ReadLine(), out fl))
            {
                Console.WriteLine("Помилка введення!");
            }

            if(fl == 2)
            {
                Console.Write("Ім'я:");
                appl.Name = Console.ReadLine();

                Console.Write("Прізвище:");
                appl.Surname = Console.ReadLine();

                Console.Write("Дата народження:");
                appl.Date = Console.ReadLine();

                Console.Write("Математика:");
                while (!int.TryParse(Console.ReadLine(), out fl))
                {
                    Console.WriteLine("Помилка введення!");
                }
                appl.Math = fl;

                Console.Write("Укр.мова:");
                while (!int.TryParse(Console.ReadLine(), out fl))
                {
                    Console.WriteLine("Помилка введення!");
                }
                appl.Ukr = fl;

                Console.Write("Англ.мова:");
                while (!int.TryParse(Console.ReadLine(), out fl))
                {
                    Console.WriteLine("Помилка введення!");
                }
                appl.Angl = fl;

                Console.Write("Бал атестата:");
                while (!int.TryParse(Console.ReadLine(), out fl))
                {
                    Console.WriteLine("Помилка введення!");
                }
                appl.Avg = fl;

                Console.Write("Навчальний заклад:");
                appl.Zaklad = Console.ReadLine();
            }
            Console.WriteLine("[1]Вивести запис");
            while (!int.TryParse(Console.ReadLine(), out fl))
            {
                Console.WriteLine("Помилка введення!");
            }
            if(fl == 1)
            {
                Console.Clear();
                appl.ShowInfo();
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("---Студент---\n[1]По замовчуванню\n[2]Ввести дані");
            while (!int.TryParse(Console.ReadLine(), out fl))
            {
                Console.WriteLine("Помилка введення!");
            }

            if (fl == 2)
            {
                Console.Write("Ім'я:");
                stud.Name = Console.ReadLine();

                Console.Write("Прізвище:");
                stud.Surname = Console.ReadLine();

                Console.Write("Дата народження:");
                stud.Date = Console.ReadLine();

                Console.Write("Курс:");
                while (!int.TryParse(Console.ReadLine(), out fl))
                {
                    Console.WriteLine("Помилка введення!");
                }
                stud.course = fl;
                Console.Write("Група:");
                stud.Group = Console.ReadLine();
                Console.Write("Факультет:");
                stud.faculty = Console.ReadLine();
                Console.Write("Вищий навчальний заклад:");
                stud.Vnz = Console.ReadLine();
            }
            Console.WriteLine("[1]Вивести запис");
            while (!int.TryParse(Console.ReadLine(), out fl))
            {
                Console.WriteLine("Помилка введення!");
            }
            if (fl == 1)
            {
                Console.Clear();
                stud.ShowInfo();
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("---Викладач---\n[1]По замовчуванню\n[2]Ввести дані");
            while (!int.TryParse(Console.ReadLine(), out fl))
            {
                Console.WriteLine("Помилка введення!");
            }

            if (fl == 2)
            {
                Console.Write("Ім'я:");
                prep.Name = Console.ReadLine();

                Console.Write("Прізвище:");
                prep.Surname = Console.ReadLine();

                Console.Write("Дата народження:");
                prep.Date = Console.ReadLine();

                Console.Write("Посада:");
                prep.posada = Console.ReadLine();
                Console.Write("Кафедра:");
                prep.kafedra = Console.ReadLine();
                Console.Write("Вищий навчальний заклад:");
                prep.vvnz = Console.ReadLine();
            }
            Console.WriteLine("[1]Вивести запис");
            while (!int.TryParse(Console.ReadLine(), out fl))
            {
                Console.WriteLine("Помилка введення!");
            }
            if (fl == 1)
            {
                Console.Clear();
                prep.ShowInfo();
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("---Користувач бібліотеки---\n[1]По замовчуванню\n[2]Ввести дані");
            while (!int.TryParse(Console.ReadLine(), out fl))
            {
                Console.WriteLine("Помилка введення!");
            }

            if (fl == 2)
            {
                Console.Write("Ім'я:");
                bibl.Name = Console.ReadLine();

                Console.Write("Прізвище:");
                bibl.Surname = Console.ReadLine();

                Console.Write("Дата народження:");
                bibl.Date = Console.ReadLine();

                Console.WriteLine("Номер:");
                while (!int.TryParse(Console.ReadLine(), out fl))
                {
                    Console.WriteLine("Помилка введення!");
                }
                bibl.Id = fl;
                Console.Write("Дата видачі:");
                bibl.Data = Console.ReadLine();
                Console.Write("Розмір внеску:");
                while (!int.TryParse(Console.ReadLine(), out fl))
                {
                    Console.Write("Помилка введення!");
                }
                bibl.Rozmir = fl;
            }
            Console.WriteLine("[1]Вивести запис");
            while (!int.TryParse(Console.ReadLine(), out fl))
            {
                Console.WriteLine("Помилка введення!");
            }
            if (fl == 1)
            {
                Console.Clear();
                bibl.ShowInfo();
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}