namespace Big_Mammas_Pizza.model
{
    public class Pizza
    {
        //instansfelter

        private string _name;
        private int  _price;
        private string _description;
        private int _pizzaNumber;

        //proberties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int PizzaNumber
        {
            get { return _pizzaNumber; }
            set { _pizzaNumber = value;}
        }
        //konstruktør

        public Pizza()
        {
            _pizzaNumber = 0;
            _name = "";
            _description = "";
            _price = 0;
        }
        public Pizza(int PizzaNummer, string Name, string Description, int Price)
        {
            _pizzaNumber= PizzaNummer;
            _name = Name;
            _description = Description;
            _price = Price;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Price)}={Price.ToString()}, {nameof(Description)}={Description}, {nameof(PizzaNumber)}={PizzaNumber.ToString()}}}";
        }
    }
}
