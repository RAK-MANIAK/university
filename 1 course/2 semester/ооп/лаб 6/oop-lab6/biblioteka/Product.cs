namespace oop_6
{
    public class Product
    {
        protected string name;
        protected float price;
        protected int quantity;
        protected string producer;
        protected int weight;
        public Currency cost;
        protected int suitability;
        public Product(string name, float price, int quantity, string producer, int weight)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.producer = producer;
            this.weight = weight;
        }
        public Product(Product prev)
        {
            name = prev.name;
            price = prev.price;
            quantity = prev.quantity;
            producer = prev.producer;
            weight = prev.weight;
            cost = prev.cost;
        }

        public Product()
        {
            name = "хліб";
            price = 20;
            quantity = 5;
            producer = "Козятин";
            weight = 300;
            cost = new Currency("гривня", 1);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Producer
        {
            get { return producer; }
            set { producer = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Suitability_1
        {
            get { return suitability; }
            set { 
                if(value > 0)
                suitability = value; 
            }
        }

        public int Suitability_2
        {
            get { return suitability; }
            set
            {
                if (value > 0)
                    suitability = value * 30;
            }
        }


        public int Suitability_3
        {
            get { return suitability; }
            set
            {
                if (value > 0)
                    suitability = value * 365;
            }
        }


        public void SetSuitability()
        {
            Console.WriteLine("Введіть '0' для повернення у меню");
            Console.WriteLine("Виберіть величину введення:\n1)Добах\n2)Місяцях\n3)Роках");
            int p, t;
            bool n0;
            do
            {
                n0 = true;

                if (int.TryParse(Console.ReadLine(), out p) && p >= 0 && p <= 3)
                {
                    n0 = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз");
                }
            } while (n0);
            if(p != 0)
            {
                Console.WriteLine("Введіть значення");
                do
                {
                    n0 = true;

                    if (int.TryParse(Console.ReadLine(), out t) && t > 0)
                    {
                        n0 = false;
                    }
                    else
                    {
                        Console.WriteLine("Введіть ще раз");
                    }
                } while (n0);
                if (p == 1)
                    Suitability_1 = t;
                if (p == 2)
                    Suitability_2 = t;
                if (p == 3)
                    Suitability_3 = t;
            }
        }




        public double GetPriceInUAH()
        {
            return price * cost.Exrate;
        }

        public double GetTotalPriceInUAH()
        {
            return price * cost.Exrate * quantity;
        }

        public int GetTotalWeight()
        {
            return weight * quantity;
        }
    }
}