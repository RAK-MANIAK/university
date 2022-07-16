namespace lab_8
{
    public class People
    {
        public string name;
        public string surname;
        public string date;

        public People()
        {
            name = "Владислав";
            surname = "Маньківський";
            date = "24.03.2004";
        }

        public People(string name, string surname, string date)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
        }
        public People(People prev)
        {
            name = prev.name;
            surname = prev.surname;
            date = prev.date;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я:{name}\tПрізвище:{surname}\tДата.нар:{date}");
        }
    }
}