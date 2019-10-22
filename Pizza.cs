public class Pizza
    {
        private int number;
        private string name;
        private decimal price;
        private bool vegetarian;

        public Pizza(int _number,string _name, decimal _price, bool _vegetarian)
        {
            number = _number;
            name = _name;
            price = _price;
            vegetarian = _vegetarian;
        }
        public Pizza(string _name, decimal _price, bool _vegetarian)
        {
            number = 0;
            name = _name;
            price = _price;
            vegetarian = _vegetarian;
        }
        public Pizza()
        {
            number = 0;
            name = "";
            price = 0;
            vegetarian = false;
        }

        public int Number
        {
            get{return number;}
            set{number = value;}
        }
        public string Name
        {
            get{return name;}
            set{name = value;}
        }

        public decimal Price
        {
            get{return price;}
            set{price = value;}
        }

        public bool Vegetarian 
        {
            get{return vegetarian;}
            set{vegetarian = value;}
        }

        public override string ToString()
        {
            string details = string.Format("{0},{1},{2},{3}",number,name,price,vegetarian.ToString());
            return details;
        }
    }