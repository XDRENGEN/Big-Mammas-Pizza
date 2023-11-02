namespace Big_Mammas_Pizza.model
{
    public class Drikke
    {
        /*
         * instans felter
         */

        private int _number;
        private string _name;
        private int _price;
        private bool _alcoholic;

        /*
         * properties
         */

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

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

        public bool Alcoholic
        {
            get { return _alcoholic; }
            set { _alcoholic = value; }
        }

        /*
         * konstruktør 
         */

        public Drikke()
        {
            _number = 0;
            _name = "";
            _price = 0;
            _alcoholic = false;
        }

        public Drikke(int number, string name, int price, bool alcoholic)
        {
            _number = number;
            _name = name;
            _price = price;
            _alcoholic = alcoholic;

        }

         public override string ToString()

        {
            return $"{{{nameof(Number)}={Number}, {nameof(Name)}={Name.ToString()}, {nameof(Price)}={Price}, {nameof(Alcoholic)}={Alcoholic.ToString()}}}";
        }
           
        

}
}
