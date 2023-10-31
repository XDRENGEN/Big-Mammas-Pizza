namespace Big_Mammas_Pizza.model
{
    public class Sandwich
    {
        private string _name;
        private int _price;
        private string _description;
        private int _sandwichNumber;

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

        public int SandwichNumber
        {
            get { return _sandwichNumber; }
            set { _sandwichNumber = value; }
        }
        //konstruktør

        public Sandwich()
        {
            _sandwichNumber = 0;
            _name = "";
            _description = "";
            _price = 0;
        }
        public Sandwich(int SandwichNummer, string Name, string Description, int Price)
        {
            _sandwichNumber = SandwichNummer;
            _name = Name;
            _description = Description;
            _price = Price;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Price)}={Price.ToString()}, {nameof(Description)}={Description}, {nameof(SandwichNumber)}={SandwichNumber.ToString()}}}";
        }
    }
}

